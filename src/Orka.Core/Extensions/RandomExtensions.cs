using System;

namespace Orka.Core.Extensions
{
    public static class RandomExtensions
    {
        public static byte[] GetRandomBytes(this Random random, int length = 64)
        {
            var arr = GC.AllocateUninitializedArray<byte>(length);
            random.NextBytes(arr);
            return arr;
        }
    }
}
