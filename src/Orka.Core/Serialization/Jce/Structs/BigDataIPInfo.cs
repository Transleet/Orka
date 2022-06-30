using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orka.Core.Serialization.Jce.Structs;

internal class BigDataIPInfo
{
    [JceMember(0)] public long Type { get; set; }
    [JceMember(1)] public string Server { get; set; }
    [JceMember(2)] public long Port { get; set; }
}
