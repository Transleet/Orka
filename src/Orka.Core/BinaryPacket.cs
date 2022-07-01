using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orka.Core;

internal static class BinaryPacket
{
    public static byte[] CombineLength(uint length, byte[] bytes)
    {
        byte[] arr = GC.AllocateUninitializedArray<byte>(sizeof(uint) + bytes.Length);
        Number.FromUInt32(length).CopyTo(arr, 0);
        bytes.CopyTo(arr, sizeof(uint));
        return arr;
    }

    public static byte[] PackUniRequestData(byte[] data)
    {
        byte[] arr = GC.AllocateUninitializedArray<byte>(data.Length + 2);
        arr[0] = 0x0A;
        data.CopyTo(arr,1);
        arr[^1] = 0x0B;
        return arr;
    }
}
