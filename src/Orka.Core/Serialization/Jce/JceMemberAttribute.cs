using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orka.Core.Serialization.Jce
{
    [AttributeUsage(AttributeTargets.Property|AttributeTargets.Field)]
    internal class JceMemberAttribute:Attribute
    {
        public JceMemberAttribute(byte tag, JceType? type = null)
        {
            Tag = tag;
            Type = type;
        }

        public byte Tag { get; set; }
        public JceType? Type { get; set; }
    }
}
