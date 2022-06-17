using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Orka.Core.Serialization.Jce;

internal static class JceSerializer
{

    public static byte[] Serialize<T>(T obj) where T : class
    {
        var stream  = new MemoryStream();
        var writer = new JceWriter(stream);
        var properties = new Dictionary<byte,PropertyInfo>();
        foreach (var property in typeof(T).GetProperties())
        {
            var attribute = property.GetCustomAttributesData().SingleOrDefault(_=>_.AttributeType==typeof(JceMemberAttribute));
            if (attribute == null)
            {
                continue;
            }
            var arg = attribute.ConstructorArguments.SingleOrDefault();
            Debug.Assert(arg.ArgumentType==typeof(byte));
            byte tag = (byte)arg.Value!;
            properties.Add(tag,property);
        }

        foreach (KeyValuePair<byte, PropertyInfo> keyValuePair in properties)
        {
            writer.WriteElement(keyValuePair.Key,keyValuePair.Value.GetValue(obj)!);
        }
        return stream.ToArray();
    }

    public static T Deserialize<T>(byte[] data) where T : class
    {
        var obj = Activator.CreateInstance<T>();
        var stream = new MemoryStream(data);
        var reader = new JceReader(stream);
        var properties = new SortedDictionary<int, PropertyInfo>();
        foreach (var property in typeof(T).GetProperties())
        {
            var attribute = property.GetCustomAttributesData().SingleOrDefault(_ => _.AttributeType == typeof(JceMemberAttribute));
            if (attribute == null)
            {
                continue;
            }
            var arg = attribute.ConstructorArguments.SingleOrDefault();
            Debug.Assert(arg.ArgumentType == typeof(byte));
            byte tag = (byte)arg.Value!;
            properties.Add(tag, property);
        }
        while (!reader.EndOfStream)
        {
            (int tag, object value) = reader.ReadElement();
            properties[tag].SetValue(obj,value);
        }
        return obj;
    }
}
