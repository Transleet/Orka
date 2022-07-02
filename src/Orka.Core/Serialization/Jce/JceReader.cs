using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Orka.Core.Extensions;
using static Orka.Core.Serialization.ProtoBuf.GroupOpenSysMsg;

namespace Orka.Core.Serialization.Jce;

internal class JceReader
{
    private readonly Stream _stream;

    public JceReader(Stream stream) => _stream = stream;
    
    public HeadData ReadHead()
    {
        var head = new HeadData();
        int b = _stream.ReadByte();
        head.Type = (JceType)(b & 0xF);
        head.Tag = (b & 0xF0) >> 4;
        if (head.Tag == 0xF)
        {
            head.Tag = _stream.ReadByte();
        }
        return head;
    }

    public (int tag, object value) ReadElement(Type expectedType)
    {
        var head = ReadHead();
        switch (head.Type)
        {
            case JceType.ZeroTag:
                return (head.Tag, Convert.ChangeType(0, expectedType));
            case JceType.Int8:
                byte b = (byte)_stream.ReadByte();
                if (expectedType == typeof(byte))
                {
                    return (head.Tag, (byte)Unsafe.As<byte, sbyte>(ref b));
                }
                return (head.Tag, Unsafe.As<byte, sbyte>(ref b));
            case JceType.Int16:
                if (expectedType == typeof(byte))
                {
                    return (head.Tag, (byte)Number.ToInt16(_stream.ReadBytes(2)));
                }
                return (head.Tag, Number.ToInt16(_stream.ReadBytes(2)));
            case JceType.Int32:
                return (head.Tag, Number.ToInt32(_stream.ReadBytes(4)));
            case JceType.Int64:
                return (head.Tag, Number.ToInt64(_stream.ReadBytes(8)));
            case JceType.Float:
                return (head.Tag, Number.ToSingle(_stream.ReadBytes(4)));
            case JceType.Double:
                return (head.Tag, Number.ToDouble(_stream.ReadBytes(8)));
            case JceType.String1:
                {
                    int length = _stream.ReadByte();
                    return (head.Tag, length > 0 ? Encoding.UTF8.GetString(_stream.ReadBytes(length)) : string.Empty);
                }
            case JceType.String4:
                {
                    int length = (int)Number.ToUInt32(_stream.ReadBytes(4));
                    return (head.Tag, length > 0 ? Encoding.UTF8.GetString(_stream.ReadBytes(length)) : string.Empty);
                }
            case JceType.SimpleList:
                {
                    ReadHead();
                    int length = Convert.ToInt32(ReadElement(typeof(int)).value);
                    return (head.Tag, length > 0 ? _stream.ReadBytes(length) : Array.Empty<byte>());
                }
            case JceType.List:
                {
                    int length = Convert.ToInt32(ReadElement(typeof(int)).value);

                    if (expectedType.IsGenericType)
                    {
                        var list = Activator.CreateInstance(expectedType)!;
                        var add = expectedType.GetMethod("Add");
                        Type? itemType = expectedType?.GenericTypeArguments[0]!;
                        for (int i = 0; i < length; i++)
                        {
                            add.Invoke(list, new[] { ReadElement(itemType).value });
                        }
                        return (head.Tag, list);
                    }
                    else
                    {
                        var list = new JceList();
                        for (int i = 0; i < length; i++)
                        {
                            list.Add(ReadElement(typeof(object)).value);
                        }
                        return (head.Tag, list);
                    }
                }
            case JceType.Map:
                {
                    int length = Convert.ToInt32(ReadElement(typeof(int)).value);
                    var map = new JceMap();
                    while (length > 0)
                    {
                        map[ReadElement(typeof(object)).value] = ReadElement(typeof(object)).value;
                        --length;
                    }
                    return (head.Tag, map);
                }
            case JceType.StructBegin:
                Debug.Assert(expectedType is not null);
                object obj = Activator.CreateInstance(expectedType)!;
                var properties = JceHelpers.GetTagsAndProperties(expectedType);
                (int tag, object value)? item = null;
                foreach (KeyValuePair<int, PropertyInfo> propertyInfo in properties)
                {
                    item ??= ReadElement(propertyInfo.Value.PropertyType);
                    if (item.Value.tag != propertyInfo.Key)
                    {
                        continue;
                    }
                    propertyInfo.Value.SetValue(obj, item.Value.value);
                    item = null;
                }
                while (ReadElement(typeof(object)).tag != -1) { }
                return (head.Tag, obj);
            case JceType.StructEnd:
                return (-1, null!);
            default:
                throw new InvalidEnumArgumentException();
        }
    }
}
