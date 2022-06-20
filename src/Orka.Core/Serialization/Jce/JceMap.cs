using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orka.Core.Serialization.Jce;

internal class JceMap : JceMap<object, object>
{
}

internal class JceMap<TK, TV> : Dictionary<TK, TV> where TK : notnull
{
}
