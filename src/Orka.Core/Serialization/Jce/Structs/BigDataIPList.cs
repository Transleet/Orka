using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orka.Core.Serialization.Jce.Structs;

internal class BigDataIPList : IJceStruct
{
    [JceMember(0)] public long ServiceType { get; set; }
    [JceMember(1)] public JceList<BigDataIPInfo> IPList { get; set; }
    [JceMember(1)] public long IFragmentSizePList { get; set; }
}
