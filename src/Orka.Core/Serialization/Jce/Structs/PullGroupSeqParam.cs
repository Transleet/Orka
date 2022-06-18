namespace Orka.Core.Serialization.Jce.Structs;

internal class PullGroupSeqParam : IJceStruct
{
    [JceMember(0)] public long GroupCode { get; set; }
    [JceMember(1)] public long LastSeqId { get; set; }
}
