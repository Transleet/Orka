﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Orka.Core.Extensions;
using Orka.Core.Serialization.Jce;
using Orka.Core.Serialization.Jce.Structs;
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
            Num1 = (sbyte)Random.Shared.Next(sbyte.MinValue, sbyte.MaxValue),
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
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void JceSerializerTest2()
    {
        var expected = new TestJceStruct2()
        {
            Str1 = "Hello, world!",
            Str4 = Encoding.UTF8.GetString(Random.Shared.GetRandomBytes(2048)),
            Bytes = Random.Shared.GetRandomBytes(2048),
            Dict = new JceMap { { "111", "222" }, { "333", "444" } },
            List = new JceList() { "555", "666", "777" }
        };
        byte[] bytes = JceSerializer.Serialize(expected);
        var actual = JceSerializer.Deserialize<TestJceStruct2>(bytes);
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void JceSerializeTest1()
    {
        byte[] expected = {
            16, 1, 32, 114, 49, 2, 2, 65, 7, 127, 86, 6, 231, 148, 176, 230, 137, 128, 102, 6, 230, 181, 169, 228,
            186, 140, 125, 0, 0, 13, 1, 1, 4, 5, 1, 4, 1, 9, 1, 9, 8, 1, 0, 129, 3, 42, 152, 0, 2, 6, 3, 49, 49, 52,
            22, 3, 53, 49, 52, 6, 4, 49, 57, 49, 57, 22, 3, 56, 49, 48, 168, 0, 2, 6, 6, 233, 135, 142, 229, 133,
            189, 22, 6, 229, 137, 141, 232, 190, 136, 6, 6, 231, 148, 176, 230, 137, 128, 22, 6, 230, 181, 169, 228,
            186, 140
        };
        var reqPacket = new RequestPacket
        {
            IVersion = 1,
            CPacketType = 114,
            IMessageType = 514,
            IRequestId = 1919,
            SServantName = "田所",
            SFuncName = "浩二",
            SBuffer = new byte[] { 1, 1, 4, 5, 1, 4, 1, 9, 1, 9, 8, 1, 0 },
            ITimeout = 810,
            Context = new JceMap { { "114", "514" }, { "1919", "810" } },
            Status = new JceMap { { "野兽", "前辈" }, { "田所", "浩二" } }
        };
        byte[] actual = JceSerializer.Serialize(reqPacket);
        Debug.WriteLine(string.Join(",",actual));
        Assert.Equal(expected,actual);
    }

    [Fact]
    public void JceDeserializeTest1()
    {
        byte[] bytes = {
            16, 1, 32, 114, 49, 2, 2, 65, 7, 127, 86, 6, 231, 148, 176, 230, 137, 128, 102, 6, 230, 181, 169, 228,
            186, 140, 125, 0, 0, 13, 1, 1, 4, 5, 1, 4, 1, 9, 1, 9, 8, 1, 0, 129, 3, 42, 152, 0, 2, 6, 3, 49, 49, 52,
            22, 3, 53, 49, 52, 6, 4, 49, 57, 49, 57, 22, 3, 56, 49, 48, 168, 0, 2, 6, 6, 233, 135, 142, 229, 133,
            189, 22, 6, 229, 137, 141, 232, 190, 136, 6, 6, 231, 148, 176, 230, 137, 128, 22, 6, 230, 181, 169, 228,
            186, 140
        };
        var expected = new RequestPacket
        {
            IVersion = 1,
            CPacketType = 114,
            IMessageType = 514,
            IRequestId = 1919,
            SServantName = "田所",
            SFuncName = "浩二",
            SBuffer = new byte[] { 1, 1, 4, 5, 1, 4, 1, 9, 1, 9, 8, 1, 0 },
            ITimeout = 810,
            Context = new JceMap { { "114", "514" }, { "1919", "810" } },
            Status = new JceMap { { "野兽", "前辈" }, { "田所", "浩二" } }
        };
        var actual = JceSerializer.Deserialize<RequestPacket>(bytes);
        Assert.Equal(expected, actual);
    }
}
