namespace Orka.Core.Serialization.Jce.Structs;

internal class PushMessageInfo : IJceStruct
{
    [JceMember(0)] public long FromUin { get; set; }
    [JceMember(1)] public long MsgTime { get; set; }
    [JceMember(2)] public short MsgType { get; set; }
    [JceMember(3)] public short MsgSeq { get; set; }
    [JceMember(4)] public string Msg { get; set; }
    [JceMember(5)] public int RealMsgTime { get; set; }
    [JceMember(6)] public byte[] VMsg { get; set; }
    [JceMember(7)] public long AppShareID { get; set; }
    [JceMember(8)] public byte[] MsgCookies { get; set; }
    [JceMember(9)] public byte[] AppShareCookie { get; set; }
    [JceMember(10)] public long MsgUid { get; set; }
    [JceMember(11)] public long LastChangeTime { get; set; }
    [JceMember(14)] public long FromInstId { get; set; }
    [JceMember(15)] public byte[] RemarkOfSender { get; set; }
    [JceMember(16)] public string FromMobile { get; set; }
    [JceMember(17)] public string FromName { get; set; }
}
