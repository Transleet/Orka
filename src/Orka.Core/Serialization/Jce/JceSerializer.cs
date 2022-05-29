using System;
using System.IO;

namespace Orka.Core.Serialization.Jce;

internal static class JceSerializer
{
    public static byte[] Serialize<T>(T obj) where T:class
    {
        throw new NotImplementedException();
    }
    
    public static T Deserialize<T>(byte[] data) where T:class
    {
        throw new NotImplementedException();
    }
}
