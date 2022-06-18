namespace Orka.Core.Serialization.Jce.Structs;

internal class DelMsgInfo : IJceStruct
{
    [JceMember(0)] public long FromUin { get; set; }
    [JceMember(1)] public long MsgTime { get; set; }
    [JceMember(2)] public short MsgSeq { get; set; }
    [JceMember(3)] public byte[] MsgCookies { get; set; }
    [JceMember(4)] public short Cmd { get; set; }
    [JceMember(5)] public long MsgType { get; set; }
    [JceMember(6)] public long AppId { get; set; }
    [JceMember(7)] public long SendTime { get; set; }
    [JceMember(8)] public int SsoSeq { get; set; }
    [JceMember(9)] public int SsoIp { get; set; }
    [JceMember(10)] public int ClientIp { get; set; }
}
