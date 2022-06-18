namespace Orka.Core.Serialization.Jce.Structs;

internal class SvcDevLoginInfo : IJceStruct
{
    [JceMember(0)] public long AppId { get; set; }
    [JceMember(1)] public byte[] Guid { get; set; }
    [JceMember(2)] public long LoginTime { get; set; }
    [JceMember(3)] public long LoginPlatform { get; set; }
    [JceMember(4)] public string LoginLocation { get; set; }
    [JceMember(5)] public string DeviceName { get; set; }
    [JceMember(6)] public string DeviceTypeInfo { get; set; }
    [JceMember(8)] public long TerType { get; set; }
    [JceMember(9)] public long ProductType { get; set; }
    [JceMember(10)] public long CanBeKicked { get; set; }
}
