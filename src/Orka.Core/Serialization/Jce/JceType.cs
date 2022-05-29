using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orka.Core.Serialization.Jce
{
    internal enum JceType : byte
    {
        Byte,
        Short,
        Int,
        Long,
        Float,
        Double,
        String1,
        String4,
        Map,
        List,
        StructBegin,
        StructEnd,
        ZeroTag,
        SimpleList,
        Null = byte.MaxValue
    }
}
