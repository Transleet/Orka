using System;
using Orka.Core.Crypto;
using Orka.Core.Extensions;

namespace Orka.Core.Packets;

internal static class Packet
{
    public static byte[] CombineWithLength(byte[] bytes)
    {
        byte[] arr = GC.AllocateUninitializedArray<byte>(sizeof(uint) + bytes.Length);
        Number.FromUInt32((uint)bytes.Length).CopyTo(arr, 0);
        bytes.CopyTo(arr, sizeof(uint));
        return arr;
    }

    public static byte[] PackUniRequestData(byte[] data)
    {
        byte[] arr = GC.AllocateUninitializedArray<byte>(data.Length + 2);
        arr[0] = 0x0A;
        data.CopyTo(arr, 1);
        arr[^1] = 0x0B;
        return arr;
    }

    public static byte[] BuildLoginPacket(OrkaClient client, string loginCommand, Action<Stream> bodyFunc, byte loginCommandType = 2)
    {
        using var stream = new MemoryStream();
        bodyFunc(stream);
        byte[] body = stream.ToArray();
        Uin uin = client.Uin;
        ushort commandId = 0x810;
        uint subAppId = client.DeviceInfo.ApkInfo.SubAppId;
        if (loginCommand == LoginCommand.WtLoginTransEmp)
        {
            uin = 0;
            commandId = 0x812;
            subAppId = ApkInfo.AndroidWatch.SubAppId;
        }

        if (loginCommandType == 2)
        {
            using var stream1 = new MemoryStream();
            stream1.WriteByte(0x02);
            stream1.WriteByte(0x01);
            stream1.Write(client.SigInfo.RandomKey);
            stream1.WriteUInt16(0x131);
            stream1.WriteUInt16(0x01);
            stream1.WriteTlv(client.Ecdh.PublicKey);
            stream1.Write(Tea.Encrypt(body, client.Ecdh.ShareKey));
            body = stream1.ToArray();

            using var stream2 = new MemoryStream();
            stream2.WriteByte(0x02);
            stream2.WriteUInt16((ushort)(body.Length + 29));
            stream2.WriteUInt16(8001);
            stream2.WriteUInt16(commandId);
            stream2.WriteUInt16(1);
            stream2.WriteUInt32(uin);
            stream2.WriteByte(3);
            stream2.WriteByte(0x87);
            stream2.WriteByte(0);
            stream2.WriteUInt32(2);
            stream2.WriteUInt32(0);
            stream2.WriteUInt32(0);
            stream2.Write(body);
            stream2.WriteByte(0x03);
            body = stream2.ToArray();
        }
        using var stream3 = new MemoryStream();
        using var stream4 = new MemoryStream();
        stream4.WriteUInt32(client.SigInfo.SeqId);
        stream4.WriteUInt32(subAppId);
        stream4.WriteUInt32(subAppId);
        stream4.Write(new byte[]{ 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00 });
        stream4.WriteWithLength(client.SigInfo.Tgt);
        stream4.WriteWithLength(loginCommand);
        stream4.WriteWithLength(client.SigInfo.Session);
        stream4.WriteWithLength(client.DeviceInfo.IMEI);
        stream4.WriteUInt32(4);
        stream4.WriteUInt16(2);
        stream4.WriteUInt32(4);
        stream3.WriteWithLength(stream4.ToArray());
        stream3.WriteWithLength(body);
        byte[] sso = stream3.ToArray();
        if (loginCommandType == 1)
        {
            sso = Tea.Encrypt(sso, client.SigInfo.D2Key);
        }
        if (loginCommandType == 2)
        {
            sso = Tea.Encrypt(sso, new byte[16]);
        }
        using var stream5 = new MemoryStream();
        stream5.WriteUInt32(0x0A);
        stream5.WriteByte(loginCommandType);
        stream5.WriteWithLength(client.SigInfo.D2);
        stream5.WriteUInt8(0);
        stream5.WriteWithLength(uin.ToString());
        stream5.Write(sso);
        return CombineWithLength(stream5.ToArray());
    }
}
