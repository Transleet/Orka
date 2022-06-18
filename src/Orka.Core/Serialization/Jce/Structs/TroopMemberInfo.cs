namespace Orka.Core.Serialization.Jce.Structs;

internal class TroopMemberInfo : IJceStruct
{
    [JceMember(0)] public long MemberUin { get; set; }
    [JceMember(1)] public short FaceId { get; set; }
    [JceMember(2)] public sbyte Age { get; set; }
    [JceMember(3)] public sbyte Gender { get; set; }
    [JceMember(4)] public string Nick { get; set; }
    [JceMember(5)] public sbyte Status { get; set; }
    [JceMember(6)] public string ShowName { get; set; }
    [JceMember(8)] public string Name { get; set; }
    [JceMember(12)] public string Memo { get; set; }
    [JceMember(13)] public string AutoRemark { get; set; }
    [JceMember(14)] public long MemberLevel { get; set; }
    [JceMember(15)] public long JoinTime { get; set; }
    [JceMember(16)] public long LastSpeakTime { get; set; }
    [JceMember(17)] public long CreditLevel { get; set; }
    [JceMember(18)] public long Flag { get; set; }
    [JceMember(19)] public long FlagExt { get; set; }
    [JceMember(20)] public long Point { get; set; }
    [JceMember(21)] public sbyte Concerned { get; set; }
    [JceMember(22)] public sbyte Shielded { get; set; }
    [JceMember(23)] public string SpecialTitle { get; set; }
    [JceMember(24)] public long SpecialTitleExpireTime { get; set; }
    [JceMember(25)] public string Job { get; set; }
    [JceMember(26)] public sbyte ApolloFlag { get; set; }
    [JceMember(27)] public long ApolloTimestamp { get; set; }
    [JceMember(28)] public long GlobalGroupLevel { get; set; }
    [JceMember(29)] public long TitleId { get; set; }
    [JceMember(30)] public long ShutUpTimestap { get; set; }
    [JceMember(31)] public long GlobalGroupPoint { get; set; }
    [JceMember(33)] public sbyte RichCardNameVer { get; set; }
    [JceMember(34)] public long VipType { get; set; }
    [JceMember(35)] public long VipLevel { get; set; }
    [JceMember(36)] public long BigClubLevel { get; set; }
    [JceMember(37)] public long BigClubFlag { get; set; }
    [JceMember(38)] public long Nameplate { get; set; }
    [JceMember(39)] public byte[] GroupHonor { get; set; }
}
