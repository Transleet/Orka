using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orka
{
     internal static class Utils
    {
        public static byte[] GetRandomBytes(this Random random,int length)
        {
            var arr = GC.AllocateUninitializedArray<byte>(4);
            random.NextBytes(arr);
            return arr;
        }
    }
}
