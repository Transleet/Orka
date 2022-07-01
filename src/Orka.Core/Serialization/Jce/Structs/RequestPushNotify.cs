namespace Orka.Core.Serialization.Jce.Structs;

internal class RequestPushNotify : IJceStruct
{
    [JceMember(0)] public long Uin { get; set; }
    [JceMember(1)] public byte Type { get; set; }
    [JceMember(2)] public string Service { get; set; }
    [JceMember(3)] public string Cmd { get; set; }
    [JceMember(4)] public byte[] NotifyCookie { get; set; }
    [JceMember(5)] public int MsgType { get; set; }
    [JceMember(6)] public int UserActive { get; set; }
    [JceMember(7)] public int GeneralFlag { get; set; }
    [JceMember(8)] public long BindedUin { get; set; }
}
