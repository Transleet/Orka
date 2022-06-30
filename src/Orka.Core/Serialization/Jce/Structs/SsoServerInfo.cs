using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orka.Core.Serialization.Jce.Structs;

internal class SsoServerInfo : IJceStruct
{
    [JceMember(1)] public string Server { get; set; }
    [JceMember(2)] public int Port { get; set; }
    [JceMember(8)] public string Location { get; set; }
}
