using System;

namespace Orka;

internal class Tea
{
    private readonly uint[] _key;
    public Tea(byte[] key)
    {
        if (key.Length != 16)
        {
            throw new Exception("Key length must be 16.");
        }

        _key = new uint[4];
        _key[0] = Number.ToUInt32(key[..4]);
        _key[1] = Number.ToUInt32(key[4..8]);
        _key[2] = Number.ToUInt32(key[8..12]);
        _key[3] = Number.ToUInt32(key[12..]);
    }

    public byte[] Encrypt(byte[] src)
    {
        int length = src.Length;
        int fill = 10 - (length + 1) % 8;
        byte[] dst = new byte[fill + length + 7];
        dst[0] = (byte)((fill - 3) | 0xF8);
        Buffer.BlockCopy(src, 0, dst, fill, src.Length);
        ulong iv1 = 0, iv2 = 0;
        for (int i = 0; i < length; i += 8)
        {
            ulong block = Number.ToUInt64(dst[i..]);
            ulong holder = block ^ iv1;
            iv1 = Encode(holder);
            iv1 ^= iv2;
            iv2 = holder;
            Buffer.BlockCopy(Number.FromUInt64(iv1), 0, dst, i, 8);
        }
        return dst;
    }

    public byte[] Decrypt(byte[] data)
    {
        if (data.Length < 16 || data.Length % 8 != 0)
        {
            throw new Exception();
        }

        byte[] dst = new byte[data.Length];
        ulong iv2 = 0, holder = 0;
        for (int i = 0; i < data.Length; i += 8)
        {
            ulong iv1 = Number.ToUInt64(data[i..]);
            iv2 ^= iv1;
            iv2 = Decode(iv2);
            Buffer.BlockCopy(Number.FromUInt64(iv2 ^ holder), 0, dst, i, 8);
            holder = iv1;
        }
        return dst[(dst[0] & 7 + 3)..(data.Length - 7)];
    }

    private ulong Encode(ulong n)
    {
        (uint v0, uint v1) = ((uint)(n >> 32), (uint)n);
        (uint t0, uint t1, uint t2, uint t3) = (_key[0], _key[1], _key[2], _key[3]);
        v0 += (v1 + 0x9e3779b9) ^ ((v1 << 4) + t0) ^ ((v1 >> 5) + t1);
        v1 += (v0 + 0x9e3779b9) ^ ((v0 << 4) + t2) ^ ((v0 >> 5) + t3);
        v0 += (v1 + 0x3c6ef372) ^ ((v1 << 4) + t0) ^ ((v1 >> 5) + t1);
        v1 += (v0 + 0x3c6ef372) ^ ((v0 << 4) + t2) ^ ((v0 >> 5) + t3);
        v0 += (v1 + 0xdaa66d2b) ^ ((v1 << 4) + t0) ^ ((v1 >> 5) + t1);
        v1 += (v0 + 0xdaa66d2b) ^ ((v0 << 4) + t2) ^ ((v0 >> 5) + t3);
        v0 += (v1 + 0x78dde6e4) ^ ((v1 << 4) + t0) ^ ((v1 >> 5) + t1);
        v1 += (v0 + 0x78dde6e4) ^ ((v0 << 4) + t2) ^ ((v0 >> 5) + t3);
        v0 += (v1 + 0x1715609d) ^ ((v1 << 4) + t0) ^ ((v1 >> 5) + t1);
        v1 += (v0 + 0x1715609d) ^ ((v0 << 4) + t2) ^ ((v0 >> 5) + t3);
        v0 += (v1 + 0xb54cda56) ^ ((v1 << 4) + t0) ^ ((v1 >> 5) + t1);
        v1 += (v0 + 0xb54cda56) ^ ((v0 << 4) + t2) ^ ((v0 >> 5) + t3);
        v0 += (v1 + 0x5384540f) ^ ((v1 << 4) + t0) ^ ((v1 >> 5) + t1);
        v1 += (v0 + 0x5384540f) ^ ((v0 << 4) + t2) ^ ((v0 >> 5) + t3);
        v0 += (v1 + 0xf1bbcdc8) ^ ((v1 << 4) + t0) ^ ((v1 >> 5) + t1);
        v1 += (v0 + 0xf1bbcdc8) ^ ((v0 << 4) + t2) ^ ((v0 >> 5) + t3);
        v0 += (v1 + 0x8ff34781) ^ ((v1 << 4) + t0) ^ ((v1 >> 5) + t1);
        v1 += (v0 + 0x8ff34781) ^ ((v0 << 4) + t2) ^ ((v0 >> 5) + t3);
        v0 += (v1 + 0x2e2ac13a) ^ ((v1 << 4) + t0) ^ ((v1 >> 5) + t1);
        v1 += (v0 + 0x2e2ac13a) ^ ((v0 << 4) + t2) ^ ((v0 >> 5) + t3);
        v0 += (v1 + 0xcc623af3) ^ ((v1 << 4) + t0) ^ ((v1 >> 5) + t1);
        v1 += (v0 + 0xcc623af3) ^ ((v0 << 4) + t2) ^ ((v0 >> 5) + t3);
        v0 += (v1 + 0x6a99b4ac) ^ ((v1 << 4) + t0) ^ ((v1 >> 5) + t1);
        v1 += (v0 + 0x6a99b4ac) ^ ((v0 << 4) + t2) ^ ((v0 >> 5) + t3);
        v0 += (v1 + 0x08d12e65) ^ ((v1 << 4) + t0) ^ ((v1 >> 5) + t1);
        v1 += (v0 + 0x08d12e65) ^ ((v0 << 4) + t2) ^ ((v0 >> 5) + t3);
        v0 += (v1 + 0xa708a81e) ^ ((v1 << 4) + t0) ^ ((v1 >> 5) + t1);
        v1 += (v0 + 0xa708a81e) ^ ((v0 << 4) + t2) ^ ((v0 >> 5) + t3);
        v0 += (v1 + 0x454021d7) ^ ((v1 << 4) + t0) ^ ((v1 >> 5) + t1);
        v1 += (v0 + 0x454021d7) ^ ((v0 << 4) + t2) ^ ((v0 >> 5) + t3);
        v0 += (v1 + 0xe3779b90) ^ ((v1 << 4) + t0) ^ ((v1 >> 5) + t1);
        v1 += (v0 + 0xe3779b90) ^ ((v0 << 4) + t2) ^ ((v0 >> 5) + t3);
        return (ulong)v0 << 32 | v1;
    }

    private ulong Decode(ulong n)
    {
        (uint v0, uint v1) = ((uint)(n >> 32), (uint)n);
        (uint t0, uint t1, uint t2, uint t3) = (_key[0], _key[1], _key[2], _key[3]);
        v1 -= (v0 + 0xe3779b90) ^ ((v0 << 4) + t2) ^ ((v0 >> 5) + t3);
        v0 -= (v1 + 0xe3779b90) ^ ((v1 << 4) + t0) ^ ((v1 >> 5) + t1);
        v1 -= (v0 + 0x454021d7) ^ ((v0 << 4) + t2) ^ ((v0 >> 5) + t3);
        v0 -= (v1 + 0x454021d7) ^ ((v1 << 4) + t0) ^ ((v1 >> 5) + t1);
        v1 -= (v0 + 0xa708a81e) ^ ((v0 << 4) + t2) ^ ((v0 >> 5) + t3);
        v0 -= (v1 + 0xa708a81e) ^ ((v1 << 4) + t0) ^ ((v1 >> 5) + t1);
        v1 -= (v0 + 0x08d12e65) ^ ((v0 << 4) + t2) ^ ((v0 >> 5) + t3);
        v0 -= (v1 + 0x08d12e65) ^ ((v1 << 4) + t0) ^ ((v1 >> 5) + t1);
        v1 -= (v0 + 0x6a99b4ac) ^ ((v0 << 4) + t2) ^ ((v0 >> 5) + t3);
        v0 -= (v1 + 0x6a99b4ac) ^ ((v1 << 4) + t0) ^ ((v1 >> 5) + t1);
        v1 -= (v0 + 0xcc623af3) ^ ((v0 << 4) + t2) ^ ((v0 >> 5) + t3);
        v0 -= (v1 + 0xcc623af3) ^ ((v1 << 4) + t0) ^ ((v1 >> 5) + t1);
        v1 -= (v0 + 0x2e2ac13a) ^ ((v0 << 4) + t2) ^ ((v0 >> 5) + t3);
        v0 -= (v1 + 0x2e2ac13a) ^ ((v1 << 4) + t0) ^ ((v1 >> 5) + t1);
        v1 -= (v0 + 0x8ff34781) ^ ((v0 << 4) + t2) ^ ((v0 >> 5) + t3);
        v0 -= (v1 + 0x8ff34781) ^ ((v1 << 4) + t0) ^ ((v1 >> 5) + t1);
        v1 -= (v0 + 0xf1bbcdc8) ^ ((v0 << 4) + t2) ^ ((v0 >> 5) + t3);
        v0 -= (v1 + 0xf1bbcdc8) ^ ((v1 << 4) + t0) ^ ((v1 >> 5) + t1);
        v1 -= (v0 + 0x5384540f) ^ ((v0 << 4) + t2) ^ ((v0 >> 5) + t3);
        v0 -= (v1 + 0x5384540f) ^ ((v1 << 4) + t0) ^ ((v1 >> 5) + t1);
        v1 -= (v0 + 0xb54cda56) ^ ((v0 << 4) + t2) ^ ((v0 >> 5) + t3);
        v0 -= (v1 + 0xb54cda56) ^ ((v1 << 4) + t0) ^ ((v1 >> 5) + t1);
        v1 -= (v0 + 0x1715609d) ^ ((v0 << 4) + t2) ^ ((v0 >> 5) + t3);
        v0 -= (v1 + 0x1715609d) ^ ((v1 << 4) + t0) ^ ((v1 >> 5) + t1);
        v1 -= (v0 + 0x78dde6e4) ^ ((v0 << 4) + t2) ^ ((v0 >> 5) + t3);
        v0 -= (v1 + 0x78dde6e4) ^ ((v1 << 4) + t0) ^ ((v1 >> 5) + t1);
        v1 -= (v0 + 0xdaa66d2b) ^ ((v0 << 4) + t2) ^ ((v0 >> 5) + t3);
        v0 -= (v1 + 0xdaa66d2b) ^ ((v1 << 4) + t0) ^ ((v1 >> 5) + t1);
        v1 -= (v0 + 0x3c6ef372) ^ ((v0 << 4) + t2) ^ ((v0 >> 5) + t3);
        v0 -= (v1 + 0x3c6ef372) ^ ((v1 << 4) + t0) ^ ((v1 >> 5) + t1);
        v1 -= (v0 + 0x9e3779b9) ^ ((v0 << 4) + t2) ^ ((v0 >> 5) + t3);
        v0 -= (v1 + 0x9e3779b9) ^ ((v1 << 4) + t0) ^ ((v1 >> 5) + t1);
        return (ulong)v0 << 32 | v1;
    }
}
