using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orka.Core.Serialization.Jce;

public class JceMemberAttribute : Attribute
{
    public JceMemberAttribute(byte tag) => Tag = tag;

    public byte Tag { get; set; }
}
