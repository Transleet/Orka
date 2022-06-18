using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orka.Core.Extensions;

internal static class StreamExtensions
{
    public static byte[] ReadBytes(this Stream stream,int length)
    {
        var arr = GC.AllocateUninitializedArray<byte>(length);
        stream.Read(arr);
        return arr;
    }
}
