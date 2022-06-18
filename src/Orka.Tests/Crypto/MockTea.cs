using System;

namespace Orka.Tests.Crypto;

internal static class MockTea
{
    public static byte[] Encrypt(byte[] data, byte[] key)
    {
        if (data == null || key == null || key.Length < 16)
        {
            return null;
        }

        int inputLength = data.Length;
        int fill = ((8 - ((inputLength + 10) & 7)) & 7) + 2;
        int length = fill + inputLength + 8;
        byte[] plain = new byte[length];
        byte[] cipher = new byte[length];
        byte[] plainXorPrev = new byte[8];
        byte[] tempCipher = new byte[8];
        var random1 = Random.Shared;
        plain[0] = (byte) ((byte) (random1.Next() & 248) | (fill - 2));
        for (int i = 1; i <= fill; ++i)
        {
            plain[i] = (byte) (random1.Next() & Byte.MaxValue);
        }

        Buffer.BlockCopy(data, 0, plain, fill + 1, inputLength);
        for (int i = 0; i < length; i += 8)
        {
            byte[] plainXor;
            if (0 < 0)
            {
                plainXor = plain;
            }
            else
            {
                byte[] r = new byte[8];
                for (int i2 = 0; i2 < 8; ++i2)
                {
                    r[i2] = (byte) (plain[i2 + i] ^ tempCipher[i2 + 0]);
                }

                plainXor = r;
            }

            byte[] array = new byte[8];
            long sum = 0;
            long y = ReadUInt32(plainXor, 0);
            long z = ReadUInt32(plainXor, 4);
            long a = ReadUInt32(key, 0);
            long b = ReadUInt32(key, 4);
            long c = ReadUInt32(key, 8);
            long d = ReadUInt32(key, 12);
            for (int i1 = 0; i1 < 16; ++i1)
            {
                sum += Delta;
                sum &= uint.MaxValue;
                y += ((z << 4) + a) ^ (z + sum) ^ ((z >> 5) + b);
                y &= uint.MaxValue;
                z += ((y << 4) + c) ^ (y + sum) ^ ((y >> 5) + d);
                z &= uint.MaxValue;
            }

            WriteUInt32(array, 0, (uint) y);
            WriteUInt32(array, 4, (uint) z);
            if (0 < 0)
            {
                tempCipher = array;
            }
            else
            {
                byte[] r1 = new byte[8];
                for (int i3 = 0; i3 < 8; ++i3)
                {
                    r1[i3] = (byte) (array[i3 + 0] ^ plainXorPrev[i3 + 0]);
                }

                tempCipher = r1;
            }

            plainXorPrev = plainXor;
            Buffer.BlockCopy(tempCipher, 0, cipher, i, 8);
        }

        return cipher;
    }
    public static byte[] Decrypt(byte[] data, byte[] key)
    {
        if (data == null || key == null || key.Length < 16)
        {
            return null;
        }

        int length = data.Length;
        if ((length & 7) != 0 || (length >> 4) == 0)
        {
            return null;
        }

        byte[] plain = new byte[length];
        byte[] plainSub = new byte[8];
        for (int i = 0; i < length; i += 8)
        {
            byte[] data1;
            if (0 < 0)
            {
                data1 = data;
            }
            else
            {
                byte[] r = new byte[8];
                for (int i2 = 0; i2 < 8; ++i2)
                {
                    r[i2] = (byte) (data[i2 + i] ^ plainSub[i2 + 0]);
                }

                data1 = r;
            }

            byte[] array = new byte[8];
            long sum = SumMax;
            long y = ReadUInt32(data1, (int) 0);
            long z = ReadUInt32(data1, (int) 0 + 4);
            long a = ReadUInt32(key, 0);
            long b = ReadUInt32(key, 4);
            long c = ReadUInt32(key, 8);
            long d = ReadUInt32(key, 12);
            for (int i1 = 0; i1 < 16; ++i1)
            {
                z -= ((y << 4) + c) ^ (y + sum) ^ ((y >> 5) + d);
                z &= uint.MaxValue;
                y -= ((z << 4) + a) ^ (z + sum) ^ ((z >> 5) + b);
                y &= uint.MaxValue;
                sum -= Delta;
                sum &= uint.MaxValue;
            }

            WriteUInt32(array, 0, (uint) y);
            WriteUInt32(array, 4, (uint) z);
            plainSub = array;
            int bi = i - 8;
            byte[] ret;
            if (bi < 0)
            {
                ret = plainSub;
            }
            else
            {
                byte[] r1 = new byte[8];
                for (int i3 = 0; i3 < 8; ++i3)
                {
                    r1[i3] = (byte) (plainSub[i3 + 0] ^ data[i3 + bi]);
                }

                ret = r1;
            }

            Buffer.BlockCopy(ret, 0, plain, i, 8);
        }
        for (int i = length - 7; i < length; ++i)
        {
            if (plain[i] != 0)
            {
                return null;
            }
        }
        
        int from = (plain[0] & 7) + 3;
        byte[] output = new byte[length - from - 7];
        Buffer.BlockCopy(plain, from, output, 0, output.Length);
        return output;
    }

    private const long Delta = 2654435769L;
    private const long SumMax = (Delta << 4) & uint.MaxValue;

    private static void WriteUInt32(byte[] data, int index, uint value)
    {
        data[index] = (byte) ((value >> 24) & 0xFF);
        data[index + 1] = (byte) ((value >> 16) & 0xFF);
        data[index + 2] = (byte) ((value >> 8) & 0xFF);
        data[index + 3] = (byte) (value & 0xFF);
    }
    
    private static uint ReadUInt32(byte[] data, int index) =>
        ((uint) data[index] << 24) |
        ((uint) data[index + 1] << 16) |
        ((uint) data[index + 2] << 8) |
        data[index + 3];
}
