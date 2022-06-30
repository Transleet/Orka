using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Orka.Core.Serialization.Jce;

internal class JceWriter
{
    private readonly Stream _stream;
    public JceWriter(Stream stream) => _stream = stream;
    public void WriteHead(JceType type, int tag)
    {
        if (tag < 0xF)
        {
            _stream.WriteByte((byte)(tag << 4 | (byte)type));
        }
        else
        {
            _stream.WriteByte((byte)(0xF0 | (byte)type));
            _stream.WriteByte((byte)tag);
        }
    }

    public void WriteElement(int tag, object value)
    {
        switch (Type.GetTypeCode(value.GetType()))
        {
            case TypeCode.Int64:
                long n1 = Convert.ToInt64(value);
                if (n1 == 0)
                {
                    WriteHead(JceType.ZeroTag, tag);
                    break;
                }
                if (n1 is > int.MaxValue or < int.MinValue)
                {
                    WriteHead(JceType.Int64, tag);
                    _stream.Write(Number.FromInt64(Convert.ToInt64(value)));
                    break;
                }
                goto case TypeCode.Int32;
            case TypeCode.Int32:
                int n2 = Convert.ToInt32(value);
                if (n2 is > short.MaxValue or < short.MinValue)
                {
                    WriteHead(JceType.Int32, tag);
                    _stream.Write(Number.FromInt32(Convert.ToInt32(value)));
                    break;
                }
                goto case TypeCode.Int16;
            case TypeCode.Int16:
                short n3 = Convert.ToInt16(value);
                if (n3 is > sbyte.MaxValue or < sbyte.MinValue)
                {
                    WriteHead(JceType.Int16, tag);
                    _stream.Write(Number.FromInt16(Convert.ToInt16(value)));
                    break;
                }
                goto case TypeCode.SByte;
            case TypeCode.SByte:
                {
                    WriteHead(JceType.Int8, tag);
                    sbyte b = Convert.ToSByte(value);
                    _stream.WriteByte(Unsafe.As<sbyte, byte>(ref b));
                    break;
                }
            case TypeCode.Single://for consistency
                WriteHead(JceType.Float, tag);
                _stream.Write(Number.FromSingle(Convert.ToSingle(value)));
                break;
            case TypeCode.Double:
                WriteHead(JceType.Double, tag);
                _stream.Write(Number.FromDouble(Convert.ToDouble(value)));
                break;
            case TypeCode.String:
                {
                    byte[] buffer = Encoding.UTF8.GetBytes((string)(object)value);
                    if (buffer.Length <= 0xFF)
                    {
                        WriteHead(JceType.String1, tag);
                        _stream.WriteByte((byte)buffer.Length);
                        _stream.Write(buffer);
                    }
                    else
                    {
                        WriteHead(JceType.String4, tag);
                        _stream.Write(Number.FromInt32(buffer.Length));
                        _stream.Write(buffer);
                    }
                    break;
                }
            case TypeCode.Object:
                {
                    if (value is byte[] buffer)
                    {
                        WriteHead(JceType.SimpleList, tag);
                        WriteHead(0, 0);
                        WriteElement(0, buffer.Length);
                        _stream.Write(buffer);
                        break;
                    }
                    if (value is JceMap map)
                    {
                        WriteHead(JceType.Map, tag);
                        WriteElement(0, map.Count);
                        foreach (KeyValuePair<object, object> entry in map)
                        {
                            WriteElement(0, entry.Key);
                            WriteElement(1, entry.Value!);
                        }
                        break;
                    }

                    if (value is JceList list)
                    {
                        WriteHead(JceType.List, tag);
                        WriteElement(0, list.Count);
                        foreach (object o in list)
                        {
                            WriteElement(0, o);
                        }
                        break;
                    }
                    JceHelpers.ThrowIfNotJceStruct(value.GetType());
                    WriteHead(JceType.StructBegin, tag);
                    var properties = JceHelpers.GetTagsAndProperties(value.GetType());
                    foreach (KeyValuePair<int, PropertyInfo> keyValuePair in properties)
                    {
                        WriteElement(keyValuePair.Key, keyValuePair.Value.GetValue(value)!);
                    }
                    WriteHead(JceType.StructEnd, 0);
                    break;
                }
            default:
                throw new Exception("No matched type found for value.");
        }
    }
}
