using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orka.Core.Serialization.Jce.Structs
{
    internal class SvcRspHttpServerList
    {
        [JceMember(1)] public int I1 { get; set; }
        [JceMember(2)] public JceList<SsoServerInfo> Servers { get; set; }
    }
}
