namespace Orka.Core.Serialization.Jce.Structs;

internal class TroopListRequest : IJceStruct
{
    [JceMember(0)] public long Uin { get; set; }
    [JceMember(1)] public byte GetMSFMsgFlag { get; set; }
    [JceMember(2)] public byte[] Cookies { get; set; }
    [JceMember(3)] public JceList<long> GroupInfo { get; set; }
    [JceMember(4)] public byte GroupFlagExt { get; set; }
    [JceMember(5)] public int Version { get; set; }
    [JceMember(6)] public long CompanyId { get; set; }
    [JceMember(7)] public long VersionNum { get; set; }
    [JceMember(8)] public byte GetLongGroupName { get; set; }
}
