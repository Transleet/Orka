namespace Orka.Core.Serialization.Jce.Structs;

internal class SvcReqRegister
{
    [JceMember(0)] public long Uin { get; set; }
    [JceMember(1)] public long Bid { get; set; }
    [JceMember(2)] public sbyte ConnType { get; set; }
    [JceMember(3)] public string Other { get; set; }
    [JceMember(4)] public int Status { get; set; }
    [JceMember(5)] public sbyte OnlinePush { get; set; }
    [JceMember(6)] public sbyte IsOnline { get; set; }
    [JceMember(7)] public sbyte IsShowOnline { get; set; }
    [JceMember(8)] public sbyte KickPC { get; set; }
    [JceMember(9)] public sbyte KickWeak { get; set; }
    [JceMember(10)] public long Timestamp { get; set; }
    [JceMember(11)] public long IOSVersion { get; set; }
    [JceMember(12)] public sbyte NetType { get; set; }
    [JceMember(13)] public string BuildVer { get; set; }
    [JceMember(14)] public sbyte RegType { get; set; }
    [JceMember(15)] public byte[] DevParam { get; set; }
    [JceMember(16)] public byte[] Guid { get; set; }
    [JceMember(17)] public int LocaleId { get; set; }
    [JceMember(18)] public sbyte SilentPush { get; set; }
    [JceMember(19)] public string DevName { get; set; }
    [JceMember(20)] public string DevType { get; set; }
    [JceMember(21)] public string OSVer { get; set; }
    [JceMember(22)] public sbyte OpenPush { get; set; }
    [JceMember(23)] public long LargeSeq { get; set; }
    [JceMember(24)] public long LastWatchStartTime { get; set; }
    [JceMember(26)] public long OldSSOIp { get; set; }
    [JceMember(27)] public long NewSSOIp { get; set; }
    [JceMember(28)] public string ChannelNo { get; set; }
    [JceMember(29)] public long CPID { get; set; }
    [JceMember(30)] public string VendorName { get; set; }
    [JceMember(31)] public string VendorOSName { get; set; }
    [JceMember(32)] public string IOSIdfa { get; set; }
    [JceMember(33)] public byte[] B769 { get; set; }
    [JceMember(34)] public sbyte IsSetStatus { get; set; }
    [JceMember(35)] public byte[] ServerBuf { get; set; }
    [JceMember(36)] public sbyte SetMute { get; set; }
    [JceMember(38)] public long ExtOnlineStatus { get; set; }
    [JceMember(39)] public int BatteryStatus { get; set; }
}
