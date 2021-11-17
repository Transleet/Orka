using System;

using NUnit.Framework;

namespace Orka.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Serialize()
        {
            FullDevice device = OrkaClient.GenerateFullDevice(1919);
            string a = device.ToString();
            Console.WriteLine(a);
            Assert.Pass();
        }
    }
}
