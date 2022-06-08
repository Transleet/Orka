using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orka.Core.Serialization.Jce
{
    internal partial class TestJceStruct
    {
        [JceMember(1)] public string Text { get; set; }
    }
}
