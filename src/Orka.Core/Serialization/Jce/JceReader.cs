using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Orka.Core.Extensions;

namespace Orka.Core.Serialization.Jce;

internal class JceReader
{
    private readonly Stream _stream;

    public JceReader(Stream stream) => _stream = stream;

    public bool EndOfStream => _stream.Position >= _stream.Length;
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

    public object ReadBody(JceType type)
    {
        switch (type)
        {
            case JceType.Int8:
                byte b = (byte)_stream.ReadByte();
                return Unsafe.As<byte, sbyte>(ref b);
            case JceType.Int16:
                return Number.ToInt16(_stream.ReadBytes(2));
            case JceType.Int32:
                return Number.ToInt32(_stream.ReadBytes(4));
            case JceType.Int64:
                return Number.ToInt64(_stream.ReadBytes(8));
            case JceType.String1:
                {
                    int length = _stream.ReadByte();
                    return length > 0 ? Encoding.UTF8.GetString(_stream.ReadBytes(length)) : string.Empty;
                }
            case JceType.String4:
                {
                    int length = (int)Number.ToUInt32(_stream.ReadBytes(4));
                    return length > 0 ? Encoding.UTF8.GetString(_stream.ReadBytes(length)) : string.Empty;
                }
            case JceType.SimpleList:
                {
                    ReadHead();
                    int length = Convert.ToInt32(ReadElement().value);
                    return length > 0 ? _stream.ReadBytes(length) : Array.Empty<byte>();
                }
            case JceType.List:
                {
                    int length = Convert.ToInt32(ReadElement().value);
                    var list = new JceList();
                    while (length > 0)
                    {
                        list.Add(ReadElement().value);
                        --length;
                    }
                    return list;
                }
            case JceType.Map:
                {
                    int length = Convert.ToInt32(ReadElement().value);
                    var map = new JceMap();
                    while (length > 0)
                    {
                        map[ReadElement().value] = ReadElement().value;
                        --length;
                    }
                    return map;
                }
            case JceType.StructBegin:
                return ReadStruct();
            case JceType.StructEnd:
                return null;
            case JceType.Float:
                return Number.ToSingle(_stream.ReadBytes(4));
            case JceType.Double:
                return Number.ToDouble(_stream.ReadBytes(8));
            default:
                throw new InvalidEnumArgumentException();
        }
    }

    public IJceStruct ReadStruct()
    {
        return null;
    }

    public (int tag, object value) ReadElement()
    {
        var head = ReadHead();
        var value = ReadBody(head.Type);
        return (head.Tag, value);
    }
}
