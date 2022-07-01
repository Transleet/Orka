namespace Orka.Core.Serialization.Jce.Structs;

internal class UinInfo : IJceStruct
{
    [JceMember(0)] public long Uin { get; set; }
    [JceMember(1)] public long Flag { get; set; }
    [JceMember(2)] public string Name { get; set; }
    [JceMember(3)] public byte Gender { get; set; }
    [JceMember(4)] public string Phone { get; set; }
    [JceMember(5)] public string Email { get; set; }
    [JceMember(6)] public string Remark { get; set; }
}
