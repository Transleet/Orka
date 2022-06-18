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

internal class JceMap<K, V> : Dictionary<K, V> where K : notnull
{
}
