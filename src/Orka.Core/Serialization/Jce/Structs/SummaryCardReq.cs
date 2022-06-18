namespace Orka.Core.Serialization.Jce.Structs;

internal class SummaryCardReq : IJceStruct
{
    [JceMember(0)] public long Uin { get; set; }
    [JceMember(1)] public int ComeFrom { get; set; }
    [JceMember(2)] public long QzoneFeedTimestamp { get; set; }
    [JceMember(3)] public sbyte IsFriend { get; set; }
    [JceMember(4)] public long GroupCode { get; set; }
    [JceMember(5)] public long GroupUin { get; set; }
    // [JceMember(6)] public byte[] Seed { get; set; }
    // [JceMember(7)] public string SearchName { get; set; }
    [JceMember(8)] public long GetControl { get; set; }
    [JceMember(9)] public int AddFriendSource { get; set; }
    [JceMember(10)] public byte[] SecureSig { get; set; }
    [JceMember(14)] public JceList<byte[]> ReqServices { get; set; }
    [JceMember(15)] public long TinyId { get; set; }
    [JceMember(16)] public long LikeSource { get; set; }
    [JceMember(18)] public sbyte ReqMedalWallInfo { get; set; }
    [JceMember(19)] public JceList<long> Req0x5ebFieldId { get; set; }
    [JceMember(20)] public sbyte ReqNearbyGodInfo { get; set; }
    [JceMember(22)] public sbyte ReqExtendCard { get; set; }


}
