using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Orka.Core.Serialization.Jce;

internal static class JceSerializer
{

    public static byte[] Serialize<T>(T obj) where T : class
    {
        throw new NotImplementedException();
    }

    public static T Deserialize<T>(byte[] data) where T : class
    {
        throw new NotImplementedException();
    }
}
