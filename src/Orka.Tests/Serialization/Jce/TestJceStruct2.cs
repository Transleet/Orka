using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orka.Core.Serialization.Jce;

namespace Orka.Tests.Serialization.Jce;

internal class TestJceStruct2 : IJceStruct
{
    [JceMember(0)] public string Str1 { get; set; }
    [JceMember(1)] public string Str4 { get; set; }
    [JceMember(2)] public byte[] Bytes { get; set; }
    [JceMember(3)] public JceMap Dict { get; set; }
    [JceMember(4)] public JceList List { get; set; }

    protected bool Equals(TestJceStruct2 other) => Str1 == other.Str1 && Str4 == other.Str4 && Bytes.SequenceEqual(other.Bytes) && Dict.Cast<DictionaryEntry>().Union(other.Dict.Cast<DictionaryEntry>()).Count() == Dict.Count && List.ToArray().SequenceEqual(other.List.ToArray());

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

        return Equals((TestJceStruct2)obj);
    }

    public override int GetHashCode() => HashCode.Combine(Str1, Str4, Bytes, Dict, List);
}
