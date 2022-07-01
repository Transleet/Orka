namespace Orka.Core.Serialization.Jce.Structs;

internal class TroopNumber : IJceStruct
{
    [JceMember(0)] public long GroupUin { get; set; }
    [JceMember(1)] public long GroupCode { get; set; }
    [JceMember(2)] public byte Flag { get; set; }
    [JceMember(3)] public long GroupInfoSeq { get; set; }
    [JceMember(4)] public string GroupName { get; set; }
    [JceMember(5)] public string GroupMemo { get; set; }
    [JceMember(6)] public long GroupFlagExt { get; set; }
    [JceMember(7)] public long GroupRankSeq { get; set; }
    [JceMember(8)] public long CertificationType { get; set; }
    [JceMember(9)] public long ShutUpTimestamp { get; set; }
    [JceMember(10)] public long MyShutUpTimestamp { get; set; }
    [JceMember(11)] public long CmdUinUinFlag { get; set; }
    [JceMember(12)] public long AdditionalFlag { get; set; }
    [JceMember(13)] public long GroupTypeFlag { get; set; }
    [JceMember(14)] public long GroupSecType { get; set; }
    [JceMember(15)] public long GroupSecTypeInfo { get; set; }
    [JceMember(16)] public long GroupClassExt { get; set; }
    [JceMember(17)] public long AppPrivilegeFlag { get; set; }
    [JceMember(18)] public long SubscriptionUin { get; set; }
    [JceMember(19)] public long MemberNum { get; set; }
    [JceMember(20)] public long MemberNumSeq { get; set; }
    [JceMember(21)] public long MemberCardSeq { get; set; }
    [JceMember(22)] public long GroupFlagExt3 { get; set; }
    [JceMember(23)] public long GroupOwnerUin { get; set; }
    [JceMember(24)] public byte IsConfGroup { get; set; }
    [JceMember(25)] public byte IsModifyConfGroupFace { get; set; }
    [JceMember(26)] public byte IsModifyConfGroupName { get; set; }
    [JceMember(27)] public long CmdUinJoinTime { get; set; }
    [JceMember(28)] public long CompanyId { get; set; }
    [JceMember(29)] public long MaxGroupMemberNum { get; set; }
    [JceMember(30)] public long CmdUinGroupMask { get; set; }
    [JceMember(31)] public long GuildAppId { get; set; }
    [JceMember(32)] public long GuildSubType { get; set; }
    [JceMember(33)] public long CmdUinRingtoneID { get; set; }
    [JceMember(34)] public long CmdUinFlagEx2 { get; set; }
}
