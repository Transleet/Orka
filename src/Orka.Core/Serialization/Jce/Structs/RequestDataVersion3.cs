using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orka.Core.Serialization.Jce.Structs
{
    internal class RequestDataVersion3:IJceStruct
    {
       [JceMember(0)] public JceMap Map { get; set; }
    }
}
