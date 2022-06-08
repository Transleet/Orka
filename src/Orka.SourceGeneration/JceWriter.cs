/*
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace Orka.SourceGenerators;

internal class JceWriter
{
    private readonly Stream _stream;

    public JceWriter(Stream stream) => _stream = stream;

    public void WriteHead(JceType type, byte tag)
    {
        if (tag < 0xF)
        {
            _stream.WriteByte((byte)(tag << 4 | (byte)type));

        }
        else
        {
            _stream.WriteByte((byte)(0xF0 | (byte)type));
            _stream.WriteByte(tag);
        }
    }

    public void WriteInt8(sbyte value, byte tag)
    {
        if (value == 0)
        {
            WriteHead(JceType.ZeroTag, tag);
        }
        else
        {
            WriteHead(JceType.Byte, tag);
            _stream.WriteByte(Unsafe.As<sbyte, byte>(ref value));
        }
    }

    public void WriteBool(bool value, byte tag)
    {
        if (value)
        {
            WriteInt8(1, tag);
        }
        else
        {
            WriteInt8(0, tag);
        }
    }

    public void WriteInt16(short value, byte tag)
    {
        if (value is >= sbyte.MinValue and <= sbyte.MinValue)
        {
            WriteInt8((sbyte)value, tag);
        }
        else
        {
            WriteHead(JceType.Short, tag);
            _stream.Write(Number.FromUInt16((ushort)value));
        }
    }

    public void WriteInt32(int value, byte tag)
    {
        if (value is >= sbyte.MinValue and <= sbyte.MinValue)
        {
            WriteInt8((sbyte)value, tag);
        }
        else if (value is >= short.MinValue and <= short.MinValue)
        {
            WriteInt16((short)value, tag);
        }
        else
        {
            WriteHead(JceType.Int, tag);
            _stream.Write(Number.FromUInt32((uint)value));
        }
    }

    public void WriteInt64(long value, byte tag)
    {
        if (value is >= sbyte.MinValue and <= sbyte.MinValue)
        {
            WriteInt8((sbyte)value, tag);
        }
        else if (value is >= short.MinValue and <= short.MinValue)
        {
            WriteInt16((short)value, tag);
        }
        else if (value is >= int.MinValue and <= int.MinValue)
        {
            WriteInt32((int)value, tag);
        }
        else
        {
            WriteHead(JceType.Long, tag);
            _stream.Write(Number.FromUInt64((uint)value));
        }
    }

    public void WriteSingle(float value, byte tag)
    {
        WriteHead(JceType.Float, tag);
        _stream.Write(Number.FromSingle(value));
    }

    public void WriteDouble(double value, byte tag)
    {
        WriteHead(JceType.Double, tag);
        _stream.Write(Number.FromDouble(value));
    }

    public void WriteString(string value, byte tag)
    {
        if (value.Length > 255)
        {
            WriteHead(JceType.String4, tag);
            _stream.Write(Number.FromUInt32((uint)value.Length));
            _stream.Write(Encoding.UTF8.GetBytes(value));
        }
        else
        {
            WriteHead(JceType.String1, tag);
            _stream.WriteByte((byte)value.Length);
            _stream.Write(Encoding.UTF8.GetBytes(value));
        }
    }

    public void WriteBytes(byte[] value, byte tag)
    {
        WriteHead(JceType.SimpleList, tag);
        _stream.WriteByte(0);
        WriteInt32(value.Length, 0);
        _stream.Write(value);
    }

    public void WriteList<T>(IList<T> value, byte tag)
    {
        WriteHead(JceType.List, tag);
        if (value.Count == 0)
        {
            WriteHead(JceType.ZeroTag, 0);
            return;
        }
        WriteInt32(value.Count, 0);
        if (typeof(T) == typeof(byte[]))
        {
            foreach (object? item in value)
            {
                WriteBytes((byte[])item!,0);
            }
        }
        else if (typeof(T) == typeof(long))
        {
            foreach (object? item in value)
            {
                WriteInt64((long)item!, 0);
            }
        }
    }
}
*/
