namespace Orka.Core.Serialization.Jce.Structs;

internal class TroopMemberListRequest : IJceStruct
{
    [JceMember(0)] public long Uin { get; set; }
    [JceMember(1)] public long GroupCode { get; set; }
    [JceMember(2)] public long NextUin { get; set; }
    [JceMember(3)] public long GroupUin { get; set; }
    [JceMember(4)] public long Version { get; set; }
    [JceMember(5)] public long ReqType { get; set; }
    [JceMember(6)] public long GetListAppointTime { get; set; }
    [JceMember(7)] public byte RichCardNameVer { get; set; }
}
