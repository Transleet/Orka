using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Orka.Tests
{
    public static class Utils
    {
        public static byte[] GetRandomBytes(this Random random, int length = 64)
        {
            var arr = GC.AllocateUninitializedArray<byte>(length);
            random.NextBytes(arr);
            return arr;
        }
    }
}
