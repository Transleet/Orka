using System;
using Orka.Core.Crypto;
using Orka.Core.Extensions;
using Xunit;

namespace Orka.Tests.Crypto;

public class TeaTests
{
    [Fact]
    public void TeaTest1()
    {
        byte[] key = Random.Shared.GetRandomBytes(16);
        byte[] expected = Random.Shared.GetRandomBytes();
        byte[] enc = MockTea.Encrypt(expected, key);
        byte[] dec = MockTea.Decrypt(enc, key);
        Assert.Equal(expected, dec);
    }

    [Fact]
    public void TeaTest2()
    {
        byte[] key = Random.Shared.GetRandomBytes(16);
        byte[] expected = Random.Shared.GetRandomBytes();
        byte[] enc = Tea.Encrypt(expected,key);
        byte[] dec = Tea.Decrypt(enc, key);
        Assert.Equal(expected, dec);
    }

    [Fact]
    public void TeaTest3()
    {
        byte[] key = Random.Shared.GetRandomBytes(16);
        byte[] expected = Random.Shared.GetRandomBytes();
        byte[] enc = MockTea.Encrypt(expected, key);
        byte[] dec = Tea.Decrypt(enc, key);
        Assert.Equal(expected, dec);
    }



    [Fact]
    public void TeaTest4()
    {
        byte[] key = Random.Shared.GetRandomBytes(16);
        byte[] expected = Random.Shared.GetRandomBytes();
        byte[] enc = Tea.Encrypt(expected, key);
        byte[] dec = MockTea.Decrypt(enc, key);
        Assert.Equal(expected, dec);
    }
}
