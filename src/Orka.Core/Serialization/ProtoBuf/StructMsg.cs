using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

internal class QPayReminderMsg
{
    [ProtoContract]
    internal class GetInfoReq
    {
        [ProtoMember(1)] public string Scene { get; set; }
        [ProtoMember(2)] public string SubCmd { get; set; }
        [ProtoMember(3)] public string InfoDate { get; set; }
    }

    [ProtoContract]
    internal class GetInfoRsp
    {
        [ProtoMember(1)] public int ResultCode { get; set; }
        [ProtoMember(2)] public string ResultInfo { get; set; }
        [ProtoMember(3)] public int Urgency { get; set; }
        [ProtoMember(4)] public int TemplateNo { get; set; }
        [ProtoMember(5)] public string Content { get; set; }
        [ProtoMember(6)] public string InfoDate { get; set; }
    }
}

internal class Structmsg
{
    [ProtoContract]
    internal class AddFrdSNInfo
    {
        [ProtoMember(1)] public int NotSeeDynamic { get; set; }
        [ProtoMember(2)] public int SetSn { get; set; }
    }

    [ProtoContract]
    internal class FlagInfo
    {
        [ProtoMember(1)] public int GrpMsgKickAdmin { get; set; }
        [ProtoMember(2)] public int GrpMsgHiddenGrp { get; set; }
        [ProtoMember(3)] public int GrpMsgWordingDown { get; set; }
        [ProtoMember(4)] public int FrdMsgGetBusiCard { get; set; }
        [ProtoMember(5)] public int GrpMsgGetOfficialAccount { get; set; }
        [ProtoMember(6)] public int GrpMsgGetPayInGroup { get; set; }
        [ProtoMember(7)] public int FrdMsgDiscuss2ManyChat { get; set; }
        [ProtoMember(8)] public int GrpMsgNotAllowJoinGrpInviteNotFrd { get; set; }
        [ProtoMember(9)] public int FrdMsgNeedWaitingMsg { get; set; }
        [ProtoMember(10)] public int FrdMsgUint32NeedAllUnreadMsg { get; set; }
        [ProtoMember(11)] public int GrpMsgNeedAutoAdminWording { get; set; }
        [ProtoMember(12)] public int GrpMsgGetTransferGroupMsgFlag { get; set; }
        [ProtoMember(13)] public int GrpMsgGetQuitPayGroupMsgFlag { get; set; }
        [ProtoMember(14)] public int GrpMsgSupportInviteAutoJoin { get; set; }
        [ProtoMember(15)] public int GrpMsgMaskInviteAutoJoin { get; set; }
        [ProtoMember(16)] public int GrpMsgGetDisbandedByAdmin { get; set; }
        [ProtoMember(17)] public int GrpMsgGetC2cInviteJoinGroup { get; set; }
    }

    [ProtoContract]
    internal class FriendInfo
    {
        [ProtoMember(1)] public string MsgJointFriend { get; set; }
        [ProtoMember(2)] public string MsgBlacklist { get; set; }
    }

    [ProtoContract]
    internal class GroupInfo
    {
        [ProtoMember(1)] public int GroupAuthType { get; set; }
        [ProtoMember(2)] public int DisplayAction { get; set; }
        [ProtoMember(3)] public string MsgAlert { get; set; }
        [ProtoMember(4)] public string MsgDetailAlert { get; set; }
        [ProtoMember(5)] public string MsgOtherAdminDone { get; set; }
        [ProtoMember(6)] public int AppPrivilegeFlag { get; set; }
    }

    [ProtoContract]
    internal class MsgInviteExt
    {
        [ProtoMember(1)] public int SrcType { get; set; }
        [ProtoMember(2)] public long SrcCode { get; set; }
        [ProtoMember(3)] public int WaitState { get; set; }
    }

    [ProtoContract]
    internal class MsgPayGroupExt
    {
        [ProtoMember(1)] public long JoinGrpTime { get; set; }
        [ProtoMember(2)] public long QuitGrpTime { get; set; }
    }

    [ProtoContract]
    internal class ReqNextSystemMsg
    {
        [ProtoMember(1)] public int MsgNum { get; set; }
        [ProtoMember(2)] public long FollowingFriendSeq { get; set; }
        [ProtoMember(3)] public long FollowingGroupSeq { get; set; }
        [ProtoMember(4)] public int Checktype { get; set; }
        [ProtoMember(5)] public FlagInfo? Flag { get; set; }
        [ProtoMember(6)] public int Language { get; set; }
        [ProtoMember(7)] public int Version { get; set; }
        [ProtoMember(8)] public long FriendMsgTypeFlag { get; set; }
    }

    [ProtoContract]
    internal class ReqSystemMsg
    {
        [ProtoMember(1)] public int MsgNum { get; set; }
        [ProtoMember(2)] public long LatestFriendSeq { get; set; }
        [ProtoMember(3)] public long LatestGroupSeq { get; set; }
        [ProtoMember(4)] public int Version { get; set; }
        [ProtoMember(5)] public int Language { get; set; }
    }

    [ProtoContract]
    internal class ReqSystemMsgAction
    {
        [ProtoMember(1)] public int MsgType { get; set; }
        [ProtoMember(2)] public long MsgSeq { get; set; }
        [ProtoMember(3)] public long ReqUin { get; set; }
        [ProtoMember(4)] public int SubType { get; set; }
        [ProtoMember(5)] public int SrcId { get; set; }
        [ProtoMember(6)] public int SubSrcId { get; set; }
        [ProtoMember(7)] public int GroupMsgType { get; set; }
        [ProtoMember(8)] public SystemMsgActionInfo? ActionInfo { get; set; }
        [ProtoMember(9)] public int Language { get; set; }
    }

    [ProtoContract]
    internal class ReqSystemMsgNew
    {
        [ProtoMember(1)] public int MsgNum { get; set; }
        [ProtoMember(2)] public long LatestFriendSeq { get; set; }
        [ProtoMember(3)] public long LatestGroupSeq { get; set; }
        [ProtoMember(4)] public int Version { get; set; }
        [ProtoMember(5)] public int Checktype { get; set; }
        [ProtoMember(6)] public FlagInfo? Flag { get; set; }
        [ProtoMember(7)] public int Language { get; set; }
        [ProtoMember(8)] public bool IsGetFrdRibbon { get; set; }
        [ProtoMember(9)] public bool IsGetGrpRibbon { get; set; }
        [ProtoMember(10)] public long FriendMsgTypeFlag { get; set; }
    }

    [ProtoContract]
    internal class ReqSystemMsgRead
    {
        [ProtoMember(1)] public long LatestFriendSeq { get; set; }
        [ProtoMember(2)] public long LatestGroupSeq { get; set; }
        [ProtoMember(3)] public int Type { get; set; }
        [ProtoMember(4)] public int Checktype { get; set; }
    }

    [ProtoContract]
    internal class RspHead
    {
        [ProtoMember(1)] public int Result { get; set; }
        [ProtoMember(2)] public string MsgFail { get; set; }
    }

    [ProtoContract]
    internal class RspNextSystemMsg
    {
        [ProtoMember(1)] public RspHead? Head { get; set; }
        [ProtoMember(2)] public List<StructMsg> Msgs { get; set; }
        [ProtoMember(3)] public long FollowingFriendSeq { get; set; }
        [ProtoMember(4)] public long FollowingGroupSeq { get; set; }
        [ProtoMember(5)] public int Checktype { get; set; }
        [ProtoMember(100)] public string GameNick { get; set; }
        [ProtoMember(101)] public byte[] UndecidForQim { get; set; }
        [ProtoMember(102)] public int UnReadCount3 { get; set; }
    }

    [ProtoContract]
    internal class RspSystemMsg
    {
        [ProtoMember(1)] public RspHead? Head { get; set; }
        [ProtoMember(2)] public List<StructMsg> Msgs { get; set; }
        [ProtoMember(3)] public int UnreadCount { get; set; }
        [ProtoMember(4)] public long LatestFriendSeq { get; set; }
        [ProtoMember(5)] public long LatestGroupSeq { get; set; }
        [ProtoMember(6)] public long FollowingFriendSeq { get; set; }
        [ProtoMember(7)] public long FollowingGroupSeq { get; set; }
        [ProtoMember(8)] public string MsgDisplay { get; set; }
    }

    [ProtoContract]
    internal class RspSystemMsgAction
    {
        [ProtoMember(1)] public RspHead? Head { get; set; }
        [ProtoMember(2)] public string MsgDetail { get; set; }
        [ProtoMember(3)] public int Type { get; set; }
        [ProtoMember(5)] public string MsgInvalidDecided { get; set; }
        [ProtoMember(6)] public int RemarkResult { get; set; }
    }

    [ProtoContract]
    internal class RspSystemMsgNew
    {
        [ProtoMember(1)] public RspHead? Head { get; set; }
        [ProtoMember(2)] public int UnreadFriendCount { get; set; }
        [ProtoMember(3)] public int UnreadGroupCount { get; set; }
        [ProtoMember(4)] public long LatestFriendSeq { get; set; }
        [ProtoMember(5)] public long LatestGroupSeq { get; set; }
        [ProtoMember(6)] public long FollowingFriendSeq { get; set; }
        [ProtoMember(7)] public long FollowingGroupSeq { get; set; }
        [ProtoMember(9)] public List<StructMsg> Friendmsgs { get; set; }
        [ProtoMember(10)] public List<StructMsg> Groupmsgs { get; set; }
        [ProtoMember(11)] public StructMsg? MsgRibbonFriend { get; set; }
        [ProtoMember(12)] public StructMsg? MsgRibbonGroup { get; set; }
        [ProtoMember(13)] public string MsgDisplay { get; set; }
        [ProtoMember(14)] public string GrpMsgDisplay { get; set; }
        [ProtoMember(15)] public int Over { get; set; }
        [ProtoMember(20)] public int Checktype { get; set; }
        [ProtoMember(100)] public string GameNick { get; set; }
        [ProtoMember(101)] public byte[] UndecidForQim { get; set; }
        [ProtoMember(102)] public int UnReadCount3 { get; set; }
    }

    [ProtoContract]
    internal class RspSystemMsgRead
    {
        [ProtoMember(1)] public RspHead? Head { get; set; }
        [ProtoMember(2)] public int Type { get; set; }
        [ProtoMember(3)] public int Checktype { get; set; }
    }

    [ProtoContract]
    internal class StructMsg
    {
        [ProtoMember(1)] public int Version { get; set; }
        [ProtoMember(2)] public int MsgType { get; set; }
        [ProtoMember(3)] public long MsgSeq { get; set; }
        [ProtoMember(4)] public long MsgTime { get; set; }
        [ProtoMember(5)] public long ReqUin { get; set; }
        [ProtoMember(6)] public int UnreadFlag { get; set; }
        [ProtoMember(50)] public SystemMsg? Msg { get; set; }
    }

    [ProtoContract]
    internal class SystemMsg
    {
        [ProtoMember(1)] public int SubType { get; set; }
        [ProtoMember(2)] public string MsgTitle { get; set; }
        [ProtoMember(3)] public string MsgDescribe { get; set; }
        [ProtoMember(4)] public string MsgAdditional { get; set; }
        [ProtoMember(5)] public string MsgSource { get; set; }
        [ProtoMember(6)] public string MsgDecided { get; set; }
        [ProtoMember(7)] public int SrcId { get; set; }
        [ProtoMember(8)] public int SubSrcId { get; set; }
        [ProtoMember(9)] public List<SystemMsgAction> Actions { get; set; }
        [ProtoMember(10)] public long GroupCode { get; set; }
        [ProtoMember(11)] public long ActionUin { get; set; }
        [ProtoMember(12)] public int GroupMsgType { get; set; }
        [ProtoMember(13)] public int GroupInviterRole { get; set; }
        [ProtoMember(14)] public FriendInfo? FriendInfo { get; set; }
        [ProtoMember(15)] public GroupInfo? GroupInfo { get; set; }
        [ProtoMember(16)] public long ActorUin { get; set; }
        [ProtoMember(17)] public string MsgActorDescribe { get; set; }
        [ProtoMember(18)] public string MsgAdditionalList { get; set; }
        [ProtoMember(19)] public int Relation { get; set; }
        [ProtoMember(20)] public int Reqsubtype { get; set; }
        [ProtoMember(21)] public long CloneUin { get; set; }
        [ProtoMember(22)] public long DiscussUin { get; set; }
        [ProtoMember(23)] public long EimGroupId { get; set; }
        [ProtoMember(24)] public MsgInviteExt? MsgInviteExtinfo { get; set; }
        [ProtoMember(25)] public MsgPayGroupExt? MsgPayGroupExtinfo { get; set; }
        [ProtoMember(26)] public int SourceFlag { get; set; }
        [ProtoMember(27)] public byte[] GameNick { get; set; }
        [ProtoMember(28)] public byte[] GameMsg { get; set; }
        [ProtoMember(29)] public int GroupFlagext3 { get; set; }
        [ProtoMember(30)] public long GroupOwnerUin { get; set; }
        [ProtoMember(31)] public int DoubtFlag { get; set; }
        [ProtoMember(32)] public byte[] WarningTips { get; set; }
        [ProtoMember(33)] public byte[] NameMore { get; set; }
        [ProtoMember(50)] public int ReqUinFaceid { get; set; }
        [ProtoMember(51)] public string ReqUinNick { get; set; }
        [ProtoMember(52)] public string GroupName { get; set; }
        [ProtoMember(53)] public string ActionUinNick { get; set; }
        [ProtoMember(54)] public string MsgQna { get; set; }
        [ProtoMember(55)] public string MsgDetail { get; set; }
        [ProtoMember(57)] public int GroupExtFlag { get; set; }
        [ProtoMember(58)] public string ActorUinNick { get; set; }
        [ProtoMember(59)] public string PicUrl { get; set; }
        [ProtoMember(60)] public string CloneUinNick { get; set; }
        [ProtoMember(61)] public string ReqUinBusinessCard { get; set; }
        [ProtoMember(63)] public string EimGroupIdName { get; set; }
        [ProtoMember(64)] public string ReqUinPreRemark { get; set; }
        [ProtoMember(65)] public string ActionUinQqNick { get; set; }
        [ProtoMember(66)] public string ActionUinRemark { get; set; }
        [ProtoMember(67)] public int ReqUinGender { get; set; }
        [ProtoMember(68)] public int ReqUinAge { get; set; }
        [ProtoMember(69)] public int C2cInviteJoinGroupFlag { get; set; }
        [ProtoMember(101)] public int CardSwitch { get; set; }
    }

    [ProtoContract]
    internal class SystemMsgAction
    {
        [ProtoMember(1)] public string Name { get; set; }
        [ProtoMember(2)] public string Result { get; set; }
        [ProtoMember(3)] public int Action { get; set; }
        [ProtoMember(4)] public SystemMsgActionInfo? ActionInfo { get; set; }
        [ProtoMember(5)] public string DetailName { get; set; }
    }

    [ProtoContract]
    internal class SystemMsgActionInfo
    {
        [ProtoMember(1)] public int Type { get; set; }
        [ProtoMember(2)] public long GroupCode { get; set; }
        [ProtoMember(3)] public byte[] Sig { get; set; }
        [ProtoMember(50)] public string Msg { get; set; }
        [ProtoMember(51)] public int GroupId { get; set; }
        [ProtoMember(52)] public string Remark { get; set; }
        [ProtoMember(53)] public bool Blacklist { get; set; }
        [ProtoMember(54)] public AddFrdSNInfo? AddFrdSNInfo { get; set; }
    }
}

[ProtoContract]
internal class Youtu
{
    [ProtoContract]
    internal class NameCardOcrRsp
    {
        [ProtoMember(1)] public int Errorcode { get; set; }
        [ProtoMember(2)] public string Errormsg { get; set; }
        [ProtoMember(3)] public string Uin { get; set; }
        [ProtoMember(4)] public float UinConfidence { get; set; }
        [ProtoMember(5)] public string Phone { get; set; }
        [ProtoMember(6)] public float PhoneConfidence { get; set; }
        [ProtoMember(7)] public string Name { get; set; }
        [ProtoMember(8)] public float NameConfidence { get; set; }
        [ProtoMember(9)] public byte[] Image { get; set; }
        [ProtoMember(10)] public string SessionId { get; set; }
    }
}
