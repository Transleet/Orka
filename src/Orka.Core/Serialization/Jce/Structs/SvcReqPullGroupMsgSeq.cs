namespace Orka.Core.Serialization.Jce.Structs;

internal class SvcReqPullGroupMsgSeq : IJceStruct
{
    [JceMember(0)] public JceList<PullGroupSeqParam> GroupInfo { get; set; }
    [JceMember(1)] public byte VerifyType { get; set; }
    [JceMember(2)] public int Filter { get; set; }
}
