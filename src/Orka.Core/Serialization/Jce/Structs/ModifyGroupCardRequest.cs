namespace Orka.Core.Serialization.Jce.Structs;

internal class ModifyGroupCardRequest : IJceStruct
{
    [JceMember(0)] public long Zero { get; set; }
    [JceMember(1)] public long GroupCode { get; set; }
    [JceMember(2)] public long NewSeq { get; set; }
    [JceMember(3)] public JceList<UinInfo> UinInfo { get; set; }
}
