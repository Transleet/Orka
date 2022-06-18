using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace Orka.Core.Serialization.Jce
{
    internal static class JceHelpers
    {
        public static SortedDictionary<int, PropertyInfo> GetTagsAndProperties<T>() where T : class, IJceStruct => GetTagsAndProperties(typeof(T));

        public static SortedDictionary<int, PropertyInfo> GetTagsAndProperties(Type type)
        {
            Debug.Assert(type.GetInterfaces().Contains(typeof(IJceStruct)) && type.IsClass);
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
    }
}
