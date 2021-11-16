namespace Orka
{
    public class Tea
    {
        //TODO May be wrong ,
        private readonly uint[] _key;
        private readonly uint[] _deltas =
        {
            0x9e3779b9, 0x3c6ef372, 0xdaa66d2b, 0x78dde6e4, 0x1715609d, 0xb54cda56, 0x5384540f, 0xf1bbcdc8,
            0x8ff34781, 0x2e2ac13a, 0xcc623af3, 0x6a99b4ac, 0x08d12e65, 0xa708a81e, 0x454021d7, 0xe3779b90,
        };

        public Tea(byte[] key)
        {
            if (key.Length != 16) throw new();
            _key = new uint[4];
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(key);
            }
            _key[0] = BitConverter.ToUInt32(key.AsSpan(12));
            _key[1] = BitConverter.ToUInt32(key.AsSpan(8));
            _key[2] = BitConverter.ToUInt32(key.AsSpan(4));
            _key[3] = BitConverter.ToUInt32(key.AsSpan());
        }

        private static void Xor(Span<byte> a, Span<byte> b, Span<byte> ret)
        {
            var aN = BitConverter.ToUInt64(a);
            var bN = BitConverter.ToUInt64(b);
            var bytes = BitConverter.GetBytes(aN ^ bN);
            bytes.AsSpan().CopyTo(ret);
        }

        public byte[] Encrypt(Span<byte> src)
        {
            var length = src.Length;
            var fill = 10 - ((length + 1) % 8);
            var tmp1 = new byte[8];
            var tmp2 = new byte[8];
            var dst = new byte[length + fill + 7];
            Random.Shared.NextBytes(dst.AsSpan(0, fill));
            dst[0] = (byte)((byte)(fill - 3) | 0xF8);
            var @in = 0;
            //#1
            if (fill < 8)
            {
                @in = 8 - fill;
                src[..@in].CopyTo(dst.AsSpan(fill));
            }
            dst.AsSpan(0, 8).CopyTo(tmp2);
            Encode(dst, dst);
            var @out = 8;
            //#2
            if (fill > 8)
            {
                src[..(16 - fill)].CopyTo(dst.AsSpan(fill));
                Xor(dst.AsSpan(8, 8), dst.AsSpan(0, 8), dst.AsSpan(8, 8));
                dst.AsSpan(8, 8).CopyTo(tmp1);
                Encode(dst.AsSpan(8), dst.AsSpan(8));
                Xor(dst.AsSpan(8), tmp2, dst.AsSpan(8));
                tmp1.CopyTo(tmp2.AsSpan());

                @in = 16 - fill;
                @out = 16;
            }
            //#3 or #4
            length -= 8;
            for (; @in < length;)
            {
                Xor(src[@in..], dst.AsSpan(@out - 8, 8), dst.AsSpan(@out));
                dst.AsSpan(@out, 8).CopyTo(tmp1);
                Encode(dst[@out..], dst.AsSpan(@out));
                Xor(dst.AsSpan(@out), tmp2, dst.AsSpan(@out));
                tmp1.CopyTo(tmp2, 0);
                @in += 8;
                @out += 8;
            }

            var tmp3 = new byte[8];
            src[@in..].CopyTo(tmp3);
            Xor(tmp3, dst.AsSpan(@out - 8), dst.AsSpan(@out));
            Encode(dst.AsSpan(@out), dst.AsSpan(@out));
            Xor(dst.AsSpan(@out), tmp2, dst.AsSpan(@out));
            return dst;
        }

        public byte[] Decrypt(Span<byte> data)
        {
            if (data.Length < 16 || data.Length % 8 != 0)
            {
                throw new();
            }

            var dst = new byte[data.Length];
            data.CopyTo(dst);
            Decode(dst, dst);
            var tmp = new byte[8];
            Buffer.BlockCopy(dst, 0, tmp, 0, 8);
            for (int i = 8; i < data.Length; i += 8)
            {
                Xor(dst.AsSpan(i), tmp, dst.AsSpan(i));
                Decode(dst.AsSpan(i), dst.AsSpan(i));
                Xor(dst.AsSpan(i, 8), data.Slice(i - 8, 8), dst.AsSpan(i, 8));
                Xor(dst.AsSpan(i), data[(i - 8)..], tmp);
            }

            return dst[((dst[0] & 7) + 3)..(data.Length - 7)];
        }

        internal void Encode(Span<byte> src, Span<byte> dst)
        {
            var (v0, v1) = Unpack(src);
            for (var i = 0; i < 0x10; i++)
            {
                v0 += ((v1 << 4) + _key[0]) ^ (v1 + _deltas[i]) ^ ((v1 >> 5) + _key[1]);
                v1 += ((v0 << 4) + _key[2]) ^ (v0 + _deltas[i]) ^ ((v0 >> 5) + _key[3]);
            }
            Repack(dst, v0, v1);
        }

        internal void Decode(Span<byte> src, Span<byte> dst)
        {
            var (v0, v1) = Unpack(src);
            for (var i = 0xf; i >= 0; i--)
            {
                v1 -= ((v0 << 4) + _key[2]) ^ (v0 + _deltas[i]) ^ ((v0 >> 5) + _key[3]);
                v0 -= ((v1 << 4) + _key[0]) ^ (v1 + _deltas[i]) ^ ((v1 >> 5) + _key[1]);
            }
            Repack(dst, v0, v1);
        }

        internal (uint v0, uint v1) Unpack(Span<byte> data)
        {
            var v1 = data[7] | ((uint)data[6] << 8) | ((uint)data[5] << 16) | ((uint)data[4] << 24);

            var v0 = data[3] | ((uint)data[2] << 8) | ((uint)data[1] << 16) | ((uint)data[0] << 24);

            return (v0, v1);
        }

        internal void Repack(Span<byte> data, uint v0, uint v1)
        {
            data[0] = (byte)(v0 >> 24);
            data[1] = (byte)(v0 >> 16);
            data[2] = (byte)(v0 >> 8);
            data[3] = (byte)v0;
            data[4] = (byte)(v1 >> 24);
            data[5] = (byte)(v1 >> 16);
            data[6] = (byte)(v1 >> 8);
            data[7] = (byte)v1;
        }
    }
}
