namespace Orka.Core.Serialization.Jce.Structs;

internal class SvcRespPushMsg : IJceStruct
{
    [JceMember(0)] public long Uin { get; set; }
    [JceMember(1)] public JceList<DelMsgInfo> DelInfos { get; set; }
    [JceMember(2)] public int Svrip { get; set; }
    [JceMember(3)] public byte[] PushToken { get; set; }
    [JceMember(4)] public int ServiceType { get; set; }
}
