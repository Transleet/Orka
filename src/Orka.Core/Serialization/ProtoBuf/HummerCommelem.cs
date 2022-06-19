using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

internal class HummerCommelem
{
    [ProtoContract]
    internal class MsgElemInfoServtype1
    {
        [ProtoMember(1)] public byte[] RewardId { get; set; }
        [ProtoMember(2)] public long SenderUin { get; set; }
        [ProtoMember(3)] public int PicType { get; set; }
        [ProtoMember(4)] public int RewardMoney { get; set; }
        [ProtoMember(5)] public byte[] Url { get; set; }
        [ProtoMember(6)] public byte[] Content { get; set; }
        [ProtoMember(7)] public int CreateTimestamp { get; set; }
        [ProtoMember(8)] public int Status { get; set; }
        [ProtoMember(9)] public int Size { get; set; }
        [ProtoMember(10)] public int VideoDuration { get; set; }
        [ProtoMember(11)] public long Seq { get; set; }
        [ProtoMember(12)] public int RewardTypeExt { get; set; }
    }

    [ProtoContract]
    internal class MsgElemInfoServtype11
    {
        [ProtoMember(1)] public byte[] ResID { get; set; }
        [ProtoMember(2)] public byte[] ResMD5 { get; set; }
        [ProtoMember(3)] public byte[] ReserveInfo1 { get; set; }
        [ProtoMember(4)] public byte[] ReserveInfo2 { get; set; }
        [ProtoMember(5)] public int DoodleDataOffset { get; set; }
        [ProtoMember(6)] public int DoodleGifId { get; set; }
        [ProtoMember(7)] public byte[] DoodleUrl { get; set; }
        [ProtoMember(8)] public byte[] DoodleMd5 { get; set; }
    }

    [ProtoContract]
    internal class MsgElemInfoServtype13
    {
        [ProtoMember(1)] public int SysHeadId { get; set; }
        [ProtoMember(2)] public int HeadFlag { get; set; }
    }

    [ProtoContract]
    internal class MsgElemInfoServtype14
    {
        [ProtoMember(1)] public int Id { get; set; }
        [ProtoMember(2)] public byte[] ReserveInfo { get; set; }
    }

    [ProtoContract]
    internal class MsgElemInfoServtype15
    {
        [ProtoMember(1)] public byte[] Vid { get; set; }
        [ProtoMember(2)] public byte[] Cover { get; set; }
        [ProtoMember(3)] public byte[] Title { get; set; }
        [ProtoMember(4)] public byte[] Summary { get; set; }
        [ProtoMember(5)] public long CreateTime { get; set; }
        [ProtoMember(6)] public byte[] CommentContent { get; set; }
        [ProtoMember(7)] public long Author { get; set; }
        [ProtoMember(8)] public int CtrVersion { get; set; }
    }

    [ProtoContract]
    internal class MsgElemInfoServtype16
    {
        [ProtoMember(1)] public long Uid { get; set; }
        [ProtoMember(2)] public byte[] UnionID { get; set; }
        [ProtoMember(3)] public byte[] StoryID { get; set; }
        [ProtoMember(4)] public byte[] Md5 { get; set; }
        [ProtoMember(5)] public byte[] ThumbUrl { get; set; }
        [ProtoMember(6)] public byte[] DoodleUrl { get; set; }
        [ProtoMember(7)] public int VideoWidth { get; set; }
        [ProtoMember(8)] public int VideoHeight { get; set; }
        [ProtoMember(9)] public byte[] SourceName { get; set; }
        [ProtoMember(10)] public byte[] SourceActionType { get; set; }
        [ProtoMember(11)] public byte[] SourceActionData { get; set; }
        [ProtoMember(12)] public int CtrVersion { get; set; }
    }

    [ProtoContract]
    internal class MsgElemInfoServtype18
    {
        [ProtoMember(1)] public long CurrentAmount { get; set; }
        [ProtoMember(2)] public long TotalAmount { get; set; }
        [ProtoMember(3)] public byte[] Listid { get; set; }
        [ProtoMember(4)] public byte[] AuthKey { get; set; }
        [ProtoMember(5)] public int Number { get; set; }
    }

    [ProtoContract]
    internal class MsgElemInfoServtype19
    {
        [ProtoMember(1)] public byte[] Data { get; set; }
    }

    [ProtoContract]
    internal class MsgElemInfoServtype2
    {
        [ProtoMember(1)] public int PokeType { get; set; }
        [ProtoMember(2)] public string PokeSummary { get; set; }
        [ProtoMember(3)] public int DoubleHit { get; set; }
        [ProtoMember(4)] public int VaspokeId { get; set; }
        [ProtoMember(5)] public string VaspokeName { get; set; }
        [ProtoMember(6)] public string VaspokeMinver { get; set; }
        [ProtoMember(7)] public int PokeStrength { get; set; }
        [ProtoMember(8)] public int MsgType { get; set; }
        [ProtoMember(9)] public int FaceBubbleCount { get; set; }
        [ProtoMember(10)] public int PokeFlag { get; set; }
    }

    [ProtoContract]
    internal class MsgElemInfoServtype20
    {
        [ProtoMember(1)] public byte[] Data { get; set; }
    }

    [ProtoContract]
    internal class MsgElemInfoServtype21
    {
        [ProtoMember(1)] public int TopicId { get; set; }
        [ProtoMember(2)] public long ConfessorUin { get; set; }
        [ProtoMember(3)] public byte[] ConfessorNick { get; set; }
        [ProtoMember(4)] public int ConfessorSex { get; set; }
        [ProtoMember(5)] public int SysmsgFlag { get; set; }
        [ProtoMember(6)] public C2CConfessContext? C2cConfessCtx { get; set; }
        [ProtoMember(7)] public byte[] Topic { get; set; }
        [ProtoMember(8)] public long ConfessTime { get; set; }
        [ProtoMember(9)] public GroupConfessMsg? GroupConfessMsg { get; set; }
        [ProtoMember(10)] public GroupConfessContext? GroupConfessCtx { get; set; }
    }
    [ProtoContract]
    internal class C2CConfessContext
    {
        [ProtoMember(1)] public long ConfessorUin { get; set; }
        [ProtoMember(2)] public long ConfessToUin { get; set; }
        [ProtoMember(3)] public long SendUin { get; set; }
        [ProtoMember(4)] public byte[] ConfessorNick { get; set; }
        [ProtoMember(5)] public byte[] Confess { get; set; }
        [ProtoMember(6)] public int BgType { get; set; }
        [ProtoMember(7)] public int TopicId { get; set; }
        [ProtoMember(8)] public long ConfessTime { get; set; }
        [ProtoMember(9)] public int ConfessorSex { get; set; }
        [ProtoMember(10)] public int BizType { get; set; }
        [ProtoMember(11)] public int ConfessNum { get; set; }
        [ProtoMember(12)] public int ConfessToSex { get; set; }
    }

    [ProtoContract]
    internal class GroupConfessContext
    {
        [ProtoMember(1)] public long ConfessorUin { get; set; }
        [ProtoMember(2)] public long ConfessToUin { get; set; }
        [ProtoMember(3)] public long SendUin { get; set; }
        [ProtoMember(4)] public int ConfessorSex { get; set; }
        [ProtoMember(5)] public byte[] ConfessToNick { get; set; }
        [ProtoMember(6)] public byte[] Topic { get; set; }
        [ProtoMember(7)] public int TopicId { get; set; }
        [ProtoMember(8)] public long ConfessTime { get; set; }
        [ProtoMember(9)] public int ConfessToNickType { get; set; }
        [ProtoMember(10)] public byte[] ConfessorNick { get; set; }
    }

    [ProtoContract]
    internal class GroupConfessItem
    {
        [ProtoMember(1)] public int TopicId { get; set; }
        [ProtoMember(2)] public long ConfessToUin { get; set; }
        [ProtoMember(3)] public byte[] ConfessToNick { get; set; }
        [ProtoMember(4)] public byte[] Topic { get; set; }
        [ProtoMember(5)] public int ConfessToNickType { get; set; }
    }

    [ProtoContract]
    internal class GroupConfessMsg
    {
        [ProtoMember(1)] public long ConfessTime { get; set; }
        [ProtoMember(2)] public long ConfessorUin { get; set; }
        [ProtoMember(3)] public int ConfessorSex { get; set; }
        [ProtoMember(4)] public int SysmsgFlag { get; set; }
        [ProtoMember(5)] public List<GroupConfessItem> ConfessItems { get; set; }
        [ProtoMember(6)] public int TotalTopicCount { get; set; }
    }
}

[ProtoContract]
internal class MsgElemInfoServtype23
{
    [ProtoMember(1)] public int FaceType { get; set; }
    [ProtoMember(2)] public int FaceBubbleCount { get; set; }
    [ProtoMember(3)] public string FaceSummary { get; set; }
    [ProtoMember(4)] public int Flag { get; set; }
    [ProtoMember(5)] public byte[] Others { get; set; }
}

[ProtoContract]
internal class MsgElemInfoServtype24
{
    [ProtoMember(1)] public LimitChatEnter? LimitChatEnter1 { get; set; }
    [ProtoMember(2)] public LimitChatExit? LimitChatExit1 { get; set; }

    [ProtoContract]
    internal class LimitChatEnter
    {
        [ProtoMember(1)] public byte[] TipsWording { get; set; }
        [ProtoMember(2)] public int LeftChatTime { get; set; }
        [ProtoMember(3)] public long MatchTs { get; set; }
        [ProtoMember(4)] public int MatchExpiredTime { get; set; }
        [ProtoMember(5)] public int C2cExpiredTime { get; set; }
        [ProtoMember(6)] public long ReadyTs { get; set; }
        [ProtoMember(7)] public byte[] MatchNick { get; set; }
    }

    [ProtoContract]
    internal class LimitChatExit
    {
        [ProtoMember(1)] public int ExitMethod { get; set; }
        [ProtoMember(2)] public long MatchTs { get; set; }
    }


    [ProtoContract]
    internal class MsgElemInfoServtype27
    {
        [ProtoMember(1)] public ImMsgBody.VideoFile? VideoFile { get; set; }
    }

    [ProtoContract]
    internal class MsgElemInfoServtype29
    {
        [ProtoMember(1)] public byte[] LuckybagMsg { get; set; }
    }

    [ProtoContract]
    internal class MsgElemInfoServtype3
    {
        [ProtoMember(1)] public ImMsgBody.CustomFace? FlashTroopPic { get; set; }
        [ProtoMember(2)] public ImMsgBody.NotOnlineImage? FlashC2cPic { get; set; }
    }

    [ProtoContract]
    internal class MsgElemInfoServtype31
    {
        [ProtoMember(1)] public byte[] Text { get; set; }
        [ProtoMember(2)] public byte[] Ext { get; set; }
    }

    [ProtoContract]
    internal class MsgElemInfoServtype33
    {
        [ProtoMember(1)] public int Index { get; set; }
        [ProtoMember(2)] public byte[] Name { get; set; }
        [ProtoMember(3)] public byte[] Compat { get; set; }
        [ProtoMember(4)] public byte[] Buf { get; set; }
    }

    [ProtoContract]
    internal class MsgElemInfoServtype4
    {
        [ProtoMember(1)] public int ImsgType { get; set; }
        [ProtoMember(4)] public StoryAioObjMsg? StStoryAioObjMsg { get; set; }
    }

    [ProtoContract]
    internal class MsgElemInfoServtype5
    {
        [ProtoMember(1)] public byte[] Vid { get; set; }
        [ProtoMember(2)] public byte[] Cover { get; set; }
        [ProtoMember(3)] public byte[] Title { get; set; }
        [ProtoMember(4)] public byte[] Summary { get; set; }
        [ProtoMember(5)] public long CreateTime { get; set; }
        [ProtoMember(6)] public byte[] CommentContent { get; set; }
        [ProtoMember(7)] public long Author { get; set; }
    }

    [ProtoContract]
    internal class MsgElemInfoServtype8
    {
        [ProtoMember(1)] public ImMsgBody.DeliverGiftMsg? WifiDeliverGiftMsg { get; set; }
    }

    [ProtoContract]
    internal class MsgElemInfoServtype9
    {
        [ProtoMember(1)] public int AnchorStatus { get; set; }
        [ProtoMember(2)] public byte[] JumpSchema { get; set; }
        [ProtoMember(3)] public string AnchorNickname { get; set; }
        [ProtoMember(4)] public byte[] AnchorHeadUrl { get; set; }
        [ProtoMember(5)] public string LiveTitle { get; set; }
    }

    [ProtoContract]
    internal class StoryAioObjMsg
    {
        [ProtoMember(1)] public string UiUrl { get; set; }
        [ProtoMember(2)] public string JmpUrl { get; set; }
    }
}
