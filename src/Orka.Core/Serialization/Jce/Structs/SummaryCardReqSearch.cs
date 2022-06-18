namespace Orka.Core.Serialization.Jce.Structs;

internal class SummaryCardReqSearch : IJceStruct
{
    [JceMember(0)] public string Keyword { get; set; }
    [JceMember(1)] public string CountryCode { get; set; }
    [JceMember(2)] public int Version { get; set; }
    [JceMember(3)] public JceList<byte[]> ReqServices { get; set; }
}
