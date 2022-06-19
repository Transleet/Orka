using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Orka.Core.Serialization.Jce;

internal static class JceSerializer
{

    public static byte[] Serialize<T>(T obj) where T : class, IJceStruct
    {
        var stream = new MemoryStream();
        var writer = new JceWriter(stream);
        var properties = JceHelpers.GetTagsAndProperties<T>();
        foreach (KeyValuePair<int, PropertyInfo> keyValuePair in properties)
        {
            writer.WriteElement(keyValuePair.Key, keyValuePair.Value.GetValue(obj)!);
        }
        return stream.ToArray();
    }

    public static T Deserialize<T>(byte[] data) where T : class, IJceStruct
    {
        var obj = Activator.CreateInstance<T>();
        var stream = new MemoryStream(data);
        var reader = new JceReader(stream);
        var properties = JceHelpers.GetTagsAndProperties<T>();
        foreach (KeyValuePair<int, PropertyInfo> propertyInfo in properties)
        {
            var item = reader.ReadElement(propertyInfo.Value.PropertyType);
            if (item.tag != propertyInfo.Key)
            {
                continue;
            }
            propertyInfo.Value.SetValue(obj, item.value);
        }
        return obj;
    }
}
