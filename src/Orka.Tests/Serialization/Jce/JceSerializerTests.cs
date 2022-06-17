using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Orka.Core.Extensions;
using Orka.Core.Serialization.Jce;
using Xunit;

namespace Orka.Tests.Serialization.Jce;


public class JceSerializerTests
{
    [Fact]
    public void JceSerializerTest1()
    {
        var expected = new TestJceStruct1()
        {
            Zero = 0,
            Num1 = (sbyte)Random.Shared.Next(sbyte.MinValue,sbyte.MaxValue),
            Num2 = (sbyte)Random.Shared.Next(sbyte.MinValue, sbyte.MaxValue),
            Num3 = (short)Random.Shared.Next(short.MinValue, short.MaxValue),
            Num4 = (sbyte)Random.Shared.Next(sbyte.MinValue, sbyte.MaxValue),
            Num5 = (short)Random.Shared.Next(short.MinValue, short.MaxValue),
            Num6 = Random.Shared.Next(),
            Num7 = (sbyte)Random.Shared.Next(sbyte.MinValue, sbyte.MaxValue),
            Num8 = (short)Random.Shared.Next(short.MinValue, short.MaxValue),
            Num9 = Random.Shared.Next(),
            Num10 = Random.Shared.NextInt64(),
            Num11 = Random.Shared.NextSingle(),
            Num12 = Random.Shared.NextDouble()
        };
        var bytes = JceSerializer.Serialize(expected);
        var actual = JceSerializer.Deserialize<TestJceStruct1>(bytes);
        Assert.Equal(expected,actual);
    }

    [Fact]
    public void JceSerializerTest2()
    {
        var expected = new TestJceStruct2()
        {
            Str1 = "Hello, world!",
            Str4 = Encoding.UTF8.GetString(Random.Shared.GetRandomBytes(2048)),
            Bytes = Random.Shared.GetRandomBytes(2048),
        };
        byte[] bytes = JceSerializer.Serialize(expected);
        var actual = JceSerializer.Deserialize<TestJceStruct2>(bytes);
        Assert.Equal(expected,actual);
    }
}
