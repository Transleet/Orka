using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Orka;

public class BinaryStream : MemoryStream
{
    public BinaryStream()
    {
    }

    public BinaryStream(byte[] buffer) : base(buffer)
    {
    }

    public byte[] ReadBytes(int length)
    {
        Span<byte> b = stackalloc byte[length];
        Read(b);
        return b.ToArray();
    }

    public long Lave { get => Length - Position; }

    public new BinaryStream Write(byte[] buffer, int offset, int count)
    {
        base.Write(buffer, offset, count);
        return this;
    }

    public new BinaryStream Write(ReadOnlySpan<byte> buffer)
    {
        base.Write(buffer);
        return this;
    }

    public new BinaryStream WriteByte(byte value)
    {
        base.WriteByte(value);
        return this;
    }

    public int ReadInt32()
    {
        return (int)BinaryPrimitives.ReadUInt32BigEndian(this.ReadBytes(4));
    }

    public ushort ReadUInt16()
    {
        return BinaryPrimitives.ReadUInt16BigEndian(this.ReadBytes(2));
    }

    public string ReadString()
    {
        return Encoding.UTF8.GetString(this.ReadBytes(ReadInt32() - 4));
    }

    public string ReadStringShort()
    {
        var data = this.ReadBytes(ReadUInt16());
        return Encoding.UTF8.GetString(data);
    }

    public Span<byte> ReadAvailable()
    {
        return this.ReadBytes((int)Lave);
    }

    public Dictionary<ushort, byte[]> ReadTlvMap(int tagSize)
    {
        var map = new Dictionary<ushort, byte[]>();
        while (true)
        {
            if (Lave < tagSize)
            {
                return map;
            }
            ushort k = 0;
            if (tagSize == 1)
            {
                k = (ushort)ReadByte();
            }
            else if (tagSize == 2)
            {
                k = ReadUInt16();
            }
            else if (tagSize == 4)
            {
                k = (ushort)ReadInt32();
            }

            if (k == 255)
            {
                return map;
            }
            map[k] = this.ReadBytes(ReadUInt16()).ToArray();
        }
    }

    public string ReadStringLimit(int limit)
    {
        var data = this.ReadBytes(limit);
        return Encoding.UTF8.GetString(data);
    }

    public byte[] ReadBytesShort()
    {
        return this.ReadBytes(ReadUInt16()).ToArray();
    }

    public BinaryStream WriteHexString(string s)
    {
        Write(Convert.FromHexString(s));
        return this;
    }

    public BinaryStream WriteUInt32(uint n)
    {
        Span<byte> span = stackalloc byte[4];
        BinaryPrimitives.WriteUInt32BigEndian(span, n);
        Write(span);
        return this;
    }

    public BinaryStream WriteUInt16(ushort n)
    {
        Span<byte> span = stackalloc byte[2];
        BinaryPrimitives.WriteUInt16BigEndian(span, n);
        Write(span);
        return this;
    }

    public BinaryStream WriteUInt64(ulong n)
    {
        Span<byte> span = stackalloc byte[8];
        BinaryPrimitives.WriteUInt64BigEndian(span, n);
        Write(span);
        return this;
    }

    public BinaryStream WriteBool(bool b)
    {
        WriteByte(b ? (byte)0x01 : (byte)0x00);
        return this;
    }

    public BinaryStream WriteString(string s)
    {
        var b = Encoding.UTF8.GetBytes(s);
        WriteUInt32((uint)(b.Length + 4));
        Write(b);
        return this;
    }

    public BinaryStream WriteIntLvPacket(int offset, byte[] data)
    {
        WriteUInt32((uint)(data.Length + offset));
        Write(data);
        return this;
    }

    public BinaryStream EncryptAndWrite(byte[] key, byte[] data)
    {
        var tea = new Tea(key);
        Write(tea.Encrypt(data));
        return this;
    }

    public BinaryStream WriteBytesShort(byte[] data)
    {
        WriteUInt16((ushort)data.Length);
        Write(data);
        return this;
    }

    public BinaryStream WriteStringShort(string str)
    {
        WriteBytesShort(Encoding.UTF8.GetBytes(str));
        return this;
    }

    public BinaryStream WriteTlvLimitedSize(byte[] data, int limit)
    {
        if (data.Length <= limit)
        {
            WriteBytesShort(data);
            return this;
        }
        WriteBytesShort(data[..limit]);
        return this;
    }
}
