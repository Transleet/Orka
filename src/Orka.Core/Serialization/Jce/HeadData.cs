using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orka.Core.Serialization.Jce;

internal struct HeadData
{
    public JceType Type { get; set; }
    public int Tag { get; set; }
}
