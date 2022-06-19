using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

[ProtoContract]
internal class GroupOpenSysMsg
{
    [ProtoContract]
    internal class LightApp
    {
        [ProtoMember(1)] public string App { get; set; }
        [ProtoMember(2)] public string View { get; set; }
        [ProtoMember(3)] public string Desc { get; set; }
        [ProtoMember(4)] public string Prompt { get; set; }
        [ProtoMember(5)] public string Ver { get; set; }
        [ProtoMember(6)] public string Meta { get; set; }
        [ProtoMember(7)] public string Config { get; set; }
        [ProtoMember(8)] public Source? Source { get; set; }
    }

    [ProtoContract]
    internal class RichMsg
    {
        [ProtoMember(1)] public string Title { get; set; }
        [ProtoMember(2)] public string Desc { get; set; }
        [ProtoMember(3)] public string Brief { get; set; }
        [ProtoMember(4)] public string Cover { get; set; }
        [ProtoMember(5)] public string Url { get; set; }
        [ProtoMember(6)] public Source? Source { get; set; }
    }

    [ProtoContract]
    internal class Sender
    {
        [ProtoMember(1)] public long Uin { get; set; }
        [ProtoMember(2)] public string Nick { get; set; }
        [ProtoMember(3)] public string Avatar { get; set; }
        [ProtoMember(4)] public string Url { get; set; }
    }

    [ProtoContract]
    internal class Source
    {
        [ProtoMember(1)] public string Name { get; set; }
        [ProtoMember(2)] public string Icon { get; set; }
        [ProtoMember(3)] public string Url { get; set; }
    }

    [ProtoContract]
    internal class SysMsgBody
    {
        [ProtoMember(1)] public long GroupId { get; set; }
        [ProtoMember(2)] public long Appid { get; set; }
        [ProtoMember(3)] public Sender? Sender { get; set; }
        [ProtoMember(4)] public int MsgType { get; set; }
        [ProtoMember(5)] public string Content { get; set; }
        [ProtoMember(6)] public RichMsg? RichMsg { get; set; }
        [ProtoMember(7)] public LightApp? LightApp { get; set; }
    }
}

[ProtoContract]
internal class TroopTips0x857
{
    [ProtoContract]
    internal class AIOGrayTipsInfo
    {
        [ProtoMember(1)] public int OptUint32ShowLastest { get; set; }
        [ProtoMember(2)] public byte[] OptBytesContent { get; set; }
        [ProtoMember(3)] public int OptUint32Remind { get; set; }
        [ProtoMember(4)] public byte[] OptBytesBrief { get; set; }
        [ProtoMember(5)] public long ReceiverUin { get; set; }
        [ProtoMember(6)] public int ReliaoAdminOpt { get; set; }
        [ProtoMember(7)] public int RobotGroupOpt { get; set; }
    }

    [ProtoContract]
    internal class AIOTopTipsInfo
    {
        [ProtoMember(1)] public byte[] OptBytesContent { get; set; }
        [ProtoMember(2)] public int OptUint32Icon { get; set; }
        [ProtoMember(3)] public int OptEnumAction { get; set; }
        [ProtoMember(4)] public byte[] OptBytesUrl { get; set; }
        [ProtoMember(5)] public byte[] OptBytesData { get; set; }
        [ProtoMember(6)] public byte[] OptBytesDataI { get; set; }
        [ProtoMember(7)] public byte[] OptBytesDataA { get; set; }
        [ProtoMember(8)] public byte[] OptBytesDataP { get; set; }
    }

    [ProtoContract]
    internal class FloatedTipsInfo
    {
        [ProtoMember(1)] public byte[] OptBytesContent { get; set; }
    }

    [ProtoContract]
    internal class GeneralGrayTipInfo
    {
        [ProtoMember(1)] public long BusiType { get; set; }
        [ProtoMember(2)] public long BusiId { get; set; }
        [ProtoMember(3)] public int CtrlFlag { get; set; }
        [ProtoMember(4)] public int C2cType { get; set; }
        [ProtoMember(5)] public int ServiceType { get; set; }
        [ProtoMember(6)] public long TemplId { get; set; }
        [ProtoMember(7)] public List<TemplParam> MsgTemplParam { get; set; }
        [ProtoMember(8)] public byte[] Content { get; set; }
        [ProtoMember(10)] public long TipsSeqId { get; set; }
        [ProtoMember(100)] public byte[] PbReserv { get; set; }
    }

    [ProtoContract]
    internal class GoldMsgTipsElem
    {
        [ProtoMember(1)] public int Type { get; set; }
        [ProtoMember(2)] public string Billno { get; set; }
        [ProtoMember(3)] public int Result { get; set; }
        [ProtoMember(4)] public int Amount { get; set; }
        [ProtoMember(5)] public int Total { get; set; }
        [ProtoMember(6)] public int Interval { get; set; }
        [ProtoMember(7)] public int Finish { get; set; }
        [ProtoMember(8)] public List<long> Uin { get; set; }
        [ProtoMember(9)] public int Action { get; set; }
    }

    [ProtoContract]
    internal class GrayData
    {
        [ProtoMember(1)] public int AllRead { get; set; }
        [ProtoMember(2)] public string FeedId { get; set; }
    }

    [ProtoContract]
    internal class GroupAnnounceTBCInfo
    {
        [ProtoMember(1)] public byte[] FeedsId { get; set; }
        [ProtoMember(2)] public long GroupId { get; set; }
        [ProtoMember(3)] public int Action { get; set; }
    }

    [ProtoContract]
    internal class GroupAsyncNotify
    {
        [ProtoMember(1)] public int MsgType { get; set; }
        [ProtoMember(2)] public long MsgSeq { get; set; }
    }

    [ProtoContract]
    internal class GroupInfoChange
    {
        [ProtoMember(1)] public int GroupHonorSwitch { get; set; }
        [ProtoMember(2)] public int GroupMemberLevelSwitch { get; set; }
        [ProtoMember(3)] public int GroupFlagext4 { get; set; }
        [ProtoMember(4)] public int AppealDeadline { get; set; }
        [ProtoMember(5)] public int GroupFlag { get; set; }
        [ProtoMember(7)] public int GroupFlagext3 { get; set; }
        [ProtoMember(8)] public int GroupClassExt { get; set; }
        [ProtoMember(9)] public int GroupInfoExtSeq { get; set; }
    }

    [ProtoContract]
    internal class GroupNotifyInfo
    {
        [ProtoMember(1)] public int OptUint32AutoPullFlag { get; set; }
        [ProtoMember(2)] public byte[] OptBytesFeedsId { get; set; }
    }

    [ProtoContract]
    internal class InstCtrl
    {
        [ProtoMember(1)] public List<InstInfo> MsgSendToInst { get; set; }
        [ProtoMember(2)] public List<InstInfo> MsgExcludeInst { get; set; }
        [ProtoMember(3)] public InstInfo? MsgFromInst { get; set; }
    }

    [ProtoContract]
    internal class InstInfo
    {
        [ProtoMember(1)] public int Apppid { get; set; }
        [ProtoMember(2)] public int Instid { get; set; }
        [ProtoMember(3)] public int Platform { get; set; }
        [ProtoMember(4)] public int OpenAppid { get; set; }
        [ProtoMember(5)] public int Productid { get; set; }
        [ProtoMember(6)] public int SsoBid { get; set; }
        [ProtoMember(7)] public byte[] Guid { get; set; }
        [ProtoMember(8)] public int VerMin { get; set; }
        [ProtoMember(9)] public int VerMax { get; set; }
    }

    [ProtoContract]
    internal class LbsShareChangePushInfo
    {
        [ProtoMember(1)] public int MsgType { get; set; }
        [ProtoMember(2)] public byte[] MsgInfo { get; set; }
        [ProtoMember(3)] public byte[] VersionCtrl { get; set; }
        [ProtoMember(4)] public long GroupId { get; set; }
        [ProtoMember(5)] public long OperUin { get; set; }
        [ProtoMember(6)] public byte[] GrayTips { get; set; }
        [ProtoMember(7)] public long MsgSeq { get; set; }
        [ProtoMember(8)] public int JoinNums { get; set; }
        [ProtoMember(99)] public int PushType { get; set; }
        [ProtoMember(100)] public byte[] ExtInfo { get; set; }
    }

    [ProtoContract]
    internal class LuckyBagNotify
    {
        [ProtoMember(1)] public byte[] MsgTips { get; set; }
    }

    [ProtoContract]
    internal class MediaChangePushInfo
    {
        [ProtoMember(1)] public int MsgType { get; set; }
        [ProtoMember(2)] public byte[] MsgInfo { get; set; }
        [ProtoMember(3)] public byte[] VersionCtrl { get; set; }
        [ProtoMember(4)] public long GroupId { get; set; }
        [ProtoMember(5)] public long OperUin { get; set; }
        [ProtoMember(6)] public byte[] GrayTips { get; set; }
        [ProtoMember(7)] public long MsgSeq { get; set; }
        [ProtoMember(8)] public int JoinNums { get; set; }
        [ProtoMember(9)] public SubMsgType0x11f.PersonalSetting? MsgPerSetting { get; set; }
        [ProtoMember(10)] public int PlayMode { get; set; }
        [ProtoMember(11)] public bool IsJoinWhenStart { get; set; }
        [ProtoMember(99)] public int MediaType { get; set; }
        [ProtoMember(100)] public byte[] ExtInfo { get; set; }

        [ProtoContract]
        internal class PersonalSetting
        {
            [ProtoMember(1)] public int ThemeId { get; set; }
            [ProtoMember(2)] public int PlayerId { get; set; }
            [ProtoMember(3)] public int FontId { get; set; }
        }
    }

    [ProtoContract]
    internal class MessageBoxInfo
    {
        [ProtoMember(1)] public byte[] OptBytesContent { get; set; }
        [ProtoMember(2)] public byte[] OptBytesTitle { get; set; }
        [ProtoMember(3)] public byte[] OptBytesButton { get; set; }
    }

    [ProtoContract]
    internal class MessageRecallReminder
    {
        [ProtoMember(1)] public long Uin { get; set; }
        [ProtoMember(2)] public byte[] Nickname { get; set; }
        [ProtoMember(3)] public List<MessageMeta> RecalledMsgList { get; set; }
        [ProtoMember(4)] public byte[] ReminderContent { get; set; }
        [ProtoMember(5)] public byte[] Userdef { get; set; }
        [ProtoMember(6)] public int GroupType { get; set; }
        [ProtoMember(7)] public int OpType { get; set; }
        [ProtoMember(8)] public long AdminUin { get; set; }
        [ProtoMember(9)] public WithDrawWordingInfo? MsgWordingInfo { get; set; }
    }

    [ProtoContract]
    internal class MessageMeta
    {
        [ProtoMember(1)] public int Seq { get; set; }
        [ProtoMember(2)] public int Time { get; set; }
        [ProtoMember(3)] public int MsgRandom { get; set; }
        [ProtoMember(4)] public int MsgType { get; set; }
        [ProtoMember(5)] public int MsgFlag { get; set; }
        [ProtoMember(6)] public long AuthorUin { get; set; }
        [ProtoMember(7)] public int IsAnonyMsg { get; set; }
    }

    [ProtoContract]
    internal class WithDrawWordingInfo
    {
        [ProtoMember(1)] public int Int32ItemId { get; set; }
        [ProtoMember(2)] public string ItemName { get; set; }
    }


    [ProtoContract]
    internal class MiniAppNotify
    {
        [ProtoMember(1)] public byte[] Msg { get; set; }
    }

    [ProtoContract]
    internal class NotifyMsgBody
    {
        [ProtoMember(1)] public int OptEnumType { get; set; }
        [ProtoMember(2)] public long OptUint64MsgTime { get; set; }
        [ProtoMember(3)] public long OptUint64MsgExpires { get; set; }
        [ProtoMember(4)] public long OptUint64GroupCode { get; set; }
        [ProtoMember(5)] public TroopTips0x857.AIOGrayTipsInfo? OptMsgGraytips { get; set; }
        [ProtoMember(6)] public MessageBoxInfo? OptMsgMessagebox { get; set; }
        [ProtoMember(7)] public TroopTips0x857.FloatedTipsInfo? OptMsgFloatedtips { get; set; }
        [ProtoMember(8)] public TroopTips0x857.AIOTopTipsInfo? OptMsgToptips { get; set; }
        [ProtoMember(9)] public RedGrayTipsInfo? OptMsgRedtips { get; set; }
        [ProtoMember(10)] public TroopTips0x857.GroupNotifyInfo? OptMsgGroupNotify { get; set; }
        [ProtoMember(11)] public MessageRecallReminder? OptMsgRecall { get; set; }
        [ProtoMember(12)] public ThemeStateNotify? OptMsgThemeNotify { get; set; }
        [ProtoMember(13)] public int ServiceType { get; set; }
        [ProtoMember(14)] public NotifyObjmsgUpdate? OptMsgObjmsgUpdate { get; set; }
        [ProtoMember(15)] public WereWolfPush? OptMsgWerewolfPush { get; set; }
        //[ProtoMember(16)] public  ApolloGameStatus.STCMGameMessage?  OptStcmGameState { get; set; }
        //[ProtoMember(17)] public  ApolloPushMsgInfo.STPushMsgElem?  AplloMsgPush { get; set; }
        [ProtoMember(18)] public Oidb0x858.GoldMsgTipsElem? OptMsgGoldtips { get; set; }
        [ProtoMember(20)] public MiniAppNotify? OptMsgMiniappNotify { get; set; }
        [ProtoMember(21)] public long OptUint64SenderUin { get; set; }
        [ProtoMember(22)] public TroopTips0x857.LuckyBagNotify? OptMsgLuckybagNotify { get; set; }
        [ProtoMember(23)] public TroopFormGrayTipsInfo? OptMsgTroopformtipsPush { get; set; }
        [ProtoMember(24)] public TroopTips0x857.MediaChangePushInfo? OptMsgMediaPush { get; set; }
        [ProtoMember(26)] public TroopTips0x857.GeneralGrayTipInfo? OptGeneralGrayTip { get; set; }
        [ProtoMember(27)] public VideoChangePushInfo? OptMsgVideoPush { get; set; }
        [ProtoMember(28)] public TroopTips0x857.LbsShareChangePushInfo? OptLbsShareChangePlusInfo { get; set; }
        [ProtoMember(29)] public SingChangePushInfo? OptMsgSingPush { get; set; }
        [ProtoMember(30)] public TroopTips0x857.GroupInfoChange? OptMsgGroupInfoChange { get; set; }
        [ProtoMember(31)] public TroopTips0x857.GroupAnnounceTBCInfo? OptGroupAnnounceTbcInfo { get; set; }
        [ProtoMember(32)] public QQVedioGamePushInfo? OptQqVedioGamePushInfo { get; set; }
        [ProtoMember(33)] public QQGroupDigestMsg? OptQqGroupDigestMsg { get; set; }
        [ProtoMember(34)] public StudyRoomMemberChangePush? OptStudyRoomMemberMsg { get; set; }
        [ProtoMember(35)] public QQVaLiveNotifyMsg? OptQqLiveNotify { get; set; }
        [ProtoMember(36)] public TroopTips0x857.GroupAsyncNotify? OptGroupAsyncNotidy { get; set; }
        [ProtoMember(37)] public long OptUint64GroupCurMsgSeq { get; set; }
        [ProtoMember(38)] public QQGroupDigestMsgSummary? OptGroupDigestMsgSummary { get; set; }
    }

    [ProtoContract]
    internal class NotifyObjmsgUpdate
    {
        [ProtoMember(1)] public byte[] ObjmsgId { get; set; }
        [ProtoMember(2)] public int UpdateType { get; set; }
        [ProtoMember(3)] public byte[] ExtMsg { get; set; }
    }

    [ProtoContract]
    internal class QQGroupDigestMsg
    {
        [ProtoMember(1)] public long GroupCode { get; set; }
        [ProtoMember(2)] public int MsgSeq { get; set; }
        [ProtoMember(3)] public int MsgRandom { get; set; }
        [ProtoMember(4)] public int OpType { get; set; }
        [ProtoMember(5)] public long MsgSender { get; set; }
        [ProtoMember(6)] public long DigestOper { get; set; }
        [ProtoMember(7)] public int OpTime { get; set; }
        [ProtoMember(8)] public int LastestMsgSeq { get; set; }
        [ProtoMember(9)] public byte[] OperNick { get; set; }
        [ProtoMember(10)] public byte[] SenderNick { get; set; }
        [ProtoMember(11)] public int ExtInfo { get; set; }
    }

    [ProtoContract]
    internal class QQGroupDigestMsgSummary
    {
        [ProtoMember(1)] public long DigestOper { get; set; }
        [ProtoMember(2)] public int OpType { get; set; }
        [ProtoMember(3)] public int OpTime { get; set; }
        [ProtoMember(4)] public byte[] DigestNick { get; set; }
        [ProtoMember(5)] public int SuccCnt { get; set; }
        [ProtoMember(6)] public List<QQGroupDigestSummaryInfo> SummaryInfo { get; set; }
    }

    [ProtoContract]
    internal class QQGroupDigestSummaryInfo
    {
        [ProtoMember(1)] public int MsgSeq { get; set; }
        [ProtoMember(2)] public int MsgRandom { get; set; }
        [ProtoMember(3)] public int ErrorCode { get; set; }
    }

    [ProtoContract]
    internal class QQVaLiveNotifyMsg
    {
        [ProtoMember(1)] public byte[] Uid { get; set; }
        [ProtoMember(2)] public int NotifyType { get; set; }
        [ProtoMember(3)] public byte[] Ext1 { get; set; }
        [ProtoMember(4)] public byte[] Ext2 { get; set; }
        [ProtoMember(5)] public byte[] Ext3 { get; set; }
    }

    [ProtoContract]
    internal class QQVedioGamePushInfo
    {
        [ProtoMember(1)] public int MsgType { get; set; }
        [ProtoMember(2)] public long GroupCode { get; set; }
        [ProtoMember(3)] public long OperUin { get; set; }
        [ProtoMember(4)] public byte[] VersionCtrl { get; set; }
        [ProtoMember(5)] public byte[] ExtInfo { get; set; }
    }

    [ProtoContract]
    internal class RedGrayTipsInfo
    {
        [ProtoMember(1)] public int OptUint32ShowLastest { get; set; }
        [ProtoMember(2)] public long SenderUin { get; set; }
        [ProtoMember(3)] public long ReceiverUin { get; set; }
        [ProtoMember(4)] public byte[] SenderRichContent { get; set; }
        [ProtoMember(5)] public byte[] ReceiverRichContent { get; set; }
        [ProtoMember(6)] public byte[] Authkey { get; set; }
        [ProtoMember(7)] public int Sint32Msgtype { get; set; }
        [ProtoMember(8)] public int LuckyFlag { get; set; }
        [ProtoMember(9)] public int HideFlag { get; set; }
        [ProtoMember(10)] public byte[] PcBody { get; set; }
        [ProtoMember(11)] public int Icon { get; set; }
        [ProtoMember(12)] public long LuckyUin { get; set; }
        [ProtoMember(13)] public int Time { get; set; }
        [ProtoMember(14)] public int Random { get; set; }
        [ProtoMember(15)] public byte[] BroadcastRichContent { get; set; }
        [ProtoMember(16)] public byte[] Idiom { get; set; }
        [ProtoMember(17)] public int IdiomSeq { get; set; }
        [ProtoMember(18)] public byte[] IdiomAlpha { get; set; }
        [ProtoMember(19)] public byte[] Jumpurl { get; set; }
        [ProtoMember(20)] public int Subchannel { get; set; }
        [ProtoMember(21)] public byte[] PoemRule { get; set; }
    }

    [ProtoContract]
    internal class ReqBody
    {
        [ProtoMember(1)] public long OptUint64GroupCode { get; set; }
        [ProtoMember(2)] public List<long> Uint64Memberuins { get; set; }
        [ProtoMember(3)] public int OptUint32Offline { get; set; }
        [ProtoMember(4)] public ImMsgHead.InstCtrl? MsgInstCtrl { get; set; }
        [ProtoMember(5)] public byte[] OptBytesMsg { get; set; }
        [ProtoMember(6)] public int OptUint32BusiType { get; set; }
    }

    [ProtoContract]
    internal class RspBody
    {
        [ProtoMember(1)] public long OptUint64GroupCode { get; set; }
    }

    [ProtoContract]
    internal class SingChangePushInfo
    {
        [ProtoMember(1)] public long Seq { get; set; }
        [ProtoMember(2)] public int ActionType { get; set; }
        [ProtoMember(3)] public long GroupId { get; set; }
        [ProtoMember(4)] public long OperUin { get; set; }
        [ProtoMember(5)] public byte[] GrayTips { get; set; }
        [ProtoMember(6)] public int JoinNums { get; set; }
    }

    [ProtoContract]
    internal class StudyRoomMemberChangePush
    {
        [ProtoMember(1)] public int MemberCount { get; set; }
    }

    [ProtoContract]
    internal class TemplParam
    {
        [ProtoMember(1)] public string Name { get; set; }
        [ProtoMember(2)] public string Value { get; set; }
    }

    [ProtoContract]
    internal class ThemeStateNotify
    {
        [ProtoMember(1)] public int State { get; set; }
        [ProtoMember(2)] public byte[] FeedsId { get; set; }
        [ProtoMember(3)] public byte[] ThemeName { get; set; }
        [ProtoMember(4)] public long ActionUin { get; set; }
        [ProtoMember(5)] public long CreateUin { get; set; }
    }

    [ProtoContract]
    internal class TroopFormGrayTipsInfo
    {
        [ProtoMember(1)] public long WriterUin { get; set; }
        [ProtoMember(2)] public long CreatorUin { get; set; }
        [ProtoMember(3)] public byte[] RichContent { get; set; }
        [ProtoMember(4)] public byte[] OptBytesUrl { get; set; }
        [ProtoMember(5)] public byte[] CreatorNick { get; set; }
    }

    [ProtoContract]
    internal class VideoChangePushInfo
    {
        [ProtoMember(1)] public long Seq { get; set; }
        [ProtoMember(2)] public int ActionType { get; set; }
        [ProtoMember(3)] public long GroupId { get; set; }
        [ProtoMember(4)] public long OperUin { get; set; }
        [ProtoMember(5)] public byte[] GrayTips { get; set; }
        [ProtoMember(6)] public int JoinNums { get; set; }
        [ProtoMember(7)] public int JoinState { get; set; }
        [ProtoMember(100)] public byte[] ExtInfo { get; set; }
    }

    [ProtoContract]
    internal class WereWolfPush
    {
        [ProtoMember(1)] public int PushType { get; set; }
        [ProtoMember(2)] public long GameRoom { get; set; }
        [ProtoMember(3)] public int EnumGameState { get; set; }
        [ProtoMember(4)] public int GameRound { get; set; }
        [ProtoMember(5)] public List<Role> Roles { get; set; }
        [ProtoMember(6)] public long Speaker { get; set; }
        [ProtoMember(7)] public long JudgeUin { get; set; }
        [ProtoMember(8)] public byte[] JudgeWords { get; set; }
        [ProtoMember(9)] public int EnumOperation { get; set; }
        [ProtoMember(10)] public long SrcUser { get; set; }
        [ProtoMember(11)] public long DstUser { get; set; }
        [ProtoMember(12)] public List<long> DeadUsers { get; set; }
        [ProtoMember(13)] public int GameResult { get; set; }
        [ProtoMember(14)] public int TimeoutSec { get; set; }
        [ProtoMember(15)] public int KillConfirmed { get; set; }
        [ProtoMember(16)] public byte[] JudgeNickname { get; set; }
        [ProtoMember(17)] public List<long> VotedTieUsers { get; set; }
    }

    [ProtoContract]
    internal class GameRecord
    {
        [ProtoMember(1)] public int Total { get; set; }
        [ProtoMember(2)] public int Win { get; set; }
        [ProtoMember(3)] public int Lose { get; set; }
        [ProtoMember(4)] public int Draw { get; set; }
    }

    [ProtoContract]
    internal class Role
    {
        [ProtoMember(1)] public long Uin { get; set; }
        [ProtoMember(2)] public int EnumType { get; set; }
        [ProtoMember(3)] public int EnumState { get; set; }
        [ProtoMember(4)] public int CanSpeak { get; set; }
        [ProtoMember(5)] public int CanListen { get; set; }
        [ProtoMember(6)] public int Position { get; set; }
        [ProtoMember(7)] public int CanVote { get; set; }
        [ProtoMember(8)] public int CanVoted { get; set; }
        [ProtoMember(9)] public int AlreadyChecked { get; set; }
        [ProtoMember(10)] public int AlreadySaved { get; set; }
        [ProtoMember(11)] public int AlreadyPoisoned { get; set; }
        [ProtoMember(12)] public int PlayerState { get; set; }
        [ProtoMember(13)] public int EnumDeadOp { get; set; }
        [ProtoMember(14)] public int EnumOperation { get; set; }
        [ProtoMember(15)] public long DstUser { get; set; }
        [ProtoMember(16)] public int OperationRound { get; set; }
        [ProtoMember(17)] public GameRecord? MsgGameRecord { get; set; }
        [ProtoMember(18)] public int IsWerewolf { get; set; }
        [ProtoMember(19)] public long DefendedUser { get; set; }
        [ProtoMember(20)] public int IsSheriff { get; set; }
    }
}
