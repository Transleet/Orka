using System;
using System.IO;
using ProtoBuf;

namespace Orka;

public partial class OrkaClient
{
    internal class Sig
    {
        public uint Seq { get; set; }
        public byte[]? Session { get; set; }
        public byte[]? RandomKey { get; set; }
        public byte[]? Tgtgt { get; set; }
        public byte[]? Tgt { get; set; }
        public byte[]? SKey { get; set; }
        public byte[]? D2 { get; set; }
        public byte[]? D2Key { get; set; }
        public byte[]? T104 { get; set; }
        public byte[]? T174 { get; set; }
        public byte[]? QrSig { get; set; }
        public BigData? BigData { get; set; }
        public byte[]? Hb408 { get; set; }
        public int EmpTime { get; set; }
    }

    public static byte[] SerializeHb408(Uin uin)
    {
        var stream = new MemoryStream();
        var buffer = GC.AllocateArray<byte>(9);

        var data = new TempData() { Num1 = 1152, Num2 = 9, };
        throw new NotImplementedException();
    }

    [ProtoContract]
    private class TempData
    {
        [ProtoMember(1)]public long Num1 { get; set; }
        [ProtoMember(2)]public long Num2 { get; set; }
        [ProtoMember(4)]public byte[] Buffer { get; set; }
        
    }
}
