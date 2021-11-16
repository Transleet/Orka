using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Orka
{
    internal static class Number
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short ToInt16(ReadOnlySpan<byte> bytes) => BinaryPrimitives.ReadInt16BigEndian(bytes);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short ToInt16(byte[] bytes) => BinaryPrimitives.ReadInt16BigEndian(bytes);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToInt32(Span<byte> bytes) => BinaryPrimitives.ReadInt32BigEndian(bytes);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToInt32(byte[] bytes) => BinaryPrimitives.ReadInt32BigEndian(bytes);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ToInt64(Span<byte> bytes) => BinaryPrimitives.ReadInt64BigEndian(bytes);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ToInt64(byte[] bytes) => BinaryPrimitives.ReadInt64BigEndian(bytes);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort ToUInt16(ReadOnlySpan<byte> bytes) => BinaryPrimitives.ReadUInt16BigEndian(bytes);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort ToUInt16(byte[] bytes) => BinaryPrimitives.ReadUInt16BigEndian(bytes);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ToUInt32(Span<byte> bytes) => BinaryPrimitives.ReadUInt32BigEndian(bytes);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ToUInt32(byte[] bytes) => BinaryPrimitives.ReadUInt32BigEndian(bytes);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ToUInt64(Span<byte> bytes) => BinaryPrimitives.ReadUInt64BigEndian(bytes);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ToUInt64(byte[] bytes) => BinaryPrimitives.ReadUInt64BigEndian(bytes);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] FromInt16(short number)
        {
            var buffer = GC.AllocateUninitializedArray<byte>(sizeof(short));
            BinaryPrimitives.WriteInt16BigEndian(buffer, number);
            return buffer;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] FromInt32(int number)
        {
            var buffer = GC.AllocateUninitializedArray<byte>(sizeof(int));
            BinaryPrimitives.WriteInt32BigEndian(buffer, number);
            return buffer;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] FromInt64(long number)
        {
            var buffer = GC.AllocateUninitializedArray<byte>(sizeof(long));
            BinaryPrimitives.WriteInt64BigEndian(buffer, number);
            return buffer;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] FromUInt16(ushort number)
        {
            var buffer = GC.AllocateUninitializedArray<byte>(sizeof(ushort));
            BinaryPrimitives.WriteUInt16BigEndian(buffer, number);
            return buffer;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] FromUInt32(uint number)
        {
            var buffer = GC.AllocateUninitializedArray<byte>(sizeof(uint));
            BinaryPrimitives.WriteUInt32BigEndian(buffer, number);
            return buffer;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] FromUInt64(ulong number)
        {
            var buffer = GC.AllocateUninitializedArray<byte>(sizeof(ulong));
            BinaryPrimitives.WriteUInt64BigEndian(buffer, number);
            return buffer;
        }
    }
}
