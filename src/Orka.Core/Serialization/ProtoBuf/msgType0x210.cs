using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

internal class MsgType0x210
{
    [ProtoContract]
    internal class SubMsgType0x43
    {
        [ProtoContract]
        internal class UpdateTips
        {
            [ProtoMember(1)] public byte[] Desc { get; set; }
        }
    }

    internal class Submsgtype0x101
    {
        [ProtoContract]
        internal class ClientReport
        {
            [ProtoMember(1)] public int ServiceId { get; set; }
            [ProtoMember(2)] public string ContentId { get; set; }
        }

        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public PushPlatform? MsgPushPlatform { get; set; }
            [ProtoMember(2)] public ClientReport? MsgClientReport { get; set; }
        }

        [ProtoContract]
        internal class PushPlatform
        {
            [ProtoMember(1)] public long FromUin { get; set; }
            [ProtoMember(2)] public string Title { get; set; }
            [ProtoMember(3)] public string Desc { get; set; }
            [ProtoMember(4)] public string TargetUrl { get; set; }
            [ProtoMember(5)] public int ForwardType { get; set; }
            [ProtoMember(6)] public string ExtDataString { get; set; }
            [ProtoMember(7)] public byte[] ExtData { get; set; }
        }
    }

    internal class Submsgtype0x102
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public string AdId { get; set; }
        }
    }
    internal class Submsgtype0x103
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public long From { get; set; }
            [ProtoMember(2)] public long To { get; set; }
            [ProtoMember(3)] public int TopicId { get; set; }
            [ProtoMember(11)] public int CurCount { get; set; }
            [ProtoMember(12)] public int TotalCount { get; set; }
        }
    }

    internal class Submsgtype0x104
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public long From { get; set; }
            [ProtoMember(2)] public long To { get; set; }
            [ProtoMember(3)] public int TopicId { get; set; }
            [ProtoMember(11)] public byte[] Wording { get; set; }
        }
    }

    internal class SubMsgType0x108
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int Type { get; set; }
            [ProtoMember(2)] public long PushUin { get; set; }
            [ProtoMember(3)] public int LikeCount { get; set; }
            [ProtoMember(4)] public int PushTime { get; set; }
        }
    }

    internal class Submsgtype0x10f
    {
        [ProtoContract]
        internal class KanDianCoinSettingWording
        {
            [ProtoMember(1)] public byte[] Wording { get; set; }
            [ProtoMember(2)] public byte[] PictureUrl { get; set; }
        }

        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int IsOpenCoinEntry { get; set; }
            [ProtoMember(2)] public int CanGetCoinCount { get; set; }
            [ProtoMember(3)] public byte[] CoinIconUrl { get; set; }
            [ProtoMember(4)] public KanDianCoinSettingWording? MsgSettingWording { get; set; }
            [ProtoMember(5)] public long LastCompletedTaskStamp { get; set; }
            [ProtoMember(6)] public long DstUin { get; set; }
        }
    }


    internal class SubMsgType0x111
    {
        [ProtoContract]
        internal class AddFriendSource
        {
            [ProtoMember(1)] public int Source { get; set; }
            [ProtoMember(2)] public int SubSource { get; set; }
        }

        [ProtoContract]
        internal class Color
        {
            [ProtoMember(1)] public int R { get; set; }
            [ProtoMember(2)] public int G { get; set; }
            [ProtoMember(3)] public int B { get; set; }
        }

        [ProtoContract]
        internal class Label
        {
            [ProtoMember(1)] public byte[] Name { get; set; }
            [ProtoMember(2)] public Color? TextColor { get; set; }
            [ProtoMember(3)] public Color? EdgingColor { get; set; }
            [ProtoMember(4)] public int LabelType { get; set; }
        }

        [ProtoContract]
        internal class MayKnowPerson
        {
            [ProtoMember(1)] public long Uin { get; set; }
            [ProtoMember(2)] public AddFriendSource? MsgIosSource { get; set; }
            [ProtoMember(3)] public AddFriendSource? MsgAndroidSource { get; set; }
            [ProtoMember(4)] public byte[] Reason { get; set; }
            [ProtoMember(5)] public byte[] Additive { get; set; }
            [ProtoMember(6)] public byte[] Nick { get; set; }
            [ProtoMember(7)] public byte[] Remark { get; set; }
            [ProtoMember(8)] public byte[] Country { get; set; }
            [ProtoMember(9)] public byte[] Province { get; set; }
            [ProtoMember(10)] public byte[] City { get; set; }
            [ProtoMember(11)] public int Age { get; set; }
            [ProtoMember(12)] public byte[] Catelogue { get; set; }
            [ProtoMember(13)] public byte[] Alghrithm { get; set; }
            [ProtoMember(14)] public byte[] Richbuffer { get; set; }
            [ProtoMember(15)] public int Qzone { get; set; }
            [ProtoMember(16)] public int Gender { get; set; }
            [ProtoMember(17)] public byte[] MobileName { get; set; }
            [ProtoMember(18)] public string Token { get; set; }
            [ProtoMember(19)] public List<Label> MsgLabels { get; set; }
        }

        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public long Type { get; set; }
            [ProtoMember(2)] public List<MayKnowPerson> MsgAddRecommendPersons { get; set; }
            [ProtoMember(3)] public List<long> Uint64DelUins { get; set; }
        }
    }


    internal class SubMsgType0x113
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int Int32AppId { get; set; }
            [ProtoMember(2)] public int Int32TaskId { get; set; }
            [ProtoMember(3)] public int EnumTaskOp { get; set; }
        }
    }


    internal class SubMsgType0x115
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public long FromUin { get; set; }
            [ProtoMember(2)] public long ToUin { get; set; }
            [ProtoMember(3)] public NotifyItem? MsgNotifyItem { get; set; }
            [ProtoMember(4)] public byte[] PbReserve { get; set; }
        }

        [ProtoContract]
        internal class NotifyItem
        {
            [ProtoMember(1)] public int Ime { get; set; }
            [ProtoMember(2)] public int Timeout { get; set; }
            [ProtoMember(3)] public long Timestamp { get; set; }
            [ProtoMember(4)] public int EventType { get; set; }
            [ProtoMember(5)] public int Interval { get; set; }
            [ProtoMember(6)] public byte[] Wording { get; set; }
        }
    }

    internal class Submsgtype0x116
    {
        [ProtoContract]
        internal class MemberInfo
        {
            [ProtoMember(1)] public long MemberUin { get; set; }
            [ProtoMember(2)] public int InviteTimestamp { get; set; }
            [ProtoMember(3)] public int TerminalType { get; set; }
            [ProtoMember(4)] public int ClientVersion { get; set; }
        }

        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public List<MemberInfo> MsgMemberJoin { get; set; }
            [ProtoMember(2)] public List<MemberInfo> MsgMemberQuit { get; set; }
            [ProtoMember(3)] public int GroupId { get; set; }
            [ProtoMember(4)] public int RoomId { get; set; }
            [ProtoMember(5)] public int InviteListTotalCount { get; set; }
            [ProtoMember(6)] public int EnumEventType { get; set; }
        }
    }


    internal class Submsgtype0x117
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public long Uin { get; set; }
            [ProtoMember(2)] public List<int> Uint32MoudleId { get; set; }
        }
    }


    internal class Submsgtype0x118
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int PushType { get; set; }
            [ProtoMember(2)] public byte[] PushData { get; set; }
            [ProtoMember(3)] public int Timestamp { get; set; }
            [ProtoMember(4)] public SystemNotify? MsgSystemNotify { get; set; }
        }

        [ProtoContract]
        internal class SystemNotify
        {
            [ProtoMember(1)] public byte[] MsgSummary { get; set; }
            [ProtoMember(2)] public int FilterFlag { get; set; }
            [ProtoMember(3)] public byte[] ExtendContent { get; set; }
            [ProtoMember(4)] public int IgnorePcActive { get; set; }
            [ProtoMember(5)] public int FilterVersion { get; set; }
            [ProtoMember(6)] public int CountFlag { get; set; }
            [ProtoMember(7)] public int FilterVersionUpperlimitFlag { get; set; }
            [ProtoMember(8)] public int FilterVersionUpperlimit { get; set; }
            [ProtoMember(9)] public byte[] CustomSound { get; set; }
            [ProtoMember(10)] public int AdmnFlag { get; set; }
            [ProtoMember(11)] public int IgnoreWithoutContent { get; set; }
            [ProtoMember(12)] public byte[] MsgTitle { get; set; }
        }
    }


    internal class SubMsgType0x119
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public long WriterUin { get; set; }
            [ProtoMember(2)] public long CreatorUin { get; set; }
            [ProtoMember(3)] public byte[] RichContent { get; set; }
            [ProtoMember(4)] public byte[] OptBytesUrl { get; set; }
            [ProtoMember(5)] public byte[] CreatorNick { get; set; }
        }
    }


    internal class Submsgtype0x11a
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int EnumResult { get; set; }
            [ProtoMember(2)] public byte[] Token { get; set; }
            [ProtoMember(3)] public byte[] EncryptKey { get; set; }
            [ProtoMember(4)] public UserData? MsgUserData { get; set; }
            [ProtoMember(5)] public int EnumBizType { get; set; }
        }

        [ProtoContract]
        internal class UserData
        {
            [ProtoMember(1)] public byte[] Ip { get; set; }
            [ProtoMember(2)] public List<int> Fixed32Port { get; set; }
            [ProtoMember(3)] public byte[] Ssid { get; set; }
            [ProtoMember(4)] public byte[] Bssid { get; set; }
            [ProtoMember(5)] public int EnumPlatform { get; set; }
        }
    }


    internal class Submsgtype0x11b
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public byte[] QrSig { get; set; }
            [ProtoMember(2)] public int EnumBizType { get; set; }
        }
    }


    internal class Submsgtype0x11c
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int Cmd { get; set; }
            [ProtoMember(2)] public int Timestamp { get; set; }
            [ProtoMember(3)] public byte[] Data { get; set; }
        }
    }


    internal class SubMsgType0x11e
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int Type { get; set; }
            [ProtoMember(2)] public string Reason { get; set; }
        }
    }


    internal class SubMsgType0x11f
    {
        [ProtoContract]
        public class MediaUserInfo
        {
            [ProtoMember(1)] public long ToUin { get; set; }
            [ProtoMember(2)] public int JoinState { get; set; }
        }

        [ProtoContract]
        public class MsgBody
        {
            [ProtoMember(1)] public int MsgType { get; set; }
            [ProtoMember(2)] public byte[] MsgInfo { get; set; }
            [ProtoMember(3)] public byte[] VersionCtrl { get; set; }
            [ProtoMember(4)] public int AioType { get; set; }
            [ProtoMember(5)] public long OperUin { get; set; }
            [ProtoMember(6)] public List<long> Uint64ToUin { get; set; }
            [ProtoMember(7)] public byte[] GrayTips { get; set; }
            [ProtoMember(8)] public long MsgSeq { get; set; }
            [ProtoMember(9)] public List<MediaUserInfo> MsgMediaUin { get; set; }
            [ProtoMember(10)] public PersonalSetting? MsgPerSetting { get; set; }
            [ProtoMember(11)] public int PlayMode { get; set; }
            [ProtoMember(99)] public int MediaType { get; set; }
            [ProtoMember(100)] public byte[] ExtInfo { get; set; }
        }

        [ProtoContract]
        public class PersonalSetting
        {
            [ProtoMember(1)] public int ThemeId { get; set; }
            [ProtoMember(2)] public int PlayerId { get; set; }
            [ProtoMember(3)] public int FontId { get; set; }
        }
    }


    internal class SubMsgType0x120
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int SrcAppId { get; set; }
            [ProtoMember(2)] public int NoticeType { get; set; }
            [ProtoMember(3)] public byte[] Reserve1 { get; set; }
            [ProtoMember(4)] public byte[] Reserve2 { get; set; }
            [ProtoMember(5)] public byte[] Reserve3 { get; set; }
            [ProtoMember(6)] public int NoticeTime { get; set; }
            [ProtoMember(7)] public long FrdUin { get; set; }
        }
    }


    internal class Submsgtype0x122
    {
        internal class GrayTipsResv
        {
            [ProtoContract]
            internal class ResvAttr
            {
                [ProtoMember(1)] public int FriendBannedFlag { get; set; }
            }
        }
        [ProtoContract]
        internal class MsgBody
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
        internal class TemplParam
        {
            [ProtoMember(1)] public string Name { get; set; }
            [ProtoMember(2)] public string Value { get; set; }
        }
    }


    internal class Submsgtype0x123
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public long BusiType { get; set; }
            [ProtoMember(2)] public long BusiId { get; set; }
            [ProtoMember(3)] public int CtrlFlag { get; set; }
            [ProtoMember(4)] public int C2cType { get; set; }
            [ProtoMember(5)] public int ServiceType { get; set; }
            [ProtoMember(6)] public long TemplId { get; set; }
            [ProtoMember(7)] public List<TemplParam> TemplParam { get; set; }
            [ProtoMember(8)] public byte[] TemplContent { get; set; }
        }

        [ProtoContract]
        internal class TemplParam
        {
            [ProtoMember(1)] public byte[] Name { get; set; }
            [ProtoMember(2)] public byte[] Value { get; set; }
        }
    }


    internal class Submsgtype0x125
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int MsgType { get; set; }
            [ProtoMember(2)] public byte[] MsgInfo { get; set; }
            [ProtoMember(3)] public byte[] VersionCtrl { get; set; }
            [ProtoMember(4)] public long OperUin { get; set; }
            [ProtoMember(5)] public byte[] GrayTips { get; set; }
            [ProtoMember(6)] public long MsgSeq { get; set; }
            [ProtoMember(99)] public int PushType { get; set; }
            [ProtoMember(100)] public byte[] ExtInfo { get; set; }
        }
    }


    internal class Submsgtype0x126
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public long MsgSeq { get; set; }
            [ProtoMember(2)] public int MsgType { get; set; }
            [ProtoMember(3)] public string MsgInfo { get; set; }
            [ProtoMember(100)] public byte[] ExtInfo { get; set; }
        }
    }


    internal class Submsgtype0x127
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public long Seq { get; set; }
            [ProtoMember(2)] public int ActionType { get; set; }
            [ProtoMember(3)] public long FriendUin { get; set; }
            [ProtoMember(4)] public long OperUin { get; set; }
            [ProtoMember(5)] public byte[] GrayTips { get; set; }
            [ProtoMember(6)] public int JoinState { get; set; }
        }
    }


    internal class Submsgtype0x128
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public byte[] Sig { get; set; }
            [ProtoMember(2)] public long MatchUin { get; set; }
            [ProtoMember(3)] public byte[] TipsWording { get; set; }
            [ProtoMember(4)] public byte[] Nick { get; set; }
            [ProtoMember(5)] public long TimeStamp { get; set; }
            [ProtoMember(6)] public int MatchExpiredTime { get; set; }
            [ProtoMember(7)] public string ReportId { get; set; }
            //[ProtoMember(8)] public  Oidb0xe03.TagInfo?  MsgTag { get; set; }
            //[ProtoMember(9)] public  Oidb0xe03.MatchUinData?  MsgMatchUinData { get; set; }
        }
    }


    internal class Submsgtype0x129
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public long Seq { get; set; }
            [ProtoMember(2)] public int ActionType { get; set; }
            [ProtoMember(3)] public long FriendUin { get; set; }
            [ProtoMember(4)] public long OperUin { get; set; }
            [ProtoMember(5)] public byte[] GrayTips { get; set; }
            [ProtoMember(6)] public int JoinState { get; set; }
        }
    }


    internal class Submsgtype0x133
    {
        [ProtoContract]
        internal class FaceFriend
        {
            [ProtoMember(1)] public long Friend { get; set; }
            [ProtoMember(2)] public byte[] Name { get; set; }
            [ProtoMember(3)] public int Type { get; set; }
        }

        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public long Uin { get; set; }
            [ProtoMember(2)] public List<FaceFriend> MsgFriends { get; set; }
            [ProtoMember(3)] public string SessionId { get; set; }
        }
    }

    internal class Submsgtype0x135
    {
        [ProtoContract]
        internal class ModulePushPb
        {
            [ProtoContract]
            internal class Content
            {
                [ProtoMember(1)] public long FromUin { get; set; }
                [ProtoMember(2)] public string Title { get; set; }
                [ProtoMember(3)] public string Desc { get; set; }
                [ProtoMember(4)] public Image? MsgImage { get; set; }
                [ProtoMember(5)] public Forward? MsgForward { get; set; }
                [ProtoMember(6)] public byte[] ExtData { get; set; }
            }

            [ProtoContract]
            internal class Forward
            {
                [ProtoMember(1)] public string Url { get; set; }
                [ProtoMember(2)] public int Type { get; set; }
            }

            [ProtoContract]
            internal class Image
            {
                [ProtoMember(1)] public string Url { get; set; }
                [ProtoMember(2)] public int Width { get; set; }
                [ProtoMember(3)] public int Height { get; set; }
            }

            [ProtoContract]
            internal class MsgBody
            {
                [ProtoMember(1)] public int Int32ServiceId { get; set; }
                [ProtoMember(2)] public int Int32SubServiceId { get; set; }
                [ProtoMember(3)] public int Int32NotifyId { get; set; }
                [ProtoMember(4)] public int Int32PushId { get; set; }
                [ProtoMember(5)] public int Int32Type { get; set; }
                [ProtoMember(6)] public int Int32RecallFlag { get; set; }
                [ProtoMember(7)] public Content? MsgContent { get; set; }
            }
        }
    }

    [ProtoContract]
    internal class Submsgtype0x13a
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int PushType { get; set; }
            [ProtoMember(2)] public byte[] PushData { get; set; }
            [ProtoMember(3)] public int Timestamp { get; set; }
            [ProtoMember(4)] public SystemNotify? MsgSystemNotify { get; set; }
        }

        [ProtoContract]
        internal class SystemNotify
        {
            [ProtoMember(1)] public byte[] MsgSummary { get; set; }
            [ProtoMember(2)] public int FilterFlag { get; set; }
            [ProtoMember(3)] public byte[] ExtendContent { get; set; }
            [ProtoMember(4)] public int IgnorePcActive { get; set; }
            [ProtoMember(5)] public int FilterVersion { get; set; }
            [ProtoMember(6)] public int CountFlag { get; set; }
            [ProtoMember(7)] public int FilterVersionUpperlimitFlag { get; set; }
            [ProtoMember(8)] public int FilterVersionUpperlimit { get; set; }
            [ProtoMember(9)] public byte[] CustomSound { get; set; }
            [ProtoMember(10)] public int AdmnFlag { get; set; }
            [ProtoMember(11)] public int IgnoreWithoutContent { get; set; }
            [ProtoMember(12)] public byte[] MsgTitle { get; set; }
        }
    }


    [ProtoContract]
    internal class Submsgtype0x13b
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int Op { get; set; }
            [ProtoMember(2)] public long MuteFriend { get; set; }
        }
    }

    /*
    internal class Submsgtype0x1a {
        internal class SubMsgType0x1a  {
            [ProtoContract]
            internal class MsgBody{
                [ProtoMember(1)] public  byte[]  FileKey { get; set; }
                [ProtoMember(2)] public  int  FromUinInt { get; set; }
                [ProtoMember(3)] public  int  ToUinInt { get; set; }
                [ProtoMember(4)] public  int  Status { get; set; }
                [ProtoMember(5)] public  int  Ttl { get; set; }
                [ProtoMember(6)] public  String  Desc { get; set; }
                [ProtoMember(7)] public  int  Type { get; set; }
                [ProtoMember(8)] public  int  CaptureTimes { get; set; }
                [ProtoMember(9)] public  long  FromUin { get; set; }
                [ProtoMember(10)] public  long  ToUin { get; set; }
            } 
        }
    }*/

    internal class Submsgtype0x26
    {
        [ProtoContract]
        internal class AppID
        {
            [ProtoMember(1)] public long AppId { get; set; }
        }

        [ProtoContract]
        internal class AppNotifyContent
        {
            [ProtoMember(1)] public byte[] Text { get; set; }
            [ProtoMember(2)] public List<AppNotifyUser> OptMsgAppNotifyUser { get; set; }
            [ProtoMember(3)] public int OnlineCount { get; set; }
            [ProtoMember(4)] public int ExpireTs { get; set; }
            [ProtoMember(5)] public int RoomMode { get; set; }
            [ProtoMember(6)] public int LiveExtraMode { get; set; }
            [ProtoMember(7)] public int GameId { get; set; }
        }

        [ProtoContract]
        internal class AppNotifyUser
        {
            [ProtoMember(1)] public long OptUint64Uin { get; set; }
            [ProtoMember(2)] public int OptUint32Flag { get; set; }
        }

        [ProtoContract]
        internal class AppTip
        {
            [ProtoMember(1)] public int TipInfoSeq { get; set; }
            [ProtoMember(2)] public byte[] Icon { get; set; }
            [ProtoMember(3)] public int IconTimeStamp { get; set; }
            [ProtoMember(4)] public byte[] Tooltip { get; set; }
            [ProtoMember(5)] public int ReportidClick { get; set; }
            [ProtoMember(6)] public int ReportidShow { get; set; }
        }

        [ProtoContract]
        internal class AppTipNotify
        {
            [ProtoMember(1)] public AppTip? MsgAppTip { get; set; }
            [ProtoMember(2)] public int Action { get; set; }
            [ProtoMember(3)] public byte[] Text { get; set; }
            [ProtoMember(4)] public int NotifySeq { get; set; }
            [ProtoMember(5)] public int NeededTipInfoSeq { get; set; }
            [ProtoMember(6)] public AppNotifyContent? OptMsgAppNotifyContent { get; set; }
        }

        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int SubCmd { get; set; }
            [ProtoMember(2)] public List<SubCmd0x1UpdateAppUnreadNum> MsgSubcmd0x1PushBody { get; set; }
            [ProtoMember(3)] public SubCmd0x2UpdateAppList? MsgSubcmd0x2PushBody { get; set; }
            [ProtoMember(4)] public SubCmd0x3UpdateDiscussAppInfo? MsgSubcmd0x3PushBody { get; set; }
            [ProtoMember(5)] public SubCmd0x4UpdateApp? MsgSubcmd0x4PushBody { get; set; }
        }
        [ProtoContract]
        internal class SubCmd0x1UpdateAppUnreadNum
        {
            [ProtoMember(1)] public AppID? MsgAppId { get; set; }
            [ProtoMember(2)] public long GroupCode { get; set; }
            [ProtoMember(3)] public int Sint32UnreadNum { get; set; }
            [ProtoMember(4)] public AppTipNotify? MsgAppTipNotify { get; set; }
            [ProtoMember(5)] public int Sint32AlbumCnt { get; set; }
        }

        [ProtoContract]
        internal class SubCmd0x2UpdateAppList
        {
            [ProtoMember(1)] public List<Submsgtype0x26.AppID> MsgAppId { get; set; }
            [ProtoMember(2)] public List<int> Uint32TimeStamp { get; set; }
            [ProtoMember(3)] public long GroupCode { get; set; }
        }

        [ProtoContract]
        internal class SubCmd0x3UpdateDiscussAppInfo
        {
            [ProtoMember(1)] public Submsgtype0x26.AppID? MsgAppId { get; set; }
            [ProtoMember(2)] public long ConfUin { get; set; }
            [ProtoMember(3)] public Submsgtype0x26.AppTipNotify? MsgAppTipNotify { get; set; }
        }

        [ProtoContract]
        internal class SubCmd0x4UpdateApp
        {
            [ProtoMember(1)] public Submsgtype0x26.AppID? MsgAppId { get; set; }
            [ProtoMember(2)] public long GroupCode { get; set; }
            [ProtoMember(3)] public int Sint32UnreadNum { get; set; }
        }

        [ProtoContract]
        internal class TransferCnt
        {
            [ProtoMember(1)] public long ChainId { get; set; }
        }
    }


    internal class SubMsgType0x27
    {
        [ProtoContract]
        internal class AddGroup
        {
            [ProtoMember(1)] public int Groupid { get; set; }
            [ProtoMember(2)] public int Sortid { get; set; }
            [ProtoMember(3)] public byte[] Groupname { get; set; }
        }

        [ProtoContract]
        internal class AppointmentNotify
        {
            [ProtoMember(1)] public long FromUin { get; set; }
            [ProtoMember(2)] public string AppointId { get; set; }
            [ProtoMember(3)] public int Notifytype { get; set; }
            [ProtoMember(4)] public string TipsContent { get; set; }
            [ProtoMember(5)] public int UnreadCount { get; set; }
            [ProtoMember(6)] public string JoinWording { get; set; }
            [ProtoMember(7)] public string ViewWording { get; set; }
            [ProtoMember(8)] public byte[] Sig { get; set; }
            [ProtoMember(9)] public byte[] EventInfo { get; set; }
            [ProtoMember(10)] public byte[] NearbyEventInfo { get; set; }
            [ProtoMember(11)] public byte[] FeedEventInfo { get; set; }
        }

        [ProtoContract]
        internal class BinaryMsg
        {
            [ProtoMember(1)] public int OpType { get; set; }
            [ProtoMember(2)] public byte[] OpValue { get; set; }
        }

        [ProtoContract]
        internal class ChatMatchInfo
        {
            [ProtoMember(1)] public byte[] Sig { get; set; }
            [ProtoMember(2)] public long Uin { get; set; }
            [ProtoMember(3)] public long MatchUin { get; set; }
            [ProtoMember(4)] public byte[] TipsWording { get; set; }
            [ProtoMember(5)] public int LeftChatTime { get; set; }
            [ProtoMember(6)] public long TimeStamp { get; set; }
            [ProtoMember(7)] public int MatchExpiredTime { get; set; }
            [ProtoMember(8)] public int C2cExpiredTime { get; set; }
            [ProtoMember(9)] public int MatchCount { get; set; }
            [ProtoMember(10)] public byte[] Nick { get; set; }
        }

        [ProtoContract]
        internal class ConfMsgRoamFlag
        {
            [ProtoMember(1)] public long Confid { get; set; }
            [ProtoMember(2)] public int Flag { get; set; }
            [ProtoMember(3)] public long Timestamp { get; set; }
        }

        [ProtoContract]
        internal class DaRenNotify
        {
            [ProtoMember(1)] public long Uin { get; set; }
            [ProtoMember(2)] public int LoginDays { get; set; }
            [ProtoMember(3)] public int Days { get; set; }
            [ProtoMember(4)] public int IsYestodayLogin { get; set; }
            [ProtoMember(5)] public int IsTodayLogin { get; set; }
        }

        [ProtoContract]
        internal class DelFriend
        {
            [ProtoMember(1)] public List<long> Uint64Uins { get; set; }
        }

        [ProtoContract]
        internal class DelGroup
        {
            [ProtoMember(1)] public int Groupid { get; set; }
        }

        [ProtoContract]
        internal class FanpaiziNotify
        {
            [ProtoMember(1)] public long FromUin { get; set; }
            [ProtoMember(2)] public string FromNick { get; set; }
            [ProtoMember(3)] public byte[] TipsContent { get; set; }
            [ProtoMember(4)] public byte[] Sig { get; set; }
        }

        [ProtoContract]
        internal class ForwardBody
        {
            [ProtoMember(1)] public int NotifyType { get; set; }
            [ProtoMember(2)] public int OpType { get; set; }
            [ProtoMember(3)] public AddGroup? MsgAddGroup { get; set; }
            [ProtoMember(4)] public DelGroup? MsgDelGroup { get; set; }
            [ProtoMember(5)] public ModGroupName? MsgModGroupName { get; set; }
            [ProtoMember(6)] public ModGroupSort? MsgModGroupSort { get; set; }
            [ProtoMember(7)] public ModFriendGroup? MsgModFriendGroup { get; set; }
            [ProtoMember(8)] public ModProfile? MsgModProfile { get; set; }
            [ProtoMember(9)] public ModFriendRemark? MsgModFriendRemark { get; set; }
            [ProtoMember(10)] public ModLongNick? MsgModLongNick { get; set; }
            [ProtoMember(11)] public ModCustomFace? MsgModCustomFace { get; set; }
            [ProtoMember(12)] public ModGroupProfile? MsgModGroupProfile { get; set; }
            [ProtoMember(13)] public ModGroupMemberProfile? MsgModGroupMemberProfile { get; set; }
            [ProtoMember(14)] public DelFriend? MsgDelFriend { get; set; }
            [ProtoMember(15)] public ModFrdRoamPriv? MsgRoamPriv { get; set; }
            [ProtoMember(16)] public GrpMsgRoamFlag? MsgGrpMsgRoamFlag { get; set; }
            [ProtoMember(17)] public ConfMsgRoamFlag? MsgConfMsgRoamFlag { get; set; }
            [ProtoMember(18)] public ModLongNick? MsgModRichLongNick { get; set; }
            [ProtoMember(19)] public BinaryMsg? MsgBinPkg { get; set; }
            [ProtoMember(20)] public ModSnsGeneralInfo? MsgModFriendRings { get; set; }
            [ProtoMember(21)] public ModConfProfile? MsgModConfProfile { get; set; }
            [ProtoMember(22)] public SnsUpdateFlag? MsgModFriendFlag { get; set; }
            [ProtoMember(23)] public AppointmentNotify? MsgAppointmentNotify { get; set; }
            [ProtoMember(25)] public DaRenNotify? MsgDarenNotify { get; set; }
            [ProtoMember(26)] public NewComeinUserNotify? MsgNewComeinUserNotify { get; set; }
            [ProtoMember(200)] public PushSearchDev? MsgPushSearchDev { get; set; }
            [ProtoMember(201)] public PushReportDev? MsgPushReportDev { get; set; }
            [ProtoMember(202)] public QQPayPush? MsgQqPayPush { get; set; }
            [ProtoMember(203)] public byte[] RedpointInfo { get; set; }
            [ProtoMember(204)] public HotFriendNotify? MsgHotFriendNotify { get; set; }
            [ProtoMember(205)] public PraiseRankNotify? MsgPraiseRankNotify { get; set; }
            [ProtoMember(210)] public MQQCampusNotify? MsgCampusNotify { get; set; }
            [ProtoMember(211)] public ModLongNick? MsgModRichLongNickEx { get; set; }
            [ProtoMember(212)] public ChatMatchInfo? MsgChatMatchInfo { get; set; }
            [ProtoMember(214)] public FrdCustomOnlineStatusChange? MsgFrdCustomOnlineStatusChange { get; set; }
            [ProtoMember(2000)] public FanpaiziNotify? MsgFanpanziNotify { get; set; }
        }

        [ProtoContract]
        internal class FrdCustomOnlineStatusChange
        {
            [ProtoMember(1)] public long Uin { get; set; }
        }

        [ProtoContract]
        internal class FriendGroup
        {
            [ProtoMember(1)] public long Fuin { get; set; }
            [ProtoMember(2)] public List<int> Uint32OldGroupId { get; set; }
            [ProtoMember(3)] public List<int> Uint32NewGroupId { get; set; }
        }

        [ProtoContract]
        internal class FriendRemark
        {
            [ProtoMember(1)] public int Type { get; set; }
            [ProtoMember(2)] public long Fuin { get; set; }
            [ProtoMember(3)] public string RmkName { get; set; }
            [ProtoMember(4)] public long GroupCode { get; set; }
        }

        [ProtoContract]
        internal class GPS
        {
            [ProtoMember(1)] public int Int32Lat { get; set; }
            [ProtoMember(2)] public int Int32Lon { get; set; }
            [ProtoMember(3)] public int Int32Alt { get; set; }
            [ProtoMember(4)] public int Int32Type { get; set; }
        }

        [ProtoContract]
        internal class GroupMemberProfileInfo
        {
            [ProtoMember(1)] public int Field { get; set; }
            [ProtoMember(2)] public string Value { get; set; }
        }

        [ProtoContract]
        internal class GroupProfileInfo
        {
            [ProtoMember(1)] public int Field { get; set; }
            [ProtoMember(2)] public byte[] Value { get; set; }
        }

        [ProtoContract]
        internal class GroupSort
        {
            [ProtoMember(1)] public int Groupid { get; set; }
            [ProtoMember(2)] public int Sortid { get; set; }
        }

        [ProtoContract]
        internal class GrpMsgRoamFlag
        {
            [ProtoMember(1)] public long Groupcode { get; set; }
            [ProtoMember(2)] public int Flag { get; set; }
            [ProtoMember(3)] public long Timestamp { get; set; }
        }

        [ProtoContract]
        internal class HotFriendNotify
        {
            [ProtoMember(1)] public long DstUin { get; set; }
            [ProtoMember(2)] public int PraiseHotLevel { get; set; }
            [ProtoMember(3)] public int ChatHotLevel { get; set; }
            [ProtoMember(4)] public int PraiseHotDays { get; set; }
            [ProtoMember(5)] public int ChatHotDays { get; set; }
            [ProtoMember(6)] public int CloseLevel { get; set; }
            [ProtoMember(7)] public int CloseDays { get; set; }
            [ProtoMember(8)] public int PraiseFlag { get; set; }
            [ProtoMember(9)] public int ChatFlag { get; set; }
            [ProtoMember(10)] public int CloseFlag { get; set; }
            [ProtoMember(11)] public long NotifyTime { get; set; }
            [ProtoMember(12)] public long LastPraiseTime { get; set; }
            [ProtoMember(13)] public long LastChatTime { get; set; }
            [ProtoMember(14)] public int QzoneHotLevel { get; set; }
            [ProtoMember(15)] public int QzoneHotDays { get; set; }
            [ProtoMember(16)] public int QzoneFlag { get; set; }
            [ProtoMember(17)] public long LastQzoneTime { get; set; }
        }

        [ProtoContract]
        internal class ModConfProfile
        {
            [ProtoMember(1)] public long Uin { get; set; }
            [ProtoMember(2)] public int ConfUin { get; set; }
            [ProtoMember(3)] public List<ProfileInfo> MsgProfileInfos { get; set; }
        }

        [ProtoContract]
        internal class ModCustomFace
        {
            [ProtoMember(1)] public int Type { get; set; }
            [ProtoMember(2)] public long Uin { get; set; }
            [ProtoMember(3)] public long GroupCode { get; set; }
            [ProtoMember(4)] public long CmdUin { get; set; }
        }

        [ProtoContract]
        internal class ModFrdRoamPriv
        {
            [ProtoMember(1)] public List<OneRoamPriv> MsgRoamPriv { get; set; }
        }

        [ProtoContract]
        internal class ModFriendGroup
        {
            [ProtoMember(1)] public List<FriendGroup> MsgFrdGroup { get; set; }
        }

        [ProtoContract]
        internal class ModFriendRemark
        {
            [ProtoMember(1)] public List<FriendRemark> MsgFrdRmk { get; set; }
        }

        [ProtoContract]
        internal class ModGroupMemberProfile
        {
            [ProtoMember(1)] public long GroupUin { get; set; }
            [ProtoMember(2)] public long Uin { get; set; }
            [ProtoMember(3)] public List<GroupMemberProfileInfo> MsgGroupMemberProfileInfos { get; set; }
            [ProtoMember(4)] public long GroupCode { get; set; }
        }

        [ProtoContract]
        internal class ModGroupName
        {
            [ProtoMember(1)] public int Groupid { get; set; }
            [ProtoMember(2)] public byte[] Groupname { get; set; }
        }

        [ProtoContract]
        internal class ModGroupProfile
        {
            [ProtoMember(1)] public long GroupUin { get; set; }
            [ProtoMember(2)] public List<GroupProfileInfo> MsgGroupProfileInfos { get; set; }
            [ProtoMember(3)] public long GroupCode { get; set; }
            [ProtoMember(4)] public long CmdUin { get; set; }
        }

        [ProtoContract]
        internal class ModGroupSort
        {
            [ProtoMember(1)] public List<GroupSort> MsgGroupsort { get; set; }
        }

        [ProtoContract]
        internal class ModLongNick
        {
            [ProtoMember(1)] public long Uin { get; set; }
            [ProtoMember(2)] public byte[] Value { get; set; }
        }

        [ProtoContract]
        internal class ModProfile
        {
            [ProtoMember(1)] public long Uin { get; set; }
            [ProtoMember(2)] public List<ProfileInfo> MsgProfileInfos { get; set; }
        }

        [ProtoContract]
        internal class ModSnsGeneralInfo
        {
            [ProtoMember(1)] public List<SnsUpateBuffer> MsgSnsGeneralInfos { get; set; }
        }

        [ProtoContract]
        internal class MQQCampusNotify
        {
            [ProtoMember(1)] public long FromUin { get; set; }
            [ProtoMember(2)] public string Wording { get; set; }
            [ProtoMember(3)] public string Target { get; set; }
            [ProtoMember(4)] public int Type { get; set; }
            [ProtoMember(5)] public string Source { get; set; }
        }

        [ProtoContract]
        internal class SubMsgType0x27MsgBody
        {
            [ProtoMember(1)] public List<ForwardBody> MsgModInfos { get; set; }
        }

        [ProtoContract]
        internal class NewComeinUser
        {
            [ProtoMember(1)] public long Uin { get; set; }
            [ProtoMember(2)] public int IsFrd { get; set; }
            [ProtoMember(3)] public byte[] Remark { get; set; }
            [ProtoMember(4)] public byte[] Nick { get; set; }
        }

        [ProtoContract]
        internal class NewComeinUserNotify
        {
            [ProtoMember(1)] public int MsgType { get; set; }
            [ProtoMember(2)] public bool BoolStrongNotify { get; set; }
            [ProtoMember(3)] public int PushTime { get; set; }
            [ProtoMember(4)] public NewComeinUser? MsgNewComeinUser { get; set; }
            [ProtoMember(5)] public NewGroup? MsgNewGroup { get; set; }
            [ProtoMember(6)] public NewGroupUser? MsgNewGroupUser { get; set; }
        }

        [ProtoContract]
        internal class NewGroup
        {
            [ProtoMember(1)] public long GroupCode { get; set; }
            [ProtoMember(2)] public byte[] GroupName { get; set; }
            [ProtoMember(3)] public long OwnerUin { get; set; }
            [ProtoMember(4)] public byte[] OwnerNick { get; set; }
            [ProtoMember(5)] public byte[] Distance { get; set; }
        }

        [ProtoContract]
        internal class NewGroupUser
        {
            [ProtoMember(1)] public long Uin { get; set; }
            [ProtoMember(2)] public int Int32Sex { get; set; }
            [ProtoMember(3)] public int Int32Age { get; set; }
            [ProtoMember(4)] public string Nick { get; set; }
            [ProtoMember(5)] public byte[] Distance { get; set; }
        }

        [ProtoContract]
        internal class OneRoamPriv
        {
            [ProtoMember(1)] public long Fuin { get; set; }
            [ProtoMember(2)] public int PrivTag { get; set; }
            [ProtoMember(3)] public int PrivValue { get; set; }
        }

        [ProtoContract]
        internal class PraiseRankNotify
        {
            [ProtoMember(11)] public int IsChampion { get; set; }
            [ProtoMember(12)] public int RankNum { get; set; }
            [ProtoMember(13)] public string Msg { get; set; }
        }

        [ProtoContract]
        internal class ProfileInfo
        {
            [ProtoMember(1)] public int Field { get; set; }
            [ProtoMember(2)] public string Value { get; set; }
        }

        [ProtoContract]
        internal class PushReportDev
        {
            [ProtoMember(1)] public int MsgType { get; set; }
            [ProtoMember(4)] public byte[] Cookie { get; set; }
            [ProtoMember(5)] public int ReportMaxNum { get; set; }
            [ProtoMember(6)] public byte[] Sn { get; set; }
        }

        [ProtoContract]
        internal class PushSearchDev
        {
            [ProtoMember(1)] public int MsgType { get; set; }
            [ProtoMember(2)] public GPS? MsgGpsInfo { get; set; }
            [ProtoMember(3)] public int DevTime { get; set; }
            [ProtoMember(4)] public int PushTime { get; set; }
            [ProtoMember(5)] public long Din { get; set; }
            [ProtoMember(6)] public string Data { get; set; }
        }

        [ProtoContract]
        internal class QQPayPush
        {
            [ProtoMember(1)] public long Uin { get; set; }
            [ProtoMember(2)] public bool BoolPayOk { get; set; }
        }

        [ProtoContract]
        internal class SnsUpateBuffer
        {
            [ProtoMember(1)] public long Uin { get; set; }
            [ProtoMember(2)] public long Code { get; set; }
            [ProtoMember(3)] public int Result { get; set; }
            [ProtoMember(400)] public List<SnsUpdateItem> MsgSnsUpdateItem { get; set; }
            [ProtoMember(401)] public List<int> Uint32Idlist { get; set; }
        }

        [ProtoContract]
        internal class SnsUpdateFlag
        {
            [ProtoMember(1)] public List<SnsUpdateOneFlag> MsgUpdateSnsFlag { get; set; }
        }

        [ProtoContract]
        internal class SnsUpdateItem
        {
            [ProtoMember(1)] public int UpdateSnsType { get; set; }
            [ProtoMember(2)] public byte[] Value { get; set; }
        }

        [ProtoContract]
        internal class SnsUpdateOneFlag
        {
            [ProtoMember(1)] public long Uin { get; set; }
            [ProtoMember(2)] public long Id { get; set; }
            [ProtoMember(3)] public int Flag { get; set; }
        }
    }


    internal class SubMsgType0x28
    {
        [ProtoContract]
        internal class FollowList
        {
            [ProtoMember(1)] public long Puin { get; set; }
            [ProtoMember(2)] public long Uin { get; set; }
            [ProtoMember(3)] public int Type { get; set; }
            [ProtoMember(4)] public int Seqno { get; set; }
            [ProtoMember(135)] public int DisableCancelChat { get; set; }
        }

        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int SubCmd { get; set; }
            [ProtoMember(2)] public RspFollowList? MsgRspFollowlist { get; set; }
            [ProtoMember(3)] public RspTypeList? MsgRspTypelist { get; set; }
        }

        [ProtoContract]
        internal class RspFollowList
        {
            [ProtoMember(1)] public List<FollowList> MsgFollowlist { get; set; }
        }

        [ProtoContract]
        internal class RspTypeList
        {
            [ProtoMember(1)] public List<TypeList> MsgTypelist { get; set; }
        }

        [ProtoContract]
        internal class TypeList
        {
            [ProtoMember(1)] public long Puin { get; set; }
            [ProtoMember(2)] public int Flag { get; set; }
            [ProtoMember(3)] public int Type { get; set; }
        }
    }


    internal class SubMsgType0x30
    {
        [ProtoContract]
        internal class BlockListNotify
        {
            [ProtoMember(1)] public List<BlockUinInfo> MsgBlockUinInfo { get; set; }
            [ProtoMember(2)] public List<long> Uint64DelUin { get; set; }
        }

        [ProtoContract]
        internal class BlockUinInfo
        {
            [ProtoMember(1)] public long BlockUin { get; set; }
            [ProtoMember(2)] public int SourceId { get; set; }
            [ProtoMember(3)] public int SourceSubId { get; set; }
        }

        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int SubCmd { get; set; }
            [ProtoMember(2)] public BlockListNotify? MsgS2cBlocklistNotify { get; set; }
        }
    }

    internal class Submsgtype0x31
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int Flag { get; set; }
            [ProtoMember(2)] public long Uin { get; set; }
            [ProtoMember(3)] public long BindUin { get; set; }
            [ProtoMember(4)] public int Time { get; set; }
        }
    }


    internal class Submsgtype0x35
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int BubbleTimestamp { get; set; }
        }
    }


    internal class Submsgtype0x3b
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int SubCmd { get; set; }
            [ProtoMember(2)] public long GroupCode { get; set; }
            [ProtoMember(3)] public int UserShowFlag { get; set; }
            [ProtoMember(4)] public int MemberLevelChanged { get; set; }
            [ProtoMember(5)] public int Officemode { get; set; }
            [ProtoMember(7)] public int MemberLevelNewChanged { get; set; }
        }
    }


    internal class Submsgtype0x3d
    {
        internal class SttResultPush
        {
            [ProtoContract]
            internal class MsgBody
            {
                [ProtoMember(1)] public int SubCmd { get; set; }
                [ProtoMember(2)] public TransPttResp? MsgPttResp { get; set; }
                [ProtoMember(3)] public TransPttShardRsp? MsgPttShardResp { get; set; }
            }

            [ProtoContract]
            internal class TextRsp
            {
                [ProtoMember(4)] public int TotalLen { get; set; }
                [ProtoMember(5)] public int Seq { get; set; }
                [ProtoMember(6)] public int Pos { get; set; }
                [ProtoMember(7)] public int Len { get; set; }
                [ProtoMember(8)] public byte[] Text { get; set; }
            }

            [ProtoContract]
            internal class TransPttResp
            {
                [ProtoMember(1)] public long Sessionid { get; set; }
                [ProtoMember(2)] public int PttType { get; set; }
                [ProtoMember(3)] public int ErrorCode { get; set; }
                [ProtoMember(4)] public int TotalLen { get; set; }
                [ProtoMember(5)] public int Seq { get; set; }
                [ProtoMember(6)] public int Pos { get; set; }
                [ProtoMember(7)] public int Len { get; set; }
                [ProtoMember(8)] public byte[] Text { get; set; }
                [ProtoMember(9)] public long SenderUin { get; set; }
                [ProtoMember(10)] public long ReceiverUin { get; set; }
                [ProtoMember(11)] public int FileID { get; set; }
                [ProtoMember(12)] public string Filemd5 { get; set; }
                [ProtoMember(13)] public string FilePath { get; set; }
            }

            [ProtoContract]
            internal class TransPttShardRsp
            {
                [ProtoMember(1)] public long Sessionid { get; set; }
                [ProtoMember(2)] public int PttType { get; set; }
                [ProtoMember(3)] public int ErrorCode { get; set; }
                [ProtoMember(9)] public long SenderUin { get; set; }
                [ProtoMember(10)] public long ReceiverUin { get; set; }
                [ProtoMember(11)] public int FileID { get; set; }
                [ProtoMember(12)] public string Filemd5 { get; set; }
                [ProtoMember(13)] public string FilePath { get; set; }
                [ProtoMember(21)] public int TotalSeq { get; set; }
                [ProtoMember(22)] public bool BoolIsTotalEnd { get; set; }
                [ProtoMember(23)] public bool BoolIsCurEnd { get; set; }
                [ProtoMember(30)] public TextRsp? CurTextRsp { get; set; }
                [ProtoMember(31)] public TextRsp? AllTextRsp { get; set; }
            }
        }
    }


    internal class Submsgtype0x3e
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int Subcmd { get; set; }
            [ProtoMember(2)] public int Random { get; set; }
            [ProtoMember(3)] public int Result { get; set; }
            [ProtoMember(4)] public byte[] Device { get; set; }
            [ProtoMember(5)] public int Sid { get; set; }
        }
    }


    internal class SubMsgType0x3f
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public List<PubUniKey> MsgPubunikey { get; set; }
        }

        [ProtoContract]
        internal class PubUniKey
        {
            [ProtoMember(1)] public long FromPubUin { get; set; }
            [ProtoMember(2)] public long QwMsgId { get; set; }
        }
    }


    internal class SubMsgType0x40
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public byte[] VUuid { get; set; }
            [ProtoMember(2)] public long FromUin { get; set; }
            [ProtoMember(3)] public long ToUin { get; set; }
            [ProtoMember(4)] public int State { get; set; }
            [ProtoMember(11)] public int Opertype { get; set; }
            [ProtoMember(12)] public string Fromphonenum { get; set; }
        }
    }


    internal class Submsgtype0x41
    {
        [ProtoContract]
        internal class GameRsultMsg
        {
            [ProtoMember(1)] public string GameName { get; set; }
            [ProtoMember(2)] public string GamePic { get; set; }
            [ProtoMember(3)] public string MoreInfo { get; set; }
            [ProtoMember(4)] public List<UinResult> MsgGameRsts { get; set; }
            [ProtoMember(5)] public string GameSubheading { get; set; }
            [ProtoMember(6)] public long Uin { get; set; }
            [ProtoMember(7)] public byte[] Nickname { get; set; }
        }

        [ProtoContract]
        internal class UinResult
        {
            [ProtoMember(1)] public long Uin { get; set; }
            [ProtoMember(2)] public byte[] Nickname { get; set; }
            [ProtoMember(3)] public int Grade { get; set; }
            [ProtoMember(4)] public string Score { get; set; }
        }
    }


    internal class Submsgtype0x42
    {
        [ProtoContract]
        internal class GameStatusSync
        {
            [ProtoMember(1)] public int GameAppid { get; set; }
            [ProtoMember(2)] public byte[] Data { get; set; }
        }
    }


    internal class Submsgtype0x44
    {
        [ProtoContract]
        internal class ClearCountMsg
        {
            [ProtoMember(1)] public long Uin { get; set; }
            [ProtoMember(2)] public int Time { get; set; }
            [ProtoMember(3)] public int Processflag { get; set; }
            [ProtoMember(4)] public int Updateflag { get; set; }
        }

        [ProtoContract]
        internal class DelMsgNotify
        {
            [ProtoMember(1)] public long Sequence { get; set; }
        }

        [ProtoContract]
        internal class FriendSyncMsg
        {
            [ProtoMember(1)] public long Uin { get; set; }
            [ProtoMember(2)] public long Fuin { get; set; }
            [ProtoMember(3)] public int Processtype { get; set; }
            [ProtoMember(4)] public int Time { get; set; }
            [ProtoMember(5)] public int Processflag { get; set; }
            [ProtoMember(6)] public int Sourceid { get; set; }
            [ProtoMember(7)] public int Sourcesubid { get; set; }
            [ProtoMember(8)] public List<string> StrWording { get; set; }
        }

        [ProtoContract]
        internal class GeneralNotify
        {
            [ProtoMember(1)] public int MsgType { get; set; }
            [ProtoMember(2)] public long MsgSeq { get; set; }
        }

        [ProtoContract]
        internal class GroupSyncMsg
        {
            [ProtoMember(1)] public int MsgType { get; set; }
            [ProtoMember(2)] public long MsgSeq { get; set; }
            [ProtoMember(3)] public long GrpCode { get; set; }
            [ProtoMember(4)] public long GaCode { get; set; }
            [ProtoMember(5)] public long OptUin1 { get; set; }
            [ProtoMember(6)] public long OptUin2 { get; set; }
            [ProtoMember(7)] public byte[] MsgBuf { get; set; }
            [ProtoMember(8)] public byte[] AuthKey { get; set; }
            [ProtoMember(9)] public int MsgStatus { get; set; }
            [ProtoMember(10)] public long ActionUin { get; set; }
            [ProtoMember(11)] public long ActionTime { get; set; }
            [ProtoMember(12)] public int CurMaxMemCount { get; set; }
            [ProtoMember(13)] public int NextMaxMemCount { get; set; }
            [ProtoMember(14)] public int CurMemCount { get; set; }
            [ProtoMember(15)] public int ReqSrcId { get; set; }
            [ProtoMember(16)] public int ReqSrcSubId { get; set; }
            [ProtoMember(17)] public int InviterRole { get; set; }
            [ProtoMember(18)] public int ExtAdminNum { get; set; }
            [ProtoMember(19)] public int Processflag { get; set; }
        }

        [ProtoContract]
        internal class ModifySyncMsg
        {
            [ProtoMember(1)] public int Time { get; set; }
        }

        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public FriendSyncMsg? MsgFriendMsgSync { get; set; }
            [ProtoMember(2)] public GroupSyncMsg? MsgGroupMsgSync { get; set; }
            [ProtoMember(3)] public ClearCountMsg? MsgCleanCountMsg { get; set; }
            [ProtoMember(4)] public ModifySyncMsg? MsgModifyMsgSync { get; set; }
            [ProtoMember(5)] public WaitingSyncMsg? MsgWaitingMsgSync { get; set; }
            [ProtoMember(7)] public DelMsgNotify? MsgDelMsgNotify { get; set; }
            [ProtoMember(8)] public GeneralNotify? MsgGeneralNotify { get; set; }
        }

        [ProtoContract]
        internal class WaitingSyncMsg
        {
            [ProtoMember(1)] public int Time { get; set; }
        }
    }

    internal class Submsgtype0x48
    {
        [ProtoContract]
        internal class RecommendDeviceLock
        {
            [ProtoMember(1)] public bool CanCancel { get; set; }
            [ProtoMember(2)] public string Wording { get; set; }
            [ProtoMember(3)] public string Title { get; set; }
            [ProtoMember(4)] public string SecondTitle { get; set; }
            [ProtoMember(5)] public string ThirdTitle { get; set; }
            [ProtoMember(6)] public List<string> WordingList { get; set; }
        }
    }


    internal class Submsgtype0x4a
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int SecCmd { get; set; }
            [ProtoMember(2)] public byte[] Data { get; set; }
        }
    }


    internal class Submsgtype0x4b
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public string Albumid { get; set; }
            [ProtoMember(2)] public string CoverUrl { get; set; }
            [ProtoMember(3)] public string AlbumName { get; set; }
            [ProtoMember(4)] public long Opuin { get; set; }
            [ProtoMember(5)] public int Time { get; set; }
            [ProtoMember(6)] public int PicCnt { get; set; }
            [ProtoMember(7)] public string PushMsgHelper { get; set; }
            [ProtoMember(8)] public string PushMsgAlbum { get; set; }
            [ProtoMember(9)] public int UsrTotal { get; set; }
            [ProtoMember(10)] public List<long> Uint64User { get; set; }
        }
    }


    internal class Submsgtype0x4e
    {
        [ProtoContract]
        internal class GroupBulletin
        {
            [ProtoMember(1)] public List<Oidb0x769.Content> MsgContent { get; set; }
        }
        [ProtoContract]
        internal class Content
        {
            [ProtoMember(1)] public byte[] Feedid { get; set; }
            [ProtoMember(2)] public long Uin { get; set; }
            [ProtoMember(3)] public int Time { get; set; }


        }

        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public long GroupId { get; set; }
            [ProtoMember(2)] public long GroupCode { get; set; }
            [ProtoMember(3)] public int Appid { get; set; }
            [ProtoMember(4)] public Submsgtype0x4e.GroupBulletin? MsgGroupBulletin { get; set; }
        }
    }


    internal class Submsgtype0x54
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int PeerType { get; set; }
            [ProtoMember(2)] public long PeerUin { get; set; }
            [ProtoMember(3)] public List<TaskInfo> TaskList { get; set; }
        }
        [ProtoContract]
        internal class TaskInfo
        {
            [ProtoMember(1)] public int TaskId { get; set; }

        }
    }


    internal class SubMsgType0x60
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int Pushcmd { get; set; }
            [ProtoMember(2)] public long Int64Ts { get; set; }
            [ProtoMember(3)] public string Ssid { get; set; }
            [ProtoMember(4)] public string Content { get; set; }
        }
    }


    internal class Submsgtype0x63
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public long Roomid { get; set; }
            [ProtoMember(2)] public int Seq { get; set; }
            [ProtoMember(3)] public string Url { get; set; }
            [ProtoMember(4)] public string Data { get; set; }
        }
    }


    internal class SubMsgType0x65
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int Cmd { get; set; }
            [ProtoMember(2)] public MsgExpiredPkg? MsgExpiredPkg { get; set; }
        }

        [ProtoContract]
        internal class MsgExpiredPkg
        {
            [ProtoMember(1)] public int Platform { get; set; }
            [ProtoMember(2)] public byte[] ExpirePkg { get; set; }
            [ProtoMember(3)] public byte[] PredownPkg { get; set; }
        }
    }


    internal class Submsgtype0x66
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int Type { get; set; }
            [ProtoMember(2)] public byte[] PushData { get; set; }
            [ProtoMember(3)] public int Timestamp { get; set; }
            [ProtoMember(4)] public byte[] NotifyText { get; set; }
            [ProtoMember(5)] public int PushFlag { get; set; }
        }
    }


    internal class Submsgtype0x67
    {
        [ProtoContract]
        internal class GroupInfo
        {
            [ProtoMember(1)] public long GroupCode { get; set; }
            [ProtoMember(2)] public string GroupName { get; set; }
            [ProtoMember(3)] public string GroupMemo { get; set; }
            [ProtoMember(4)] public int MemberNum { get; set; }
            [ProtoMember(5)] public int GroupType { get; set; }
        }

        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public List<GroupInfo> MsgGrpinfo { get; set; }
        }
    }


    internal class Submsgtype0x69
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int Appid { get; set; }
            [ProtoMember(2)] public bool BoolDisplayReddot { get; set; }
            [ProtoMember(3)] public int Number { get; set; }
            [ProtoMember(4)] public int Reason { get; set; }
            [ProtoMember(5)] public int LastTime { get; set; }
            [ProtoMember(6)] public long CmdUin { get; set; }
            [ProtoMember(7)] public byte[] FaceUrl { get; set; }
            [ProtoMember(8)] public byte[] CustomBuffer { get; set; }
            [ProtoMember(9)] public int ExpireTime { get; set; }
            [ProtoMember(10)] public int CmdUinType { get; set; }
            [ProtoMember(11)] public int ReportType { get; set; }
            [ProtoMember(12)] public bool BoolTestEnv { get; set; }
        }
    }


    internal class SubMsgType0x6b
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public long ToUin { get; set; }
            [ProtoMember(2)] public byte[] TipsContent { get; set; }
            [ProtoMember(3)] public byte[] YesText { get; set; }
            [ProtoMember(4)] public byte[] NoText { get; set; }
        }
    }


    internal class SubMsgType0x6f
    {
        [ProtoContract]
        internal class AddFriendSource
        {
            [ProtoMember(1)] public int Source { get; set; }
            [ProtoMember(2)] public int SubSource { get; set; }
        }

        [ProtoContract]
        internal class AddQimFriendNotifyToQQ
        {
            [ProtoMember(1)] public int OpType { get; set; }
            [ProtoMember(2)] public long Uin { get; set; }
            [ProtoMember(3)] public int Gender { get; set; }
            [ProtoMember(4)] public byte[] SmartRemark { get; set; }
            [ProtoMember(5)] public byte[] Longnick { get; set; }
            [ProtoMember(6)] public long StorysTotalNum { get; set; }
            [ProtoMember(7)] public long CaresCount { get; set; }
            [ProtoMember(8)] public long FansCount { get; set; }
            [ProtoMember(9)] public byte[] Wording { get; set; }
            [ProtoMember(10)] public byte[] SrcWording { get; set; }
        }

        [ProtoContract]
        internal class AddQimNotLoginFrdNotifyToQQ
        {
            [ProtoMember(1)] public long Uin { get; set; }
            [ProtoMember(2)] public byte[] Nick { get; set; }
            [ProtoMember(3)] public int Gender { get; set; }
            [ProtoMember(4)] public int Age { get; set; }
            [ProtoMember(5)] public byte[] Coverstory { get; set; }
            [ProtoMember(6)] public long StorysTotalNum { get; set; }
            [ProtoMember(7)] public List<VideoInfo> MsgVideoInfo { get; set; }
            [ProtoMember(8)] public byte[] Wording { get; set; }
            [ProtoMember(9)] public long QqUin { get; set; }
        }

        [ProtoContract]
        internal class BirthdayReminderPush
        {
            [ProtoMember(2004)] public byte[] ReminderWording { get; set; }
        }

        [ProtoContract]
        internal class FanpaiziNotify
        {
            [ProtoMember(1)] public long FromUin { get; set; }
            [ProtoMember(2)] public string FromNick { get; set; }
            [ProtoMember(3)] public byte[] TipsContent { get; set; }
            [ProtoMember(4)] public byte[] Sig { get; set; }
        }

        [ProtoContract]
        internal class ForwardBody
        {
            [ProtoMember(1)] public int NotifyType { get; set; }
            [ProtoMember(2)] public int OpType { get; set; }
            [ProtoMember(2000)] public FanpaiziNotify? MsgFanpanziNotify { get; set; }
            [ProtoMember(2001)] public MCardNotificationLike? MsgMcardNotificationLike { get; set; }
            [ProtoMember(2002)] public VipInfoNotify? MsgVipInfoNotify { get; set; }
            [ProtoMember(2003)] public PushLostDevFound? MsgPushLostDevFound { get; set; }
            [ProtoMember(2004)] public BirthdayReminderPush? MsgBirthdayReminderPush { get; set; }
            [ProtoMember(2005)] public PushLostDevFound? MsgPushLostDev { get; set; }
            [ProtoMember(2007)] public RewardInfo? MsgBabyqRewardInfo { get; set; }
            [ProtoMember(2008)] public HotFriendNotify? MsgHotFriendNotify { get; set; }
            [ProtoMember(2009)] public QimRecomendMsg? MsgPushQimRecommend { get; set; }
            [ProtoMember(2010)] public QimFriendNotify? MsgModQimFriend { get; set; }
            [ProtoMember(2011)] public QimFriendNotifyToQQ? MsgModQimFriendToQq { get; set; }
        }

        [ProtoContract]
        internal class GPS
        {
            [ProtoMember(1)] public int Int32Lat { get; set; }
            [ProtoMember(2)] public int Int32Lon { get; set; }
            [ProtoMember(3)] public int Int32Alt { get; set; }
            [ProtoMember(4)] public int Int32Type { get; set; }
        }

        [ProtoContract]
        internal class HotFriendNotify
        {
            [ProtoMember(1)] public long DstUin { get; set; }
            [ProtoMember(2)] public int PraiseHotLevel { get; set; }
            [ProtoMember(3)] public int ChatHotLevel { get; set; }
            [ProtoMember(4)] public int PraiseHotDays { get; set; }
            [ProtoMember(5)] public int ChatHotDays { get; set; }
            [ProtoMember(6)] public int CloseLevel { get; set; }
            [ProtoMember(7)] public int CloseDays { get; set; }
            [ProtoMember(8)] public int PraiseFlag { get; set; }
            [ProtoMember(9)] public int ChatFlag { get; set; }
            [ProtoMember(10)] public int CloseFlag { get; set; }
            [ProtoMember(11)] public long NotifyTime { get; set; }
            [ProtoMember(12)] public long LastPraiseTime { get; set; }
            [ProtoMember(13)] public long LastChatTime { get; set; }
        }

        [ProtoContract]
        internal class MCardNotificationLike
        {
            [ProtoMember(1)] public long FromUin { get; set; }
            [ProtoMember(2)] public int CounterTotal { get; set; }
            [ProtoMember(3)] public int CounterNew { get; set; }
            [ProtoMember(4)] public string Wording { get; set; }
        }

        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public List<ForwardBody> MsgModInfos { get; set; }
        }

        [ProtoContract]
        internal class PushLostDevFound
        {
            [ProtoMember(1)] public int MsgType { get; set; }
            [ProtoMember(3)] public int DevTime { get; set; }
            [ProtoMember(6)] public long Din { get; set; }
        }

        [ProtoContract]
        internal class QimFriendNotify
        {
            [ProtoMember(1)] public int OpType { get; set; }
            [ProtoMember(2)] public List<long> Uint64Uins { get; set; }
            [ProtoMember(3)] public long FansUnreadCount { get; set; }
            [ProtoMember(4)] public long FansTotalCount { get; set; }
            [ProtoMember(5)] public long PushTime { get; set; }
            [ProtoMember(6)] public List<byte[]> BytesMobiles { get; set; }
        }

        [ProtoContract]
        internal class QimFriendNotifyToQQ
        {
            [ProtoMember(1)] public int NotifyType { get; set; }
            [ProtoMember(2)] public AddQimFriendNotifyToQQ? MsgAddNotifyToQq { get; set; }
            [ProtoMember(3)] public UpgradeQimFriendNotify? MsgUpgradeNotify { get; set; }
            [ProtoMember(4)] public AddQimNotLoginFrdNotifyToQQ? MsgAddNotLoginFrdNotifyToQq { get; set; }
        }

        [ProtoContract]
        internal class QimRecomendInfo
        {
            [ProtoMember(1)] public long Uin { get; set; }
            [ProtoMember(2)] public byte[] Name { get; set; }
            [ProtoMember(3)] public byte[] Reason { get; set; }
            [ProtoMember(4)] public int Gender { get; set; }
            [ProtoMember(5)] public byte[] Longnick { get; set; }
            [ProtoMember(6)] public byte[] Alghbuff { get; set; }
            [ProtoMember(7)] public int Age { get; set; }
            [ProtoMember(8)] public int Source { get; set; }
            [ProtoMember(9)] public byte[] SourceReason { get; set; }
            [ProtoMember(10)] public AddFriendSource? MsgIosSource { get; set; }
            [ProtoMember(11)] public AddFriendSource? MsgAndroidSource { get; set; }
        }

        [ProtoContract]
        internal class QimRecomendMsg
        {
            [ProtoMember(1)] public List<QimRecomendInfo> MsgRecomendList { get; set; }
            [ProtoMember(2)] public long Timestamp { get; set; }
        }

        [ProtoContract]
        internal class RewardInfo
        {
            [ProtoMember(1)] public int Type { get; set; }
            [ProtoMember(2)] public byte[] Name { get; set; }
            [ProtoMember(3)] public byte[] JmpUrl { get; set; }
            [ProtoMember(4)] public byte[] Cookies { get; set; }
            [ProtoMember(5)] public byte[] JmpWording { get; set; }
            [ProtoMember(6)] public byte[] OptWording { get; set; }
            [ProtoMember(7)] public byte[] OptUrl { get; set; }
            [ProtoMember(8)] public long FaceAddonId { get; set; }
            [ProtoMember(9)] public byte[] IconUrl { get; set; }
            [ProtoMember(10)] public byte[] ToastWording { get; set; }
            [ProtoMember(11)] public int ReportType { get; set; }
        }

        [ProtoContract]
        internal class UpgradeQimFriendNotify
        {
            [ProtoMember(1)] public long Uin { get; set; }
            [ProtoMember(2)] public byte[] Wording { get; set; }
        }

        [ProtoContract]
        internal class VideoInfo
        {
            [ProtoMember(1)] public byte[] Vid { get; set; }
            [ProtoMember(2)] public byte[] VideoCoverUrl { get; set; }
        }

        [ProtoContract]
        internal class VipInfoNotify
        {
            [ProtoMember(1)] public long Uin { get; set; }
            [ProtoMember(2)] public int VipLevel { get; set; }
            [ProtoMember(3)] public int VipIdentify { get; set; }
            [ProtoMember(4)] public int Ext { get; set; }
            [ProtoMember(5)] public string ExtString { get; set; }
            [ProtoMember(6)] public int RedFlag { get; set; }
            [ProtoMember(7)] public int DisableRedEnvelope { get; set; }
            [ProtoMember(8)] public int RedpackId { get; set; }
            [ProtoMember(9)] public string RedpackName { get; set; }
        }
    }


    internal class Submsgtype0x71
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public List<ReportAppInfo> MsgAppInfo { get; set; }
            [ProtoMember(2)] public long UiUin { get; set; }
        }

        [ProtoContract]
        internal class RedDisplayInfo
        {
            [ProtoMember(1)] public List<RedTypeInfo> MsgRedTypeInfo { get; set; }
            [ProtoMember(2)] public RedTypeInfo? MsgTabDisplayInfo { get; set; }
        }

        [ProtoContract]
        internal class RedTypeInfo
        {
            [ProtoMember(1)] public int RedType { get; set; }
            [ProtoMember(2)] public string RedContent { get; set; }
            [ProtoMember(3)] public string RedDesc { get; set; }
            [ProtoMember(4)] public int RedPriority { get; set; }
        }

        [ProtoContract]
        internal class ReportAppInfo
        {
            [ProtoMember(1)] public int AppId { get; set; }
            [ProtoMember(2)] public int Int32NewFlag { get; set; }
            [ProtoMember(3)] public int Type { get; set; }
            [ProtoMember(4)] public string Buffer { get; set; }
            [ProtoMember(5)] public string Path { get; set; }
            [ProtoMember(6)] public int PushRedTs { get; set; }
            [ProtoMember(7)] public string Mission { get; set; }
            [ProtoMember(8)] public int Int32Appset { get; set; }
            [ProtoMember(9)] public int Int32Num { get; set; }
            [ProtoMember(10)] public string IconUrl { get; set; }
            [ProtoMember(11)] public int Int32IconFlag { get; set; }
            [ProtoMember(12)] public int Int32IconType { get; set; }
            [ProtoMember(13)] public int Duration { get; set; }
            [ProtoMember(14)] public ReportVersion? MsgVersionInfo { get; set; }
            [ProtoMember(15)] public int AndroidAppId { get; set; }
            [ProtoMember(16)] public int IosAppId { get; set; }
            [ProtoMember(17)] public string AndroidPath { get; set; }
            [ProtoMember(18)] public string IosPath { get; set; }
            [ProtoMember(19)] public int Int32MissionLevel { get; set; }
            [ProtoMember(20)] public RedDisplayInfo? MsgDisplayDesc { get; set; }
        }

        [ProtoContract]
        internal class ReportVersion
        {
            [ProtoMember(1)] public int Int32PlantId { get; set; }
            [ProtoMember(2)] public bool BoolAllver { get; set; }
            [ProtoMember(3)] public List<string> StrVersion { get; set; }
        }
    }

    internal class SubMsgType0x72
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int SubCmd { get; set; }
            [ProtoMember(2)] public int Urgency { get; set; }
            [ProtoMember(3)] public int TemplateNo { get; set; }
            [ProtoMember(4)] public string Content { get; set; }
            [ProtoMember(5)] public string InfoDate { get; set; }
        }
    }


    internal class SubMsgType0x76
    {
        [ProtoContract]
        internal class BirthdayNotify
        {
            [ProtoMember(1)] public List<OneBirthdayFriend> MsgOneFriend { get; set; }
            [ProtoMember(2)] public int Reserved { get; set; }
            [ProtoMember(3)] public List<OneGiftMessage> GiftMsg { get; set; }
            [ProtoMember(4)] public string TopPicUrl { get; set; }
            [ProtoMember(5)] public string Extend { get; set; }
        }

        [ProtoContract]
        internal class GeoGraphicNotify
        {
            [ProtoMember(1)] public byte[] LocalCity { get; set; }
            [ProtoMember(2)] public List<OneGeoGraphicFriend> MsgOneFriend { get; set; }
        }

        [ProtoContract]
        internal class MemorialDayNotify
        {
            [ProtoMember(1)] public List<OneMemorialDayInfo> AnniversaryInfo { get; set; }
        }

        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int MsgType { get; set; }
            [ProtoMember(2)] public bool BoolStrongNotify { get; set; }
            [ProtoMember(3)] public int PushTime { get; set; }
            [ProtoMember(4)] public GeoGraphicNotify? MsgGeographicNotify { get; set; }
            [ProtoMember(5)] public BirthdayNotify? MsgBirthdayNotify { get; set; }
            [ProtoMember(6)] public byte[] NotifyWording { get; set; }
            [ProtoMember(7)] public MemorialDayNotify? MsgMemorialdayNotify { get; set; }
        }

        [ProtoContract]
        internal class OneBirthdayFriend
        {
            [ProtoMember(1)] public long Uin { get; set; }
            [ProtoMember(2)] public bool BoolLunarBirth { get; set; }
            [ProtoMember(3)] public int BirthMonth { get; set; }
            [ProtoMember(4)] public int BirthDate { get; set; }
            [ProtoMember(5)] public long MsgSendTime { get; set; }
            [ProtoMember(6)] public int BirthYear { get; set; }
        }

        [ProtoContract]
        internal class OneGeoGraphicFriend
        {
            [ProtoMember(1)] public long Uin { get; set; }
        }

        [ProtoContract]
        internal class OneGiftMessage
        {
            [ProtoMember(1)] public int GiftId { get; set; }
            [ProtoMember(2)] public string GiftName { get; set; }
            [ProtoMember(3)] public int Type { get; set; }
            [ProtoMember(4)] public string GiftUrl { get; set; }
            [ProtoMember(5)] public int Price { get; set; }
            [ProtoMember(6)] public int PlayCnt { get; set; }
            [ProtoMember(7)] public string BackgroundColor { get; set; }
        }

        [ProtoContract]
        internal class OneMemorialDayInfo
        {
            [ProtoMember(1)] public long Uin { get; set; }
            [ProtoMember(2)] public long Type { get; set; }
            [ProtoMember(3)] public int MemorialTime { get; set; }
            [ProtoMember(11)] public byte[] MainWordingNick { get; set; }
            [ProtoMember(12)] public byte[] MainWordingEvent { get; set; }
            [ProtoMember(13)] public byte[] SubWording { get; set; }
            [ProtoMember(14)] public byte[] Greetings { get; set; }
            [ProtoMember(15)] public int FriendGender { get; set; }
        }
    }


    internal class Submsgtype0x78
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int Type { get; set; }
            [ProtoMember(2)] public int Version { get; set; }
        }
    }


    internal class Submsgtype0x7a
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public byte[] Content { get; set; }
            [ProtoMember(2)] public long FromUin { get; set; }
            [ProtoMember(3)] public string Nick { get; set; }
            [ProtoMember(4)] public long DiscussUin { get; set; }
            [ProtoMember(5)] public string DiscussNick { get; set; }
            [ProtoMember(6)] public long Seq { get; set; }
            [ProtoMember(7)] public long AtTime { get; set; }
        }
    }


    internal class Submsgtype0x7c
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public long Uin { get; set; }
            [ProtoMember(2)] public int Int32Cmd { get; set; }
            [ProtoMember(3)] public List<string> StringCmdExt { get; set; }
            [ProtoMember(4)] public long Seq { get; set; }
            [ProtoMember(5)] public List<string> StringSeqExt { get; set; }
        }
    }


    internal class Submsgtype0x7e
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public string Notice { get; set; }
            [ProtoMember(2)] public WalletMsgPush? MsgOnlinePush { get; set; }
        }

        [ProtoContract]
        internal class WalletMsgPush
        {
            [ProtoMember(1)] public int Action { get; set; }
            [ProtoMember(2)] public int Timestamp { get; set; }
            [ProtoMember(3)] public byte[] Extend { get; set; }
            [ProtoMember(4)] public string Serialno { get; set; }
            [ProtoMember(5)] public string Billno { get; set; }
            [ProtoMember(6)] public string Appinfo { get; set; }
            [ProtoMember(7)] public int Amount { get; set; }
            [ProtoMember(8)] public string Jumpurl { get; set; }
        }
    }

    internal class SubMsgType0x83
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public List<MsgParams> MsgParams { get; set; }
            [ProtoMember(2)] public long Seq { get; set; }
            [ProtoMember(3)] public long GroupId { get; set; }
        }

        [ProtoContract]
        internal class MsgParams
        {
            [ProtoMember(1)] public int Type { get; set; }
            [ProtoMember(2)] public long FromUin { get; set; }
            [ProtoMember(3)] public long ToUin { get; set; }
            [ProtoMember(4)] public string DataString { get; set; }
            [ProtoMember(5)] public byte[] Data { get; set; }
        }

        internal class MsgRep
        {

        }
    }


    internal class SubMsgType0x85
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int ShowLastest { get; set; }
            [ProtoMember(2)] public long SenderUin { get; set; }
            [ProtoMember(3)] public long ReceiverUin { get; set; }
            [ProtoMember(4)] public byte[] SenderRichContent { get; set; }
            [ProtoMember(5)] public byte[] ReceiverRichContent { get; set; }
            [ProtoMember(6)] public byte[] Authkey { get; set; }
            [ProtoMember(7)] public byte[] PcBody { get; set; }
            [ProtoMember(8)] public int Icon { get; set; }
            [ProtoMember(9)] public int Random { get; set; }
            [ProtoMember(10)] public long RedSenderUin { get; set; }
            [ProtoMember(11)] public int Type { get; set; }
            [ProtoMember(12)] public int SubType { get; set; }
            [ProtoMember(13)] public byte[] Jumpurl { get; set; }
        }
    }


    internal class SubMsgType0x86
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int NotifyFlag { get; set; }
            [ProtoMember(2)] public byte[] NotifyWording { get; set; }
        }
    }


    internal class SubMsgType0x87
    {
        [ProtoContract]
        internal class CloneInfo
        {
            [ProtoMember(1)] public long Uin { get; set; }
            [ProtoMember(2)] public byte[] Remark { get; set; }
            [ProtoMember(3)] public byte[] OriginNick { get; set; }
            [ProtoMember(4)] public int ShowInAio { get; set; }
            [ProtoMember(5)] public long ToUin { get; set; }
            [ProtoMember(6)] public byte[] ToNick { get; set; }
            [ProtoMember(7)] public int SrcGender { get; set; }
        }

        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public long FriendMsgTypeFlag { get; set; }
            [ProtoMember(2)] public List<MsgNotify> MsgMsgNotify { get; set; }
            [ProtoMember(3)] public MsgNotifyUnread? MsgMsgNotifyUnread { get; set; }
        }

        [ProtoContract]
        internal class MsgNotify
        {
            [ProtoMember(1)] public long Uin { get; set; }
            [ProtoMember(2)] public long Fuin { get; set; }
            [ProtoMember(3)] public int Time { get; set; }
            [ProtoMember(4)] public int Reqsubtype { get; set; }
            [ProtoMember(5)] public int MaxCount { get; set; }
            [ProtoMember(6)] public CloneInfo? MsgCloneInfo { get; set; }
        }

        [ProtoContract]
        internal class MsgNotifyUnread
        {
            [ProtoMember(1)] public int Unreadcount { get; set; }
        }
    }


    internal class Submsgtype0x89
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public long UiUin { get; set; }
            [ProtoMember(2)] public int PushRedTs { get; set; }
            [ProtoMember(3)] public List<NumRedBusiInfo> MsgNumRed { get; set; }
        }

        [ProtoContract]
        internal class NumRedBusiInfo
        {
            [ProtoMember(1)] public string ClientVerBegin { get; set; }
            [ProtoMember(2)] public string ClientVerEnd { get; set; }
            [ProtoMember(3)] public int PlatId { get; set; }
            [ProtoMember(4)] public int AppId { get; set; }
            [ProtoMember(5)] public int AndroidAppId { get; set; }
            [ProtoMember(6)] public int IosAppId { get; set; }
            [ProtoMember(7)] public string Path { get; set; }
            [ProtoMember(8)] public string AndroidPath { get; set; }
            [ProtoMember(9)] public string IosPath { get; set; }
            [ProtoMember(10)] public string Missionid { get; set; }
            [ProtoMember(11)] public long Msgid { get; set; }
            [ProtoMember(12)] public int Status { get; set; }
            [ProtoMember(13)] public int ExpireTime { get; set; }
            [ProtoMember(14)] public int Int32Appset { get; set; }
        }
    }


    internal class SubMsgType0x8d
    {
        [ProtoContract]
        internal class ChannelNotify
        {
            [ProtoMember(1)] public long ChannelId { get; set; }
            [ProtoMember(2)] public byte[] ChannelName { get; set; }
            [ProtoMember(3)] public byte[] Wording { get; set; }
            [ProtoMember(4)] public List<long> TopArticleIdList { get; set; }
        }

        [ProtoContract]
        internal class CommentFeeds
        {
            [ProtoMember(1)] public long FeedsOwner { get; set; }
            [ProtoMember(2)] public long FeedsId { get; set; }
            [ProtoMember(3)] public long CommentUin { get; set; }
            [ProtoMember(4)] public byte[] CommentId { get; set; }
            [ProtoMember(5)] public long ReplyUin { get; set; }
            [ProtoMember(6)] public byte[] ReplyId { get; set; }
            [ProtoMember(7)] public byte[] CommentInfo { get; set; }
            [ProtoMember(8)] public byte[] FeedsSubject { get; set; }
        }

        [ProtoContract]
        internal class DeleteComment
        {
            [ProtoMember(1)] public long FeedsOwner { get; set; }
            [ProtoMember(2)] public long FeedsId { get; set; }
            [ProtoMember(3)] public long CommentUin { get; set; }
            [ProtoMember(4)] public byte[] CommentId { get; set; }
            [ProtoMember(5)] public long ReplyUin { get; set; }
            [ProtoMember(6)] public byte[] ReplyId { get; set; }
            [ProtoMember(7)] public long DeleteUin { get; set; }
        }

        [ProtoContract]
        internal class DeleteFeeds
        {
            [ProtoMember(1)] public long FeedsOwner { get; set; }
            [ProtoMember(2)] public long FeedsId { get; set; }
            [ProtoMember(3)] public long DeleteUin { get; set; }
        }

        [ProtoContract]
        internal class LikeFeeds
        {
            [ProtoMember(1)] public long FeedsOwner { get; set; }
            [ProtoMember(2)] public long FeedsId { get; set; }
            [ProtoMember(3)] public long LikeUin { get; set; }
            [ProtoMember(4)] public byte[] FeedsSubject { get; set; }
        }

        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public List<NotifyBody> MsgNotifyInfos { get; set; }
            [ProtoMember(2)] public RedSpotNotifyBody? RedSpotNotifyBody { get; set; }
        }

        [ProtoContract]
        internal class NotifyBody
        {
            [ProtoMember(1)] public int NotifyType { get; set; }
            [ProtoMember(2)] public int Seq { get; set; }
            [ProtoMember(3)] public int PushTime { get; set; }
            [ProtoMember(10)] public PublishFeeds? MsgPublishFeeds { get; set; }
            [ProtoMember(11)] public CommentFeeds? MsgCommentFeeds { get; set; }
            [ProtoMember(12)] public LikeFeeds? MsgLikeFeeds { get; set; }
            [ProtoMember(13)] public DeleteFeeds? MsgDeleteFeeds { get; set; }
            [ProtoMember(14)] public DeleteComment? MsgDeleteComment { get; set; }
        }

        [ProtoContract]
        internal class PublishFeeds
        {
            [ProtoMember(1)] public long FeedsOwner { get; set; }
            [ProtoMember(2)] public long FeedsId { get; set; }
        }

        [ProtoContract]
        internal class RedSpotNotifyBody
        {
            [ProtoMember(1)] public int Time { get; set; }
            [ProtoMember(2)] public List<long> NewChannelList { get; set; }
            [ProtoMember(3)] public byte[] GuideWording { get; set; }
            [ProtoMember(4)] public ChannelNotify? MsgChannelNotify { get; set; }
        }
    }


    internal class Submsgtype0x8f
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public SourceID? MsgSourceId { get; set; }
            [ProtoMember(2)] public byte[] FeedsId { get; set; }
            [ProtoMember(3)] public int EnumMsgType { get; set; }
            [ProtoMember(4)] public byte[] ExtMsg { get; set; }
            [ProtoMember(5)] public long AuthorUin { get; set; }
            [ProtoMember(6)] public long ConfirmUin { get; set; }
        }

        [ProtoContract]
        internal class SourceID
        {
            [ProtoMember(1)] public int SourceType { get; set; }
            [ProtoMember(2)] public long SourceCode { get; set; }
        }
    }


    internal class SubMsgType0x90
    {
        [ProtoContract]
        internal class DpNotifyMsgBdoy
        {
            [ProtoMember(1)] public int Pid { get; set; }
            [ProtoMember(2)] public long Din { get; set; }
            [ProtoMember(3)] public List<NotifyItem> MsgNotifyInfo { get; set; }
            [ProtoMember(4)] public string ExtendInfo { get; set; }
        }

        [ProtoContract]
        internal class Head
        {
            [ProtoMember(1)] public int Cmd { get; set; }
        }

        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public Head? MsgHead { get; set; }
            [ProtoMember(2)] public PushBody? MsgBody1 { get; set; }
        }

        [ProtoContract]
        internal class NotifyItem
        {
            [ProtoMember(1)] public int Propertyid { get; set; }
        }

        [ProtoContract]
        internal class OccupyMicrophoneNotifyMsgBody
        {
            [ProtoMember(1)] public int Uin { get; set; }
            [ProtoMember(2)] public long Din { get; set; }
        }

        [ProtoContract]
        internal class PushBody
        {
            [ProtoMember(1)] public DpNotifyMsgBdoy? MsgDpNotifyBody { get; set; }
            [ProtoMember(2)] public OccupyMicrophoneNotifyMsgBody? MsgOccupyMicrophoneBody { get; set; }
        }
    }


    internal class SubMsgType0x92
    {
        [ProtoContract]
        internal class CrmS2CMsgHead
        {
            [ProtoMember(1)] public int CrmSubCmd { get; set; }
            [ProtoMember(2)] public int HeadLen { get; set; }
            [ProtoMember(3)] public int VerNo { get; set; }
            [ProtoMember(4)] public long KfUin { get; set; }
            [ProtoMember(5)] public int Seq { get; set; }
            [ProtoMember(6)] public int PackNum { get; set; }
            [ProtoMember(7)] public int CurPack { get; set; }
            [ProtoMember(8)] public string BufSig { get; set; }
        }

        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int SubCmd { get; set; }
            [ProtoMember(2)] public CrmS2CMsgHead? MsgCrmCommonHead { get; set; }
            [ProtoMember(100)] public S2CPushEmanMsgToC? MsgPushEmanMsg { get; set; }
        }
        [ProtoContract]
        internal class S2CPushEmanMsgToC
        {
            [ProtoMember(1)] public long Uin { get; set; }
            [ProtoMember(2)] public string Xml { get; set; }
        }
    }


    internal class Submsgtype0x93
    {
        [ProtoContract]
        internal class LiteMailIndexInfo
        {
            [ProtoMember(1)] public byte[] FeedsId { get; set; }
            [ProtoMember(2)] public SourceID? MsgSourceId { get; set; }
        }

        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int MsgType { get; set; }
            [ProtoMember(2)] public UnreadMailCountChanged? MsgUmcChanged { get; set; }
            [ProtoMember(3)] public StateChangeNotify? MsgStateChanged { get; set; }
        }

        [ProtoContract]
        internal class SourceID
        {
            [ProtoMember(1)] public int SourceType { get; set; }
            [ProtoMember(2)] public long SourceCode { get; set; }
        }

        [ProtoContract]
        internal class StateChangeNotify
        {
            [ProtoMember(1)] public SourceID? MsgSourceId { get; set; }
            [ProtoMember(2)] public byte[] FeedsId { get; set; }
            [ProtoMember(3)] public int EnumMsgType { get; set; }
            [ProtoMember(4)] public byte[] ExtMsg { get; set; }
            [ProtoMember(5)] public long ReqUin { get; set; }
            [ProtoMember(6)] public List<LiteMailIndexInfo> MsgLiteMailIndex { get; set; }
        }

        [ProtoContract]
        internal class UnreadMailCountChanged
        {
            [ProtoMember(1)] public UnreadMailCountInfo? MsgUmc { get; set; }
        }

        [ProtoContract]
        internal class UnreadMailCountInfo
        {
            [ProtoMember(1)] public int UnreadCount { get; set; }
            [ProtoMember(2)] public int DataVersion { get; set; }
        }
    }


    internal class Submsgtype0x94
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int TaskId { get; set; }
            [ProtoMember(2)] public int FolderReddotFlag { get; set; }
            [ProtoMember(3)] public int DiscoverReddotFlag { get; set; }
            [ProtoMember(4)] public int StartTs { get; set; }
            [ProtoMember(5)] public int EndTs { get; set; }
            [ProtoMember(6)] public int PeriodOfValidity { get; set; }
            [ProtoMember(7)] public string FolderMsg { get; set; }
            [ProtoMember(8)] public int DiscountReddotFlag { get; set; }
            [ProtoMember(9)] public int NearbyReddotFlag { get; set; }
            [ProtoMember(10)] public int MineReddotFlag { get; set; }
            [ProtoMember(11)] public int OnlyDiscoverReddotFlag { get; set; }
            [ProtoMember(12)] public int OnlyDiscountReddotFlag { get; set; }
            [ProtoMember(13)] public int OnlyNearbyReddotFlag { get; set; }
            [ProtoMember(14)] public int OnlyMineReddotFlag { get; set; }
            [ProtoMember(15)] public int TaskType { get; set; }
            [ProtoMember(16)] public string TaskInfo { get; set; }
            [ProtoMember(17)] public string TypeName { get; set; }
            [ProtoMember(18)] public string TypeColor { get; set; }
            [ProtoMember(19)] public string JumpUrl { get; set; }
        }
    }


    internal class Submsgtype0x96
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public string PushMsg { get; set; }
            [ProtoMember(2)] public int PushType { get; set; }
        }
    }


    internal class Submsgtype0x97
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public string BusinessUin { get; set; }
            [ProtoMember(2)] public string JsonContext { get; set; }
        }
    }

    internal class Submsgtype0x98
    {
        [ProtoContract]
        internal class ModBlock
        {
            [ProtoMember(1)] public int Op { get; set; }
        }

        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public long Uin { get; set; }
            [ProtoMember(2)] public int SubCmd { get; set; }
            [ProtoMember(3)] public ModBlock? MsgModBlock { get; set; }
        }
    }


    internal class SubMsgType0x9b
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public long AppId { get; set; }
            [ProtoMember(2)] public int MainType { get; set; }
            [ProtoMember(3)] public int SubType { get; set; }
            [ProtoMember(4)] public byte[] ExtMsg { get; set; }
            [ProtoMember(5)] public byte[] WorkflowId { get; set; }
        }

        [ProtoContract]
        internal class PbOfficeNotify
        {
            [ProtoMember(1)] public int OptUint32MyofficeFlag { get; set; }
            [ProtoMember(2)] public List<long> Uint64Appid { get; set; }
        }
    }


    internal class SubMsgType0x9d
    {
        [ProtoContract]
        internal class ModuleUpdateNotify
        {
            [ProtoMember(1)] public int ModuleId { get; set; }
            [ProtoMember(2)] public int ModuleVersion { get; set; }
            [ProtoMember(3)] public int ModuleState { get; set; }
        }

        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int SubCmd { get; set; }
            [ProtoMember(2)] public List<ModuleUpdateNotify> LolaModuleUpdate { get; set; }
        }
    }


    internal class SubmsgType0x9e
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int Type { get; set; }
            [ProtoMember(2)] public byte[] Wording { get; set; }
            [ProtoMember(3)] public byte[] Url { get; set; }
            [ProtoMember(4)] public int AuthKey { get; set; }
        }
    }


    internal class Submsgtype0x9f
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int ShowLastest { get; set; }
            [ProtoMember(2)] public long SenderUin { get; set; }
            [ProtoMember(3)] public long ReceiverUin { get; set; }
            [ProtoMember(4)] public byte[] SenderRichContent { get; set; }
            [ProtoMember(5)] public byte[] ReceiverRichContent { get; set; }
            [ProtoMember(6)] public byte[] Authkey { get; set; }
            [ProtoMember(7)] public int Sint32Sessiontype { get; set; }
            [ProtoMember(8)] public long GroupUin { get; set; }
        }
    }


    internal class Submsgtype0xa0
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int IsMassBlessOpen { get; set; }
        }
    }


    internal class Submsgtype0xa1
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int SubCmd { get; set; }
            [ProtoMember(2)] public long Qid { get; set; }
            [ProtoMember(3)] public int Fixed32UpdateTime { get; set; }
            [ProtoMember(4)] public int TeamCreatedDestroied { get; set; }
            [ProtoMember(5)] public List<long> Uint64OfficeFaceChangedUins { get; set; }
        }
    }


    internal class Submsgtype0xa2
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int ShowLastest { get; set; }
            [ProtoMember(2)] public long SenderUin { get; set; }
            [ProtoMember(3)] public long ReceiverUin { get; set; }
            [ProtoMember(4)] public byte[] SenderRichContent { get; set; }
            [ProtoMember(5)] public byte[] ReceiverRichContent { get; set; }
            [ProtoMember(6)] public byte[] Authkey { get; set; }
        }
    }


    internal class Submsgtype0xa4
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public byte[] Title { get; set; }
            [ProtoMember(2)] public byte[] Brief { get; set; }
            [ProtoMember(3)] public byte[] Url { get; set; }
        }
    }


    internal class SubMsgType0xa8
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int ActionType { get; set; }
            [ProtoMember(2)] public int ActionSubType { get; set; }
            [ProtoMember(3)] public byte[] MsgSummary { get; set; }
            [ProtoMember(4)] public byte[] ExtendContent { get; set; }
        }
    }


    internal class SubMsgType0xaa
    {
        [ProtoContract]
        internal class GameTeamMsgBody
        {
            [ProtoMember(1)] public int GameTeamCmd { get; set; }
            [ProtoMember(2)] public GameTeamTurnOverMessage? MsgTurnOverMessage { get; set; }
            [ProtoMember(3)] public GameTeamStartGameMessage? MsgStartGameMessage { get; set; }
            [ProtoMember(4)] public GameTeamUpdateTeamMessage? MsgUpdateTeamMessage { get; set; }
        }

        [ProtoContract]
        internal class GameTeamStartGameMessage
        {
            [ProtoMember(1)] public string Gamedata { get; set; }
            [ProtoMember(2)] public int PlatformType { get; set; }
            [ProtoMember(3)] public string Title { get; set; }
            [ProtoMember(4)] public string Summary { get; set; }
            [ProtoMember(5)] public string PicUrl { get; set; }
            [ProtoMember(6)] public string Appid { get; set; }
            [ProtoMember(7)] public string AppStoreId { get; set; }
            [ProtoMember(8)] public string PackageName { get; set; }
            [ProtoMember(9)] public long CreateMsgTime { get; set; }
            [ProtoMember(10)] public int Expire { get; set; }
            [ProtoMember(11)] public long BuildTeamTime { get; set; }
        }

        [ProtoContract]
        internal class GameTeamTurnOverMessage
        {
            [ProtoMember(1)] public string TeamId { get; set; }
            [ProtoMember(2)] public int SessionType { get; set; }
            [ProtoMember(3)] public string SourceUin { get; set; }
            [ProtoMember(4)] public string ActionUin { get; set; }
            [ProtoMember(5)] public int ActionType { get; set; }
            [ProtoMember(6)] public int CurrentCount { get; set; }
            [ProtoMember(7)] public int TotalCount { get; set; }
            [ProtoMember(8)] public long CreateMsgTime { get; set; }
            [ProtoMember(9)] public int Status { get; set; }
            [ProtoMember(10)] public int Expire { get; set; }
            [ProtoMember(11)] public long BuildTeamTime { get; set; }
            [ProtoMember(12)] public string LeaderUin { get; set; }
            [ProtoMember(13)] public int Uin32LeaderStatus { get; set; }
            [ProtoMember(14)] public List<InviteSource> InviteSourceList { get; set; }
        }

        [ProtoContract]
        internal class GameTeamUpdateTeamMessage
        {
            [ProtoMember(1)] public string TeamId { get; set; }
            [ProtoMember(2)] public string GameId { get; set; }
            [ProtoMember(3)] public int Status { get; set; }
            [ProtoMember(4)] public string ModeImg { get; set; }
            [ProtoMember(5)] public int CurrentCount { get; set; }
            [ProtoMember(6)] public long CreateMsgTime { get; set; }
            [ProtoMember(7)] public int Expire { get; set; }
            [ProtoMember(8)] public long BuildTeamTime { get; set; }
            [ProtoMember(9)] public string LeaderUin { get; set; }
            [ProtoMember(10)] public int Uin32LeaderStatus { get; set; }
        }

        [ProtoContract]
        internal class InviteSource
        {
            [ProtoMember(1)] public int Type { get; set; }
            [ProtoMember(2)] public string Src { get; set; }
        }

        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int Cmd { get; set; }
            [ProtoMember(2)] public GameTeamMsgBody? MsgGameTeamMsg { get; set; }
            [ProtoMember(3)] public OnlineDocMsgBody? MsgOnlineDocMsg { get; set; }
        }

        [ProtoContract]
        internal class OnlineDocMsgBody
        {
            [ProtoMember(1)] public int OnlineDocCmd { get; set; }
            [ProtoMember(2)] public OnlineDocPushChangeTitleMessage? MsgPushChangeTitleMessage { get; set; }
            [ProtoMember(3)] public OnlineDocPushNewPadMessage? MsgPushNewPadMessage { get; set; }
            [ProtoMember(4)] public OnlineDocPushPreviewToEditMessage? MsgPushPreviewToEdit { get; set; }
        }

        [ProtoContract]
        internal class OnlineDocPushChangeTitleMessage
        {
            [ProtoMember(1)] public int Domainid { get; set; }
            [ProtoMember(2)] public byte[] Localpadid { get; set; }
            [ProtoMember(3)] public byte[] Title { get; set; }
            [ProtoMember(4)] public long LastEditorUin { get; set; }
            [ProtoMember(5)] public byte[] LastEditorNick { get; set; }
            [ProtoMember(6)] public long LastEditTime { get; set; }
        }

        [ProtoContract]
        internal class OnlineDocPushNewPadMessage
        {
            [ProtoMember(1)] public byte[] PadUrl { get; set; }
            [ProtoMember(2)] public int Type { get; set; }
            [ProtoMember(3)] public byte[] Title { get; set; }
            [ProtoMember(4)] public long CreateTime { get; set; }
            [ProtoMember(5)] public long CreatorUin { get; set; }
            [ProtoMember(6)] public byte[] CreatorNick { get; set; }
            [ProtoMember(7)] public long LastEditorUin { get; set; }
            [ProtoMember(8)] public byte[] LastEditorNick { get; set; }
            [ProtoMember(9)] public long LastEditTime { get; set; }
            [ProtoMember(10)] public bool BoolPinnedFlag { get; set; }
            [ProtoMember(11)] public long LastViewerUin { get; set; }
            [ProtoMember(12)] public byte[] LastViewerNick { get; set; }
            [ProtoMember(13)] public long LastViewTime { get; set; }
            [ProtoMember(14)] public long LastPinnedTime { get; set; }
            [ProtoMember(15)] public long CurrentUserBrowseTime { get; set; }
            [ProtoMember(16)] public long HostuserUin { get; set; }
            [ProtoMember(17)] public byte[] HostuserNick { get; set; }
            [ProtoMember(18)] public long LastAuthTime { get; set; }
            [ProtoMember(19)] public int Policy { get; set; }
            [ProtoMember(20)] public int RightFlag { get; set; }
            [ProtoMember(21)] public int Domainid { get; set; }
            [ProtoMember(22)] public byte[] Localpadid { get; set; }
            [ProtoMember(23)] public long LastUnpinnedTime { get; set; }
            [ProtoMember(24)] public bool BoolDeleteFlag { get; set; }
            [ProtoMember(25)] public long LastDeleteTime { get; set; }
            [ProtoMember(26)] public byte[] ThumbUrl { get; set; }
            [ProtoMember(27)] public byte[] Pdid { get; set; }
        }

        [ProtoContract]
        internal class OnlineDocPushPreviewToEditMessage
        {
            [ProtoMember(1)] public int Version { get; set; }
            [ProtoMember(2)] public byte[] Title { get; set; }
            [ProtoMember(3)] public byte[] PadUrl { get; set; }
            [ProtoMember(4)] public byte[] AioSession { get; set; }
        }
    }


    internal class SubMsgType0xab
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public long Uin { get; set; }
            [ProtoMember(2)] public long Gc { get; set; }
            [ProtoMember(3)] public string RewardId { get; set; }
            [ProtoMember(4)] public int RewardStatus { get; set; }
        }
    }


    internal class SubMsgType0xae
    {
        [ProtoContract]
        internal class AddFriendSource
        {
            [ProtoMember(1)] public int Source { get; set; }
            [ProtoMember(2)] public int SubSource { get; set; }
        }

        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int Type { get; set; }
            [ProtoMember(2)] public PushPeopleMayKnow? MsgPeopleMayKonw { get; set; }
            [ProtoMember(3)] public PushPeopleMayKnowV2? MsgPersonsMayKnow { get; set; }
        }

        [ProtoContract]
        internal class PersonMayKnow
        {
            [ProtoMember(1)] public long Uin { get; set; }
            [ProtoMember(2)] public byte[] Name { get; set; }
            [ProtoMember(3)] public int Age { get; set; }
            [ProtoMember(4)] public int Sex { get; set; }
            [ProtoMember(5)] public byte[] MainReason { get; set; }
            [ProtoMember(6)] public byte[] SoureReason { get; set; }
            [ProtoMember(7)] public byte[] Alghrithm { get; set; }
            [ProtoMember(8)] public int Source { get; set; }
            [ProtoMember(9)] public AddFriendSource? MsgIosSource { get; set; }
            [ProtoMember(10)] public AddFriendSource? MsgAndroidSource { get; set; }
            [ProtoMember(11)] public byte[] Msg { get; set; }
            [ProtoMember(12)] public int GameSource { get; set; }
            [ProtoMember(13)] public byte[] RoleName { get; set; }
        }

        [ProtoContract]
        internal class PushPeopleMayKnow
        {
            [ProtoMember(1)] public int Fixed32Timestamp { get; set; }
            [ProtoMember(2)] public byte[] WordingMsg { get; set; }
        }

        [ProtoContract]
        internal class PushPeopleMayKnowV2
        {
            [ProtoMember(1)] public int Fixed32Timestamp { get; set; }
            [ProtoMember(2)] public List<PersonMayKnow> MsgFriendList { get; set; }
            [ProtoMember(3)] public byte[] RoleName { get; set; }
        }
    }


    internal class Submsgtype0xb1
    {
        [ProtoContract]
        internal class DealInviteInfo
        {
            [ProtoMember(1)] public long Uin { get; set; }
            [ProtoMember(2)] public long GroupCode { get; set; }
            [ProtoMember(3)] public string Id { get; set; }
            [ProtoMember(4)] public int DealResult { get; set; }
        }

        [ProtoContract]
        internal class InviteInfo
        {
            [ProtoMember(1)] public long Uin { get; set; }
            [ProtoMember(2)] public long GroupCode { get; set; }
            [ProtoMember(3)] public int ExpireTime { get; set; }
            [ProtoMember(4)] public string Id { get; set; }
        }

        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int NotifyType { get; set; }
            [ProtoMember(2)] public InviteInfo? InviteInfo { get; set; }
            [ProtoMember(3)] public UninviteInfo? UniviteInfo { get; set; }
            [ProtoMember(4)] public DealInviteInfo? DealInfo { get; set; }
        }

        [ProtoContract]
        internal class UninviteInfo
        {
            [ProtoMember(1)] public long Uin { get; set; }
            [ProtoMember(2)] public long GroupCode { get; set; }
            [ProtoMember(3)] public string Id { get; set; }
        }
    }


    internal class SubMsgType0xb3
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int Type { get; set; }
            [ProtoMember(2)] public PushAddFrdNotify MsgAddFrdNotify { get; set; }
        }

        [ProtoContract]
        internal class PushAddFrdNotify
        {
            [ProtoMember(1)] public long Fuin { get; set; }
            [ProtoMember(2)] public long FuinBubbleId { get; set; }
            [ProtoMember(3)] public int Fixed32Timestamp { get; set; }
            [ProtoMember(4)] public string Wording { get; set; }
            [ProtoMember(5)] public string FuinNick { get; set; }
            [ProtoMember(6)] public int SourceId { get; set; }
            [ProtoMember(7)] public int SubsourceId { get; set; }
            [ProtoMember(8)] public byte[] Mobile { get; set; }
            [ProtoMember(9)] public long ReqUin { get; set; }
        }
    }


    internal class SubMsgType0xb5
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public byte[] GrayTipContent { get; set; }
            [ProtoMember(2)] public int AnimationPackageId { get; set; }
            [ProtoMember(3)] public byte[] AnimationPackageUrlA { get; set; }
            [ProtoMember(4)] public byte[] AnimationPackageUrlI { get; set; }
            [ProtoMember(5)] public byte[] RemindBrief { get; set; }
            [ProtoMember(6)] public int GiftId { get; set; }
            [ProtoMember(7)] public int GiftCount { get; set; }
            [ProtoMember(8)] public byte[] AnimationBrief { get; set; }
            [ProtoMember(9)] public long SenderUin { get; set; }
            [ProtoMember(10)] public long ReceiverUin { get; set; }
            [ProtoMember(11)] public byte[] StmessageTitle { get; set; }
            [ProtoMember(12)] public byte[] StmessageSubtitle { get; set; }
            [ProtoMember(13)] public byte[] StmessageMessage { get; set; }
            [ProtoMember(14)] public int StmessageGiftpicid { get; set; }
            [ProtoMember(15)] public byte[] StmessageComefrom { get; set; }
            [ProtoMember(16)] public int StmessageExflag { get; set; }
            [ProtoMember(17)] public byte[] ToAllGiftId { get; set; }
            [ProtoMember(10000)] public long GroupCode { get; set; }
        }
    }


    internal class SubMsgType0xbe
    {
        [ProtoContract]
        internal class Medal
        {
            [ProtoMember(1)] public int Id { get; set; }
            [ProtoMember(2)] public int Level { get; set; }
            [ProtoMember(3)] public int Type { get; set; }
            [ProtoMember(4)] public string IconUrl { get; set; }
            [ProtoMember(5)] public string FlashUrl { get; set; }
            [ProtoMember(6)] public string Name { get; set; }
        }

        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public long Uin { get; set; }
            [ProtoMember(2)] public long GroupCode { get; set; }
            [ProtoMember(3)] public int NotifyType { get; set; }
            [ProtoMember(4)] public int OnlineLevel { get; set; }
            [ProtoMember(5)] public List<Medal> MsgMedalList { get; set; }
        }
    }


    internal class Submsgtype0xc1
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public long Groupid { get; set; }
            [ProtoMember(2)] public int MemberNum { get; set; }
            [ProtoMember(3)] public String Data { get; set; }
        }
    }


    internal class Submsgtype0xc3
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int Type { get; set; }
            [ProtoMember(2)] public byte[] PushData { get; set; }
            [ProtoMember(3)] public long Timestamp { get; set; }
        }
    }


    internal class Submsgtype0xc5
    {
        [ProtoContract]
        internal class BBInfo
        {
            [ProtoMember(1)] public long BbUin { get; set; }
            [ProtoMember(2)] public int Src { get; set; }
        }

        [ProtoContract]
        internal class BiuBody
        {
            [ProtoMember(1)] public long BiuUin { get; set; }
        }

        [ProtoContract]
        internal class CommentInfo
        {
            [ProtoMember(2)] public long CommentUin { get; set; }
            [ProtoMember(3)] public byte[] CommentId { get; set; }
            [ProtoMember(4)] public long ReplyUin { get; set; }
            [ProtoMember(5)] public byte[] ReplyId { get; set; }
            [ProtoMember(6)] public byte[] CommentContent { get; set; }
        }

        [ProtoContract]
        internal class LikeInfo
        {
            [ProtoMember(2)] public long LikeUin { get; set; }
            [ProtoMember(3)] public int Op { get; set; }
            [ProtoMember(4)] public byte[] ReplyId { get; set; }
        }

        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int Bid { get; set; }
            [ProtoMember(2)] public int Source { get; set; }
            [ProtoMember(3)] public int OperatorType { get; set; }
            [ProtoMember(4)] public long ArticleId { get; set; }
            [ProtoMember(5)] public int PushTime { get; set; }
            [ProtoMember(6)] public long Seq { get; set; }
            [ProtoMember(7)] public string Msgid { get; set; }
            [ProtoMember(10)] public NotifyBody? MsgNotifyInfos { get; set; }
            [ProtoMember(11)] public byte[] DiandianCookie { get; set; }
        }

        [ProtoContract]
        internal class NotifyBody
        {
            [ProtoMember(1)] public StyleSheet? MsgStyleSheet { get; set; }
            [ProtoMember(10)] public CommentInfo? MsgCommentArticle { get; set; }
            [ProtoMember(11)] public LikeInfo? MsgLikeArticle { get; set; }
            [ProtoMember(12)] public BBInfo? MsgBbInfo { get; set; }
            [ProtoMember(13)] public List<RedPointInfo> RedPointInfo { get; set; }
        }

        [ProtoContract]
        internal class RedPointInfo
        {
            [ProtoMember(1)] public int ItemId { get; set; }
            [ProtoMember(2)] public int RedPointItemType { get; set; }
            [ProtoMember(3)] public byte[] Url { get; set; }
            [ProtoMember(4)] public long EffectTime { get; set; }
            [ProtoMember(5)] public long FailureTime { get; set; }
        }

        [ProtoContract]
        internal class StyleSheet
        {
            [ProtoMember(1)] public int ShowFolder { get; set; }
            [ProtoMember(2)] public int FolderRedType { get; set; }
            [ProtoMember(3)] public byte[] OrangeWord { get; set; }
            [ProtoMember(4)] public byte[] Summary { get; set; }
            [ProtoMember(5)] public TipsBody? MsgTipBody { get; set; }
            [ProtoMember(6)] public int ShowLockScreen { get; set; }
            [ProtoMember(7)] public int MsgType { get; set; }
            [ProtoMember(8)] public BiuBody? MsgBiuBody { get; set; }
            [ProtoMember(9)] public int IsLow { get; set; }
        }

        [ProtoContract]
        internal class TipsBody
        {
            [ProtoMember(1)] public int TipsUiType { get; set; }
            [ProtoMember(2)] public long Uin { get; set; }
            [ProtoMember(3)] public byte[] IconUrl { get; set; }
            [ProtoMember(4)] public byte[] Content { get; set; }
            [ProtoMember(5)] public byte[] Schema { get; set; }
            [ProtoMember(6)] public byte[] BusinessInfo { get; set; }
        }
    }


    internal class Submsgtype0xc6
    {
        internal class SubMsgType0xc6
        {
            [ProtoContract]
            internal class AccountExceptionAlertBody
            {
                [ProtoMember(1)] public string Title { get; set; }
                [ProtoMember(2)] public string Content { get; set; }
                [ProtoMember(3)] public string LeftButtonText { get; set; }
                [ProtoMember(4)] public string RightButtonText { get; set; }
                [ProtoMember(5)] public string RightButtonLink { get; set; }
                [ProtoMember(6)] public int LeftButtonId { get; set; }
                [ProtoMember(7)] public int RightButtonId { get; set; }
            }

            [ProtoContract]
            internal class MsgBody
            {
                [ProtoMember(1)] public int SecCmd { get; set; }
                [ProtoMember(2)] public AccountExceptionAlertBody? MsgS2cAccountExceptionNotify { get; set; }
            }
        }
    }


    internal class Submsgtype0xc7
    {
        [ProtoContract]
        internal class ForwardBody
        {
            [ProtoMember(1)] public int NotifyType { get; set; }
            [ProtoMember(2)] public int OpType { get; set; }
            [ProtoMember(3000)] public HotFriendNotify? MsgHotFriendNotify { get; set; }
            [ProtoMember(4000)] public RelationalChainChange? MsgRelationalChainChange { get; set; }
        }

        [ProtoContract]
        internal class FriendShipFlagNotify
        {
            [ProtoMember(1)] public long DstUin { get; set; }
            [ProtoMember(2)] public int Level1 { get; set; }
            [ProtoMember(3)] public int Level2 { get; set; }
            [ProtoMember(4)] public int ContinuityDays { get; set; }
            [ProtoMember(5)] public int ChatFlag { get; set; }
            [ProtoMember(6)] public long LastChatTime { get; set; }
            [ProtoMember(7)] public long NotifyTime { get; set; }
            [ProtoMember(8)] public int Seq { get; set; }
        }

        [ProtoContract]
        internal class HotFriendNotify
        {
            [ProtoMember(1)] public long DstUin { get; set; }
            [ProtoMember(2)] public int PraiseHotLevel { get; set; }
            [ProtoMember(3)] public int ChatHotLevel { get; set; }
            [ProtoMember(4)] public int PraiseHotDays { get; set; }
            [ProtoMember(5)] public int ChatHotDays { get; set; }
            [ProtoMember(6)] public int CloseLevel { get; set; }
            [ProtoMember(7)] public int CloseDays { get; set; }
            [ProtoMember(8)] public int PraiseFlag { get; set; }
            [ProtoMember(9)] public int ChatFlag { get; set; }
            [ProtoMember(10)] public int CloseFlag { get; set; }
            [ProtoMember(11)] public long NotifyTime { get; set; }
            [ProtoMember(12)] public long LastPraiseTime { get; set; }
            [ProtoMember(13)] public long LastChatTime { get; set; }
            [ProtoMember(14)] public int QzoneHotLevel { get; set; }
            [ProtoMember(15)] public int QzoneHotDays { get; set; }
            [ProtoMember(16)] public int QzoneFlag { get; set; }
            [ProtoMember(17)] public long LastQzoneTime { get; set; }
            [ProtoMember(51)] public int ShowRecheckEntry { get; set; }
            [ProtoMember(52)] public byte[] WildcardWording { get; set; }
            [ProtoMember(100)] public int LoverFlag { get; set; }
            [ProtoMember(200)] public int KeyHotLevel { get; set; }
            [ProtoMember(201)] public int KeyHotDays { get; set; }
            [ProtoMember(202)] public int KeyFlag { get; set; }
            [ProtoMember(203)] public long LastKeyTime { get; set; }
            [ProtoMember(204)] public byte[] KeyWording { get; set; }
            [ProtoMember(205)] public int KeyTransFlag { get; set; }
            [ProtoMember(206)] public int LoverKeyBusinessType { get; set; }
            [ProtoMember(207)] public int LoverKeySubBusinessType { get; set; }
            [ProtoMember(208)] public byte[] LoverKeyMainWording { get; set; }
            [ProtoMember(209)] public byte[] LoverKeyLinkWording { get; set; }
            [ProtoMember(300)] public int BoatLevel { get; set; }
            [ProtoMember(301)] public int BoatDays { get; set; }
            [ProtoMember(302)] public int BoatFlag { get; set; }
            [ProtoMember(303)] public int LastBoatTime { get; set; }
            [ProtoMember(304)] public byte[] BoatWording { get; set; }
            [ProtoMember(400)] public int NotifyType { get; set; }
            [ProtoMember(401)] public FriendShipFlagNotify? MsgFriendshipFlagNotify { get; set; }
        }

        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public List<ForwardBody> MsgModInfos { get; set; }
        }

        [ProtoContract]
        internal class RelationalChainChange
        {
            [ProtoMember(1)] public long Appid { get; set; }
            [ProtoMember(2)] public long SrcUin { get; set; }
            [ProtoMember(3)] public long DstUin { get; set; }
            [ProtoMember(4)] public int ChangeType { get; set; }
            [ProtoMember(5)] public RelationalChainInfo? MsgRelationalChainInfoOld { get; set; }
            [ProtoMember(6)] public RelationalChainInfo? MsgRelationalChainInfoNew { get; set; }
            [ProtoMember(7)] public ToDegradeInfo? MsgToDegradeInfo { get; set; }
            [ProtoMember(20)] public List<RelationalChainInfos> RelationalChainInfos { get; set; }
            [ProtoMember(100)] public List<int> Uint32FeatureId { get; set; }
        }

        [ProtoContract]
        internal class RelationalChainInfo
        {
            [ProtoMember(1)] public int Type { get; set; }
            [ProtoMember(2)] public byte[] Attr { get; set; }
            [ProtoMember(1002)] public byte[] IntimateInfo { get; set; }
            [ProtoMember(91001)] public byte[] MusicSwitch { get; set; }
            [ProtoMember(101001)] public byte[] MutualmarkAlienation { get; set; }
        }

        [ProtoContract]
        internal class RelationalChainInfos
        {
            [ProtoMember(1)] public RelationalChainInfo? MsgRelationalChainInfoOld { get; set; }
            [ProtoMember(2)] public RelationalChainInfo? MsgRelationalChainInfoNew { get; set; }
        }

        [ProtoContract]
        internal class ToDegradeInfo
        {
            [ProtoMember(1)] public List<ToDegradeItem> ToDegradeItem { get; set; }
            [ProtoMember(2)] public byte[] Nick { get; set; }
            [ProtoMember(3)] public long NotifyTime { get; set; }
        }

        [ProtoContract]
        internal class ToDegradeItem
        {
            [ProtoMember(1)] public int Type { get; set; }
            [ProtoMember(2)] public int OldLevel { get; set; }
            [ProtoMember(3)] public int NewLevel { get; set; }
            [ProtoMember(11)] public int ContinuityDays { get; set; }
            [ProtoMember(12)] public long LastActionTime { get; set; }
        }
    }

    internal class Mutualmark
    {
        [ProtoContract]
        internal class MutualmarkInfo
        {
            [ProtoMember(1)] public long LastActionTime { get; set; }
            [ProtoMember(2)] public int Level { get; set; }
            [ProtoMember(3)] public long LastChangeTime { get; set; }
            [ProtoMember(4)] public int ContinueDays { get; set; }
            [ProtoMember(5)] public byte[] WildcardWording { get; set; }
            [ProtoMember(6)] public long NotifyTime { get; set; }
            [ProtoMember(7)] public long IconStatus { get; set; }
            [ProtoMember(8)] public long IconStatusEndTime { get; set; }
            [ProtoMember(9)] public int CloseFlag { get; set; }
            [ProtoMember(10)] public byte[] ResourceInfo { get; set; }
        }

        [ProtoContract]
        internal class ResourceInfo17
        {
            [ProtoMember(1)] public byte[] DynamicUrl { get; set; }
            [ProtoMember(2)] public byte[] StaticUrl { get; set; }
            [ProtoMember(3)] public byte[] CartoonUrl { get; set; }
            [ProtoMember(4)] public byte[] CartoonMd5 { get; set; }
            [ProtoMember(5)] public int PlayCartoon { get; set; }
            [ProtoMember(6)] public byte[] Word { get; set; }
        }
    }


    internal class Submsgtype0xc9
    {
        [ProtoContract]
        internal class BusinessMsg
        {
            [ProtoMember(1)] public int MsgType { get; set; }
            [ProtoMember(2)] public byte[] MsgData { get; set; }
            [ProtoMember(3)] public bool BoolTabVisible { get; set; }
        }

        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int Type { get; set; }
            [ProtoMember(2)] public long FromUin { get; set; }
            [ProtoMember(3)] public long ActionUin { get; set; }
            [ProtoMember(4)] public int Source { get; set; }
            [ProtoMember(5)] public List<BusinessMsg> MsgBusinessMsg { get; set; }
            [ProtoMember(6)] public bool BoolNewFriend { get; set; }
        }
    }


    internal class Submsgtype0xca
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public long Uin { get; set; }
            [ProtoMember(2)] public List<MsgContent> MsgList { get; set; }
        }

        [ProtoContract]
        internal class MsgContent
        {
            [ProtoMember(1)] public long Tag { get; set; }
            [ProtoMember(2)] public long MsgType { get; set; }
            [ProtoMember(3)] public long Seq { get; set; }
            [ProtoMember(4)] public string Content { get; set; }
            [ProtoMember(5)] public long ActionId { get; set; }
            [ProtoMember(6)] public long Ts { get; set; }
            [ProtoMember(7)] public long Expts { get; set; }
            [ProtoMember(8)] public string ErrorMsg { get; set; }
            [ProtoMember(9)] public long ShowSpace { get; set; }
            [ProtoMember(10)] public string RegionUrl { get; set; }
        }
    }


    internal class Submsgtype0xcb
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int AnchorStatus { get; set; }
            [ProtoMember(2)] public byte[] JumpSchema { get; set; }
            [ProtoMember(3)] public byte[] AnchorNickname { get; set; }
            [ProtoMember(4)] public byte[] AnchorHeadUrl { get; set; }
            [ProtoMember(5)] public byte[] LiveWording { get; set; }
            [ProtoMember(6)] public byte[] LiveEndWording { get; set; }
            [ProtoMember(7)] public byte[] C2cMsgWording { get; set; }
            [ProtoMember(8)] public int LiveWordingType { get; set; }
            [ProtoMember(9)] public int EndWordingType { get; set; }
        }
    }


    internal class Submsgtype0xcc
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int MsgType { get; set; }
            [ProtoMember(2)] public byte[] MsgInfo { get; set; }
            [ProtoMember(3)] public long Uin { get; set; }
            [ProtoMember(4)] public byte[] UnionId { get; set; }
            [ProtoMember(5)] public byte[] SubType { get; set; }
            [ProtoMember(6)] public byte[] FeedId { get; set; }
            [ProtoMember(7)] public byte[] Vid { get; set; }
            [ProtoMember(8)] public byte[] CoverUrl { get; set; }
        }
    }


    internal class Submsgtype0xce
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public long Int64StartTime { get; set; }
            [ProtoMember(2)] public long Int64EndTime { get; set; }
            [ProtoMember(3)] public string Params { get; set; }
        }
    }



    internal class Submsgtype0xcf
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int Rsptype { get; set; }
            [ProtoMember(2)] public string Rspbody { get; set; }
        }
    }



    internal class Submsgtype0xd0
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int MsgType { get; set; }
            [ProtoMember(2)] public byte[] MsgInfo { get; set; }
            [ProtoMember(3)] public long HotTopicId { get; set; }
            [ProtoMember(4)] public byte[] HotTopicName { get; set; }
            [ProtoMember(5)] public long BigVId { get; set; }
            [ProtoMember(6)] public byte[] BigVUnionId { get; set; }
            [ProtoMember(7)] public int PgcType { get; set; }
            [ProtoMember(8)] public byte[] PgcColumnUnionId { get; set; }
            [ProtoMember(9)] public byte[] Link { get; set; }
            [ProtoMember(10)] public byte[] SubType { get; set; }
            [ProtoMember(11)] public byte[] CoverUrl { get; set; }
        }
    }



    internal class Submsgtype0xd7
    {
        [ProtoContract]
        internal class Content
        {
            [ProtoMember(1)] public byte[] FromUser { get; set; }
            [ProtoMember(2)] public byte[] PlainText { get; set; }
            [ProtoMember(3)] public byte[] BuluoWord { get; set; }
            [ProtoMember(4)] public AppointDefine.RichText? RichFreshWord { get; set; }
        }

        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int Type { get; set; }
            [ProtoMember(2)] public int MsgboxUnreadCount { get; set; }
            [ProtoMember(3)] public int UnreadCount { get; set; }
            [ProtoMember(4)] public Content? MsgContent { get; set; }
            [ProtoMember(5)] public long Timestamp { get; set; }
        }
    }



    internal class Submsgtype0xda
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int MsgType { get; set; }
            [ProtoMember(2)] public byte[] MsgInfo { get; set; }
            [ProtoMember(3)] public byte[] SubType { get; set; }
            [ProtoMember(4)] public byte[] VersionCtrl { get; set; }
            [ProtoMember(5)] public byte[] FeedId { get; set; }
            [ProtoMember(6)] public byte[] UnionId { get; set; }
            [ProtoMember(7)] public int CommentId { get; set; }
            [ProtoMember(8)] public byte[] IconUnionId { get; set; }
            [ProtoMember(9)] public byte[] CoverUrl { get; set; }
            [ProtoMember(10)] public int OperType { get; set; }
            [ProtoMember(11)] public byte[] GroupUnionid { get; set; }
            [ProtoMember(12)] public byte[] Vid { get; set; }
            [ProtoMember(13)] public byte[] DoodleUrl { get; set; }
            [ProtoMember(14)] public byte[] FromNick { get; set; }
            [ProtoMember(15)] public byte[] VidUrl { get; set; }
            [ProtoMember(16)] public byte[] ExtInfo { get; set; }
        }
    }



    internal class Submsgtype0xdb
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int Rsptype { get; set; }
            [ProtoMember(2)] public string Rspbody { get; set; }
        }
    }



    internal class Submsgtype0xdc
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public List<MsgContent> MsgList { get; set; }
            [ProtoMember(2)] public int MsgType { get; set; }
            [ProtoMember(3)] public List<MsgContent> MsgList0x02 { get; set; }
            [ProtoMember(4)] public string MinQqVer { get; set; }
        }

        [ProtoContract]
        internal class MsgContent
        {
            [ProtoMember(1)] public long MasterPri { get; set; }
            [ProtoMember(2)] public long SubPri { get; set; }
            [ProtoMember(3)] public long ShowTimes { get; set; }
            [ProtoMember(4)] public long ShowBegTs { get; set; }
            [ProtoMember(5)] public long ExpTs { get; set; }
            [ProtoMember(6)] public long MsgSentTs { get; set; }
            [ProtoMember(7)] public long ActionId { get; set; }
            [ProtoMember(8)] public string Wording { get; set; }
            [ProtoMember(9)] public string Scheme { get; set; }
            [ProtoMember(10)] public string RegionUrl { get; set; }
            [ProtoMember(11)] public long WordingColor { get; set; }
            [ProtoMember(12)] public long MsgId { get; set; }
            [ProtoMember(13)] public long BubbleId { get; set; }
            [ProtoMember(14)] public string Tips { get; set; }
            [ProtoMember(15)] public long GameId { get; set; }
        }
    }

    internal class Submsgtype0xdd
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int MsgType { get; set; }
            [ProtoMember(2)] public List<long> Uint64InviteUin { get; set; }
            [ProtoMember(3)] public long InviteLeader { get; set; }
            [ProtoMember(4)] public WifiPOIInfo? MsgPoiInfo { get; set; }
            [ProtoMember(5)] public List<PlayerState> MsgPlayerState { get; set; }
        }
        [ProtoContract]
        internal class PlayerState
        {
            [ProtoMember(1)] public long Uin { get; set; }
            [ProtoMember(2)] public int State { get; set; }
        }

        [ProtoContract]
        internal class SeatsInfo
        {
            [ProtoMember(1)] public int SeatFlag { get; set; }
            [ProtoMember(2)] public long GuestUin { get; set; }
            [ProtoMember(3)] public int SeatId { get; set; }
            [ProtoMember(4)] public int SeatSeq { get; set; }
        }

        [ProtoContract]
        internal class WifiPOIInfo
        {
            [ProtoMember(1)] public byte[] Uid { get; set; }
            [ProtoMember(2)] public byte[] Name { get; set; }
            [ProtoMember(3)] public int FaceId { get; set; }
            [ProtoMember(4)] public byte[] Sig { get; set; }
            [ProtoMember(5)] public int GroupCode { get; set; }
            [ProtoMember(6)] public int GroupUin { get; set; }
            [ProtoMember(7)] public int VisitorNum { get; set; }
            [ProtoMember(8)] public int WifiPoiType { get; set; }
            [ProtoMember(9)] public int IsMember { get; set; }
            [ProtoMember(10)] public int Distance { get; set; }
            [ProtoMember(11)] public int MsgTabSwitchOff { get; set; }
            [ProtoMember(12)] public string FaceUrl { get; set; }
            [ProtoMember(13)] public int HotThemeGroupFlag { get; set; }
            [ProtoMember(14)] public string BannerUrl { get; set; }
            [ProtoMember(15)] public int SpecialFlag { get; set; }
            [ProtoMember(16)] public int TotalNumLimit { get; set; }
            [ProtoMember(17)] public int IsAdmin { get; set; }
            [ProtoMember(18)] public string JoinGroupUrl { get; set; }
            [ProtoMember(19)] public int GroupTypeFlag { get; set; }
            [ProtoMember(20)] public int CreaterCityId { get; set; }
            [ProtoMember(21)] public int IsUserCreate { get; set; }
            [ProtoMember(22)] public long OwnerUin { get; set; }
            [ProtoMember(23)] public int AuditFlag { get; set; }
            [ProtoMember(24)] public int TvPkFlag { get; set; }
            [ProtoMember(25)] public int SubType { get; set; }
            [ProtoMember(26)] public long LastMsgSeq { get; set; }
            [ProtoMember(27)] public List<SeatsInfo> MsgSeatsInfo { get; set; }
            [ProtoMember(28)] public long FlowerNum { get; set; }
            [ProtoMember(29)] public long FlowerPoint { get; set; }
            [ProtoMember(31)] public long FavoritesTime { get; set; }
            [ProtoMember(32)] public int FavoritesExpired { get; set; }
            [ProtoMember(33)] public int GroupId { get; set; }
            [ProtoMember(34)] public long PraiseNums { get; set; }
            [ProtoMember(35)] public long ReportPraiseGapTime { get; set; }
            [ProtoMember(36)] public long ReportPraiseGapFrequency { get; set; }
            [ProtoMember(37)] public long GetPraiseGapTime { get; set; }
            [ProtoMember(38)] public long VistorJoinGroupTime { get; set; }
            [ProtoMember(39)] public int GroupIsNotExist { get; set; }
            [ProtoMember(40)] public int GuestNum { get; set; }
            [ProtoMember(41)] public int HighQualityFlag { get; set; }
            [ProtoMember(42)] public long ExitGroupCode { get; set; }
            [ProtoMember(43)] public int Int32Latitude { get; set; }
            [ProtoMember(44)] public int Int32Longitude { get; set; }
            [ProtoMember(45)] public string Smemo { get; set; }
            [ProtoMember(46)] public int IsAllCountry { get; set; }
        }
    }



    internal class Submsgtype0xde
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int MsgType { get; set; }
            [ProtoMember(2)] public byte[] UnionId { get; set; }
            [ProtoMember(3)] public long Uid { get; set; }
            [ProtoMember(4)] public byte[] Vid { get; set; }
            [ProtoMember(5)] public byte[] VideoCover { get; set; }
        }

    }


    internal class Submsgtype0xdf
    {
        [ProtoContract]
        internal class MsgBody
        {
            // [ProtoMember(1)] public  ApolloGameStatus.STCMGameMessage?  MsgGameState { get; set; }
            [ProtoMember(2)] public List<int> Uint32UinList { get; set; }
        }

    }


    internal class Submsgtype0xe0
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public byte[] PushExt { get; set; }
        }

    }


    internal class Submsgtype0xe1
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public byte[] PushExt { get; set; }
        }

    }


    internal class Submsgtype0xe4
    {
        [ProtoContract]
        internal class GeoInfo
        {
            [ProtoMember(1)] public long Latitude { get; set; }
            [ProtoMember(2)] public long Longitude { get; set; }
        }

        [ProtoContract]
        internal class GiftMsg
        {
            [ProtoMember(1)] public long FromUin { get; set; }
            [ProtoMember(2)] public long ToUin { get; set; }
            [ProtoMember(3)] public int ProductId { get; set; }
            [ProtoMember(4)] public int GiftId { get; set; }
            [ProtoMember(5)] public long GiftNum { get; set; }
            [ProtoMember(6)] public string Roomid { get; set; }
            [ProtoMember(7)] public byte[] GiftWording { get; set; }
            [ProtoMember(8)] public byte[] Packageurl { get; set; }
            [ProtoMember(50)] public int CurAddDuration { get; set; }
            [ProtoMember(51)] public int AllAddDuration { get; set; }
        }

        [ProtoContract]
        internal class LikeMsg
        {
            [ProtoMember(1)] public long FromUin { get; set; }
            [ProtoMember(2)] public long ToUin { get; set; }
        }

        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public Player? MsgMatchPlayer { get; set; }
            [ProtoMember(2)] public int Distance { get; set; }
            [ProtoMember(3)] public string Hint { get; set; }
            [ProtoMember(4)] public int Countdown { get; set; }
            [ProtoMember(5)] public byte[] Key { get; set; }
            [ProtoMember(6)] public int Type { get; set; }
            [ProtoMember(7)] public int CallType { get; set; }
            [ProtoMember(8)] public byte[] DisplayDistance { get; set; }
            [ProtoMember(9)] public LikeMsg? MsgLike { get; set; }
            [ProtoMember(10)] public GiftMsg? MsgGift { get; set; }
            [ProtoMember(11)] public Room? MsgRoom { get; set; }
        }

        [ProtoContract]
        internal class Player
        {
            [ProtoMember(1)] public long Uin { get; set; }
            [ProtoMember(2)] public byte[] Nickname { get; set; }
            [ProtoMember(3)] public byte[] LogoUrl { get; set; }
            [ProtoMember(4)] public int Gender { get; set; }
            [ProtoMember(5)] public int Level { get; set; }
            [ProtoMember(6)] public int Age { get; set; }
        }

        [ProtoContract]
        internal class Room
        {
            [ProtoMember(1)] public string RoomId { get; set; }
        }
    }



    internal class Submsgtype0xe5
    {
        [ProtoContract]
        internal class CrmS2CMsgHead
        {
            [ProtoMember(1)] public int CrmSubCmd { get; set; }
            [ProtoMember(2)] public int HeadLen { get; set; }
            [ProtoMember(3)] public int VerNo { get; set; }
            [ProtoMember(4)] public long KfUin { get; set; }
            [ProtoMember(5)] public int Seq { get; set; }
            [ProtoMember(6)] public int PackNum { get; set; }
            [ProtoMember(7)] public int CurPack { get; set; }
            [ProtoMember(8)] public string BufSig { get; set; }
        }

        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int SubCmd { get; set; }
            [ProtoMember(2)] public CrmS2CMsgHead? MsgCrmCommonHead { get; set; }
            [ProtoMember(3)] public S2CCcAgentStatusChangePush? MsgS2cCcAgentStatusChangePush { get; set; }
            [ProtoMember(4)] public S2CCcConfigChangePush? MsgS2cCcConfigChangePush { get; set; }
            [ProtoMember(5)] public S2CCcExceptionOccurPush? MsgS2cCcExceptionOccurPush { get; set; }
            [ProtoMember(6)] public S2CCcTalkingStatusChangePush? MsgS2cCcTalkingStatusChangePush { get; set; }
            [ProtoMember(7)] public S2CCcAgentActionResultPush? MsgS2cCcAgentActionResultPush { get; set; }
            [ProtoMember(8)] public S2CCallRecordChangePush? MsgS2cCallRecordChangePush { get; set; }
            [ProtoMember(9)] public S2CSMSEventPush? MsgS2cSmsEventPush { get; set; }
            [ProtoMember(10)] public S2CAgentCallStatusEventPush? MsgS2cAgentCallStatusEventPush { get; set; }
            [ProtoMember(11)] public S2CUserGetCouponForKFExtEventPush? MsgS2cUserGetCouponForKfextEventPush { get; set; }
            [ProtoMember(12)] public S2CUserGetCouponForCEventPush? MsgS2cUserGetCouponForCEventPush { get; set; }
        }
        [ProtoContract]
        internal class S2CAgentCallStatusEventPush
        {
            [ProtoMember(1)] public int Type { get; set; }
            [ProtoMember(2)] public int CallStatus { get; set; }
            [ProtoMember(3)] public int RingAsr { get; set; }
            [ProtoMember(4)] public string Callid { get; set; }
            [ProtoMember(5)] public long FromKfext { get; set; }
            [ProtoMember(6)] public int Timestamp { get; set; }
        }

        [ProtoContract]
        internal class S2CCallRecordChangePush
        {
            [ProtoMember(1)] public long Kfext { get; set; }
            [ProtoMember(2)] public long Fixed64Timestamp { get; set; }
        }

        [ProtoContract]
        internal class S2CCcAgentActionResultPush
        {
            [ProtoMember(1)] public int Type { get; set; }
            [ProtoMember(2)] public string Callid { get; set; }
            [ProtoMember(3)] public int Result { get; set; }
            [ProtoMember(4)] public int Timestamp { get; set; }
            [ProtoMember(5)] public int Status { get; set; }
            [ProtoMember(6)] public byte[] TargetName { get; set; }
            [ProtoMember(7)] public long TargetKfext { get; set; }
        }

        [ProtoContract]
        internal class S2CCcAgentStatusChangePush
        {
            [ProtoMember(1)] public int ReadyDevice { get; set; }
            [ProtoMember(2)] public long UpdateTime { get; set; }
            [ProtoMember(3)] public int DeviceSubState { get; set; }
        }

        [ProtoContract]
        internal class S2CCcConfigChangePush
        {
            [ProtoMember(1)] public int Optype { get; set; }
        }

        [ProtoContract]
        internal class S2CCcExceptionOccurPush
        {
            [ProtoMember(1)] public int Optype { get; set; }
        }

        [ProtoContract]
        internal class S2CCcTalkingStatusChangePush
        {
            [ProtoMember(1)] public int TalkingStatus { get; set; }
            [ProtoMember(2)] public string Callid { get; set; }
        }

        [ProtoContract]
        internal class S2CSMSEventPush
        {
            [ProtoMember(1)] public int Type { get; set; }
            [ProtoMember(2)] public string PhoneNum { get; set; }
            [ProtoMember(3)] public long Timestamp { get; set; }
            [ProtoMember(4)] public string SmsId { get; set; }
            [ProtoMember(5)] public string EventMsg { get; set; }
        }

        [ProtoContract]
        internal class S2CUserGetCouponForCEventPush
        {
            [ProtoMember(1)] public long Qquin { get; set; }
            [ProtoMember(2)] public long Kfuin { get; set; }
            [ProtoMember(3)] public long CouponId { get; set; }
            [ProtoMember(4)] public int Timestamp { get; set; }
            [ProtoMember(5)] public long Kfext { get; set; }
            [ProtoMember(6)] public string TipsContent { get; set; }
        }

        [ProtoContract]
        internal class S2CUserGetCouponForKFExtEventPush
        {
            [ProtoMember(1)] public int ChannelType { get; set; }
            [ProtoMember(2)] public long Fakeuin { get; set; }
            [ProtoMember(3)] public long Qquin { get; set; }
            [ProtoMember(4)] public string Openid { get; set; }
            [ProtoMember(5)] public string Visitorid { get; set; }
            [ProtoMember(6)] public string Appid { get; set; }
            [ProtoMember(7)] public long QqPubUin { get; set; }
            [ProtoMember(8)] public long Kfuin { get; set; }
            [ProtoMember(9)] public long CouponId { get; set; }
            [ProtoMember(10)] public string NotifyTips { get; set; }
            [ProtoMember(11)] public int Timestamp { get; set; }
            [ProtoMember(12)] public long Kfext { get; set; }
        }
    }



    internal class Submsgtype0xe8
    {
        [ProtoContract]
        internal class MsgBody
        {
            //[ProtoMember(1)] public ApolloPushMsgInfo.STPushMsgElem? MsgItem { get; set; }
        }

    }


    internal class Submsgtype0xe9
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int BusinessType { get; set; }
            [ProtoMember(2)] public byte[] Business { get; set; }
        }

    }


    internal class Submsgtype0xea
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public byte[] Title { get; set; }
            [ProtoMember(2)] public byte[] Content { get; set; }
        }

    }


    internal class Submsgtype0xee
    {
        [ProtoContract]
        internal class AccountInfo
        {
            [ProtoMember(1)] public long Id { get; set; }
            [ProtoMember(2)] public byte[] Name { get; set; }
            [ProtoMember(3)] public byte[] IconUrl { get; set; }
        }

        [ProtoContract]
        internal class ContextInfo
        {
            [ProtoMember(1)] public long Id { get; set; }
            [ProtoMember(2)] public byte[] Title { get; set; }
            [ProtoMember(3)] public List<PictureInfo> MsgPicList { get; set; }
            [ProtoMember(4)] public byte[] JumpUrl { get; set; }
            [ProtoMember(5)] public byte[] OrangeWord { get; set; }
            [ProtoMember(6)] public byte[] Brief { get; set; }
            [ProtoMember(7)] public int EnumContextType { get; set; }
            [ProtoMember(8)] public byte[] VideoBrief { get; set; }
        }

        [ProtoContract]
        internal class ControlInfo
        {
            [ProtoMember(1)] public int CommentLength { get; set; }
            [ProtoMember(2)] public int ShowLine { get; set; }
            [ProtoMember(3)] public int FontSize { get; set; }
        }

        [ProtoContract]
        internal class ExtraInfo
        {
            [ProtoMember(1)] public byte[] Ext { get; set; }
            [ProtoMember(2)] public byte[] Cookie { get; set; }
        }

        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public byte[] Id { get; set; }
            [ProtoMember(2)] public long Seq { get; set; }
            [ProtoMember(3)] public int Bid { get; set; }
            [ProtoMember(11)] public List<NotifyInfo> MsgNotifyList { get; set; }
        }

        [ProtoContract]
        internal class NotifyInfo
        {
            [ProtoMember(1)] public StyleSheet? MsgStyleSheet { get; set; }
            [ProtoMember(2)] public int EnumApppushType { get; set; }
            [ProtoMember(3)] public OrdinaryPushInfo? MsgOrdinaryPushInfo { get; set; }
            [ProtoMember(4)] public SocialPushInfo? MsgSocialPushInfo { get; set; }
            [ProtoMember(5)] public UGCPushInfo? MsgUgcPushInfo { get; set; }
            [ProtoMember(11)] public ContextInfo? MsgContextInfo { get; set; }
            [ProtoMember(12)] public AccountInfo? MsgAccountInfo { get; set; }
            [ProtoMember(13)] public StatisticsInfo? MsgStatisticsInfo { get; set; }
            [ProtoMember(14)] public ControlInfo? MsgControlInfo { get; set; }
            [ProtoMember(21)] public ExtraInfo? MsgExtraInfo { get; set; }
        }

        [ProtoContract]
        internal class OrangeControlInfo
        {
            [ProtoMember(1)] public byte[] Color { get; set; }
            [ProtoMember(2)] public int FontSize { get; set; }
        }

        [ProtoContract]
        internal class OrdinaryPushInfo
        {
            [ProtoMember(1)] public OrangeControlInfo? MsgLabelControlInfo { get; set; }
        }

        [ProtoContract]
        internal class PictureInfo
        {
            [ProtoMember(1)] public byte[] Url { get; set; }
        }

        [ProtoContract]
        internal class SocialPushInfo
        {
            [ProtoMember(1)] public long FeedsId { get; set; }
            [ProtoMember(2)] public byte[] BiuReason { get; set; }
            [ProtoMember(3)] public byte[] BiuComment { get; set; }
        }

        [ProtoContract]
        internal class StatisticsInfo
        {
            [ProtoMember(1)] public long AlgorithmId { get; set; }
            [ProtoMember(2)] public long StrategyId { get; set; }
            [ProtoMember(3)] public long FolderStatus { get; set; }
        }

        [ProtoContract]
        internal class StyleSheet
        {
            [ProtoMember(1)] public int EnumStyleType { get; set; }
            [ProtoMember(2)] public int ArkEnable { get; set; }
            [ProtoMember(3)] public long Scene { get; set; }
            [ProtoMember(11)] public int Duration { get; set; }
            [ProtoMember(12)] public long EndTime { get; set; }
        }

        [ProtoContract]
        internal class UGCPushInfo
        {
            [ProtoMember(1)] public long FeedsId { get; set; }
            [ProtoMember(2)] public byte[] UgcReason { get; set; }
        }
    }



    internal class Submsgtype0xf9
    {
        [ProtoContract]
        internal class AdInfo
        {
            [ProtoMember(1)] public long FromUin { get; set; }
            [ProtoMember(2)] public string Nick { get; set; }
            [ProtoMember(3)] public string HeadUrl { get; set; }
            [ProtoMember(4)] public string Brief { get; set; }
            [ProtoMember(5)] public string Action { get; set; }
            [ProtoMember(6)] public int Flag { get; set; }
            [ProtoMember(7)] public int ServiceID { get; set; }
            [ProtoMember(8)] public int TemplateID { get; set; }
            [ProtoMember(9)] public string Url { get; set; }
            [ProtoMember(10)] public MsgCommonData? MsgMsgCommonData { get; set; }
            [ProtoMember(11)] public List<Video> MsgVideo { get; set; }
            [ProtoMember(12)] public int PushTime { get; set; }
            [ProtoMember(13)] public int InvalidTime { get; set; }
            [ProtoMember(14)] public int MaxExposureTime { get; set; }
        }

        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public byte[] ZipAdInfo { get; set; }
        }

        [ProtoContract]
        internal class MsgCommonData
        {
            [ProtoMember(1)] public string AdId { get; set; }
            [ProtoMember(2)] public string AdPosId { get; set; }
            [ProtoMember(3)] public bool BoolBannerShow { get; set; }
            [ProtoMember(4)] public int Bannertype { get; set; }
            [ProtoMember(5)] public int JumpType { get; set; }
            [ProtoMember(6)] public string JumpUrl { get; set; }
            [ProtoMember(7)] public string AppId { get; set; }
            [ProtoMember(8)] public string AppName { get; set; }
            [ProtoMember(9)] public string Packagename { get; set; }
            [ProtoMember(10)] public string AndroidDownloadUrl { get; set; }
            [ProtoMember(11)] public string Scheme { get; set; }
            [ProtoMember(12)] public string IosDownloadUrl { get; set; }
            [ProtoMember(13)] public string BannerImgUrl { get; set; }
            [ProtoMember(14)] public string BannerText { get; set; }
            [ProtoMember(15)] public string BannerButtonText { get; set; }
            [ProtoMember(16)] public bool BoolSilentDownload { get; set; }
            [ProtoMember(17)] public int AudioSwitchType { get; set; }
            [ProtoMember(18)] public int PreDownloadType { get; set; }
            [ProtoMember(19)] public string ReportLink { get; set; }
            [ProtoMember(20)] public bool BoolHorizontalVideo { get; set; }
            [ProtoMember(21)] public int AudioFadeinDuration { get; set; }
            [ProtoMember(22)] public string OpenJumpUrlGuide { get; set; }
            [ProtoMember(23)] public string MyappDownloadUrl { get; set; }
            [ProtoMember(24)] public string JumpTypeParams { get; set; }
            [ProtoMember(25)] public int ScrollUpToJump { get; set; }
            [ProtoMember(26)] public int ControlVariable { get; set; }
            [ProtoMember(27)] public int AutoJump { get; set; }
            [ProtoMember(28)] public string ClickLink { get; set; }
            [ProtoMember(29)] public int MonitorType { get; set; }
            [ProtoMember(30)] public string ShareNick { get; set; }
            [ProtoMember(31)] public string ShareAdHeadUrl { get; set; }
            [ProtoMember(32)] public string ShareAdBrief { get; set; }
            [ProtoMember(33)] public string ShareAdTxt { get; set; }
            [ProtoMember(34)] public string ShareAdIconUrl { get; set; }
            [ProtoMember(35)] public string ShareJumpUrl { get; set; }
            [ProtoMember(36)] public int ControlPluginTime { get; set; }
        }

        [ProtoContract]
        internal class Video
        {
            [ProtoMember(1)] public int Layout { get; set; }
            [ProtoMember(2)] public string Cover { get; set; }
            [ProtoMember(3)] public string Src { get; set; }
        }

    }


    internal class Submsgtype0xfd
    {
        [ProtoContract]
        internal class AdInfo
        {
            [ProtoMember(1)] public long FromUin { get; set; }
            [ProtoMember(2)] public string AdId { get; set; }
            [ProtoMember(3)] public int AdSeq { get; set; }
        }

        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public AdInfo? MsgAdInfo { get; set; }
        }

    }


    internal class Submsgtype0xfe
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public byte[] Wording { get; set; }
            [ProtoMember(2)] public int InnerUnreadNum { get; set; }
            [ProtoMember(3)] public int BoxUnreadNum { get; set; }
            [ProtoMember(4)] public int UpdateTime { get; set; }
        }
    }
}
