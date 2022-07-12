using System.Security.Cryptography;
using System.Text;
using Orka.Core.Crypto;
using Orka.Core.Extensions;
using ProtoBuf;

namespace Orka.Core.Packets;

internal static class Tlv
{
    public static byte[] T1(Uin uin)
    {
        return CreateTlvPacket(0x01, stream =>
        {
            stream.WriteUInt16(1);
            stream.Write(Random.Shared.GetRandomBytes(4));
            stream.WriteUInt32(uin);
            stream.WriteUInt32((uint)DateTimeOffset.Now.ToUnixTimeSeconds());
            stream.Write(new byte[4]);
            stream.WriteUInt16(0);
        });
    }

    public static byte[] T8()
    {
        return CreateTlvPacket(0x08, stream =>
        {
            stream.WriteUInt16(0);
            stream.WriteUInt32(2052);
            stream.WriteUInt16(0);
        });
    }

    public static byte[] T16(DeviceInfo deviceInfo, ApkInfo protocol)
    {
        return CreateTlvPacket(0x16, stream =>
        {
            stream.WriteUInt32(7);
            stream.WriteUInt32(protocol.AppId);
            stream.WriteUInt32(protocol.SubAppId);
            stream.Write(deviceInfo.Guid);
            stream.WriteTlv(protocol.ApkId);
            stream.WriteTlv(protocol.SortVersionName);
            stream.WriteTlv(protocol.ApkSign);
        });
    }
    public static byte[] T18(Uin uin, ApkInfo protocol)
    {
        return CreateTlvPacket(0x18, stream =>
        {
            stream.WriteUInt16(1);
            stream.WriteUInt32(1536);
            stream.WriteUInt32(protocol.AppId);
            stream.WriteUInt32(0);
            stream.WriteUInt32(uin);
            stream.WriteUInt16(0);
            stream.WriteUInt16(0);
        });
    }

    public static byte[] T1B()
    {
        return CreateTlvPacket(0x1B, stream =>
        {
            stream.WriteUInt32(0);
            stream.WriteUInt32(0);
            stream.WriteUInt32(3);
            stream.WriteUInt32(4);
            stream.WriteUInt32(72);
            stream.WriteUInt32(2);
            stream.WriteUInt32(2);
            stream.WriteUInt16(0);
        });
    }

    public static byte[] T1D()
    {
        return CreateTlvPacket(0x1D, stream =>
        {
            stream.WriteByte(1);
            stream.WriteUInt32(184024956);
            stream.WriteUInt32(0);
            stream.WriteByte(0);
            stream.WriteUInt32(0);
        });
    }

    public static byte[] T1F()
    {
        return CreateTlvPacket(0x1F, stream =>
        {
            stream.WriteByte(1);
            stream.WriteTlv("android");
            stream.WriteTlv("7.1.2");
            stream.WriteUInt16(2);
            stream.WriteTlv("China Mobile GSM");
            stream.WriteTlv(Array.Empty<byte>());
            stream.WriteTlv("wifi");
        });
    }

    public static byte[] T33(DeviceInfo deviceInfo)
    {
        return CreateTlvPacket(0x33, stream =>
        {
            stream.Write(deviceInfo.Guid);
        });
    }

    public static byte[] T35()
    {
        return CreateTlvPacket(0x35, stream =>
        {
            stream.WriteUInt32(8);
        });
    }

    public static byte[] T100(ApkInfo protocol, bool emp = false)
    {
        return CreateTlvPacket(0x100, stream =>
        {
            stream.WriteUInt16(1);
            stream.WriteUInt32(7);
            stream.WriteUInt32(protocol.AppId);
            stream.WriteUInt32(emp ? 2 : protocol.SubAppId);
            stream.WriteUInt32(0);
            stream.WriteUInt32(protocol.MainSigMap);
        });
    }

    public static byte[] T104(SigInfo sigInfo)
    {
        return CreateTlvPacket(0x104, stream =>
        {
            stream.Write(sigInfo.T104);
        });
    }

    public static byte[] T106(Uin uin, DeviceInfo deviceInfo, ApkInfo protocol, SigInfo sigInfo, byte[] md5Password)
    {
        return CreateTlvPacket(0x106, s =>
        {
            using var stream = new MemoryStream();
            stream.WriteUInt16(4);
            stream.Write(Random.Shared.GetRandomBytes(4));
            stream.WriteUInt32(7);
            stream.WriteUInt32(protocol.AppId);
            stream.WriteUInt32(0);
            stream.WriteUInt64(uin);
            stream.WriteInt32((int)DateTimeOffset.Now.ToUnixTimeSeconds());
            stream.Write(new byte[4]);
            stream.WriteByte(1);
            stream.Write(md5Password);
            stream.Write(sigInfo.Tgtgt);
            stream.WriteUInt32(0);
            stream.WriteByte(1);
            stream.Write(deviceInfo.Guid);
            stream.WriteUInt32(protocol.SubAppId);
            stream.WriteUInt32(1);
            stream.WriteTlv(uin.ToString());
            stream.WriteUInt16(0);
            byte[] body = stream.ToArray();
            var key = new List<byte>();
            key.AddRange(md5Password);
            key.AddRange(new byte[4]);
            key.AddRange(Number.FromUInt32(uin));
            s.Write(Tea.Encrypt(body,MD5.HashData(key.ToArray())));
        });

    }

    public static byte[] T107()
    {
        return CreateTlvPacket(0x107, stream =>
        {
            stream.WriteUInt16(0);
            stream.WriteByte(0);
            stream.WriteUInt16(0);
            stream.WriteByte(1);
        });
    }

    public static byte[] T109(DeviceInfo deviceInfo)
    {
        return CreateTlvPacket(0x109, stream =>
        {
            stream.Write(MD5.HashData(Encoding.UTF8.GetBytes(deviceInfo.IMEI)));
        });
    }

    public static byte[] T10A(SigInfo sigInfo)
    {
        return CreateTlvPacket(0x10A, stream =>
        {
            stream.Write(sigInfo.Tgt);
        });
    }

    public static byte[] T116(ApkInfo protocol)
    {
        return CreateTlvPacket(0x116, stream =>
        {
            stream.WriteByte(0);
            stream.WriteUInt32(protocol.MiscBitmap);
            stream.WriteUInt32(protocol.SubSigMap);
            stream.WriteByte(1);
            stream.WriteUInt32(1600000226);
        });
    }

    public static byte[] T124(DeviceInfo deviceInfo)
    {
        return CreateTlvPacket(0x124, stream =>
        {
            stream.WriteTlv(deviceInfo.OSType, 16);
            stream.WriteTlv(deviceInfo.Version.Release, 16);
            stream.WriteUInt16(2);
            stream.WriteTlv(deviceInfo.SimInfo, 16);
            stream.WriteUInt16(0);
            stream.WriteTlv(deviceInfo.APN);
        });
    }

    public static byte[] T128(DeviceInfo deviceInfo)
    {
        return CreateTlvPacket(0x128, stream =>
        {
            stream.WriteUInt16(0);
            stream.WriteByte(0);
            stream.WriteByte(1);
            stream.WriteByte(0);
            stream.WriteUInt32(16777216);
            stream.WriteTlv(deviceInfo.Model, 32);
            stream.WriteTlv(deviceInfo.Guid, 16);
            stream.WriteTlv(deviceInfo.Brand, 16);
        });
    }

    public static byte[] T141(DeviceInfo deviceInfo)
    {
        return CreateTlvPacket(0x141, stream =>
        {
            stream.WriteUInt16(1);
            stream.WriteTlv(deviceInfo.SimInfo);
            stream.WriteUInt16(2);
            stream.WriteTlv(deviceInfo.APN);
        });
    }

    public static byte[] T142(ApkInfo protocol)
    {
        return CreateTlvPacket(0x142, stream =>
        {
            stream.WriteUInt16(0);
            stream.WriteTlv(protocol.ApkId, 32);
        });
    }

    public static byte[] T143(SigInfo sigInfo)
    {
        return CreateTlvPacket(0x143, stream =>
        {
            stream.Write(sigInfo.D2);
        });
    }

    public static byte[] T144(DeviceInfo deviceInfo, SigInfo sigInfo)
    {
        return CreateTlvPacket(0x144, stream =>
        {
            using var s = new MemoryStream();
            s.WriteUInt16(5);
            s.Write(T109(deviceInfo));
            s.Write(T52D(deviceInfo));
            s.Write(T124(deviceInfo));
            s.Write(T128(deviceInfo));
            s.Write(T16E(deviceInfo));
            stream.Write(Tea.Encrypt(s.ToArray(), sigInfo.Tgtgt));
        });
    }

    public static byte[] T145(DeviceInfo deviceInfo)
    {
        return CreateTlvPacket(0x145, stream =>
        {
            stream.Write(deviceInfo.Guid);
        });
    }

    public static byte[] T147(ApkInfo protocol)
    {
        return CreateTlvPacket(0x147, stream =>
        {
            stream.WriteUInt32(protocol.AppId);
            stream.WriteTlv(protocol.SortVersionName, 5);
            stream.WriteTlv(protocol.ApkSign);
        });
    }

    public static byte[] T154(SigInfo sigInfo)
    {
        return CreateTlvPacket(0x154, stream =>
        {
            stream.WriteUInt32(sigInfo.SeqId);
        });
    }

    public static byte[] T16E(DeviceInfo deviceInfo)
    {
        return CreateTlvPacket(0x16E, stream =>
        {
            stream.Write(deviceInfo.Model);
        });
    }

    public static byte[] T174(SigInfo sigInfo)
    {
        return CreateTlvPacket(0x174, stream =>
        {
            stream.Write(sigInfo.T174);
        });
    }

    public static byte[] T177(ApkInfo protocol)
    {
        return CreateTlvPacket(0x177, stream =>
        {
            stream.WriteByte(0x01);
            stream.WriteUInt32(protocol.BuildTime);
            stream.WriteTlv(protocol.SdkVersion);
        });
    }
    public static byte[] T17A()
    {
        return CreateTlvPacket(0x17A, stream =>
        {
            stream.WriteUInt32(9);
        });
    }

    public static byte[] T17C(string code)
    {
        return CreateTlvPacket(0x17C, stream =>
        {
            stream.WriteTlv(code);
        });
    }

    public static byte[] T187(DeviceInfo deviceInfo)
    {
        return CreateTlvPacket(0x187, stream =>
        {
            stream.Write(MD5.HashData(deviceInfo.MacAddress));
        });
    }

    public static byte[] T188(DeviceInfo deviceInfo)
    {
        return CreateTlvPacket(0x188, stream =>
        {
            stream.Write(MD5.HashData(Encoding.UTF8.GetBytes(deviceInfo.AndroidId)));
        });
    }


    public static byte[] T191()
    {
        return CreateTlvPacket(0x191, stream =>
        {
            stream.WriteByte(0x82);
        });
    }

    public static byte[] T193(string ticket)
    {
        return CreateTlvPacket(0x193, stream =>
        {
            stream.WriteString(ticket);
        });
    }

    public static byte[] T194(DeviceInfo deviceInfo)
    {
        return CreateTlvPacket(0x194, stream =>
        {
            stream.Write(deviceInfo.IMSI);
        });
    }

    public static byte[] T197()
    {
        return CreateTlvPacket(0x197, stream =>
        {
            stream.WriteTlv(new byte[1]);
        });
    }

    public static byte[] T198()
    {
        return CreateTlvPacket(0x198, stream =>
        {
            stream.WriteTlv(new byte[1]);
        });
    }

    public static byte[] T202(DeviceInfo deviceInfo)
    {
        return CreateTlvPacket(0x202, stream =>
        {
            stream.WriteTlv(deviceInfo.WifiBSSID, 16);
            stream.WriteTlv(deviceInfo.WifiSSID, 32);
        });
    }

    public static byte[] T400(Uin uin, DeviceInfo deviceInfo)
    {
        return CreateTlvPacket(0x400, stream =>
        {
            stream.WriteUInt16(1);
            stream.WriteUInt64(uin);
            stream.Write(deviceInfo.Guid);
            stream.Write(Random.Shared.GetRandomBytes(16));
            stream.WriteInt32(1);
            stream.WriteInt32(16);
            stream.WriteInt32((int)DateTimeOffset.Now.ToUnixTimeSeconds());
            stream.Write(Array.Empty<byte>());
        });
    }

    public static byte[] T401()
    {
        return CreateTlvPacket(0x401, stream =>
        {
            stream.Write(Random.Shared.GetRandomBytes(16));
        });
    }

    public static byte[] T511()
    {
        var domains = new HashSet<string>
        {
            "aq.qq.com",
            "buluo.qq.com",
            "connect.qq.com",
            "docs.qq.com",
            "game.qq.com",
            "gamecenter.qq.com",
            // "graph.qq.com",
            "haoma.qq.com",
            "id.qq.com",
            // "imgcache.qq.com",
            "kg.qq.com",
            "mail.qq.com",
            "mma.qq.com",
            "office.qq.com",
            // "om.qq.com",
            "openmobile.qq.com",
            "qqweb.qq.com",
            "qun.qq.com",
            "qzone.qq.com",
            "ti.qq.com",
            "v.qq.com",
            "vip.qq.com",
            "y.qq.com",
        };
        return CreateTlvPacket(0x511, stream =>
        {
            stream.WriteUInt16((ushort)domains.Count);
            foreach (string domain in domains)
            {
                stream.WriteByte(0x01);
                stream.WriteTlv(domain);
            }
        });
    }

    public static byte[] T516()
    {
        return CreateTlvPacket(0x516, stream =>
        {
            stream.WriteUInt32(0);
        });
    }

    public static byte[] T521()
    {
        return CreateTlvPacket(0x521, stream =>
        {
            stream.WriteUInt32(0);
            stream.WriteUInt16(0);
        });
    }

    public static byte[] T525()
    {
        return CreateTlvPacket(0x525, stream =>
        {
            stream.WriteUInt16(1);
            stream.WriteUInt16(0x536);
            stream.WriteTlv(new byte[] { 0x1, 0x0 });
        });
    }

    public static byte[] T52D(DeviceInfo deviceInfo)
    {
        var device = new Serialization.ProtoBuf.DeviceInfo()
        {
            Bootloader = deviceInfo.Bootloader,
            ProcVersion = deviceInfo.ProcVersion,
            Codename = deviceInfo.Version.CodeName,
            Incremental = deviceInfo.Version.Incremental,
            Fingerprint = deviceInfo.FingerPrint,
            BootId = deviceInfo.BootId,
            AndroidId = deviceInfo.AndroidId,
            BaseBand = deviceInfo.BaseBand,
            InnerVersion = deviceInfo.Version.Incremental
        };

        return CreateTlvPacket(0x52D, stream =>
        {
            Serializer.Serialize(stream, device);
        });
    }


    private static byte[] CreateTlvPacket(ushort tag, Action<Stream> action)
    {
        using var stream = new MemoryStream();
        action(stream);
        byte[] arr = stream.ToArray();
        byte[] pkt = GC.AllocateUninitializedArray<byte>(arr.Length + 4);
        Number.FromUInt16(tag).CopyTo(pkt, 0);
        Number.FromUInt16((ushort)arr.Length).CopyTo(pkt, 2);
        Array.Copy(arr, 0, pkt, 4, arr.Length);
        return pkt;
    }

    

    
}
