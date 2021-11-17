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
        public byte[]? QRSig { get; set; }
        public BigData? BigData { get; set; }

        public byte[]? HB408 { get; set; }
    }
}