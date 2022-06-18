namespace Orka.Core.Serialization.Jce.Structs;

internal class FriendListRequest : IJceStruct
{
    [JceMember(0)] public int Reqtype { get; set; }
    [JceMember(1)] public sbyte IfReflush { get; set; }
    [JceMember(2)] public long Uin { get; set; }
    [JceMember(3)] public short StartIndex { get; set; }
    [JceMember(4)] public short FriendCount { get; set; }
    [JceMember(5)] public sbyte GroupId { get; set; }
    [JceMember(6)] public sbyte IfGetGroupInfo { get; set; }
    [JceMember(7)] public sbyte GroupStartIndex { get; set; }
    [JceMember(8)] public sbyte GroupCount { get; set; }
    [JceMember(9)] public sbyte IfGetMSFGroup { get; set; }
    [JceMember(10)] public sbyte IfShowTermType { get; set; }
    [JceMember(11)] public long Version { get; set; }
    [JceMember(12)] public JceList<long> UinList { get; set; }
    [JceMember(13)] public int AppType { get; set; }
    [JceMember(14)] public sbyte IfGetDOVId { get; set; }
    [JceMember(15)] public sbyte IfGetBothFlag { get; set; }
    [JceMember(16)] public byte[] D50 { get; set; }
    [JceMember(17)] public byte[] D6B { get; set; }
    [JceMember(18)] public JceList<long> SnsTypeList { get; set; }
}
