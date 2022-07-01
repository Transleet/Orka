using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace Orka.Core.Serialization.Jce;

internal static class JceHelpers
{
    private static readonly Exception s_exception = new("Provided type must be JceStruct.");
    public static SortedDictionary<int, PropertyInfo> GetTagsAndProperties<T>() where T : class => GetTagsAndProperties(typeof(T));

    public static SortedDictionary<int, PropertyInfo> GetTagsAndProperties(Type type)
    {
        ThrowIfNotJceStruct(type);
        var properties = new SortedDictionary<int, PropertyInfo>();
        foreach (var property in type.GetProperties())
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
        return properties;
    }
    
    public static void ThrowIfNotJceStruct<T>() => ThrowIfNotJceStruct(typeof(T));
    
    public static void ThrowIfNotJceStruct(Type type)
    {
        if (type.GetInterface("IJceStruct") is not null)
        {
            return;
        }
        if (type.IsClass)
        {
            var attribute = type.GetCustomAttributesData().SingleOrDefault(_ => _.AttributeType == typeof(JceStructAttribute));
            if (attribute is null)
            {
                if (type.GetProperties().Any(_ => _.GetCustomAttributesData().SingleOrDefault(a => a.AttributeType == typeof(JceMemberAttribute)) is null))
                {
                    throw s_exception;
                }
            }
        }
        else
        {
            throw s_exception;
        }
    }
}
