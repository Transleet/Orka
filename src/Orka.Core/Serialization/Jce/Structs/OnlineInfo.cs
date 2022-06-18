namespace Orka.Core.Serialization.Jce.Structs;

internal class OnlineInfo : IJceStruct
{
    [JceMember(0)] public int InstanceId { get; set; }
    [JceMember(1)] public int ClientType { get; set; }
    [JceMember(2)] public int OnlineStatus { get; set; }
    [JceMember(3)] public int PlatformId { get; set; }
    [JceMember(4)] public string SubPlatform { get; set; }
    [JceMember(5)] public long UClientType { get; set; }
}
