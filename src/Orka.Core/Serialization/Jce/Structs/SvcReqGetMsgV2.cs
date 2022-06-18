namespace Orka.Core.Serialization.Jce.Structs;

internal class SvcReqGetMsgV2 : IJceStruct
{
    [JceMember(0)] public long Uin { get; set; }
    [JceMember(1)] public int DateTime { get; set; }
    [JceMember(4)] public sbyte RecivePic { get; set; }
    [JceMember(6)] public short Ability { get; set; }
    [JceMember(9)] public sbyte Channel { get; set; }
    [JceMember(16)] public sbyte Inst { get; set; }
    [JceMember(17)] public sbyte ChannelEx { get; set; }
    [JceMember(18)] public byte[] SyncCookie { get; set; }
    [JceMember(19)] public int SyncFlag { get; set; }
    [JceMember(20)] public sbyte RambleFlag { get; set; }
    [JceMember(26)] public long GeneralAbi { get; set; }
    [JceMember(27)] public byte[] PubAccountCookie { get; set; }
}
