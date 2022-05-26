using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Orka.Tests
{
    public class TeaTests
    {
        [Fact]
        public void TeaTest1()
        {
            var key = Random.Shared.GetRandomBytes(16);
            var expected = Random.Shared.GetRandomBytes();
            var tea = new Tea(key);
            var enc = MockTea.Encrypt(expected, key);
            var dec = MockTea.Decrypt(enc, key);
            Assert.Equal(expected, dec);
        }

        [Fact]
        public void TeaTest2()
        {
            var key = Random.Shared.GetRandomBytes(16);
            var expected = Random.Shared.GetRandomBytes();
            var tea = new Tea(key);
            var enc = MockTea.Encrypt(expected, key);
            var dec = tea.Decrypt(enc);
            Assert.Equal(expected, dec);
        }

        [Fact]
        public void TeaTest3()
        {
            var key = Random.Shared.GetRandomBytes(16);
            var expected = Random.Shared.GetRandomBytes();
            var tea = new Tea(key);
            var enc = tea.Encrypt(expected);
            var dec = tea.Decrypt(enc);
            Assert.Equal(expected, dec);
        }

        [Fact]
        public void TeaTest4()
        {
            var key = Random.Shared.GetRandomBytes(16);
            var expected = Random.Shared.GetRandomBytes();
            var tea = new Tea(key);
            var enc = tea.Encrypt(expected);
            var dec = MockTea.Decrypt(enc,key);
            Assert.Equal(expected, dec);
        }
    }
}
