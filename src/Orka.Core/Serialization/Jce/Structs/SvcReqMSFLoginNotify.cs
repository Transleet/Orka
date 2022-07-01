namespace Orka.Core.Serialization.Jce.Structs;

internal class SvcReqMSFLoginNotify : IJceStruct
{
    [JceMember(0)] public long AppId { get; set; }
    [JceMember(1)] public byte Status { get; set; }
    [JceMember(2)] public byte Tablet { get; set; }
    [JceMember(3)] public long Platform { get; set; }
    [JceMember(4)] public string Title { get; set; }
    [JceMember(5)] public string Info { get; set; }
    [JceMember(6)] public long ProductType { get; set; }
    [JceMember(7)] public long ClientType { get; set; }
    [JceMember(8)] public JceList<InstanceInfo> InstanceList { get; set; }
}
