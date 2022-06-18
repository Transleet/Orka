namespace Orka.Core.Serialization.Jce.Structs;

internal class DelFriendReq : IJceStruct
{
    [JceMember(0)] public long Uin { get; set; }
    [JceMember(1)] public long DelUin { get; set; }
    [JceMember(2)] public sbyte DelType { get; set; }
    [JceMember(3)] public int Version { get; set; }
}
