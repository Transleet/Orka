using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

[ProtoContract]
internal class ImCommon
{
    [ProtoContract]
    internal class GroupInfo
    {
        [ProtoMember(1)] public long GroupId { get; set; }
        [ProtoMember(2)] public int GroupType { get; set; }
    }

    [ProtoContract]
    internal class Signature
    {
        [ProtoMember(1)] public int KeyType { get; set; }
        [ProtoMember(2)] public int SessionAppId { get; set; }
        [ProtoMember(3)] public byte[] SessionKey { get; set; }
    }

    [ProtoContract]
    internal class Token
    {
        [ProtoMember(1)] public byte[] Buf { get; set; }
        [ProtoMember(2)] public int C2cType { get; set; }
        [ProtoMember(3)] public int ServiceType { get; set; }
    }

    [ProtoContract]
    internal class User
    {
        [ProtoMember(1)] public long Uin { get; set; }
        [ProtoMember(2)] public int AppId { get; set; }
        [ProtoMember(3)] public int InstanceId { get; set; }
        [ProtoMember(4)] public int AppType { get; set; }
        [ProtoMember(5)] public int ClientIp { get; set; }
        [ProtoMember(6)] public int Version { get; set; }
        [ProtoMember(7)] public string PhoneNumber { get; set; }
        [ProtoMember(8)] public int PlatformId { get; set; }
        [ProtoMember(9)] public int Language { get; set; }
        [ProtoMember(10)] public byte[] EquipKey { get; set; }
    }
}

[ProtoContract]
internal class ImImagent
{
    [ProtoContract]
    internal class ImAgentHead
    {
        [ProtoMember(1)] public int Command { get; set; }
        [ProtoMember(2)] public int Seq { get; set; }
        [ProtoMember(3)] public int Result { get; set; }
        [ProtoMember(4)] public string Err { get; set; }
        [ProtoMember(5)] public byte[] EchoBuf { get; set; }
        [ProtoMember(6)] public ImCommon.User? ReqUser { get; set; }
        [ProtoMember(7)] public Requestinfo? ReqInfo { get; set; }
        [ProtoMember(8)] public Signature? Signature { get; set; }
        [ProtoMember(9)] public int SubCmd { get; set; }
        [ProtoMember(10)] public int ServerIp { get; set; }
    }

    [ProtoContract]
    internal class ImAgentPackage
    {
        [ProtoMember(1)] public ImAgentHead? Head { get; set; }
        [ProtoMember(11)] public ImMsg.MsgSendReq? MsgSendReq { get; set; }
        [ProtoMember(12)] public ImMsg.MsgSendResp? MsgSendResp { get; set; }
    }

    [ProtoContract]
    internal class Requestinfo
    {
        [ProtoMember(1)] public int ReqIp { get; set; }
        [ProtoMember(2)] public int ReqPort { get; set; }
        [ProtoMember(3)] public int ReqFlag { get; set; }
    }

    [ProtoContract]
    internal class Signature
    {
        [ProtoMember(1)] public int KeyType { get; set; }
        [ProtoMember(2)] public int SessionAppId { get; set; }
        [ProtoMember(3)] public byte[] SessionKey { get; set; }
    }
}

[ProtoContract]
internal class ImMsg
{
    [ProtoContract]
    internal class C2C
    {
        [ProtoMember(1)] public ImCommon.User? Sender { get; set; }
        [ProtoMember(2)] public ImCommon.User? Receiver { get; set; }
        [ProtoMember(3)] public C2CRelation? C2cRelation { get; set; }
    }

    [ProtoContract]
    internal class C2CRelation
    {
        [ProtoMember(1)] public int C2cType { get; set; }
        [ProtoMember(2)] public ImCommon.GroupInfo? GroupInfo { get; set; }
        [ProtoMember(3)] public ImCommon.Token? Token { get; set; }
    }

    [ProtoContract]
    internal class ContentHead
    {
        [ProtoMember(1)] public int PkgNum { get; set; }
        [ProtoMember(2)] public int PkgIndex { get; set; }
        [ProtoMember(3)] public int Seq { get; set; }
        [ProtoMember(4)] public int DateTime { get; set; }
        [ProtoMember(5)] public int MsgType { get; set; }
        [ProtoMember(6)] public int DivSeq { get; set; }
        [ProtoMember(7)] public long MsgdbUin { get; set; }
        [ProtoMember(8)] public int MsgdbSeq { get; set; }
        [ProtoMember(9)] public int WordMsgSeq { get; set; }
        [ProtoMember(10)] public int MsgRand { get; set; }
    }

    [ProtoContract]
    internal class Group
    {
        [ProtoMember(1)] public ImCommon.User? Sender { get; set; }
        [ProtoMember(2)] public ImCommon.User? Receiver { get; set; }
        [ProtoMember(3)] public ImCommon.GroupInfo? GroupInfo { get; set; }
    }

    [ProtoContract]
    internal class Msg
    {
        [ProtoMember(1)] public MsgHead? Head { get; set; }
        [ProtoMember(2)] public ImMsgBody.MsgBody? Body { get; set; }
    }

    [ProtoContract]
    internal class MsgHead
    {
        [ProtoMember(1)] public RoutingHead? RoutingHead { get; set; }
        [ProtoMember(2)] public ContentHead? ContentHead { get; set; }
        [ProtoMember(3)] public byte[] GbkTmpMsgBody { get; set; }
    }

    [ProtoContract]
    internal class MsgSendReq
    {
        [ProtoMember(1)] public Msg? Msg { get; set; }
        [ProtoMember(2)] public byte[] BuMsg { get; set; }
        [ProtoMember(3)] public int MsgTailId { get; set; }
        [ProtoMember(4)] public int ConnMsgFlag { get; set; }
        [ProtoMember(5)] public byte[] Cookie { get; set; }
    }

    [ProtoContract]
    internal class MsgSendResp
    {

    }

    [ProtoContract]
    internal class RoutingHead
    {
        [ProtoMember(1)] public C2C? C2c { get; set; }
        [ProtoMember(2)] public Group? Group { get; set; }
    }
}

[ProtoContract]
internal class ImMsgBody
{
    [ProtoContract]
    internal class AnonymousGroupMsg
    {
        [ProtoMember(1)] public int Flags { get; set; }
        [ProtoMember(2)] public byte[] AnonId { get; set; }
        [ProtoMember(3)] public byte[] AnonNick { get; set; }
        [ProtoMember(4)] public int HeadPortrait { get; set; }
        [ProtoMember(5)] public int ExpireTime { get; set; }
        [ProtoMember(6)] public int BubbleId { get; set; }
        [ProtoMember(7)] public byte[] RankColor { get; set; }
    }

    [ProtoContract]
    internal class ApolloActMsg
    {
        [ProtoMember(1)] public int ActionId { get; set; }
        [ProtoMember(2)] public byte[] ActionName { get; set; }
        [ProtoMember(3)] public byte[] ActionText { get; set; }
        [ProtoMember(4)] public int Flag { get; set; }
        [ProtoMember(5)] public int PeerUin { get; set; }
        [ProtoMember(6)] public int SenderTs { get; set; }
        [ProtoMember(7)] public int PeerTs { get; set; }
        [ProtoMember(8)] public int Int32SenderStatus { get; set; }
        [ProtoMember(9)] public int Int32PeerStatus { get; set; }
        [ProtoMember(10)] public int DiytextId { get; set; }
        [ProtoMember(11)] public byte[] DiytextContent { get; set; }
        [ProtoMember(12)] public byte[] InputText { get; set; }
        [ProtoMember(13)] public byte[] PbReserve { get; set; }
    }

    [ProtoContract]
    internal class ArkAppElem
    {
        [ProtoMember(1)] public string AppName { get; set; }
        [ProtoMember(2)] public string MinVersion { get; set; }
        [ProtoMember(3)] public string XmlTemplate { get; set; }
        [ProtoMember(4)] public byte[] Data { get; set; }
    }

    [ProtoContract]
    internal class Attr
    {
        [ProtoMember(1)] public int CodePage { get; set; }
        [ProtoMember(2)] public int Time { get; set; }
        [ProtoMember(3)] public int Random { get; set; }
        [ProtoMember(4)] public int Color { get; set; }
        [ProtoMember(5)] public int Size { get; set; }
        [ProtoMember(6)] public int Effect { get; set; }
        [ProtoMember(7)] public int CharSet { get; set; }
        [ProtoMember(8)] public int PitchAndFamily { get; set; }
        [ProtoMember(9)] public string FontName { get; set; }
        [ProtoMember(10)] public byte[] ReserveData { get; set; }
    }

    [ProtoContract]
    internal class BitAppMsg
    {
        [ProtoMember(1)] public byte[] Buf { get; set; }
    }

    [ProtoContract]
    internal class BlessingMessage
    {
        [ProtoMember(1)] public int MsgType { get; set; }
        [ProtoMember(2)] public int ExFlag { get; set; }
    }

    [ProtoContract]
    internal class CommonElem
    {
        [ProtoMember(1)] public int ServiceType { get; set; }
        [ProtoMember(2)] public byte[] PbElem { get; set; }
        [ProtoMember(3)] public int BusinessType { get; set; }
    }

    [ProtoContract]
    internal class ConferenceTipsInfo
    {
        [ProtoMember(1)] public int SessionType { get; set; }
        [ProtoMember(2)] public long SessionUin { get; set; }
        [ProtoMember(3)] public string Text { get; set; }
    }

    [ProtoContract]
    internal class CrmElem
    {
        [ProtoMember(1)] public byte[] CrmBuf { get; set; }
        [ProtoMember(2)] public byte[] MsgResid { get; set; }
        [ProtoMember(3)] public int QidianFlag { get; set; }
        [ProtoMember(4)] public int PushFlag { get; set; }
        [ProtoMember(5)] public int CountFlag { get; set; }
    }

    [ProtoContract]
    internal class CustomElem
    {
        [ProtoMember(1)] public byte[] Desc { get; set; }
        [ProtoMember(2)] public byte[] Data { get; set; }
        [ProtoMember(3)] public int EnumType { get; set; }
        [ProtoMember(4)] public byte[] Ext { get; set; }
        [ProtoMember(5)] public byte[] Sound { get; set; }
    }

    [ProtoContract]
    internal class CustomFace
    {
        [ProtoMember(1)] public byte[] Guid { get; set; }
        [ProtoMember(2)] public string FilePath { get; set; }
        [ProtoMember(3)] public string Shortcut { get; set; }
        [ProtoMember(4)] public byte[] Buffer { get; set; }
        [ProtoMember(5)] public byte[] Flag { get; set; }
        [ProtoMember(6)] public byte[]? OldData { get; set; }
        [ProtoMember(7)] public int FileId { get; set; }
        [ProtoMember(8)] public int ServerIp { get; set; }
        [ProtoMember(9)] public int ServerPort { get; set; }
        [ProtoMember(10)] public int FileType { get; set; }
        [ProtoMember(11)] public byte[] Signature { get; set; }
        [ProtoMember(12)] public int Useful { get; set; }
        [ProtoMember(13)] public byte[] PicMd5 { get; set; }
        [ProtoMember(14)] public string ThumbUrl { get; set; }
        [ProtoMember(15)] public string BigUrl { get; set; }
        [ProtoMember(16)] public string OrigUrl { get; set; }
        [ProtoMember(17)] public int BizType { get; set; }
        [ProtoMember(18)] public int RepeatIndex { get; set; }
        [ProtoMember(19)] public int RepeatImage { get; set; }
        [ProtoMember(20)] public int ImageType { get; set; }
        [ProtoMember(21)] public int Index { get; set; }
        [ProtoMember(22)] public int Width { get; set; }
        [ProtoMember(23)] public int Height { get; set; }
        [ProtoMember(24)] public int Source { get; set; }
        [ProtoMember(25)] public int Size { get; set; }
        [ProtoMember(26)] public int Origin { get; set; }
        [ProtoMember(27)] public int ThumbWidth { get; set; }
        [ProtoMember(28)] public int ThumbHeight { get; set; }
        [ProtoMember(29)] public int ShowLen { get; set; }
        [ProtoMember(30)] public int DownloadLen { get; set; }
        [ProtoMember(31)] public string _400Url { get; set; }
        [ProtoMember(32)] public int _400Width { get; set; }
        [ProtoMember(33)] public int _400Height { get; set; }
        [ProtoMember(34)] public byte[] PbReserve { get; set; }
    }

    [ProtoContract]
    internal class DeliverGiftMsg
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
        [ProtoMember(18)] public byte[] ComefromLink { get; set; }
        [ProtoMember(19)] public byte[] PbReserve { get; set; }
        [ProtoMember(20)] public byte[] ReceiverName { get; set; }
        [ProtoMember(21)] public byte[] ReceiverPic { get; set; }
        [ProtoMember(22)] public byte[] StmessageGifturl { get; set; }
    }

    [ProtoContract]
    internal class EIMInfo
    {
        [ProtoMember(1)] public long RootId { get; set; }
        [ProtoMember(2)] public int Flag { get; set; }
    }

    [ProtoContract]
    internal class Elem
    {
        [ProtoMember(1)] public Text? Text { get; set; }
        [ProtoMember(2)] public Face? Face { get; set; }
        [ProtoMember(3)] public OnlineImage? OnlineImage { get; set; }
        [ProtoMember(4)] public SubMsgType0xc1.NotOnlineImage? NotOnlineImage { get; set; }
        [ProtoMember(5)] public TransElem? TransElemInfo { get; set; }
        [ProtoMember(6)] public MarketFace? MarketFace { get; set; }
        [ProtoMember(7)] public ElemFlags? ElemFlags { get; set; }
        [ProtoMember(8)] public CustomFace? CustomFace { get; set; }
        [ProtoMember(9)] public ElemFlags2? ElemFlags2 { get; set; }
        [ProtoMember(10)] public FunFace? FunFace { get; set; }
        [ProtoMember(11)] public SecretFileMsg? SecretFile { get; set; }
        [ProtoMember(12)] public RichMsg? RichMsg { get; set; }
        [ProtoMember(13)] public GroupFile? GroupFile { get; set; }
        [ProtoMember(14)] public PubGroup? PubGroup { get; set; }
        [ProtoMember(15)] public MarketTrans? MarketTrans { get; set; }
        [ProtoMember(16)] public ExtraInfo? ExtraInfo { get; set; }
        [ProtoMember(17)] public ShakeWindow? ShakeWindow { get; set; }
        [ProtoMember(18)] public PubAccount? PubAccount { get; set; }
        [ProtoMember(19)] public VideoFile? VideoFile { get; set; }
        [ProtoMember(20)] public TipsInfo? TipsInfo { get; set; }
        [ProtoMember(21)] public AnonymousGroupMsg? AnonGroupMsg { get; set; }
        [ProtoMember(22)] public QQLiveOld? QqLiveOld { get; set; }
        [ProtoMember(23)] public LifeOnlineAccount? LifeOnline { get; set; }
        // [ProtoMember(24)] public  QQWalletMsg?  QqwalletMsg { get; set; }
        [ProtoMember(25)] public CrmElem? CrmElem { get; set; }
        [ProtoMember(26)] public ConferenceTipsInfo? ConferenceTipsInfo { get; set; }
        [ProtoMember(27)] public RedBagInfo? RedbagInfo { get; set; }
        [ProtoMember(28)] public LowVersionTips? LowVersionTips { get; set; }
        [ProtoMember(29)] public byte[]? BankcodeCtrlInfo { get; set; }
        [ProtoMember(30)] public NearByMessageType? NearByMsg { get; set; }
        [ProtoMember(31)] public CustomElem? CustomElem { get; set; }
        [ProtoMember(32)] public LocationInfo? LocationInfo { get; set; }
        [ProtoMember(33)] public PubAccInfo? PubAccInfo { get; set; }
        [ProtoMember(34)] public SmallEmoji? SmallEmoji { get; set; }
        [ProtoMember(35)] public FSJMessageElem? FsjMsgElem { get; set; }
        [ProtoMember(36)] public ArkAppElem? ArkApp { get; set; }
        [ProtoMember(37)] public GeneralFlags? GeneralFlags { get; set; }
        [ProtoMember(38)] public CustomFace? HcFlashPic { get; set; }
        [ProtoMember(39)] public DeliverGiftMsg? DeliverGiftMsg { get; set; }
        [ProtoMember(40)] public BitAppMsg? BitappMsg { get; set; }
        [ProtoMember(41)] public OpenQQData? OpenQqData { get; set; }
        [ProtoMember(42)] public ApolloActMsg? ApolloMsg { get; set; }
        [ProtoMember(43)] public GroupPubAccountInfo? GroupPubAccInfo { get; set; }
        [ProtoMember(44)] public BlessingMessage? BlessMsg { get; set; }
        [ProtoMember(45)] public SourceMsg? SrcMsg { get; set; }
        [ProtoMember(46)] public LolaMsg? LolaMsg { get; set; }
        [ProtoMember(47)] public GroupBusinessMsg? GroupBusinessMsg { get; set; }
        [ProtoMember(48)] public WorkflowNotifyMsg? MsgWorkflowNotify { get; set; }
        [ProtoMember(49)] public PatsElem? PatElem { get; set; }
        [ProtoMember(50)] public GroupPostElem? GroupPostElem { get; set; }
        [ProtoMember(51)] public LightAppElem? LightApp { get; set; }
        [ProtoMember(52)] public EIMInfo? EimInfo { get; set; }
        [ProtoMember(53)] public CommonElem? CommonElem { get; set; }
    }


    [ProtoContract]
    internal class ElemFlags
    {
        [ProtoMember(1)] public byte[] Flags1 { get; set; }
        [ProtoMember(2)] public byte[] BusinessData { get; set; }
    }

    [ProtoContract]
    internal class ElemFlags2
    {
        [ProtoMember(1)] public int ColorTextId { get; set; }
        [ProtoMember(2)] public long MsgId { get; set; }
        [ProtoMember(3)] public int WhisperSessionId { get; set; }
        [ProtoMember(4)] public int PttChangeBit { get; set; }
        [ProtoMember(5)] public int VipStatus { get; set; }
        [ProtoMember(6)] public int CompatibleId { get; set; }
        [ProtoMember(7)] public List<Inst> Insts { get; set; }
        [ProtoMember(8)] public int MsgRptCnt { get; set; }
        [ProtoMember(9)] public Inst? SrcInst { get; set; }
        [ProtoMember(10)] public int Longtitude { get; set; }
        [ProtoMember(11)] public int Latitude { get; set; }
        [ProtoMember(12)] public int CustomFont { get; set; }
        [ProtoMember(13)] public PcSupportDef? PcSupportDef { get; set; }
        [ProtoMember(14)] public int CrmFlags { get; set; }
    }
    [ProtoContract]
    internal class Inst
    {
        [ProtoMember(1)] public int AppId { get; set; }
        [ProtoMember(2)] public int InstId { get; set; }
    }


    [ProtoContract]
    internal class ExtraInfo
    {
        [ProtoMember(1)] public string Nick { get; set; }
        [ProtoMember(2)] public byte[] GroupCard { get; set; }
        [ProtoMember(3)] public int Level { get; set; }
        [ProtoMember(4)] public int Flags { get; set; }
        [ProtoMember(5)] public int GroupMask { get; set; }
        [ProtoMember(6)] public int MsgTailId { get; set; }
        [ProtoMember(7)] public byte[] SenderTitle { get; set; }
        [ProtoMember(8)] public byte[] ApnsTips { get; set; }
        [ProtoMember(9)] public long Uin { get; set; }
        [ProtoMember(10)] public int MsgStateFlag { get; set; }
        [ProtoMember(11)] public int ApnsSoundType { get; set; }
        [ProtoMember(12)] public int NewGroupFlag { get; set; }
    }

    [ProtoContract]
    internal class Face
    {
        [ProtoMember(1)] public int Index { get; set; }
        [ProtoMember(2)] public byte[] Old { get; set; }
        [ProtoMember(11)] public byte[] Buf { get; set; }
    }

    [ProtoContract]
    internal class FSJMessageElem
    {
        [ProtoMember(1)] public int MsgType { get; set; }
    }

    [ProtoContract]
    internal class FunFace
    {
        [ProtoMember(1)] public Turntable? MsgTurntable { get; set; }
        [ProtoMember(2)] public Bomb? MsgBomb { get; set; }
    }

    [ProtoContract]
    internal class Bomb
    {
        [ProtoMember(1)] public bool BoolBurst { get; set; }
    }

    [ProtoContract]
    internal class Turntable
    {
        [ProtoMember(1)] public List<long> Uint64UinList { get; set; }
        [ProtoMember(2)] public long HitUin { get; set; }
        [ProtoMember(3)] public string HitUinNick { get; set; }
    }


    [ProtoContract]
    internal class GeneralFlags
    {
        [ProtoMember(1)] public int BubbleDiyTextId { get; set; }
        [ProtoMember(2)] public int GroupFlagNew { get; set; }
        [ProtoMember(3)] public long Uin { get; set; }
        [ProtoMember(4)] public byte[] RpId { get; set; }
        [ProtoMember(5)] public int PrpFold { get; set; }
        [ProtoMember(6)] public int LongTextFlag { get; set; }
        [ProtoMember(7)] public string LongTextResid { get; set; }
        [ProtoMember(8)] public int GroupType { get; set; }
        [ProtoMember(9)] public int ToUinFlag { get; set; }
        [ProtoMember(10)] public int GlamourLevel { get; set; }
        [ProtoMember(11)] public int MemberLevel { get; set; }
        [ProtoMember(12)] public long GroupRankSeq { get; set; }
        [ProtoMember(13)] public int OlympicTorch { get; set; }
        [ProtoMember(14)] public byte[] BabyqGuideMsgCookie { get; set; }
        [ProtoMember(15)] public int Uin32ExpertFlag { get; set; }
        [ProtoMember(16)] public int BubbleSubId { get; set; }
        [ProtoMember(17)] public long PendantId { get; set; }
        [ProtoMember(18)] public byte[] RpIndex { get; set; }
        [ProtoMember(19)] public byte[] PbReserve { get; set; }
    }

    [ProtoContract]
    internal class GroupBusinessMsg
    {
        [ProtoMember(1)] public int Flags { get; set; }
        [ProtoMember(2)] public byte[] HeadUrl { get; set; }
        [ProtoMember(3)] public byte[] HeadClkUrl { get; set; }
        [ProtoMember(4)] public byte[] Nick { get; set; }
        [ProtoMember(5)] public byte[] NickColor { get; set; }
        [ProtoMember(6)] public byte[] Rank { get; set; }
        [ProtoMember(7)] public byte[] RankColor { get; set; }
        [ProtoMember(8)] public byte[] RankBgcolor { get; set; }
    }

    [ProtoContract]
    internal class GroupFile
    {
        [ProtoMember(1)] public byte[] Filename { get; set; }
        [ProtoMember(2)] public long FileSize { get; set; }
        [ProtoMember(3)] public byte[] FileId { get; set; }
        [ProtoMember(4)] public byte[] BatchId { get; set; }
        [ProtoMember(5)] public byte[] FileKey { get; set; }
        [ProtoMember(6)] public byte[] Mark { get; set; }
        [ProtoMember(7)] public long Sequence { get; set; }
        [ProtoMember(8)] public byte[] BatchItemId { get; set; }
        [ProtoMember(9)] public int FeedMsgTime { get; set; }
        [ProtoMember(10)] public byte[] PbReserve { get; set; }
    }

    [ProtoContract]
    internal class GroupPostElem
    {
        [ProtoMember(1)] public int TransType { get; set; }
        [ProtoMember(2)] public byte[] TransMsg { get; set; }
    }

    [ProtoContract]
    internal class GroupPubAccountInfo
    {
        [ProtoMember(1)] public long PubAccount { get; set; }
    }

    [ProtoContract]
    internal class LifeOnlineAccount
    {
        [ProtoMember(1)] public long UniqueId { get; set; }
        [ProtoMember(2)] public int Op { get; set; }
        [ProtoMember(3)] public int ShowTime { get; set; }
        [ProtoMember(4)] public int Report { get; set; }
        [ProtoMember(5)] public int Ack { get; set; }
        [ProtoMember(6)] public long Bitmap { get; set; }
        [ProtoMember(7)] public byte[] GdtImpData { get; set; }
        [ProtoMember(8)] public byte[] GdtCliData { get; set; }
        [ProtoMember(9)] public byte[] ViewId { get; set; }
    }

    [ProtoContract]
    internal class LightAppElem
    {
        [ProtoMember(1)] public byte[] Data { get; set; }
        [ProtoMember(2)] public byte[] MsgResid { get; set; }
    }


    [ProtoContract]
    internal class LocationInfo
    {
        [ProtoMember(1)] public double Longitude { get; set; }
        [ProtoMember(2)] public double Latitude { get; set; }
        [ProtoMember(3)] public byte[] Desc { get; set; }
    }

    [ProtoContract]
    internal class LolaMsg
    {
        [ProtoMember(1)] public byte[] MsgResid { get; set; }
        [ProtoMember(2)] public byte[] EncodeContent { get; set; }
        [ProtoMember(3)] public byte[] LongMsgUrl { get; set; }
        [ProtoMember(4)] public byte[] DownloadKey { get; set; }
    }

    [ProtoContract]
    internal class LowVersionTips
    {
        [ProtoMember(1)] public int BusinessId { get; set; }
        [ProtoMember(2)] public int SessionType { get; set; }
        [ProtoMember(3)] public long SessionUin { get; set; }
        [ProtoMember(4)] public long SenderUin { get; set; }
        [ProtoMember(5)] public string Text { get; set; }
    }

    [ProtoContract]
    internal class MarketFace
    {
        [ProtoMember(1)] public byte[] FaceName { get; set; }
        [ProtoMember(2)] public int ItemType { get; set; }
        [ProtoMember(3)] public int FaceInfo { get; set; }
        [ProtoMember(4)] public byte[] FaceId { get; set; }
        [ProtoMember(5)] public int TabId { get; set; }
        [ProtoMember(6)] public int SubType { get; set; }
        [ProtoMember(7)] public byte[] Key { get; set; }
        [ProtoMember(8)] public byte[] Param { get; set; }
        [ProtoMember(9)] public int MediaType { get; set; }
        [ProtoMember(10)] public int ImageWidth { get; set; }
        [ProtoMember(11)] public int ImageHeight { get; set; }
        [ProtoMember(12)] public byte[] MobileParam { get; set; }
        [ProtoMember(13)] public byte[] PbReserve { get; set; }
    }

    [ProtoContract]
    internal class MarketTrans
    {
        [ProtoMember(1)] public int Int32Flag { get; set; }
        [ProtoMember(2)] public byte[] Xml { get; set; }
        [ProtoMember(3)] public byte[] MsgResid { get; set; }
        [ProtoMember(4)] public int Ability { get; set; }
        [ProtoMember(5)] public int MinAbility { get; set; }
    }

    [ProtoContract]
    internal class MsgBody
    {
        [ProtoMember(1)] public RichText RichText { get; set; }
        [ProtoMember(2)] public byte[] MsgContent { get; set; }
        [ProtoMember(3)] public byte[] MsgEncryptContent { get; set; }
    }

    [ProtoContract]
    internal class MsgBodySubtype4
    {
        [ProtoMember(1)] public NotOnlineFile? MsgNotOnlineFile { get; set; }
        [ProtoMember(2)] public int MsgTime { get; set; }
    }

    [ProtoContract]
    internal class NearByMessageType
    {
        [ProtoMember(1)] public int Type { get; set; }
        [ProtoMember(2)] public int IdentifyType { get; set; }
    }

    [ProtoContract]
    internal class NotOnlineFile
    {
        [ProtoMember(1)] public int FileType { get; set; }
        [ProtoMember(2)] public byte[] Sig { get; set; }
        [ProtoMember(3)] public byte[] FileUuid { get; set; }
        [ProtoMember(4)] public byte[] FileMd5 { get; set; }
        [ProtoMember(5)] public byte[] FileName { get; set; }
        [ProtoMember(6)] public long FileSize { get; set; }
        [ProtoMember(7)] public byte[] Note { get; set; }
        [ProtoMember(8)] public int Reserved { get; set; }
        [ProtoMember(9)] public int Subcmd { get; set; }
        [ProtoMember(10)] public int MicroCloud { get; set; }
        [ProtoMember(11)] public List<byte[]> BytesFileUrls { get; set; }
        [ProtoMember(12)] public int DownloadFlag { get; set; }
        [ProtoMember(50)] public int DangerEvel { get; set; }
        [ProtoMember(51)] public int LifeTime { get; set; }
        [ProtoMember(52)] public int UploadTime { get; set; }
        [ProtoMember(53)] public int AbsFileType { get; set; }
        [ProtoMember(54)] public int ClientType { get; set; }
        [ProtoMember(55)] public int ExpireTime { get; set; }
        [ProtoMember(56)] public byte[] PbReserve { get; set; }
    }

    [ProtoContract]
    internal class NotOnlineImage
    {
        [ProtoMember(1)] public string FilePath { get; set; }
        [ProtoMember(2)] public long FileLen { get; set; }
        [ProtoMember(3)] public string DownloadPath { get; set; }
        [ProtoMember(4)] public byte[]? OldVerSendFile { get; set; }
        [ProtoMember(5)] public int ImgType { get; set; }
        [ProtoMember(6)] public byte[] PreviewsImage { get; set; }
        [ProtoMember(7)] public byte[] PicMd5 { get; set; }
        [ProtoMember(8)] public int PicHeight { get; set; }
        [ProtoMember(9)] public int PicWidth { get; set; }
        [ProtoMember(10)] public string ResId { get; set; }
        [ProtoMember(11)] public byte[] Flag { get; set; }
        [ProtoMember(12)] public string ThumbUrl { get; set; }
        [ProtoMember(13)] public int Original { get; set; }
        [ProtoMember(14)] public string BigUrl { get; set; }
        [ProtoMember(15)] public string OrigUrl { get; set; }
        [ProtoMember(16)] public int BizType { get; set; }
        [ProtoMember(17)] public int Result { get; set; }
        [ProtoMember(18)] public int Index { get; set; }
        [ProtoMember(19)] public byte[] OpFaceBuf { get; set; }
        [ProtoMember(20)] public bool OldPicMd5 { get; set; }
        [ProtoMember(21)] public int ThumbWidth { get; set; }
        [ProtoMember(22)] public int ThumbHeight { get; set; }
        [ProtoMember(23)] public int FileId { get; set; }
        [ProtoMember(24)] public int ShowLen { get; set; }
        [ProtoMember(25)] public int DownloadLen { get; set; }
        [ProtoMember(26)] public string _400Url { get; set; }
        [ProtoMember(27)] public int _400Width { get; set; }
        [ProtoMember(28)] public int _400Height { get; set; }
        [ProtoMember(29)] public byte[] PbReserve { get; set; }
    }


    [ProtoContract]
    internal class OnlineImage
    {
        [ProtoMember(1)] public byte[] Guid { get; set; }
        [ProtoMember(2)] public byte[] FilePath { get; set; }
        [ProtoMember(3)] public byte[] OldVerSendFile { get; set; }
    }

    [ProtoContract]
    internal class OpenQQData
    {
        [ProtoMember(1)] public byte[] CarQqData { get; set; }
    }

    [ProtoContract]
    internal class PatsElem
    {
        [ProtoMember(1)] public int PatType { get; set; }
        [ProtoMember(2)] public int PatCount { get; set; }
    }

    [ProtoContract]
    internal class PcSupportDef
    {
        [ProtoMember(1)] public int PcPtlBegin { get; set; }
        [ProtoMember(2)] public int PcPtlEnd { get; set; }
        [ProtoMember(3)] public int MacPtlBegin { get; set; }
        [ProtoMember(4)] public int MacPtlEnd { get; set; }
        [ProtoMember(5)] public List<int> PtlsSupport { get; set; }
        [ProtoMember(6)] public List<int> PtlsNotSupport { get; set; }
    }

    [ProtoContract]
    internal class Ptt
    {
        [ProtoMember(1)] public int FileType { get; set; }
        [ProtoMember(2)] public long SrcUin { get; set; }
        [ProtoMember(3)] public byte[] FileUuid { get; set; }
        [ProtoMember(4)] public byte[] FileMd5 { get; set; }
        [ProtoMember(5)] public byte[] FileName { get; set; }
        [ProtoMember(6)] public int FileSize { get; set; }
        [ProtoMember(7)] public byte[] Reserve { get; set; }
        [ProtoMember(8)] public int FileId { get; set; }
        [ProtoMember(9)] public int ServerIp { get; set; }
        [ProtoMember(10)] public int ServerPort { get; set; }
        [ProtoMember(11)] public bool BoolValid { get; set; }
        [ProtoMember(12)] public byte[] Signature { get; set; }
        [ProtoMember(13)] public byte[] Shortcut { get; set; }
        [ProtoMember(14)] public byte[] FileKey { get; set; }
        [ProtoMember(15)] public int MagicPttIndex { get; set; }
        [ProtoMember(16)] public int VoiceSwitch { get; set; }
        [ProtoMember(17)] public byte[] PttUrl { get; set; }
        [ProtoMember(18)] public byte[] GroupFileKey { get; set; }
        [ProtoMember(19)] public int Time { get; set; }
        [ProtoMember(20)] public byte[] DownPara { get; set; }
        [ProtoMember(29)] public int Format { get; set; }
        [ProtoMember(30)] public byte[] PbReserve { get; set; }
        [ProtoMember(31)] public List<byte[]> BytesPttUrls { get; set; }
        [ProtoMember(32)] public int DownloadFlag { get; set; }
    }

    [ProtoContract]
    internal class PubAccInfo
    {
        [ProtoMember(1)] public int IsInterNum { get; set; }
        [ProtoMember(2)] public string IngMsgTemplateId { get; set; }
        [ProtoMember(3)] public string IngLongMsgUrl { get; set; }
        [ProtoMember(4)] public byte[] DownloadKey { get; set; }
    }

    [ProtoContract]
    internal class PubAccount
    {
        [ProtoMember(1)] public byte[] Buf { get; set; }
        [ProtoMember(2)] public long PubAccountUin { get; set; }
    }

    [ProtoContract]
    internal class PubGroup
    {
        [ProtoMember(1)] public byte[] Nickname { get; set; }
        [ProtoMember(2)] public int Gender { get; set; }
        [ProtoMember(3)] public int Age { get; set; }
        [ProtoMember(4)] public int Distance { get; set; }
    }

    [ProtoContract]
    internal class QQLiveOld
    {
        [ProtoMember(1)] public int SubCmd { get; set; }
        [ProtoMember(2)] public byte[] ShowText { get; set; }
        [ProtoMember(3)] public byte[] Param { get; set; }
        [ProtoMember(4)] public byte[] Introduce { get; set; }
    }

    [ProtoContract]
    internal class QQWalletAioBody
    {
        [ProtoMember(1)] public long Senduin { get; set; }
        [ProtoMember(2)] public QQWalletAioElem? Sender { get; set; }
        [ProtoMember(3)] public QQWalletAioElem? Receiver { get; set; }
        [ProtoMember(4)] public int Sint32Channelid { get; set; }
        [ProtoMember(5)] public int Sint32Templateid { get; set; }
        [ProtoMember(6)] public int Resend { get; set; }
        [ProtoMember(7)] public int MsgPriority { get; set; }
        [ProtoMember(8)] public int Sint32Redtype { get; set; }
        [ProtoMember(9)] public byte[] Billno { get; set; }
        [ProtoMember(10)] public byte[] Authkey { get; set; }
        [ProtoMember(11)] public int Sint32Sessiontype { get; set; }
        [ProtoMember(12)] public int Sint32Msgtype { get; set; }
        [ProtoMember(13)] public int Sint32Envelopeid { get; set; }
        [ProtoMember(14)] public byte[] Name { get; set; }
        [ProtoMember(15)] public int Sint32Conftype { get; set; }
        [ProtoMember(16)] public int Sint32MsgFrom { get; set; }
        [ProtoMember(17)] public byte[] PcBody { get; set; }
        [ProtoMember(18)] public byte[] IngIndex { get; set; }
        [ProtoMember(19)] public int Redchannel { get; set; }
        [ProtoMember(20)] public List<long> GrapUin { get; set; }
        [ProtoMember(21)] public byte[] PbReserve { get; set; }
    }

    [ProtoContract]
    internal class QQWalletAioElem
    {
        [ProtoMember(1)] public int Background { get; set; }
        [ProtoMember(2)] public int Icon { get; set; }
        [ProtoMember(3)] public byte[] Title { get; set; }
        [ProtoMember(4)] public byte[] Subtitle { get; set; }
        [ProtoMember(5)] public byte[] Content { get; set; }
        [ProtoMember(6)] public byte[] Linkurl { get; set; }
        [ProtoMember(7)] public byte[] Blackstripe { get; set; }
        [ProtoMember(8)] public byte[] Notice { get; set; }
        [ProtoMember(9)] public int TitleColor { get; set; }
        [ProtoMember(10)] public int SubtitleColor { get; set; }
        [ProtoMember(11)] public byte[] ActionsPriority { get; set; }
        [ProtoMember(12)] public byte[] JumpUrl { get; set; }
        [ProtoMember(13)] public byte[] NativeIos { get; set; }
        [ProtoMember(14)] public byte[] NativeAndroid { get; set; }
        [ProtoMember(15)] public byte[] Iconurl { get; set; }
        [ProtoMember(16)] public int ContentColor { get; set; }
        [ProtoMember(17)] public int ContentBgcolor { get; set; }
        [ProtoMember(18)] public byte[] AioImageLeft { get; set; }
        [ProtoMember(19)] public byte[] AioImageRight { get; set; }
        [ProtoMember(20)] public byte[] CftImage { get; set; }
        [ProtoMember(21)] public byte[] PbReserve { get; set; }
    }

    [ProtoContract]
    internal class QQWalletMsg
    {
        [ProtoMember(1)] public QQWalletAioBody? AioBody { get; set; }
    }

    [ProtoContract]
    internal class RedBagInfo
    {
        [ProtoMember(1)] public int RedbagType { get; set; }
    }

    [ProtoContract]
    internal class RichMsg
    {
        [ProtoMember(1)] public byte[] Template1 { get; set; }
        [ProtoMember(2)] public int ServiceId { get; set; }
        [ProtoMember(3)] public byte[] MsgResid { get; set; }
        [ProtoMember(4)] public int Rand { get; set; }
        [ProtoMember(5)] public int Seq { get; set; }
        [ProtoMember(6)] public int Flags { get; set; }
    }

    [ProtoContract]
    internal class RichText
    {
        [ProtoMember(1)] public ImMsgBody.Attr? Attr { get; set; }
        [ProtoMember(2)] public List<AppointDefine.Elem> Elems { get; set; }
        [ProtoMember(3)] public NotOnlineFile? NotOnlineFile { get; set; }
        [ProtoMember(4)] public Ptt? Ptt { get; set; }
        [ProtoMember(5)] public TmpPtt? TmpPtt { get; set; }
        [ProtoMember(6)] public Trans211TmpMsg? Trans211TmpMsg { get; set; }
    }

    [ProtoContract]
    internal class SecretFileMsg
    {
        [ProtoMember(1)] public byte[] FileKey { get; set; }
        [ProtoMember(2)] public long FromUin { get; set; }
        [ProtoMember(3)] public long ToUin { get; set; }
        [ProtoMember(4)] public int Status { get; set; }
        [ProtoMember(5)] public int Ttl { get; set; }
        [ProtoMember(6)] public int Type { get; set; }
        [ProtoMember(7)] public int EncryptPreheadLength { get; set; }
        [ProtoMember(8)] public int EncryptType { get; set; }
        [ProtoMember(9)] public byte[] EncryptKey { get; set; }
        [ProtoMember(10)] public int ReadTimes { get; set; }
        [ProtoMember(11)] public int LeftTime { get; set; }
        [ProtoMember(12)] public SubMsgType0xc1.NotOnlineImage? NotOnlineImage { get; set; }
        [ProtoMember(13)] public ElemFlags2? ElemFlags2 { get; set; }
        [ProtoMember(14)] public int Opertype { get; set; }
        [ProtoMember(15)] public string Fromphonenum { get; set; }
    }

    [ProtoContract]
    internal class ShakeWindow
    {
        [ProtoMember(1)] public int Type { get; set; }
        [ProtoMember(2)] public int Reserve { get; set; }
        [ProtoMember(3)] public long Uin { get; set; }
    }

    [ProtoContract]
    internal class SmallEmoji
    {
        [ProtoMember(1)] public int PackIdSum { get; set; }
        [ProtoMember(2)] public int ImageType { get; set; }
    }

    [ProtoContract]
    internal class SourceMsg
    {
        [ProtoMember(1)] public List<int> OrigSeqs { get; set; }
        [ProtoMember(2)] public long SenderUin { get; set; }
        [ProtoMember(3)] public int Time { get; set; }
        [ProtoMember(4)] public int Flag { get; set; }
        [ProtoMember(5)] public List<AppointDefine.Elem> Elems { get; set; }
        [ProtoMember(6)] public int Type { get; set; }
        [ProtoMember(7)] public byte[] RichMsg { get; set; }
        [ProtoMember(8)] public byte[] PbReserve { get; set; }

        [ProtoMember(9)] public byte[]? SrcMsg { get; set; }
        [ProtoMember(10)] public long ToUin { get; set; }
        [ProtoMember(11)] public byte[] TroopName { get; set; }
    }

    [ProtoContract]
    internal class Text
    {
        [ProtoMember(1)] public string Str { get; set; }
        [ProtoMember(2)] public string Link { get; set; }
        [ProtoMember(3)] public byte[] Attr6Buf { get; set; }
        [ProtoMember(4)] public byte[] Attr7Buf { get; set; }
        [ProtoMember(11)] public byte[] Buf { get; set; }
        [ProtoMember(12)] public byte[] PbReserve { get; set; }
    }

    [ProtoContract]
    internal class TipsInfo
    {
        [ProtoMember(1)] public string Text { get; set; }
    }

    [ProtoContract]
    internal class TmpPtt
    {
        [ProtoMember(1)] public int FileType { get; set; }
        [ProtoMember(2)] public byte[] FileUuid { get; set; }
        [ProtoMember(3)] public byte[] FileMd5 { get; set; }
        [ProtoMember(4)] public byte[] FileName { get; set; }
        [ProtoMember(5)] public int FileSize { get; set; }
        [ProtoMember(6)] public int PttTimes { get; set; }
        [ProtoMember(7)] public int UserType { get; set; }
        [ProtoMember(8)] public int PtttransFlag { get; set; }
        [ProtoMember(9)] public int BusiType { get; set; }
        [ProtoMember(10)] public long MsgId { get; set; }
        [ProtoMember(30)] public byte[] PbReserve { get; set; }
        [ProtoMember(31)] public byte[] PttEncodeData { get; set; }
    }

    [ProtoContract]
    internal class Trans211TmpMsg
    {
        [ProtoMember(1)] public byte[] MsgBody { get; set; }
        [ProtoMember(2)] public int C2cCmd { get; set; }
    }

    [ProtoContract]
    internal class TransElem
    {
        [ProtoMember(1)] public int ElemType { get; set; }
        [ProtoMember(2)] public byte[] ElemValue { get; set; }
    }

    [ProtoContract]
    internal class VideoFile
    {
        [ProtoMember(1)] public byte[] FileUuid { get; set; }
        [ProtoMember(2)] public byte[] FileMd5 { get; set; }
        [ProtoMember(3)] public byte[] FileName { get; set; }
        [ProtoMember(4)] public int FileFormat { get; set; }
        [ProtoMember(5)] public int FileTime { get; set; }
        [ProtoMember(6)] public int FileSize { get; set; }
        [ProtoMember(7)] public int ThumbWidth { get; set; }
        [ProtoMember(8)] public int ThumbHeight { get; set; }
        [ProtoMember(9)] public byte[] ThumbFileMd5 { get; set; }
        [ProtoMember(10)] public byte[] Source { get; set; }
        [ProtoMember(11)] public int ThumbFileSize { get; set; }
        [ProtoMember(12)] public int BusiType { get; set; }
        [ProtoMember(13)] public int FromChatType { get; set; }
        [ProtoMember(14)] public int ToChatType { get; set; }
        [ProtoMember(15)] public bool BoolSupportProgressive { get; set; }
        [ProtoMember(16)] public int FileWidth { get; set; }
        [ProtoMember(17)] public int FileHeight { get; set; }
        [ProtoMember(18)] public int SubBusiType { get; set; }
        [ProtoMember(19)] public int VideoAttr { get; set; }
        [ProtoMember(20)] public List<byte[]> BytesThumbFileUrls { get; set; }
        [ProtoMember(21)] public List<byte[]> BytesVideoFileUrls { get; set; }
        [ProtoMember(22)] public int ThumbDownloadFlag { get; set; }
        [ProtoMember(23)] public int VideoDownloadFlag { get; set; }
        [ProtoMember(24)] public byte[] PbReserve { get; set; }
    }

    [ProtoContract]
    internal class WorkflowNotifyMsg
    {
        [ProtoMember(1)] public byte[] ExtMsg { get; set; }
        [ProtoMember(2)] public long CreateUin { get; set; }
    }
}

[ProtoContract]
internal class ImMsgHead
{
    [ProtoContract]
    internal class C2CHead
    {
        [ProtoMember(1)] public long ToUin { get; set; }
        [ProtoMember(2)] public long FromUin { get; set; }
        [ProtoMember(3)] public int CcType { get; set; }
        [ProtoMember(4)] public int CcCmd { get; set; }
        [ProtoMember(5)] public byte[] AuthPicSig { get; set; }
        [ProtoMember(6)] public byte[] AuthSig { get; set; }
        [ProtoMember(7)] public byte[] AuthBuf { get; set; }
        [ProtoMember(8)] public int ServerTime { get; set; }
        [ProtoMember(9)] public int ClientTime { get; set; }
        [ProtoMember(10)] public int Rand { get; set; }
        [ProtoMember(11)] public string IngPhoneNumber { get; set; }
    }

    [ProtoContract]
    internal class CSHead
    {
        [ProtoMember(1)] public long Uin { get; set; }
        [ProtoMember(2)] public int Command { get; set; }
        [ProtoMember(3)] public int Seq { get; set; }
        [ProtoMember(4)] public int Version { get; set; }
        [ProtoMember(5)] public int RetryTimes { get; set; }
        [ProtoMember(6)] public int ClientType { get; set; }
        [ProtoMember(7)] public int Pubno { get; set; }
        [ProtoMember(8)] public int Localid { get; set; }
        [ProtoMember(9)] public int Timezone { get; set; }
        [ProtoMember(10)] public int ClientIp { get; set; }
        [ProtoMember(11)] public int ClientPort { get; set; }
        [ProtoMember(12)] public int ConnIp { get; set; }
        [ProtoMember(13)] public int ConnPort { get; set; }
        [ProtoMember(14)] public int InterfaceIp { get; set; }
        [ProtoMember(15)] public int InterfacePort { get; set; }
        [ProtoMember(16)] public int ActualIp { get; set; }
        [ProtoMember(17)] public int Flag { get; set; }
        [ProtoMember(18)] public int Timestamp { get; set; }
        [ProtoMember(19)] public int Subcmd { get; set; }
        [ProtoMember(20)] public int Result { get; set; }
        [ProtoMember(21)] public int AppId { get; set; }
        [ProtoMember(22)] public int InstanceId { get; set; }
        [ProtoMember(23)] public long SessionId { get; set; }
        [ProtoMember(24)] public int IdcId { get; set; }
    }

    [ProtoContract]
    internal class DeltaHead
    {
        [ProtoMember(1)] public long TotalLen { get; set; }
        [ProtoMember(2)] public long Offset { get; set; }
        [ProtoMember(3)] public long AckOffset { get; set; }
        [ProtoMember(4)] public byte[] Cookie { get; set; }
        [ProtoMember(5)] public byte[] AckCookie { get; set; }
        [ProtoMember(6)] public int Result { get; set; }
        [ProtoMember(7)] public int Flags { get; set; }
    }

    [ProtoContract]
    internal class Head
    {
        [ProtoMember(1)] public int HeadType { get; set; }
        [ProtoMember(2)] public CSHead? MsgCsHead { get; set; }
        [ProtoMember(3)] public S2CHead? MsgS2cHead { get; set; }
        [ProtoMember(4)] public HttpConnHead? MsgHttpconnHead { get; set; }
        [ProtoMember(5)] public int PaintFlag { get; set; }
        [ProtoMember(6)] public LoginSig? MsgLoginSig { get; set; }
        [ProtoMember(7)] public DeltaHead? MsgDeltaHead { get; set; }
        [ProtoMember(8)] public C2CHead? MsgC2cHead { get; set; }
        [ProtoMember(9)] public SConnHead? MsgSconnHead { get; set; }
        [ProtoMember(10)] public InstCtrl? MsgInstCtrl { get; set; }
    }

    [ProtoContract]
    internal class HttpConnHead
    {
        [ProtoMember(1)] public long Uin { get; set; }
        [ProtoMember(2)] public int Command { get; set; }
        [ProtoMember(3)] public int SubCommand { get; set; }
        [ProtoMember(4)] public int Seq { get; set; }
        [ProtoMember(5)] public int Version { get; set; }
        [ProtoMember(6)] public int RetryTimes { get; set; }
        [ProtoMember(7)] public int ClientType { get; set; }
        [ProtoMember(8)] public int PubNo { get; set; }
        [ProtoMember(9)] public int LocalId { get; set; }
        [ProtoMember(10)] public int TimeZone { get; set; }
        [ProtoMember(11)] public int ClientIp { get; set; }
        [ProtoMember(12)] public int ClientPort { get; set; }
        [ProtoMember(13)] public int QzhttpIp { get; set; }
        [ProtoMember(14)] public int QzhttpPort { get; set; }
        [ProtoMember(15)] public int SppIp { get; set; }
        [ProtoMember(16)] public int SppPort { get; set; }
        [ProtoMember(17)] public int Flag { get; set; }
        [ProtoMember(18)] public byte[] Key { get; set; }
        [ProtoMember(19)] public int CompressType { get; set; }
        [ProtoMember(20)] public int OriginSize { get; set; }
        [ProtoMember(21)] public int ErrorCode { get; set; }
        [ProtoMember(22)] public RedirectMsg? MsgRedirect { get; set; }
        [ProtoMember(23)] public int CommandId { get; set; }
        [ProtoMember(24)] public int ServiceCmdid { get; set; }
        [ProtoMember(25)] public TransOidbHead? MsgOidbhead { get; set; }
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
        [ProtoMember(10)] public int EnumDeviceType { get; set; }
    }

    [ProtoContract]
    internal class LoginSig
    {
        [ProtoMember(1)] public int Type { get; set; }
        [ProtoMember(2)] public byte[] Sig { get; set; }
    }

    [ProtoContract]
    internal class RedirectMsg
    {
        [ProtoMember(1)] public int LastRedirectIp { get; set; }
        [ProtoMember(2)] public int LastRedirectPort { get; set; }
        [ProtoMember(3)] public int RedirectIp { get; set; }
        [ProtoMember(4)] public int RedirectPort { get; set; }
        [ProtoMember(5)] public int RedirectCount { get; set; }
    }

    [ProtoContract]
    internal class S2CHead
    {
        [ProtoMember(1)] public int SubMsgtype { get; set; }
        [ProtoMember(2)] public int MsgType { get; set; }
        [ProtoMember(3)] public long FromUin { get; set; }
        [ProtoMember(4)] public int MsgId { get; set; }
        [ProtoMember(5)] public int RelayIp { get; set; }
        [ProtoMember(6)] public int RelayPort { get; set; }
        [ProtoMember(7)] public long ToUin { get; set; }
    }

    [ProtoContract]
    internal class SConnHead
    {

    }

    [ProtoContract]
    internal class TransOidbHead
    {
        [ProtoMember(1)] public int Command { get; set; }
        [ProtoMember(2)] public int ServiceType { get; set; }
        [ProtoMember(3)] public int Result { get; set; }
        [ProtoMember(4)] public string ErrorMsg { get; set; }
    }
}

[ProtoContract]
internal class ImReceipt
{
    [ProtoContract]
    internal class MsgInfo
    {
        [ProtoMember(1)] public long FromUin { get; set; }
        [ProtoMember(2)] public long ToUin { get; set; }
        [ProtoMember(3)] public int MsgSeq { get; set; }
        [ProtoMember(4)] public int MsgRandom { get; set; }
    }

    [ProtoContract]
    internal class ReceiptInfo
    {
        [ProtoMember(1)] public long ReadTime { get; set; }
    }

    [ProtoContract]
    internal class ReceiptReq
    {
        [ProtoMember(1)] public int Command { get; set; }
        [ProtoMember(2)] public MsgInfo? MsgInfo { get; set; }
    }

    [ProtoContract]
    internal class ReceiptResp
    {
        [ProtoMember(1)] public int Command { get; set; }
        [ProtoMember(2)] public ReceiptInfo? ReceiptInfo { get; set; }
    }
}

[ProtoContract]
internal class ObjMsg
{
    [ProtoContract]
    internal class MsgContentInfo
    {
        [ProtoMember(1)] public byte[] ContentInfoId { get; set; }
        [ProtoMember(2)] public MsgFile? MsgFile { get; set; }

    }
    [ProtoContract]
    internal class MsgFile
    {
        [ProtoMember(1)] public int BusId { get; set; }
        [ProtoMember(2)] public string FilePath { get; set; }
        [ProtoMember(3)] public long FileSize { get; set; }
        [ProtoMember(4)] public string FileName { get; set; }
        [ProtoMember(5)] public long Int64DeadTime { get; set; }
        [ProtoMember(6)] public byte[] FileSha1 { get; set; }
        [ProtoMember(7)] public string Ext { get; set; }
    }

    [ProtoContract]
    internal class MsgPic
    {
        [ProtoMember(1)] public byte[] SmallPicUrl { get; set; }
        [ProtoMember(2)] public byte[] OriginalPicUrl { get; set; }
        [ProtoMember(3)] public int LocalPicId { get; set; }
    }

    [ProtoContract]
    internal class ObjMsg1
    {
        [ProtoMember(1)] public int MsgType { get; set; }
        [ProtoMember(2)] public byte[] Title { get; set; }
        [ProtoMember(3)] public List<byte[]> BytesAbstact { get; set; }
        [ProtoMember(5)] public byte[] TitleExt { get; set; }
        [ProtoMember(6)] public List<MsgPic> MsgPic { get; set; }
        [ProtoMember(7)] public List<MsgContentInfo> MsgContentInfo { get; set; }
        [ProtoMember(8)] public int ReportIdShow { get; set; }
    }
}
