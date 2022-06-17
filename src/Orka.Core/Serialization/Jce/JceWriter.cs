using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Orka.Core.Serialization.Jce
{
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

        public void WriteBody(JceType type, object value)
        {
            switch (type)
            {
                case JceType.Int8:
                    sbyte b = Convert.ToSByte(value);
                    _stream.WriteByte(Unsafe.As<sbyte, byte>(ref b));
                    break;
                case JceType.Int16:
                    _stream.Write(Number.FromInt16(Convert.ToInt16(value)));
                    break;
                case JceType.Int32:
                    _stream.Write(Number.FromInt32(Convert.ToInt32(value)));
                    break;
                case JceType.Int64:
                    _stream.Write(Number.FromInt64(Convert.ToInt64(value)));
                    break;
                case JceType.Float:
                    _stream.Write(Number.FromSingle(Convert.ToSingle(value)));
                    break;
                case JceType.Double:
                    _stream.Write(Number.FromDouble(Convert.ToDouble(value)));
                    break;
                case JceType.String1:
                    {
                        byte[] buffer = (byte[])value;
                        _stream.WriteByte((byte)buffer.Length);
                        _stream.Write(buffer);
                        break;
                    }
                case JceType.String4:
                    {
                        byte[] buffer = (byte[])value;
                        _stream.Write(Number.FromInt32(buffer.Length));
                        _stream.Write(buffer);
                    }
                    break;
                case JceType.Map:
                    {
                        var map = (Hashtable)value;
                        WriteElement(0, map.Count);
                        foreach (DictionaryEntry dictionaryEntry in map)
                        {
                            WriteElement(0, dictionaryEntry.Key);
                            WriteElement(1, dictionaryEntry.Value!);
                        }
                        break;
                    }
                case JceType.List:
                    {
                        var list = (IList)value;
                        WriteElement(0, list.Count);
                        foreach (object o in list)
                        {
                            WriteElement(0, o);
                        }
                        break;
                    }
                case JceType.SimpleList:
                    {
                        byte[] buffer = (byte[])value;
                        WriteHead(0, 0);
                        WriteElement(0, buffer.Length);
                        _stream.Write(buffer);
                        break;
                    }
                case JceType.ZeroTag:
                default:
                    break;

            }
        }

        public void WriteElement(int tag, object value)
        {
            //TODO Process Nested JceStruct
            if (value is IJceStruct)
            {

            }
            JceType type = JceType.Null;
            switch (Type.GetTypeCode(value.GetType()))
            {
                case TypeCode.Int64:
                    long n1 = Convert.ToInt64(value);
                    if (n1 == 0)
                    {
                        type = JceType.ZeroTag;
                        break;
                    }
                    if (n1 is > int.MaxValue or < int.MinValue)
                    {
                        type = JceType.Int64;
                        break;
                    }
                    goto case TypeCode.Int32;
                case TypeCode.Int32:
                    int n2 = Convert.ToInt32(value);
                    if (n2 is > short.MaxValue or < short.MinValue)
                    {
                        type = JceType.Int32;
                        break;
                    }
                    goto case TypeCode.Int16;
                case TypeCode.Int16:
                    short n3 = Convert.ToInt16(value);
                    if (n3 is > sbyte.MaxValue or < sbyte.MinValue)
                    {
                        type = JceType.Int16;
                        break;
                    }
                    goto case TypeCode.SByte;
                case TypeCode.SByte:
                    sbyte n4 = Convert.ToSByte(value);
                    type = JceType.Int8;
                    break;
                case TypeCode.Single:
                    type = JceType.Float;//for consistency
                    break;
                case TypeCode.Double:
                    type = JceType.Double;
                    break;
                case TypeCode.String:
                    {
                        byte[] buffer = Encoding.UTF8.GetBytes((string)value);
                        type = buffer.Length <= 0xff ? JceType.String1 : JceType.String4;
                        value = buffer;
                        break;
                    }
                case TypeCode.Object:
                    if (value is byte[])
                    {
                        type = JceType.SimpleList;
                        break;
                    }

                    if (value is IList)
                    {
                        type = JceType.List;
                        break;
                    }
                    if (value is IDictionary)
                    {
                        type = JceType.Map;
                        break;
                    }
                    throw new Exception();
                default:
                    throw new Exception();
            }
            WriteHead(type, tag);
            WriteBody(type, value);
        }
    }
}
