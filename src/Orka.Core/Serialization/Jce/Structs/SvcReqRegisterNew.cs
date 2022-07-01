namespace Orka.Core.Serialization.Jce.Structs;

internal class SvcReqRegisterNew : IJceStruct
{
    [JceMember(0)] public long RequestOptional { get; set; }
    [JceMember(1)] public SvcReqGetMsgV2 C2CMsg { get; set; }
    [JceMember(2)] public SvcReqPullGroupMsgSeq GroupMsg { get; set; }
    [JceMember(14)] public byte DisGroupMsgFilter { get; set; }
    [JceMember(15)] public byte GroupMask { get; set; }
    [JceMember(16)] public long EndSeq { get; set; }
    [JceMember(20)] public byte[] O769Body { get; set; }
}
