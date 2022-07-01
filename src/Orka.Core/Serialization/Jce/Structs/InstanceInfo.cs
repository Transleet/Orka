namespace Orka.Core.Serialization.Jce.Structs;

internal class InstanceInfo : IJceStruct
{
    [JceMember(0)] public int AppId { get; set; }
    [JceMember(1)] public byte Tablet { get; set; }
    [JceMember(2)] public long Platform { get; set; }
    [JceMember(3)] public long ProductType { get; set; }
    [JceMember(4)] public long ClientType { get; set; }
}
