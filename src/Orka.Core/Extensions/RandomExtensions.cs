using System;

namespace Orka.Core.Extensions;

internal static class RandomExtensions
{
    public static byte[] GetRandomBytes(this Random random, int length = 64)
    {
        byte[] arr = GC.AllocateUninitializedArray<byte>(length);
        random.NextBytes(arr);
        return arr;
    }
}
