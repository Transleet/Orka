using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orka.Core.Serialization.Jce.Structs
{
    internal class BigDataChannel:IJceStruct
    {
        [JceMember(0)]public JceList<BigDataIPList> IPLists { get; set; }
        [JceMember(1)]public byte[] SigSession { get; set; }
        [JceMember(2)]public byte[] KeySession { get; set; }
        [JceMember(3)]public long SigUin { get; set; }
        [JceMember(4)]public long ConnectFlag { get; set; }
        [JceMember(5)]public byte[] PbBuf { get; set; }
    }
}
