using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

internal class Common
{
    [ProtoContract]
    internal class BindInfo
    {
        [ProtoMember(1)] public long FriUin { get; set; }
        [ProtoMember(2)] public string FriNick { get; set; }
        [ProtoMember(3)] public long Time { get; set; }
        [ProtoMember(4)] public int BindStatus { get; set; }
    }

    [ProtoContract]
    internal class MedalInfo
    {
        [ProtoMember(1)] public int Id { get; set; }
        [ProtoMember(2)] public int Type { get; set; }
        [ProtoMember(4)] public long Seq { get; set; }
        [ProtoMember(5)] public string Name { get; set; }
        [ProtoMember(6)] public int Newflag { get; set; }
        [ProtoMember(7)] public long Time { get; set; }
        [ProtoMember(8)] public BindInfo? MsgBindFri { get; set; }
        [ProtoMember(11)] public string Desc { get; set; }
        [ProtoMember(31)] public int Level { get; set; }
        [ProtoMember(36)] public List<MedalTaskInfo> Taskinfos { get; set; }
        [ProtoMember(40)] public int Point { get; set; }
        [ProtoMember(41)] public int PointLevel2 { get; set; }
        [ProtoMember(42)] public int PointLevel3 { get; set; }
        [ProtoMember(43)] public long SeqLevel2 { get; set; }
        [ProtoMember(44)] public long SeqLevel3 { get; set; }
        [ProtoMember(45)] public long TimeLevel2 { get; set; }
        [ProtoMember(46)] public long TimeLevel3 { get; set; }
        [ProtoMember(47)] public string DescLevel2 { get; set; }
        [ProtoMember(48)] public string DescLevel3 { get; set; }
        [ProtoMember(49)] public int Endtime { get; set; }
        [ProtoMember(50)] public string DetailUrl { get; set; }
        [ProtoMember(51)] public string DetailUrl2 { get; set; }
        [ProtoMember(52)] public string DetailUrl3 { get; set; }
        [ProtoMember(53)] public string TaskDesc { get; set; }
        [ProtoMember(54)] public string TaskDesc2 { get; set; }
        [ProtoMember(55)] public string TaskDesc3 { get; set; }
        [ProtoMember(56)] public int LevelCount { get; set; }
        [ProtoMember(57)] public int NoProgress { get; set; }
        [ProtoMember(58)] public string Resource { get; set; }
        [ProtoMember(59)] public int FromuinLevel { get; set; }
        [ProtoMember(60)] public int Unread { get; set; }
        [ProtoMember(61)] public int Unread2 { get; set; }
        [ProtoMember(62)] public int Unread3 { get; set; }
    }

    [ProtoContract]
    internal class MedalTaskInfo
    {
        [ProtoMember(1)] public int Taskid { get; set; }
        [ProtoMember(32)] public int Int32TaskValue { get; set; }
        [ProtoMember(33)] public int TarValue { get; set; }
        [ProtoMember(34)] public int TarValueLevel2 { get; set; }
        [ProtoMember(35)] public int TarValueLevel3 { get; set; }
    }
}

[ProtoContract]
internal class AppointDefine
{
    [ProtoContract]
    internal class ADFeedContent
    {
        [ProtoMember(1)] public UserInfo? MsgUserInfo { get; set; }
        [ProtoMember(2)] public List<string> StrPicUrl { get; set; }
        [ProtoMember(3)] public RichText? MsgText { get; set; }
        [ProtoMember(4)] public string AttendInfo { get; set; }
        [ProtoMember(5)] public string ActionUrl { get; set; }
        [ProtoMember(6)] public int PublishTime { get; set; }
        [ProtoMember(7)] public HotTopicList? MsgHotTopicList { get; set; }
        [ProtoMember(8)] public string MoreUrl { get; set; }
        [ProtoMember(9)] public string RecordDuration { get; set; }
    }

    [ProtoContract]
    internal class RichText
    {
        [ProtoMember(1)] public List<Elem> MsgElems { get; set; }
    }

    [ProtoContract]
    internal class RankEvent
    {
        [ProtoMember(1)] public int Listtype { get; set; }
        [ProtoMember(2)] public int Notifytype { get; set; }
        [ProtoMember(3)] public int Eventtime { get; set; }
        [ProtoMember(4)] public int Seq { get; set; }
        [ProtoMember(5)] public string NotifyTips { get; set; }
    }

    [ProtoContract]
    internal class Wifi
    {
        [ProtoMember(1)] public long Mac { get; set; }
        [ProtoMember(2)] public int Int32Rssi { get; set; }
    }

    [ProtoContract]
    internal class InterestItem
    {
        [ProtoMember(1)] public long TagId { get; set; }
        [ProtoMember(2)] public string TagName { get; set; }
        [ProtoMember(3)] public string TagIconUrl { get; set; }
        [ProtoMember(4)] public string TagHref { get; set; }
        [ProtoMember(5)] public string TagBackColor { get; set; }
        [ProtoMember(6)] public string TagFontColor { get; set; }
        [ProtoMember(7)] public string TagVid { get; set; }
        [ProtoMember(8)] public int TagType { get; set; }
        [ProtoMember(9)] public int AddTime { get; set; }
        [ProtoMember(10)] public string TagCategory { get; set; }
        [ProtoMember(11)] public string TagOtherUrl { get; set; }
        [ProtoMember(12)] public int Bid { get; set; }
    }

    [ProtoContract]
    internal class ShopID
    {
        [ProtoMember(1)] public string Shopid { get; set; }
        [ProtoMember(2)] public int Sp { get; set; }
    }

    [ProtoContract]
    internal class FeedComment
    {
        [ProtoMember(1)] public string CommentId { get; set; }
        [ProtoMember(2)] public string FeedId { get; set; }
        [ProtoMember(3)] public StrangerInfo? MsgPublisherInfo { get; set; }
        [ProtoMember(4)] public int Time { get; set; }
        [ProtoMember(6)] public ReplyInfo? MsgReplyInfo { get; set; }
        [ProtoMember(7)] public int Flag { get; set; }
        [ProtoMember(8)] public RichText? MsgContent { get; set; }
        [ProtoMember(9)] public int Hot { get; set; }
    }

    [ProtoContract]
    internal class ADFeed
    {
        [ProtoMember(1)] public int TaskId { get; set; }
        [ProtoMember(2)] public int Style { get; set; }
        [ProtoMember(3)] public byte[] Content { get; set; }
    }

    [ProtoContract]
    internal class Cell
    {
        [ProtoMember(1)] public int Int32Mcc { get; set; }
        [ProtoMember(2)] public int Int32Mnc { get; set; }
        [ProtoMember(3)] public int Int32Lac { get; set; }
        [ProtoMember(4)] public int Int32Cellid { get; set; }
        [ProtoMember(5)] public int Int32Rssi { get; set; }
    }

    [ProtoContract]
    internal class RecentVistorEvent
    {
        [ProtoMember(1)] public int Eventtype { get; set; }
        [ProtoMember(2)] public long EventTinyid { get; set; }
        [ProtoMember(3)] public int UnreadCount { get; set; }
    }

    [ProtoContract]
    internal class OrganizerInfo
    {
        [ProtoMember(1)] public string HostName { get; set; }
        [ProtoMember(2)] public string HostUrl { get; set; }
        [ProtoMember(3)] public string HostCover { get; set; }
    }

    [ProtoContract]
    internal class InterestTag
    {
        [ProtoMember(1)] public int TagType { get; set; }
        [ProtoMember(2)] public List<InterestItem> MsgTagList { get; set; }
    }

    [ProtoContract]
    internal class AppointInfoEx
    {
        [ProtoMember(1)] public string FeedsPicUrl { get; set; }
        [ProtoMember(2)] public string FeedsUrl { get; set; }
        [ProtoMember(3)] public string DetailTitle { get; set; }
        [ProtoMember(4)] public string DetailDescribe { get; set; }
        [ProtoMember(5)] public int ShowPublisher { get; set; }
        [ProtoMember(6)] public string DetailPicUrl { get; set; }
        [ProtoMember(7)] public string DetailUrl { get; set; }
        [ProtoMember(8)] public int ShowAttend { get; set; }
    }

    [ProtoContract]
    internal class DateComment
    {
        [ProtoMember(1)] public string CommentId { get; set; }
        [ProtoMember(2)] public AppointID? MsgAppointId { get; set; }
        [ProtoMember(3)] public StrangerInfo? MsgPublisherInfo { get; set; }
        [ProtoMember(4)] public int Time { get; set; }
        [ProtoMember(6)] public ReplyInfo? MsgReplyInfo { get; set; }
        [ProtoMember(7)] public int Flag { get; set; }
        [ProtoMember(8)] public RichText? MsgContent { get; set; }
    }

    [ProtoContract]
    internal class AppointContent
    {
        [ProtoMember(1)] public int AppointSubject { get; set; }
        [ProtoMember(2)] public int PayType { get; set; }
        [ProtoMember(3)] public int AppointDate { get; set; }
        [ProtoMember(4)] public int AppointGender { get; set; }
        [ProtoMember(5)] public string AppointIntroduce { get; set; }
        [ProtoMember(6)] public AddressInfo? MsgAppointAddress { get; set; }
        [ProtoMember(7)] public TravelInfo? MsgTravelInfo { get; set; }
    }

    [ProtoContract]
    internal class FeedInfo
    {
        [ProtoMember(1)] public long FeedType { get; set; }
        [ProtoMember(2)] public string FeedId { get; set; }
        [ProtoMember(3)] public FeedContent? MsgFeedContent { get; set; }
        [ProtoMember(4)] public NearbyTopic? MsgTopicInfo { get; set; }
        [ProtoMember(5)] public long PublishTime { get; set; }
        [ProtoMember(6)] public int PraiseCount { get; set; }
        [ProtoMember(7)] public int PraiseFlag { get; set; }
        [ProtoMember(8)] public List<StrangerInfo> MsgPraiseUser { get; set; }
        [ProtoMember(9)] public int CommentCount { get; set; }
        [ProtoMember(10)] public List<FeedComment> MsgCommentList { get; set; }
        [ProtoMember(11)] public int CommentRetAll { get; set; }
        [ProtoMember(12)] public int HotFlag { get; set; }
        [ProtoMember(13)] public long SvrReserved { get; set; }
        [ProtoMember(14)] public HotEntry? MsgHotEntry { get; set; }
    }

    [ProtoContract]
    internal class HotTopicList
    {
        [ProtoMember(1)] public List<HotTopic> TopicList { get; set; }
    }

    [ProtoContract]
    internal class FeedContent
    {
        [ProtoMember(1)] public List<string> StrPicUrl { get; set; }
        [ProtoMember(2)] public RichText? MsgText { get; set; }
        [ProtoMember(3)] public string HrefUrl { get; set; }
        [ProtoMember(5)] public string GroupName { get; set; }
        [ProtoMember(6)] public string GroupBulletin { get; set; }
        [ProtoMember(7)] public int FeedType { get; set; }
        [ProtoMember(8)] public string PoiId { get; set; }
        [ProtoMember(9)] public string PoiTitle { get; set; }
        [ProtoMember(20)] public int EffectiveTime { get; set; }
        [ProtoMember(21)] public int ExpiationTime { get; set; }
        [ProtoMember(22)] public LocaleInfo? MsgLocale { get; set; }
        [ProtoMember(23)] public int FeedsIndex { get; set; }
        [ProtoMember(24)] public ADFeed? MsgAd { get; set; }
        [ProtoMember(25)] public byte[] PrivateData { get; set; }
    }

    [ProtoContract]
    internal class TravelInfo
    {
        [ProtoMember(1)] public LocaleInfo? MsgDepartLocale { get; set; }
        [ProtoMember(2)] public LocaleInfo? MsgDestination { get; set; }
        [ProtoMember(3)] public int Vehicle { get; set; }
        [ProtoMember(4)] public int PartnerCount { get; set; }
        [ProtoMember(5)] public string PlacePicUrl { get; set; }
        [ProtoMember(6)] public string PlaceUrl { get; set; }
    }

    [ProtoContract]
    internal class RecentFreshFeed
    {
        [ProtoMember(1)] public List<FreshFeedInfo> FreshFeedInfo { get; set; }
        [ProtoMember(2)] public long Uid { get; set; }
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
    internal class AppointID
    {
        [ProtoMember(1)] public string RequestId { get; set; }
    }

    [ProtoContract]
    internal class LocaleInfo
    {
        [ProtoMember(1)] public string Name { get; set; }
        [ProtoMember(2)] public string Country { get; set; }
        [ProtoMember(3)] public string Province { get; set; }
        [ProtoMember(4)] public string City { get; set; }
        [ProtoMember(5)] public string Region { get; set; }
        [ProtoMember(6)] public string Poi { get; set; }
        [ProtoMember(7)] public GPS? MsgGps { get; set; }
        [ProtoMember(8)] public string Address { get; set; }
    }

    [ProtoContract]
    internal class LBSInfo
    {
        [ProtoMember(1)] public GPS? MsgGps { get; set; }
        [ProtoMember(2)] public List<Wifi> MsgWifis { get; set; }
        [ProtoMember(3)] public List<Cell> MsgCells { get; set; }
    }

    [ProtoContract]
    internal class FeedEvent
    {
        [ProtoMember(1)] public long EventId { get; set; }
        [ProtoMember(2)] public int Time { get; set; }
        [ProtoMember(3)] public int Eventtype { get; set; }
        [ProtoMember(4)] public StrangerInfo? MsgUserInfo { get; set; }
        [ProtoMember(5)] public FeedInfo? MsgFeedInfo { get; set; }
        [ProtoMember(6)] public string EventTips { get; set; }
        [ProtoMember(7)] public FeedComment? MsgComment { get; set; }
        [ProtoMember(8)] public long CancelEventId { get; set; }
    }

    [ProtoContract]
    internal class FeedsCookie
    {
        [ProtoMember(1)] public List<string> StrList { get; set; }
        [ProtoMember(2)] public int Pose { get; set; }
        [ProtoMember(3)] public byte[] Cookie { get; set; }
        [ProtoMember(4)] public List<long> Uint64Topics { get; set; }
    }

    [ProtoContract]
    internal class NearbyTopic
    {
        [ProtoMember(1)] public long TopicId { get; set; }
        [ProtoMember(2)] public string Topic { get; set; }
        [ProtoMember(3)] public string Foreword { get; set; }
        [ProtoMember(4)] public int CreateTime { get; set; }
        [ProtoMember(5)] public int UpdateTime { get; set; }
        [ProtoMember(6)] public int HotFlag { get; set; }
        [ProtoMember(7)] public int ButtonStyle { get; set; }
        [ProtoMember(8)] public string ButtonSrc { get; set; }
        [ProtoMember(9)] public string BackgroundSrc { get; set; }
        [ProtoMember(10)] public string AttendeeInfo { get; set; }
        [ProtoMember(11)] public int Index { get; set; }
        [ProtoMember(12)] public int PublishScope { get; set; }
        [ProtoMember(13)] public int EffectiveTime { get; set; }
        [ProtoMember(14)] public int ExpiationTime { get; set; }
        [ProtoMember(15)] public int PushedUsrCount { get; set; }
        [ProtoMember(16)] public int TimerangeLeft { get; set; }
        [ProtoMember(17)] public int TimerangeRight { get; set; }
        [ProtoMember(18)] public string Area { get; set; }
    }

    [ProtoContract]
    internal class NearbyEvent
    {
        [ProtoMember(1)] public int Eventtype { get; set; }
        [ProtoMember(2)] public RankEvent? MsgRankevent { get; set; }
        [ProtoMember(3)] public long EventUin { get; set; }
        [ProtoMember(4)] public long EventTinyid { get; set; }
    }

    [ProtoContract]
    internal class Feed
    {
        [ProtoMember(1)] public PublisherInfo? MsgUserInfo { get; set; }
        [ProtoMember(2)] public FeedInfo? MsgFeedInfo { get; set; }
        [ProtoMember(3)] public int OwnerFlag { get; set; }
    }

    [ProtoContract]
    internal class ActivityInfo
    {
        [ProtoMember(2)] public string Name { get; set; }
        [ProtoMember(3)] public string Cover { get; set; }
        [ProtoMember(4)] public string Url { get; set; }
        [ProtoMember(5)] public int StartTime { get; set; }
        [ProtoMember(6)] public int EndTime { get; set; }
        [ProtoMember(7)] public string LocName { get; set; }
        [ProtoMember(8)] public long Enroll { get; set; }
        [ProtoMember(9)] public long CreateUin { get; set; }
        [ProtoMember(10)] public int CreateTime { get; set; }
        [ProtoMember(11)] public OrganizerInfo OrganizerInfo { get; set; }
        [ProtoMember(12)] public long? Flag { get; set; }
    }

    [ProtoContract]
    internal class HotEntry
    {
        [ProtoMember(1)] public int OpenFlag { get; set; }
        [ProtoMember(2)] public int RestTime { get; set; }
        [ProtoMember(3)] public string Foreword { get; set; }
        [ProtoMember(4)] public string BackgroundSrc { get; set; }
    }

    [ProtoContract]
    internal class UserFeed
    {
        [ProtoMember(1)] public PublisherInfo? MsgUserInfo { get; set; }
        [ProtoMember(2)] public FeedInfo? MsgFeedInfo { get; set; }
        [ProtoMember(3)] public int OwnerFlag { get; set; }
        [ProtoMember(4)] public ActivityInfo? MsgActivityInfo { get; set; }
    }

    [ProtoContract]
    internal class Elem
    {
        [ProtoMember(1)] public string Content { get; set; }
        [ProtoMember(2)] public Face? MsgFaceInfo { get; set; }
    }

    [ProtoContract]
    internal class HotFreshFeedList
    {
        [ProtoMember(1)] public List<HotUserFeed> MsgFeeds { get; set; }
        [ProtoMember(2)] public int UpdateTime { get; set; }
    }

    [ProtoContract]
    internal class RptInterestTag
    {
        [ProtoMember(1)] public List<InterestTag> InterestTags { get; set; }
    }

    [ProtoContract]
    internal class AddressInfo
    {
        [ProtoMember(1)] public string CompanyZone { get; set; }
        [ProtoMember(2)] public string CompanyName { get; set; }
        [ProtoMember(3)] public string CompanyAddr { get; set; }
        [ProtoMember(4)] public string CompanyPicUrl { get; set; }
        [ProtoMember(5)] public string CompanyUrl { get; set; }
        [ProtoMember(6)] public ShopID? MsgCompanyId { get; set; }
    }

    [ProtoContract]
    internal class PublisherInfo
    {
        [ProtoMember(1)] public long Tinyid { get; set; }
        [ProtoMember(2)] public byte[] Nickname { get; set; }
        [ProtoMember(3)] public int Age { get; set; }
        [ProtoMember(4)] public int Gender { get; set; }
        [ProtoMember(5)] public string Constellation { get; set; }
        [ProtoMember(6)] public int Profession { get; set; }
        [ProtoMember(7)] public string Distance { get; set; }
        [ProtoMember(8)] public int Marriage { get; set; }
        [ProtoMember(9)] public string Vipinfo { get; set; }
        [ProtoMember(10)] public int Recommend { get; set; }
        [ProtoMember(11)] public int Godflag { get; set; }
        [ProtoMember(12)] public int Chatflag { get; set; }
        [ProtoMember(13)] public int ChatupCount { get; set; }
        [ProtoMember(14)] public int Charm { get; set; }
        [ProtoMember(15)] public int CharmLevel { get; set; }
        [ProtoMember(16)] public int PubNumber { get; set; }
        [ProtoMember(17)] public CommonLabel? MsgCommonLabel { get; set; }
        [ProtoMember(18)] public int RecentVistorTime { get; set; }
        [ProtoMember(19)] public byte[] StrangerDeclare { get; set; }
        [ProtoMember(20)] public long FriendUin { get; set; }
        [ProtoMember(21)] public int HistoryFlag { get; set; }
        [ProtoMember(22)] public long Followflag { get; set; }
    }

    [ProtoContract]
    internal class HotUserFeed
    {
        [ProtoMember(1)] public string FeedId { get; set; }
        [ProtoMember(2)] public int PraiseCount { get; set; }
        [ProtoMember(3)] public long PublishUid { get; set; }
        [ProtoMember(4)] public int PublishTime { get; set; }
    }

    [ProtoContract]
    internal class FreshFeedInfo
    {
        [ProtoMember(1)] public long Uin { get; set; }
        [ProtoMember(2)] public int Time { get; set; }
        [ProtoMember(3)] public string FeedId { get; set; }
        [ProtoMember(4)] public long FeedType { get; set; }
    }

    [ProtoContract]
    internal class CommonLabel
    {
        [ProtoMember(1)] public int LableId { get; set; }
        [ProtoMember(2)] public byte[] LableMsgPre { get; set; }
        [ProtoMember(3)] public byte[] LableMsgLast { get; set; }
        [ProtoMember(4)] public List<byte[]> InterstName { get; set; }
        [ProtoMember(5)] public List<int> InterstType { get; set; }
    }

    [ProtoContract]
    internal class Face
    {
        [ProtoMember(1)] public int Index { get; set; }
    }

    [ProtoContract]
    internal class StrangerInfo
    {
        [ProtoMember(1)] public long Tinyid { get; set; }
        [ProtoMember(2)] public byte[] Nickname { get; set; }
        [ProtoMember(3)] public int Age { get; set; }
        [ProtoMember(4)] public int Gender { get; set; }
        [ProtoMember(5)] public int Dating { get; set; }
        [ProtoMember(6)] public int ListIdx { get; set; }
        [ProtoMember(7)] public string Constellation { get; set; }
        [ProtoMember(8)] public int Profession { get; set; }
        [ProtoMember(9)] public int Marriage { get; set; }
        [ProtoMember(10)] public string Vipinfo { get; set; }
        [ProtoMember(11)] public int Recommend { get; set; }
        [ProtoMember(12)] public int Godflag { get; set; }
        [ProtoMember(13)] public int Charm { get; set; }
        [ProtoMember(14)] public int CharmLevel { get; set; }
        [ProtoMember(15)] public long Uin { get; set; }
    }

    [ProtoContract]
    internal class HotTopic
    {
        [ProtoMember(1)] public long Id { get; set; }
        [ProtoMember(2)] public string Title { get; set; }
        [ProtoMember(3)] public long TopicType { get; set; }
        [ProtoMember(4)] public long Total { get; set; }
        [ProtoMember(5)] public long Times { get; set; }
        [ProtoMember(6)] public long HistoryTimes { get; set; }
        [ProtoMember(7)] public string BgUrl { get; set; }
        [ProtoMember(8)] public string Url { get; set; }
        [ProtoMember(9)] public string ExtraInfo { get; set; }
    }

    [ProtoContract]
    internal class DateEvent
    {
        [ProtoMember(1)] public long EventId { get; set; }
        [ProtoMember(2)] public int Time { get; set; }
        [ProtoMember(3)] public int Type { get; set; }
        [ProtoMember(4)] public StrangerInfo? MsgUserInfo { get; set; }
        [ProtoMember(5)] public AppointInfo? MsgDateInfo { get; set; }
        [ProtoMember(6)] public int AttendIdx { get; set; }
        [ProtoMember(7)] public string EventTips { get; set; }
        [ProtoMember(8)] public DateComment? MsgComment { get; set; }
        [ProtoMember(9)] public long CancelEventId { get; set; }
    }

    [ProtoContract]
    internal class AppointInfo
    {
        [ProtoMember(1)] public AppointID? MsgAppointId { get; set; }
        [ProtoMember(2)] public AppointContent? MsgAppointment { get; set; }
        [ProtoMember(3)] public int AppointStatus { get; set; }
        [ProtoMember(4)] public string JoinWording { get; set; }
        [ProtoMember(5)] public string ViewWording { get; set; }
        [ProtoMember(6)] public int UnreadCount { get; set; }
        [ProtoMember(7)] public int Owner { get; set; }
        [ProtoMember(8)] public int Join { get; set; }
        [ProtoMember(9)] public int View { get; set; }
        [ProtoMember(10)] public string CommentWording { get; set; }
        [ProtoMember(11)] public int CommentNum { get; set; }
        [ProtoMember(12)] public int AttendStatus { get; set; }
        [ProtoMember(13)] public AppointInfoEx? MsgAppointmentEx { get; set; }
    }

    [ProtoContract]
    internal class UserInfo
    {
        [ProtoMember(1)] public long Uin { get; set; }
        [ProtoMember(2)] public byte[] Nickname { get; set; }
        [ProtoMember(3)] public int Age { get; set; }
        [ProtoMember(4)] public int Gender { get; set; }
        [ProtoMember(5)] public byte[] Avatar { get; set; }
    }

    [ProtoContract]
    internal class ReplyInfo
    {
        [ProtoMember(1)] public string CommentId { get; set; }
        [ProtoMember(2)] public StrangerInfo? MsgStrangerInfo { get; set; }
    }
}
