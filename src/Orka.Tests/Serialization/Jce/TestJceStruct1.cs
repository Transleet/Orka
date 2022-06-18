using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Orka.Core.Serialization.Jce;

namespace Orka.Tests.Serialization.Jce;

internal class TestJceStruct1 : IJceStruct
{
    [JceMember(0)] public int Zero { get; set; }
    [JceMember(1)] public sbyte Num1 { get; set; }
    [JceMember(2)] public short Num2 { get; set; }
    [JceMember(3)] public short Num3 { get; set; }
    [JceMember(4)] public int Num4 { get; set; }
    [JceMember(5)] public int Num5 { get; set; }
    [JceMember(6)] public int Num6 { get; set; }
    [JceMember(7)] public long Num7 { get; set; }
    [JceMember(8)] public long Num8 { get; set; }
    [JceMember(9)] public long Num9 { get; set; }
    [JceMember(10)] public long Num10 { get; set; }
    [JceMember(11)] public float Num11 { get; set; }
    [JceMember(12)] public double Num12 { get; set; }

    protected bool Equals(TestJceStruct1 other) => Zero == other.Zero && Num1 == other.Num1 && Num2 == other.Num2 && Num3 == other.Num3 && Num4 == other.Num4 && Num5 == other.Num5 && Num6 == other.Num6 && Num7 == other.Num7 && Num8 == other.Num8 && Num9 == other.Num9 && Num10 == other.Num10 && Num11.Equals(other.Num11) && Num12.Equals(other.Num12);

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj))
        {
            return false;
        }

        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        if (obj.GetType() != this.GetType())
        {
            return false;
        }

        return Equals((TestJceStruct1)obj);
    }

    public override int GetHashCode()
    {
        var hashCode = new HashCode();
        hashCode.Add(Zero);
        hashCode.Add(Num1);
        hashCode.Add(Num2);
        hashCode.Add(Num3);
        hashCode.Add(Num4);
        hashCode.Add(Num5);
        hashCode.Add(Num6);
        hashCode.Add(Num7);
        hashCode.Add(Num8);
        hashCode.Add(Num9);
        hashCode.Add(Num10);
        hashCode.Add(Num11);
        hashCode.Add(Num12);
        return hashCode.ToHashCode();
    }
}
