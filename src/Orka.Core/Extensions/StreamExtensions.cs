using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orka.Core.Extensions;

internal static class StreamExtensions
{
    public static byte[] ReadBytes(this Stream stream, int length)
    {
        byte[] arr = GC.AllocateUninitializedArray<byte>(length);
        int read = stream.Read(arr);
        return arr;
    }

    public static void WriteUInt8(this Stream stream, byte n)
    {
        stream.WriteByte(n);
    }
    public static void WriteUInt16(this Stream stream, ushort n)
    {
        stream.Write(Number.FromUInt16(n));
    }

    public static void WriteUInt32(this Stream stream, uint n)
    {
        stream.Write(Number.FromUInt32(n));
    }

    public static void WriteUInt64(this Stream stream, ulong n)
    {
        stream.Write(Number.FromUInt64(n));
    }

    public static void WriteInt32(this Stream stream, int n)
    {
        stream.Write(Number.FromInt32(n));
    }

    public static void WriteString(this Stream stream, string s)
    {
        stream.Write(Encoding.UTF8.GetBytes(s));
    }


    public static void WriteWithLength(this Stream stream, string s)
    {
        stream.WriteUInt32((uint)Encoding.UTF8.GetByteCount(s));
        stream.WriteString(s);
    }

    public static void WriteWithLength(this Stream stream, byte[] b)
    {
        stream.WriteUInt32((uint)b.Length);
        stream.Write(b);
    }

    public static void WriteTlv(this Stream stream, string s)
    {
        WriteTlv(stream, Encoding.UTF8.GetBytes(s));
    }

    public static void WriteTlv(this Stream stream, byte[] b)
    {
        stream.WriteUInt16((ushort)b.Length);
        stream.Write(b);
    }

    public static void WriteTlv(this Stream stream, string s, int limit)
    {
        WriteTlv(stream, Encoding.UTF8.GetBytes(s), limit);
    }

    public static void WriteTlv(this Stream stream, byte[] b, int limit)
    {
        WriteTlv(stream, b.Length <= limit ? b : b[..limit]);
    }
}
