namespace Orka.Core.Serialization.Jce.Structs;

internal class SvcRespRegister : IJceStruct
{
    [JceMember(0)] public long Uin { get; set; }
    [JceMember(1)] public long Bid { get; set; }
    [JceMember(2)] public sbyte ReplyCode { get; set; }
    [JceMember(3)] public string Result { get; set; }
    [JceMember(4)] public long ServerTime { get; set; }
    [JceMember(5)] public sbyte LogQQ { get; set; }
    [JceMember(6)] public sbyte NeedKik { get; set; }
    [JceMember(7)] public sbyte UpdateFlag { get; set; }
    [JceMember(8)] public long Timestamp { get; set; }
    [JceMember(9)] public sbyte CrashFlag { get; set; }
    [JceMember(10)] public string ClientIp { get; set; }
    [JceMember(11)] public int ClientPort { get; set; }
    [JceMember(12)] public int HelloInterval { get; set; }
    [JceMember(13)] public int LargeSeq { get; set; }
    [JceMember(14)] public sbyte LargeSeqUpdate { get; set; }
    [JceMember(15)] public byte[] D769RspBody { get; set; }
    [JceMember(16)] public int Status { get; set; }
    [JceMember(17)] public long ExtOnlineStatus { get; set; }
    [JceMember(18)] public long ClientBatteryGetInterval { get; set; }
    [JceMember(19)] public long ClientAutoStatusInterval { get; set; }
}
