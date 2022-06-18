namespace Orka.Core.Serialization.Jce.Structs;

internal class SvcReqGetDevLoginInfo : IJceStruct
{
    [JceMember(0)] public byte[] Guid { get; set; }
    [JceMember(1)] public string AppName { get; set; }
    [JceMember(2)] public long LoginType { get; set; }
    [JceMember(3)] public long Timestamp { get; set; }
    [JceMember(4)] public long NextItemIndex { get; set; }
    [JceMember(5)] public long RequireMax { get; set; }
    [JceMember(6)] public long GetDevListType { get; set; }
}
