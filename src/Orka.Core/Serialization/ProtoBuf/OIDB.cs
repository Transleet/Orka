using System;
using System.Collections.Generic;
using Org.BouncyCastle.Bcpg;
using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

internal class Oidb0x5d4  {
    [ProtoContract]
    internal class DelResult{
        [ProtoMember(1)] public  long  Uin { get; set; }
        [ProtoMember(2)] public  int  Res { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  List<Long>  UinList { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  int  Seq { get; set; }
        [ProtoMember(2)] public  List<DelResult>  Result { get; set; }
    } 
}

internal class Oidb0x5d2  {
    [ProtoContract]
    internal class FriendInfo{
        [ProtoMember(1)] public  long  Uin { get; set; }
        [ProtoMember(2)] public  int  Gender { get; set; }
        [ProtoMember(3)] public  int  Age { get; set; }
        [ProtoMember(4)] public  int  Group { get; set; }
        [ProtoMember(5)] public  int  Login { get; set; }
        [ProtoMember(6)] public  byte[]  Remark { get; set; }
    } 

    [ProtoContract]
    internal class FriendEntry{
        [ProtoMember(1)] public  long  Uin { get; set; }
        [ProtoMember(2)] public  byte[]  Nick { get; set; }
    } 

    [ProtoContract]
    internal class GroupInfo{
        [ProtoMember(1)] public  int  Id { get; set; }
        [ProtoMember(2)] public  byte[]  Name { get; set; }
    } 

    [ProtoContract]
    internal class LoginInfo{
        [ProtoMember(1)] public  int  Id { get; set; }
        [ProtoMember(2)] public  byte[]  Name { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  int  SubCmd { get; set; }
        [ProtoMember(2)] public  ReqGetList?  ReqGetList { get; set; }
        [ProtoMember(3)] public  ReqGetInfo?  ReqGetInfo { get; set; }
    } 

    [ProtoContract]
    internal class ReqGetInfo{
        [ProtoMember(1)] public  List<Long>  UinList { get; set; }
    } 

    [ProtoContract]
    internal class ReqGetList{
        [ProtoMember(1)] public  int  Seq { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  int  SubCmd { get; set; }
        [ProtoMember(2)] public  RspGetList?  RspGetList { get; set; }
        [ProtoMember(3)] public  RspGetInfo?  RspGetInfo { get; set; }
    } 

    [ProtoContract]
    internal class RspGetInfo{
        [ProtoMember(1)] public  List<GroupInfo>  GroupInfo { get; set; }
        [ProtoMember(2)] public  List<LoginInfo>  LoginInfo { get; set; }
        [ProtoMember(3)] public  int  Time { get; set; }
        [ProtoMember(4)] public  List<FriendInfo>  FrdInfo { get; set; }
        [ProtoMember(5)] public  List<Long>  FrdDelete { get; set; }
    } 

    [ProtoContract]
    internal class RspGetList{
        [ProtoMember(1)] public  int  Seq { get; set; }
        [ProtoMember(2)] public  List<FriendEntry>  List { get; set; }
    } 
}

internal class Oidb0x496 {
    [ProtoContract]
    internal class AioKeyword{
        [ProtoMember(1)] public  List<AioKeywordInfo>  Keywords { get; set; }
        [ProtoMember(2)] public  List<AioKeywordRuleInfo>  Rules { get; set; }
        [ProtoMember(3)] public  int  Version { get; set; }
    } 

    [ProtoContract]
    internal class AioKeywordInfo{
        [ProtoMember(1)] public  string  Word { get; set; }
        [ProtoMember(2)] public  int  RuleId { get; set; }
    } 

    [ProtoContract]
    internal class AioKeywordRuleInfo{
        [ProtoMember(1)] public  int  RuleId { get; set; }
        [ProtoMember(2)] public  int  StartTime { get; set; }
        [ProtoMember(3)] public  int  EndTime { get; set; }
        [ProtoMember(4)] public  int  PostionFlag { get; set; }
        [ProtoMember(5)] public  List<int>  MatchGroupClass { get; set; }
        [ProtoMember(6)] public  int  Version { get; set; }
    } 

    [ProtoContract]
    internal class GroupMsgConfig{
        [ProtoMember(1)] public  bool  BoolUinEnable { get; set; }
        [ProtoMember(2)] public  int  MaxAioMsg { get; set; }
        [ProtoMember(3)] public  int  EnableHelper { get; set; }
        [ProtoMember(4)] public  int  GroupMaxNumber { get; set; }
        [ProtoMember(5)] public  int  NextUpdateTime { get; set; }
    } 

    [ProtoContract]
    internal class MsgSeqInfo{
        [ProtoMember(1)] public  long  GroupCode { get; set; }
        [ProtoMember(2)] public  List<Long>  ManagerUinList { get; set; }
        [ProtoMember(3)] public  long  UpdateTime { get; set; }
        [ProtoMember(4)] public  long  FirstUnreadManagerMsgSeq { get; set; }
        [ProtoMember(5)] public  List<Long>  Uint64ManagerMsgSeq { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  long  GroupCode { get; set; }
        [ProtoMember(2)] public  long  UpdateTime { get; set; }
        [ProtoMember(3)] public  long  ManagerUinList { get; set; }
        [ProtoMember(4)] public  long  FirstUnreadManagerMsgSeq { get; set; }
        [ProtoMember(5)] public  int  JustFetchMsgConfig { get; set; }
        [ProtoMember(6)] public  int  Type { get; set; }
        [ProtoMember(7)] public  int  Version { get; set; }
        [ProtoMember(8)] public  int  AioKeywordVersion { get; set; }
    } 

    [ProtoContract]
    internal class Robot{
        [ProtoMember(1)] public  int  Version { get; set; }
        [ProtoMember(2)] public  List<UinRange>  UinRange { get; set; }
        [ProtoMember(3)] public  List<string>  FireKeywords { get; set; }
        [ProtoMember(4)] public  List<string>  StartKeywords { get; set; }
        [ProtoMember(5)] public  List<string>  EndKeywords { get; set; }
        [ProtoMember(6)] public  int  SessionTimeout { get; set; }
        [ProtoMember(7)] public  List<RobotSubscribeCategory>  SubscribeCategories { get; set; }
    } 

    [ProtoContract]
    internal class RobotSubscribeCategory{
        [ProtoMember(1)] public  int  Id { get; set; }
        [ProtoMember(2)] public  string  Name { get; set; }
        [ProtoMember(3)] public  int  Type { get; set; }
        [ProtoMember(4)] public  string  NextWording { get; set; }
        [ProtoMember(5)] public  string  NextContent { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  List<MsgSeqInfo>  MsgSeqInfo { get; set; }
        [ProtoMember(2)] public  long  MaxAioMsg { get; set; }
        [ProtoMember(3)] public  long  MaxPositionMsg { get; set; }
        [ProtoMember(4)] public  GroupMsgConfig?  MsgGroupMsgConfig { get; set; }
        [ProtoMember(5)] public  Robot?  RobotConfig { get; set; }
        [ProtoMember(6)] public  AioKeyword?  AioKeywordConfig { get; set; }
    } 

    [ProtoContract]
    internal class UinRange{
        [ProtoMember(1)] public  long  StartUin { get; set; }
        [ProtoMember(2)] public  long  EndUin { get; set; }
    } 
}


[ProtoContract]
internal class Oidb0x8a0  {
    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  long  OptUint64GroupCode { get; set; }
        [ProtoMember(2)] public  List<KickResult>  MsgKickResult { get; set; }
    } 

    [ProtoContract]
    internal class KickResult{
        [ProtoMember(1)] public  int  OptUint32Result { get; set; }
        [ProtoMember(2)] public  long  OptUint64MemberUin { get; set; }
    } 

    [ProtoContract]
    internal class KickMemberInfo{
        [ProtoMember(1)] public  int  OptUint32Operate { get; set; }
        [ProtoMember(2)] public  long  OptUint64MemberUin { get; set; }
        [ProtoMember(3)] public  int  OptUint32Flag { get; set; }
        [ProtoMember(4)] public  byte[]  OptBytesMsg { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  long  OptUint64GroupCode { get; set; }
        [ProtoMember(2)] public  List<KickMemberInfo>  MsgKickList { get; set; }
        [ProtoMember(3)] public  List<Long>  KickList { get; set; }
        [ProtoMember(4)] public  int  KickFlag { get; set; }
        [ProtoMember(5)] public  byte[]  KickMsg { get; set; }
    } 
}


[ProtoContract]
internal class Oidb0x8fc  {
    [ProtoContract]
    internal class CardNameElem{
        [ProtoMember(1)] public  int  EnumCardType { get; set; }
        [ProtoMember(2)] public  byte[]  Value { get; set; }
    } 

    [ProtoContract]
    internal class CommCardNameBuf{
        [ProtoMember(1)] public  List<RichCardNameElem>  RichCardName { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  long  GroupCode { get; set; }
        [ProtoMember(2)] public  int  ShowFlag { get; set; }
        [ProtoMember(3)] public  List<MemberInfo>  MemLevelInfo { get; set; }
        [ProtoMember(4)] public  List<LevelName>  LevelName { get; set; }
        [ProtoMember(5)] public  int  UpdateTime { get; set; }
        [ProtoMember(6)] public  int  OfficeMode { get; set; }
        [ProtoMember(7)] public  int  GroupOpenAppid { get; set; }
        [ProtoMember(8)] public  ClientInfo?  MsgClientInfo { get; set; }
        [ProtoMember(9)] public  byte[]  AuthKey { get; set; }
    } 

    [ProtoContract]
    internal class MemberInfo{
        [ProtoMember(1)] public  long  Uin { get; set; }
        [ProtoMember(2)] public  int  Point { get; set; }
        [ProtoMember(3)] public  int  ActiveDay { get; set; }
        [ProtoMember(4)] public  int  Level { get; set; }
        [ProtoMember(5)] public  byte[]  SpecialTitle { get; set; }
        [ProtoMember(6)] public  int  SpecialTitleExpireTime { get; set; }
        [ProtoMember(7)] public  byte[]  UinName { get; set; }
        [ProtoMember(8)] public  byte[]  MemberCardName { get; set; }
        [ProtoMember(9)] public  byte[]  Phone { get; set; }
        [ProtoMember(10)] public  byte[]  Email { get; set; }
        [ProtoMember(11)] public  byte[]  Remark { get; set; }
        [ProtoMember(12)] public  int  Gender { get; set; }
        [ProtoMember(13)] public  byte[]  Job { get; set; }
        [ProtoMember(14)] public  int  TribeLevel { get; set; }
        [ProtoMember(15)] public  int  TribePoint { get; set; }
        [ProtoMember(16)] public  List<CardNameElem>  RichCardName { get; set; }
        [ProtoMember(17)] public  byte[]  CommRichCardName { get; set; }
    } 

    [ProtoContract]
    internal class RichCardNameElem{
        [ProtoMember(1)] public  byte[]  Ctrl { get; set; }
        [ProtoMember(2)] public  byte[]  Text { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  long  GroupCode { get; set; }
        [ProtoMember(2)] public  string  ErrInfo { get; set; }
    } 

    [ProtoContract]
    internal class ClientInfo{
        [ProtoMember(1)] public  int  Implat { get; set; }
        [ProtoMember(2)] public  string  IngClientver { get; set; }
    } 

    [ProtoContract]
    internal class LevelName{
        [ProtoMember(1)] public  int  Level { get; set; }
        [ProtoMember(2)] public  string  Name { get; set; }
    } 
}

[ProtoContract]
internal class Oidb0x88d  {
    [ProtoContract]
    internal class GroupExInfoOnly{
        [ProtoMember(1)] public  int  TribeId { get; set; }
        [ProtoMember(2)] public  int  MoneyForAddGroup { get; set; }
    } 

    [ProtoContract]
    internal class ReqGroupInfo{
        [ProtoMember(1)] public  long  GroupCode { get; set; }
        [ProtoMember(2)] public  GroupInfo?  Stgroupinfo { get; set; }
        [ProtoMember(3)] public  int  LastGetGroupNameTime { get; set; }
    } 

    [ProtoContract]
    internal class RspGroupInfo{
        [ProtoMember(1)] public  long  GroupCode { get; set; }
        [ProtoMember(2)] public  int  Result { get; set; }
        [ProtoMember(3)] public  GroupInfo?  Stgroupinfo { get; set; }
    } 

    [ProtoContract]
    internal class GroupGeoInfo{
        [ProtoMember(1)] public  long  Owneruin { get; set; }
        [ProtoMember(2)] public  int  Settime { get; set; }
        [ProtoMember(3)] public  int  Cityid { get; set; }
        [ProtoMember(4)] public  long  Int64Longitude { get; set; }
        [ProtoMember(5)] public  long  Int64Latitude { get; set; }
        [ProtoMember(6)] public  byte[]  Geocontent { get; set; }
        [ProtoMember(7)] public  long  PoiId { get; set; }
    } 

    [ProtoContract]
    internal class TagRecord{
        [ProtoMember(1)] public  long  FromUin { get; set; }
        [ProtoMember(2)] public  long  GroupCode { get; set; }
        [ProtoMember(3)] public  byte[]  TagId { get; set; }
        [ProtoMember(4)] public  long  SetTime { get; set; }
        [ProtoMember(5)] public  int  GoodNum { get; set; }
        [ProtoMember(6)] public  int  BadNum { get; set; }
        [ProtoMember(7)] public  int  TagLen { get; set; }
        [ProtoMember(8)] public  byte[]  TagValue { get; set; }
    } 

    [ProtoContract]
    internal class GroupInfo{
        [ProtoMember(1)] public  Long?  GroupOwner { get; set; }
        [ProtoMember(2)] public  Int?  GroupCreateTime { get; set; }
        [ProtoMember(3)] public  Int?  GroupFlag { get; set; }
        [ProtoMember(4)] public  Int?  GroupFlagExt { get; set; }
        [ProtoMember(5)] public  Int?  GroupMemberMaxNum { get; set; }
        [ProtoMember(6)] public  Int?  GroupMemberNum { get; set; }
        [ProtoMember(7)] public  Int?  GroupOption { get; set; }
        [ProtoMember(8)] public  Int?  GroupClassExt { get; set; }
        [ProtoMember(9)] public  Int?  GroupSpecialClass { get; set; }
        [ProtoMember(10)] public  Int?  GroupLevel { get; set; }
        [ProtoMember(11)] public  Int?  GroupFace { get; set; }
        [ProtoMember(12)] public  Int?  GroupDefaultPage { get; set; }
        [ProtoMember(13)] public  Int?  GroupInfoSeq { get; set; }
        [ProtoMember(14)] public  Int?  GroupRoamingTime { get; set; }
        [ProtoMember(15)] public  string?  GroupName { get; set; }
        [ProtoMember(16)] public  string?  GroupMemo { get; set; }
        [ProtoMember(17)] public  string?  IngGroupFingerMemo { get; set; }
        [ProtoMember(18)] public  string?  IngGroupClassText { get; set; }
        [ProtoMember(19)] public  List<int>  GroupAllianceCode { get; set; }
        [ProtoMember(20)] public  Int?  GroupExtraAdmNum { get; set; }
        [ProtoMember(21)] public  Long?  GroupUin { get; set; }
        [ProtoMember(22)] public  Int?  GroupCurMsgSeq { get; set; }
        [ProtoMember(23)] public  Int?  GroupLastMsgTime { get; set; }
        [ProtoMember(24)] public  string?  IngGroupQuestion { get; set; }
        [ProtoMember(25)] public  string?  IngGroupAnswer { get; set; }
        [ProtoMember(26)] public  Int?  GroupVisitorMaxNum { get; set; }
        [ProtoMember(27)] public  Int?  GroupVisitorCurNum { get; set; }
        [ProtoMember(28)] public  Int?  LevelNameSeq { get; set; }
        [ProtoMember(29)] public  Int?  GroupAdminMaxNum { get; set; }
        [ProtoMember(30)] public  Int?  GroupAioSkinTimestamp { get; set; }
        [ProtoMember(31)] public  Int?  GroupBoardSkinTimestamp { get; set; }
        [ProtoMember(32)] public  string?  IngGroupAioSkinUrl { get; set; }
        [ProtoMember(33)] public  string?  IngGroupBoardSkinUrl { get; set; }
        [ProtoMember(34)] public  Int?  GroupCoverSkinTimestamp { get; set; }
        [ProtoMember(35)] public  string?  IngGroupCoverSkinUrl { get; set; }
        [ProtoMember(36)] public  Int?  GroupGrade { get; set; }
        [ProtoMember(37)] public  Int?  ActiveMemberNum { get; set; }
        [ProtoMember(38)] public  Int?  CertificationType { get; set; }
        [ProtoMember(39)] public  string?  IngCertificationText { get; set; }
        [ProtoMember(40)] public  string?  IngGroupRichFingerMemo { get; set; }
        [ProtoMember(41)] public  List<TagRecord>  TagRecord { get; set; }
        [ProtoMember(42)] public  GroupGeoInfo?  GroupGeoInfo { get; set; }
        [ProtoMember(43)] public  Int?  HeadPortraitSeq { get; set; }
        [ProtoMember(44)] public  GroupHeadPortrait?  MsgHeadPortrait { get; set; }
        [ProtoMember(45)] public  Int?  ShutupTimestamp { get; set; }
        [ProtoMember(46)] public  Int?  ShutupTimestampMe { get; set; }
        [ProtoMember(47)] public  Int?  CreateSourceFlag { get; set; }
        [ProtoMember(48)] public  Int?  CmduinMsgSeq { get; set; }
        [ProtoMember(49)] public  Int?  CmduinJoinTime { get; set; }
        [ProtoMember(50)] public  Int?  CmduinUinFlag { get; set; }
        [ProtoMember(51)] public  Int?  CmduinFlagEx { get; set; }
        [ProtoMember(52)] public  Int?  CmduinNewMobileFlag { get; set; }
        [ProtoMember(53)] public  Int?  CmduinReadMsgSeq { get; set; }
        [ProtoMember(54)] public  Int?  CmduinLastMsgTime { get; set; }
        [ProtoMember(55)] public  Int?  GroupTypeFlag { get; set; }
        [ProtoMember(56)] public  Int?  AppPrivilegeFlag { get; set; }
        [ProtoMember(57)] public  GroupExInfoOnly?  StGroupExInfo { get; set; }
        [ProtoMember(58)] public  Int?  GroupSecLevel { get; set; }
        [ProtoMember(59)] public  Int?  GroupSecLevelInfo { get; set; }
        [ProtoMember(60)] public  Int?  CmduinPrivilege { get; set; }
        [ProtoMember(61)] public  ByteArray?  IngPoidInfo { get; set; }
        [ProtoMember(62)] public  Int?  CmduinFlagEx2 { get; set; }
        [ProtoMember(63)] public  Long?  ConfUin { get; set; }
        [ProtoMember(64)] public  Int?  ConfMaxMsgSeq { get; set; }
        [ProtoMember(65)] public  Int?  ConfToGroupTime { get; set; }
        [ProtoMember(66)] public  Int?  PasswordRedbagTime { get; set; }
        [ProtoMember(67)] public  Long?  SubscriptionUin { get; set; }
        [ProtoMember(68)] public  Int?  MemberListChangeSeq { get; set; }
        [ProtoMember(69)] public  Int?  MembercardSeq { get; set; }
        [ProtoMember(70)] public  Long?  RootId { get; set; }
        [ProtoMember(71)] public  Long?  ParentId { get; set; }
        [ProtoMember(72)] public  Int?  TeamSeq { get; set; }
        [ProtoMember(73)] public  Long?  HistoryMsgBeginTime { get; set; }
        [ProtoMember(74)] public  Long?  InviteNoAuthNumLimit { get; set; }
        [ProtoMember(75)] public  Int?  CmduinHistoryMsgSeq { get; set; }
        [ProtoMember(76)] public  Int?  CmduinJoinMsgSeq { get; set; }
        [ProtoMember(77)] public  Int?  GroupFlagext3 { get; set; }
        [ProtoMember(78)] public  Int?  GroupOpenAppid { get; set; }
        [ProtoMember(79)] public  Int?  IsConfGroup { get; set; }
        [ProtoMember(80)] public  Int?  IsModifyConfGroupFace { get; set; }
        [ProtoMember(81)] public  Int?  IsModifyConfGroupName { get; set; }
        [ProtoMember(82)] public  Int?  NoFingerOpenFlag { get; set; }
        [ProtoMember(83)] public  Int?  NoCodeFingerOpenFlag { get; set; }
        [ProtoMember(84)] public  Int?  AutoAgreeJoinGroupUserNumForNormalGroup { get; set; }
        [ProtoMember(85)] public  Int?  AutoAgreeJoinGroupUserNumForConfGroup { get; set; }
        [ProtoMember(86)] public  Int?  IsAllowConfGroupMemberNick { get; set; }
        [ProtoMember(87)] public  Int?  IsAllowConfGroupMemberAtAll { get; set; }
        [ProtoMember(88)] public  Int?  IsAllowConfGroupMemberModifyGroupName { get; set; }
        [ProtoMember(89)] public  string?  LongGroupName { get; set; }
        [ProtoMember(90)] public  Int?  CmduinJoinRealMsgSeq { get; set; }
        [ProtoMember(91)] public  Int?  IsGroupFreeze { get; set; }
        [ProtoMember(92)] public  Int?  MsgLimitFrequency { get; set; }
        [ProtoMember(93)] public  ByteArray?  JoinGroupAuth { get; set; }
        [ProtoMember(94)] public  Int?  HlGuildAppid { get; set; }
        [ProtoMember(95)] public  Int?  HlGuildSubType { get; set; }
        [ProtoMember(96)] public  Int?  HlGuildOrgid { get; set; }
        [ProtoMember(97)] public  Int?  IsAllowHlGuildBinary { get; set; }
        [ProtoMember(98)] public  Int?  CmduinRingtoneId { get; set; }
        [ProtoMember(99)] public  Int?  GroupFlagext4 { get; set; }
        [ProtoMember(100)] public  Int?  GroupFreezeReason { get; set; }
    } 

    [ProtoContract]
    internal class GroupHeadPortraitInfo{
        [ProtoMember(1)] public  int  Uint32PicId { get; set; }
        [ProtoMember(2)] public  int  LeftX { get; set; }
        [ProtoMember(3)] public  int  LeftY { get; set; }
        [ProtoMember(4)] public  int  RightX { get; set; }
        [ProtoMember(5)] public  int  RightY { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  List<RspGroupInfo>  Stzrspgroupinfo { get; set; }
        [ProtoMember(2)] public  byte[]  Errorinfo { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  int  Appid { get; set; }
        [ProtoMember(2)] public  List<ReqGroupInfo>  Stzreqgroupinfo { get; set; }
        [ProtoMember(3)] public  int  PcClientVersion { get; set; }
    } 

    [ProtoContract]
    internal class GroupHeadPortrait{
        [ProtoMember(1)] public  int  PicCnt { get; set; }
        [ProtoMember(2)] public  List<GroupHeadPortraitInfo>  MsgInfo { get; set; }
        [ProtoMember(3)] public  int  DefaultId { get; set; }
        [ProtoMember(4)] public  int  VerifyingPicCnt { get; set; }
        [ProtoMember(5)] public  List<GroupHeadPortraitInfo>  MsgVerifyingpicInfo { get; set; }
    } 
}

[ProtoContract]
internal class Oidb0x89a  {
    [ProtoContract]
    internal class GroupNewGuidelinesInfo{
        [ProtoMember(1)] public  bool  BoolEnabled { get; set; }
        [ProtoMember(2)] public  byte[]  IngContent { get; set; }
    } 

    [ProtoContract]
    internal class Groupinfo{
        Int?    [ProtoMember(1)  var groupExtAdmNum { get; set; }
        Int?    [ProtoMember(2)  var flag { get; set; }
        ByteArray?    [ProtoMember(3)  var ingGroupName { get; set; }
        ByteArray?    [ProtoMember(4)  var ingGroupMemo { get; set; }
        ByteArray?    [ProtoMember(5)  var ingGroupFingerMemo { get; set; }
        ByteArray?    [ProtoMember(6)  var ingGroupAioSkinUrl { get; set; }
        ByteArray?    [ProtoMember(7)  var ingGroupBoardSkinUrl { get; set; }
        ByteArray?    [ProtoMember(8)  var ingGroupCoverSkinUrl { get; set; }
        Int?    [ProtoMember(9)  var groupGrade { get; set; }
        Int?    [ProtoMember(10)  var activeMemberNum { get; set; }
        Int?    [ProtoMember(11)  var certificationType { get; set; }
        ByteArray?    [ProtoMember(12)  var ingCertificationText { get; set; }
        ByteArray?    [ProtoMember(13)  var ingGroupRichFingerMemo { get; set; }
        GroupNewGuidelinesInfo?    [ProtoMember(14)  var stGroupNewguidelines { get; set; }
        Int?    [ProtoMember(15)  var groupFace { get; set; }
        Int?    [ProtoMember(16)  var addOption { get; set; }
        Int?    [ProtoMember(17)  var shutupTime { get; set; }
        Int?    [ProtoMember(18)  var groupTypeFlag { get; set; }
        List<byte[]>    [ProtoMember(19)  var stringGroupTag { get; set; }
        GroupGeoInfo?    [ProtoMember(20)  var msgGroupGeoInfo { get; set; }
        Int?    [ProtoMember(21)  var groupClassExt { get; set; }
        ByteArray?    [ProtoMember(22)  var ingGroupClassText { get; set; }
        Int?    [ProtoMember(23)  var appPrivilegeFlag { get; set; }
        Int?    [ProtoMember(24)  var appPrivilegeMask { get; set; }
        GroupExInfoOnly?    [ProtoMember(25)  var stGroupExInfo { get; set; }
        Int?    [ProtoMember(26)  var groupSecLevel { get; set; }
        Int?    [ProtoMember(27)  var groupSecLevelInfo { get; set; }
        Long?    [ProtoMember(28)  var subscriptionUin { get; set; }
        Int?    [ProtoMember(29)  var allowMemberInvite { get; set; }
        ByteArray?    [ProtoMember(30)  var ingGroupQuestion { get; set; }
        ByteArray?    [ProtoMember(31)  var ingGroupAnswer { get; set; }
        Int?    [ProtoMember(32)  var groupFlagext3 { get; set; }
        Int?    [ProtoMember(33)  var groupFlagext3Mask { get; set; }
        Int?    [ProtoMember(34)  var groupOpenAppid { get; set; }
        Int?    [ProtoMember(35)  var noFingerOpenFlag { get; set; }
        Int?    [ProtoMember(36)  var noCodeFingerOpenFlag { get; set; }
        Long?    [ProtoMember(37)  var rootId { get; set; }
        Int?    [ProtoMember(38)  var msgLimitFrequency { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  long  GroupCode { get; set; }
        [ProtoMember(2)] public  byte[]  Errorinfo { get; set; }
    } 

    [ProtoContract]
    internal class GroupExInfoOnly{
        [ProtoMember(1)] public  int  TribeId { get; set; }
        [ProtoMember(2)] public  int  MoneyForAddGroup { get; set; }
    } 

    [ProtoContract]
    internal class GroupGeoInfo{
        [ProtoMember(1)] public  int  CityId { get; set; }
        [ProtoMember(2)] public  long  Longtitude { get; set; }
        [ProtoMember(3)] public  long  Latitude { get; set; }
        [ProtoMember(4)] public  byte[]  IngGeoContent { get; set; }
        [ProtoMember(5)] public  long  PoiId { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  long  GroupCode { get; set; }
        [ProtoMember(2)] public  Groupinfo?  StGroupInfo { get; set; }
        [ProtoMember(3)] public  long  OriginalOperatorUin { get; set; }
        [ProtoMember(4)] public  int  ReqGroupOpenAppid { get; set; }
    } 
}

[ProtoContract]
internal class Cmd0x7cb  {
    [ProtoContract]
    internal class ConfigItem{
        [ProtoMember(1)] public  int  Id { get; set; }
        [ProtoMember(2)] public  string  Config { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  int  TimeStamp { get; set; }
        [ProtoMember(2)] public  int  TimeGap { get; set; }
        [ProtoMember(3)] public  List<CommentConfig>  CommentConfigs { get; set; }
        [ProtoMember(4)] public  string  AttendTipsToA { get; set; }
        [ProtoMember(5)] public  string  FirstMsgTips { get; set; }
        [ProtoMember(6)] public  List<ConfigItem>  CancleConfig { get; set; }
        [ProtoMember(7)] public  DateRequest?  MsgDateRequest { get; set; }
        [ProtoMember(8)] public  List<byte[]>  MsgHotLocale { get; set; }
        [ProtoMember(9)] public  List<TopicConfig>  MsgTopicList { get; set; }
        [ProtoMember(10)] public  string  TravelMsgTips { get; set; }
        [ProtoMember(11)] public  string  TravelProfileTips { get; set; }
        [ProtoMember(12)] public  string  TravelAttenTips { get; set; }
        [ProtoMember(13)] public  int  TopicDefault { get; set; }
    } 

    [ProtoContract]
    internal class CommentConfig{
        [ProtoMember(1)] public  int  AppointSubject { get; set; }
        [ProtoMember(2)] public  List<ConfigItem>  MsgConfigs { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  int  TimeStamp { get; set; }
    } 

    [ProtoContract]
    internal class DateRequest{
        [ProtoMember(1)] public  int  Time { get; set; }
        [ProtoMember(2)] public  string  ErrMsg { get; set; }
    } 

    [ProtoContract]
    internal class TopicConfig{
        [ProtoMember(1)] public  int  TopicId { get; set; }
        [ProtoMember(2)] public  string  TopicName { get; set; }
        [ProtoMember(3)] public  int  Deadline { get; set; }
        [ProtoMember(4)] public  string  ErrDeadline { get; set; }
    } 
}

[ProtoContract]
internal class Oidb0x87a  {
    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  string  Country { get; set; }
        [ProtoMember(2)] public  string  Telephone { get; set; }
        [ProtoMember(3)] public  int  ResendInterval { get; set; }
        [ProtoMember(4)] public  byte[]  Guid { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  string  Country { get; set; }
        [ProtoMember(2)] public  string  Telephone { get; set; }
        [ProtoMember(3)] public  byte[]  Guid { get; set; }
        [ProtoMember(4)] public  int  EnumButype { get; set; }
    } 
}

[ProtoContract]
internal class GroupAppPb  {
    [ProtoContract]
    internal class ClientInfo{
        [ProtoMember(1)] public  int  Platform { get; set; }
        [ProtoMember(2)] public  string  Version { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  AppList?  FullList { get; set; }
        [ProtoMember(2)] public  AppList?  GroupGrayList { get; set; }
        [ProtoMember(3)] public  AppList?  RedPointList { get; set; }
        [ProtoMember(4)] public  int  CacheInterval { get; set; }
    } 

    [ProtoContract]
    internal class AppList{
        [ProtoMember(1)] public  string  Hash { get; set; }
        [ProtoMember(2)] public  List<AppInfo>  Infos { get; set; }
    } 

    [ProtoContract]
    internal class AppInfo{
        [ProtoMember(1)] public  int  Appid { get; set; }
        [ProtoMember(2)] public  string  Icon { get; set; }
        [ProtoMember(3)] public  string  Name { get; set; }
        [ProtoMember(4)] public  string  Url { get; set; }
        [ProtoMember(5)] public  int  IsGray { get; set; }
        [ProtoMember(6)] public  string  IconSimpleDay { get; set; }
        [ProtoMember(7)] public  string  IconSimpleNight { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  ClientInfo?  Client { get; set; }
        [ProtoMember(2)] public  long  GroupId { get; set; }
        [ProtoMember(3)] public  int  GroupType { get; set; }
        [ProtoMember(4)] public  string  FullListHash { get; set; }
        [ProtoMember(5)] public  string  GroupGrayListHash { get; set; }
    } 
}

[ProtoContract]
internal class Oidb0xc34  {
    [ProtoContract]
    internal class RspBody 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  long  Uin { get; set; }
    } 
}

[ProtoContract]
internal class Cmd0x5fd  {
    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  AppointDefine.DateComment?  MsgComment { get; set; }
        [ProtoMember(2)] public  int  MaxFetchCount { get; set; }
        [ProtoMember(3)] public  string  LastCommentId { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  List<AppointDefine.DateComment>  MsgComment { get; set; }
        [ProtoMember(2)] public  string  ErrorTips { get; set; }
        [ProtoMember(3)] public  int  ClearCacheFlag { get; set; }
        [ProtoMember(4)] public  string  CommentWording { get; set; }
        [ProtoMember(5)] public  int  CommentNum { get; set; }
    } 
}

[ProtoContract]
internal class Oidb0xbcb  {
    [ProtoContract]
    internal class CheckUrlReqItem{
        [ProtoMember(1)] public  string  Url { get; set; }
        [ProtoMember(2)] public  string  Refer { get; set; }
        [ProtoMember(3)] public  string  Plateform { get; set; }
        [ProtoMember(4)] public  string  QqPfTo { get; set; }
        [ProtoMember(5)] public  int  MsgType { get; set; }
        [ProtoMember(6)] public  int  MsgFrom { get; set; }
        [ProtoMember(7)] public  long  MsgChatid { get; set; }
        [ProtoMember(8)] public  long  ServiceType { get; set; }
        [ProtoMember(9)] public  long  SendUin { get; set; }
        [ProtoMember(10)] public  string  ReqType { get; set; }
    } 

    [ProtoContract]
    internal class CheckUrlRsp{
        [ProtoMember(1)] public  List<UrlCheckResult>  Results { get; set; }
        [ProtoMember(2)] public  int  NextReqDuration { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(9)] public  int  NotUseCache { get; set; }
        [ProtoMember(10)] public  CheckUrlReq?  CheckUrlReq { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  string  Wording { get; set; }
        [ProtoMember(10)] public  CheckUrlRsp?  CheckUrlRsp { get; set; }
    } 

    [ProtoContract]
    internal class CheckUrlReq{
        [ProtoMember(1)] public  List<string>  Url { get; set; }
        [ProtoMember(2)] public  string  Refer { get; set; }
        [ProtoMember(3)] public  string  Plateform { get; set; }
        [ProtoMember(4)] public  string  QqPfTo { get; set; }
        [ProtoMember(5)] public  int  MsgType { get; set; }
        [ProtoMember(6)] public  int  MsgFrom { get; set; }
        [ProtoMember(7)] public  long  MsgChatid { get; set; }
        [ProtoMember(8)] public  long  ServiceType { get; set; }
        [ProtoMember(9)] public  long  SendUin { get; set; }
        [ProtoMember(10)] public  string  ReqType { get; set; }
        [ProtoMember(11)] public  string  OriginalUrl { get; set; }
    } 

    [ProtoContract]
    internal class UrlCheckResult{
        [ProtoMember(1)] public  string  Url { get; set; }
        [ProtoMember(2)] public  int  Result { get; set; }
        [ProtoMember(3)] public  int  JumpResult { get; set; }
        [ProtoMember(4)] public  string  JumpUrl { get; set; }
        [ProtoMember(5)] public  int  Level { get; set; }
        [ProtoMember(6)] public  int  SubLevel { get; set; }
        [ProtoMember(7)] public  int  Umrtype { get; set; }
        [ProtoMember(8)] public  int  RetFrom { get; set; }
        [ProtoMember(9)] public  long  OperationBit { get; set; }
    } 
}

[ProtoContract]
internal class Oidb0xbfe  {
    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  int  ReceiveStatus { get; set; }
        [ProtoMember(2)] public  byte[]  JumpUrl { get; set; }
        [ProtoMember(3)] public  int  Flag { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  long  Uin { get; set; }
    } 
}

[ProtoContract]
internal class Oidb0xbe8  {
    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  long  Uin { get; set; }
        [ProtoMember(2)] public  int  EnumOpCode { get; set; }
        [ProtoMember(3)] public  int  RspOfPopupFlag { get; set; }
        [ProtoMember(4)] public  int  PopupCountNow { get; set; }
    } 

    [ProtoContract]
    internal class PopupResult{
        [ProtoMember(1)] public  int  PopupResult { get; set; }
        [ProtoMember(2)] public  int  PopupFieldid { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  long  Uin { get; set; }
        [ProtoMember(2)] public  int  EnumOpCode { get; set; }
        [ProtoMember(3)] public  int  ReqOfPopupFlag { get; set; }
        [ProtoMember(4)] public  int  RstOfPopupFlag { get; set; }
        [ProtoMember(5)] public  int  Mqq808WelcomepageFlag { get; set; }
        [ProtoMember(6)] public  List<PopupResult>  MsgPopupResult { get; set; }
    } 
}

[ProtoContract]
internal class Cmd0x7de  {
    [ProtoContract]
    internal class UserProfile{
        [ProtoMember(1)] public  AppointDefine.PublisherInfo?  MsgPublisherInfo { get; set; }
        [ProtoMember(2)] public  AppointDefine.AppointInfo?  MsgAppointsInfo { get; set; }
        [ProtoMember(3)] public  List<AppointDefine.StrangerInfo>  MsgVistorInfo { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  BusiRespHead?  MsgHead { get; set; }
        [ProtoMember(2)] public  List<UserProfile>  MsgUserList { get; set; }
        [ProtoMember(3)] public  int  Ended { get; set; }
        [ProtoMember(4)] public  byte[]  Cookie { get; set; }
    } 

    [ProtoContract]
    internal class BusiRespHead{
        [ProtoMember(1)] public  int  Int32Version { get; set; }
        [ProtoMember(2)] public  int  Int32Seq { get; set; }
        [ProtoMember(3)] public  int  Int32ReplyCode { get; set; }
        [ProtoMember(4)] public  string  Result { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  BusiReqHead?  MsgHead { get; set; }
        [ProtoMember(2)] public  AppointDefine.LBSInfo?  MsgLbsInfo { get; set; }
        [ProtoMember(3)] public  int  Time { get; set; }
        [ProtoMember(4)] public  int  Subject { get; set; }
        [ProtoMember(5)] public  int  Gender { get; set; }
        [ProtoMember(6)] public  int  AgeLow { get; set; }
        [ProtoMember(7)] public  int  AgeUp { get; set; }
        [ProtoMember(8)] public  int  Profession { get; set; }
        [ProtoMember(9)] public  byte[]  Cookie { get; set; }
        [ProtoMember(10)] public  AppointDefine.LocaleInfo?  MsgDestination { get; set; }
    } 

    [ProtoContract]
    internal class BusiReqHead{
        [ProtoMember(1)] public  int  Int32Version { get; set; }
        [ProtoMember(2)] public  int  Int32Seq { get; set; }
    } 
}

[ProtoContract]
internal class Cmd0x7a8  {
    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  long  ReqUin { get; set; }
        [ProtoMember(11)] public  int  OnlyObtained { get; set; }
        [ProtoMember(12)] public  int  ReadReport { get; set; }
        [ProtoMember(13)] public  int  SortType { get; set; }
        [ProtoMember(14)] public  int  OnlyNew { get; set; }
        [ProtoMember(15)] public  List<int>  FilterMedalIds { get; set; }
        [ProtoMember(16)] public  int  OnlySummary { get; set; }
        [ProtoMember(17)] public  int  DoScan { get; set; }
        [ProtoMember(18)] public  int  StartTimestamp { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  string  Nick { get; set; }
        [ProtoMember(2)] public  int  MetalRank { get; set; }
        [ProtoMember(3)] public  int  FriCount { get; set; }
        [ProtoMember(4)] public  int  MetalCount { get; set; }
        [ProtoMember(5)] public  int  MetalTotal { get; set; }
        [ProtoMember(6)] public  List<Common.MedalInfo>  MsgMedal { get; set; }
        [ProtoMember(8)] public  int  TotalPoint { get; set; }
        [ProtoMember(9)] public  int  Int32NewCount { get; set; }
        [ProtoMember(10)] public  int  Int32UpgradeCount { get; set; }
        [ProtoMember(11)] public  string  PromptParams { get; set; }
        [ProtoMember(12)] public  int  Now { get; set; }
    } 

    [ProtoContract]
    internal class MedalNews{
        [ProtoMember(1)] public  long  FriUin { get; set; }
        [ProtoMember(2)] public  string  FriNick { get; set; }
        [ProtoMember(3)] public  Common.MedalInfo?  MsgMedal { get; set; }
    } 
}


[ProtoContract]
internal class Cmd0x5fe  {
    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  AppointDefine.AppointID?  MsgAppointId { get; set; }
        [ProtoMember(2)] public  string  CommentId { get; set; }
        [ProtoMember(3)] public  int  FetchOldCount { get; set; }
        [ProtoMember(4)] public  int  FetchNewCount { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  List<AppointDefine.DateComment>  MsgComment { get; set; }
        [ProtoMember(2)] public  string  ErrorTips { get; set; }
        [ProtoMember(3)] public  int  FetchOldOver { get; set; }
        [ProtoMember(4)] public  int  FetchNewOver { get; set; }
    } 
}

[ProtoContract]
internal class Oidb0xc35  {
    [ProtoContract]
    internal class RspBody 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  long  Uin { get; set; }
        [ProtoMember(2)] public  List<ExposeItem>  MsgExposeInfo { get; set; }
    } 

    [ProtoContract]
    internal class ExposeItem{
        [ProtoMember(1)] public  long  Friend { get; set; }
        [ProtoMember(2)] public  int  PageId { get; set; }
        [ProtoMember(3)] public  int  EntranceId { get; set; }
        [ProtoMember(4)] public  int  ActionId { get; set; }
        [ProtoMember(5)] public  int  ExposeCount { get; set; }
        [ProtoMember(6)] public  int  ExposeTime { get; set; }
        [ProtoMember(7)] public  byte[]  AlgoBuffer { get; set; }
        [ProtoMember(8)] public  byte[]  Addition { get; set; }
    } 
}

[ProtoContract]
internal class Oidb0xc0d  {
    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  long  CompletedTaskStamp { get; set; }
        [ProtoMember(2)] public  byte[]  ErrMsg { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  long  Uin { get; set; }
        [ProtoMember(2)] public  int  TaskType { get; set; }
        [ProtoMember(3)] public  int  TaskPoint { get; set; }
    } 
}

[ProtoContract]
internal class OidbSso  {
    [ProtoContract]
    internal class OIDBSSOPkg{
        [ProtoMember(1)] public  int  Command { get; set; }
        [ProtoMember(2)] public  int ServiceType { get; set; }
        [ProtoMember(3)] public  int  Result { get; set; }
        [ProtoMember(4)] public  byte[]  Bodybuffer { get; set; }
        [ProtoMember(5)] public  string  ErrorMsg { get; set; }
        [ProtoMember(6)] public  string  ClientVersion { get; set; }
    } , Packet {
        fun checkSuccess(actionName: String) {
            check(result == 0) {
                "${actionName.capitalize()} failed. result=$result, errorMsg=$errorMsg"
            }
        }
    }
}

[ProtoContract]
internal class Cmd0xc83  {
    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(101)] public  long  FromUin { get; set; }
        [ProtoMember(102)] public  long  ToUin { get; set; }
        [ProtoMember(103)] public  int  Op { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(101)] public  int  Result { get; set; }
        [ProtoMember(102)] public  int  RetryInterval { get; set; }
    } 
}

[ProtoContract]
internal class Cmd0xccb  {
    [ProtoContract]
    internal class GroupMsgInfo{
        [ProtoMember(1)] public  int  MsgSeq { get; set; }
        [ProtoMember(2)] public  int  RoamFlag { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  int  Type { get; set; }
        [ProtoMember(2)] public  long  DestUin { get; set; }
        [ProtoMember(3)] public  long  GroupCode { get; set; }
        [ProtoMember(4)] public  List<C2cMsgInfo>  C2cMsg { get; set; }
        [ProtoMember(5)] public  List<GroupMsgInfo>  GroupMsg { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  int  Type { get; set; }
        [ProtoMember(2)] public  long  DestUin { get; set; }
        [ProtoMember(3)] public  long  GroupCode { get; set; }
        [ProtoMember(4)] public  List<C2cMsgInfo>  C2cMsg { get; set; }
        [ProtoMember(5)] public  List<GroupMsgInfo>  GroupMsg { get; set; }
        [ProtoMember(6)] public  byte[]  ResId { get; set; }
    } 

    [ProtoContract]
    internal class C2cMsgInfo{
        [ProtoMember(1)] public  int  MsgSeq { get; set; }
        [ProtoMember(2)] public  int  MsgTime { get; set; }
        [ProtoMember(3)] public  int  MsgRandom { get; set; }
        [ProtoMember(4)] public  int  RoamFlag { get; set; }
    } 
}

[ProtoContract]
internal class Oidb0xd84  {
    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  byte[]  Xmitinfo { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  byte[]  Xmitinfo { get; set; }
    } 
}

[ProtoContract]
internal class Oidb0x5e1  {
    [ProtoContract]
    internal class UdcUinData{
        [ProtoMember(1)] public  long  Uin { get; set; }
        [ProtoMember(4)] public  byte[]  Openid { get; set; }
        [ProtoMember(20002)] public  byte[]  Nick { get; set; }
        [ProtoMember(20003)] public  byte[]  Country { get; set; }
        [ProtoMember(20004)] public  byte[]  Province { get; set; }
        [ProtoMember(20009)] public  int  Gender { get; set; }
        [ProtoMember(20014)] public  int  Allow { get; set; }
        [ProtoMember(20015)] public  int  FaceId { get; set; }
        [ProtoMember(20020)] public  byte[]  City { get; set; }
        [ProtoMember(20027)] public  int  CommonPlace1 { get; set; }
        [ProtoMember(20030)] public  byte[]  Mss3Bitmapextra { get; set; }
        [ProtoMember(20031)] public  byte[]  Birthday { get; set; }
        [ProtoMember(20032)] public  byte[]  CityId { get; set; }
        [ProtoMember(20033)] public  int  Lang1 { get; set; }
        [ProtoMember(20034)] public  int  Lang2 { get; set; }
        [ProtoMember(20035)] public  int  Lang3 { get; set; }
        [ProtoMember(20041)] public  int  CityZoneId { get; set; }
        [ProtoMember(20056)] public  int  Oin { get; set; }
        [ProtoMember(20059)] public  int  BubbleId { get; set; }
        [ProtoMember(21001)] public  byte[]  Mss2Identity { get; set; }
        [ProtoMember(21002)] public  byte[]  Mss1Service { get; set; }
        [ProtoMember(21003)] public  int  Lflag { get; set; }
        [ProtoMember(21004)] public  int  ExtFlag { get; set; }
        [ProtoMember(21006)] public  byte[]  BasicSvrFlag { get; set; }
        [ProtoMember(21007)] public  byte[]  BasicCliFlag { get; set; }
        [ProtoMember(24101)] public  byte[]  PengyouRealname { get; set; }
        [ProtoMember(24103)] public  int  PengyouGender { get; set; }
        [ProtoMember(24118)] public  int  PengyouFlag { get; set; }
        [ProtoMember(26004)] public  byte[]  FullBirthday { get; set; }
        [ProtoMember(26005)] public  byte[]  FullAge { get; set; }
        [ProtoMember(26010)] public  int  SimpleUpdateTime { get; set; }
        [ProtoMember(26011)] public  int  MssUpdateTime { get; set; }
        [ProtoMember(27022)] public  int  GroupMemCreditFlag { get; set; }
        [ProtoMember(27025)] public  long  FaceAddonId { get; set; }
        [ProtoMember(27026)] public  byte[]  MusicGene { get; set; }
        [ProtoMember(40323)] public  int  FileShareBit { get; set; }
        [ProtoMember(40404)] public  int  RecommendPrivacyCtrl { get; set; }
        [ProtoMember(40505)] public  int  OldFriendChat { get; set; }
        [ProtoMember(40602)] public  int  BusinessBit { get; set; }
        [ProtoMember(41305)] public  int  CrmBit { get; set; }
        [ProtoMember(41810)] public  int  ForbidFileshareBit { get; set; }
        [ProtoMember(42333)] public  int  UserLoginGuardFace { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(11)] public  List<UdcUinData>  MsgUinData { get; set; }
        [ProtoMember(12)] public  List<Long>  Uint64UnfinishedUins { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  List<Long>  Uint64Uins { get; set; }
        [ProtoMember(2)] public  int  StartTime { get; set; }
        [ProtoMember(3)] public  int  MaxPackageSize { get; set; }
        [ProtoMember(4)] public  List<byte[]>  BytesOpenid { get; set; }
        [ProtoMember(5)] public  int  Appid { get; set; }
        [ProtoMember(20002)] public  int  ReqNick { get; set; }
        [ProtoMember(20003)] public  int  ReqCountry { get; set; }
        [ProtoMember(20004)] public  int  ReqProvince { get; set; }
        [ProtoMember(20009)] public  int  ReqGender { get; set; }
        [ProtoMember(20014)] public  int  ReqAllow { get; set; }
        [ProtoMember(20015)] public  int  ReqFaceId { get; set; }
        [ProtoMember(20020)] public  int  ReqCity { get; set; }
        [ProtoMember(20027)] public  int  ReqCommonPlace1 { get; set; }
        [ProtoMember(20030)] public  int  ReqMss3Bitmapextra { get; set; }
        [ProtoMember(20031)] public  int  ReqBirthday { get; set; }
        [ProtoMember(20032)] public  int  ReqCityId { get; set; }
        [ProtoMember(20033)] public  int  ReqLang1 { get; set; }
        [ProtoMember(20034)] public  int  ReqLang2 { get; set; }
        [ProtoMember(20035)] public  int  ReqLang3 { get; set; }
        [ProtoMember(20041)] public  int  ReqCityZoneId { get; set; }
        [ProtoMember(20056)] public  int  ReqOin { get; set; }
        [ProtoMember(20059)] public  int  ReqBubbleId { get; set; }
        [ProtoMember(21001)] public  int  ReqMss2Identity { get; set; }
        [ProtoMember(21002)] public  int  ReqMss1Service { get; set; }
        [ProtoMember(21003)] public  int  ReqLflag { get; set; }
        [ProtoMember(21004)] public  int  ReqExtFlag { get; set; }
        [ProtoMember(21006)] public  int  ReqBasicSvrFlag { get; set; }
        [ProtoMember(21007)] public  int  ReqBasicCliFlag { get; set; }
        [ProtoMember(24101)] public  int  ReqPengyouRealname { get; set; }
        [ProtoMember(24103)] public  int  ReqPengyouGender { get; set; }
        [ProtoMember(24118)] public  int  ReqPengyouFlag { get; set; }
        [ProtoMember(26004)] public  int  ReqFullBirthday { get; set; }
        [ProtoMember(26005)] public  int  ReqFullAge { get; set; }
        [ProtoMember(26010)] public  int  ReqSimpleUpdateTime { get; set; }
        [ProtoMember(26011)] public  int  ReqMssUpdateTime { get; set; }
        [ProtoMember(27022)] public  int  ReqGroupMemCreditFlag { get; set; }
        [ProtoMember(27025)] public  int  ReqFaceAddonId { get; set; }
        [ProtoMember(27026)] public  int  ReqMusicGene { get; set; }
        [ProtoMember(40323)] public  int  ReqFileShareBit { get; set; }
        [ProtoMember(40404)] public  int  ReqRecommendPrivacyCtrlBit { get; set; }
        [ProtoMember(40505)] public  int  ReqOldFriendChatBit { get; set; }
        [ProtoMember(40602)] public  int  ReqBusinessBit { get; set; }
        [ProtoMember(41305)] public  int  ReqCrmBit { get; set; }
        [ProtoMember(41810)] public  int  ReqForbidFileshareBit { get; set; }
        [ProtoMember(42333)] public  int  UserLoginGuardFace { get; set; }
    } 
}

[ProtoContract]
internal class Oidb0xc90  {
    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  List<Long>  CommunityBid { get; set; }
        [ProtoMember(2)] public  int  Page { get; set; }
    } 

    [ProtoContract]
    internal class CommunityWebInfo{
        [ProtoMember(1)] public  List<CommunityConfigInfo>  CommunityInfoItem { get; set; }
        [ProtoMember(2)] public  int  Page { get; set; }
        [ProtoMember(3)] public  int  End { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  List<CommunityConfigInfo>  CommunityInfoItem { get; set; }
        [ProtoMember(2)] public  byte[]  JumpConcernCommunityUrl { get; set; }
        [ProtoMember(3)] public  byte[]  CommunityTitleWording { get; set; }
        [ProtoMember(4)] public  byte[]  MoreUrlWording { get; set; }
        [ProtoMember(5)] public  CommunityWebInfo?  WebCommunityInfo { get; set; }
        [ProtoMember(6)] public  byte[]  JumpCommunityChannelUrl { get; set; }
    } 

    [ProtoContract]
    internal class CommunityConfigInfo{
        [ProtoMember(1)] public  byte[]  JumpHomePageUrl { get; set; }
        [ProtoMember(2)] public  byte[]  Name { get; set; }
        [ProtoMember(3)] public  byte[]  PicUrl { get; set; }
        [ProtoMember(4)] public  int  DynamicCount { get; set; }
        [ProtoMember(5)] public  long  CommunityBid { get; set; }
        [ProtoMember(6)] public  int  FollowStatus { get; set; }
    } 
}

[ProtoContract]
internal class Cmd0xd8a  {
    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  int  Retcode { get; set; }
        [ProtoMember(2)] public  string  Res { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  long  Uin { get; set; }
        [ProtoMember(2)] public  int  Cmd { get; set; }
        [ProtoMember(3)] public  string  Body { get; set; }
        [ProtoMember(4)] public  ClientInfo?  ClientInfo { get; set; }
    } 

    [ProtoContract]
    internal class ClientInfo{
        [ProtoMember(1)] public  int  Implat { get; set; }
        [ProtoMember(2)] public  string  IngClientver { get; set; }
    } 
}

[ProtoContract]
internal class Oidb0xb6f  {
    [ProtoContract]
    internal class ReportFreqRspBody{
        [ProtoMember(1)] public  Identity?  Identity { get; set; }
        [ProtoMember(4)] public  long  RemainTimes { get; set; }
        [ProtoMember(5)] public  int  ExpireTime { get; set; }
    } 

    [ProtoContract]
    internal class Identity{
        [ProtoMember(1)] public  string  ApiName { get; set; }
        [ProtoMember(2)] public  int  Appid { get; set; }
        [ProtoMember(3)] public  int  Apptype { get; set; }
        [ProtoMember(4)] public  int  Bizid { get; set; }
        [ProtoMember(10)] public  long  IntExt1 { get; set; }
        [ProtoMember(20)] public  string  Ext1 { get; set; }
    } 

    [ProtoContract]
    internal class ThresholdInfo{
        [ProtoMember(1)] public  long  ThresholdPerMinute { get; set; }
        [ProtoMember(2)] public  long  ThresholdPerDay { get; set; }
        [ProtoMember(3)] public  long  ThresholdPerHour { get; set; }
        [ProtoMember(4)] public  long  ThresholdPerWeek { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  ReportFreqRspBody?  ReportFreqRsp { get; set; }
    } 

    [ProtoContract]
    internal class ReportFreqReqBody{
        [ProtoMember(1)] public  Identity?  Identity { get; set; }
        [ProtoMember(2)] public  long  InvokeTimes { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  ReportFreqReqBody?  ReportFreqReq { get; set; }
    } 
}

[ProtoContract]
internal class Cmd0x7dc  {
    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  int  Seq { get; set; }
        [ProtoMember(2)] public  string  Wording { get; set; }
        [ProtoMember(3)] public  List<AppointDefine.AppointInfo>  MsgAppointInfo { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  int  Seq { get; set; }
        [ProtoMember(2)] public  AppointDefine.AppointContent?  MsgAppointment { get; set; }
        [ProtoMember(3)] public  AppointDefine.LBSInfo?  MsgLbsInfo { get; set; }
        [ProtoMember(4)] public  int  Overwrite { get; set; }
    } 
}

[ProtoContract]
internal class Cmd0x7cd  {
    [ProtoContract]
    internal class AppointBrife{
        [ProtoMember(1)] public  AppointDefine.PublisherInfo?  MsgPublisherInfo { get; set; }
        [ProtoMember(2)] public  AppointDefine.AppointInfo?  MsgAppointsInfo { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  int  Stamp { get; set; }
        [ProtoMember(2)] public  int  Over { get; set; }
        [ProtoMember(3)] public  int  Next { get; set; }
        [ProtoMember(4)] public  List<AppointBrife>  MsgAppointsInfo { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  int  Stamp { get; set; }
        [ProtoMember(2)] public  int  Start { get; set; }
        [ProtoMember(3)] public  int  Want { get; set; }
        [ProtoMember(4)] public  AppointDefine.LBSInfo?  MsgLbsInfo { get; set; }
        [ProtoMember(5)] public  List<AppointDefine.AppointID>  MsgAppointIds { get; set; }
        [ProtoMember(6)] public  int  AppointOperation { get; set; }
        [ProtoMember(100)] public  long  RequestUin { get; set; }
    } 
}

[ProtoContract]
internal class Oidb0xc0c  {
    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  int  IsTaskCompleted { get; set; }
        [ProtoMember(2)] public  int  TaskPoint { get; set; }
        [ProtoMember(3)] public  byte[]  GuideWording { get; set; }
        [ProtoMember(4)] public  int  NeedShowProgress { get; set; }
        [ProtoMember(5)] public  int  OriginalProgress { get; set; }
        [ProtoMember(6)] public  int  NowProgress { get; set; }
        [ProtoMember(7)] public  int  TotalProgress { get; set; }
        [ProtoMember(8)] public  int  NeedExecTask { get; set; }
    } 

    [ProtoContract]
    internal class VideoSrcType{
        [ProtoMember(1)] public  int  SourceType { get; set; }
        [ProtoMember(2)] public  int  VideoFromType { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  long  Uin { get; set; }
        [ProtoMember(2)] public  int  TaskType { get; set; }
        [ProtoMember(3)] public  byte[]  Rowkey { get; set; }
        [ProtoMember(4)] public  long  FeedsId { get; set; }
        [ProtoMember(5)] public  VideoSrcType?  MsgVideoFromType { get; set; }
    } 
}

[ProtoContract]
internal class Cmd0x5fb  {
    [ProtoContract]
    internal class ReqInfo{
        [ProtoMember(3)] public  int  Time { get; set; }
        [ProtoMember(4)] public  int  Subject { get; set; }
        [ProtoMember(5)] public  int  Gender { get; set; }
        [ProtoMember(6)] public  int  AgeLow { get; set; }
        [ProtoMember(7)] public  int  AgeUp { get; set; }
        [ProtoMember(8)] public  int  Profession { get; set; }
        [ProtoMember(9)] public  byte[]  Cookie { get; set; }
        [ProtoMember(10)] public  AppointDefine.LocaleInfo?  MsgDestination { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  BusiReqHead?  MsgHead { get; set; }
        [ProtoMember(2)] public  AppointDefine.LBSInfo?  MsgLbsInfo { get; set; }
        [ProtoMember(3)] public  byte[]  ReqInfo { get; set; }
    } 

    [ProtoContract]
    internal class BusiRespHead{
        [ProtoMember(1)] public  int  Int32Version { get; set; }
        [ProtoMember(2)] public  int  Int32Seq { get; set; }
        [ProtoMember(3)] public  int  Int32ReplyCode { get; set; }
        [ProtoMember(4)] public  string  Result { get; set; }
    } 

    [ProtoContract]
    internal class UserProfile{
        [ProtoMember(1)] public  long  Int64Id { get; set; }
        [ProtoMember(2)] public  int  Int32IdType { get; set; }
        [ProtoMember(3)] public  string  Url { get; set; }
        [ProtoMember(4)] public  int  Int32PicType { get; set; }
        [ProtoMember(5)] public  int  Int32SubPicType { get; set; }
        [ProtoMember(6)] public  string  Title { get; set; }
        [ProtoMember(7)] public  string  Content { get; set; }
        [ProtoMember(8)] public  string  Content2 { get; set; }
        [ProtoMember(9)] public  string  PicUrl { get; set; }
    } 

    [ProtoContract]
    internal class BusiReqHead{
        [ProtoMember(1)] public  int  Int32Version { get; set; }
        [ProtoMember(2)] public  int  Int32Seq { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  BusiRespHead?  MsgHead { get; set; }
        [ProtoMember(2)] public  byte[]  MsgUserList { get; set; }
    } 
}

[ProtoContract]
internal class Oidb0xb61  {
    [ProtoContract]
    internal class GetAppinfoReq{
        [ProtoMember(1)] public  int  Appid { get; set; }
        [ProtoMember(2)] public  int  AppType { get; set; }
        [ProtoMember(3)] public  int  Platform { get; set; }
    } 

    [ProtoContract]
    internal class GetPkgUrlReq{
        [ProtoMember(1)] public  int  Appid { get; set; }
        [ProtoMember(2)] public  int  AppType { get; set; }
        [ProtoMember(3)] public  int  AppVersion { get; set; }
        [ProtoMember(4)] public  int  Platform { get; set; }
        [ProtoMember(5)] public  string  SysVersion { get; set; }
        [ProtoMember(6)] public  string  QqVersion { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  string  Wording { get; set; }
        [ProtoMember(2)] public  int  NextReqDuration { get; set; }
        [ProtoMember(10)] public  GetAppinfoRsp?  GetAppinfoRsp { get; set; }
        [ProtoMember(11)] public  GetPkgUrlRsp?  GetMqqappUrlRsp { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(10)] public  GetAppinfoReq?  GetAppinfoReq { get; set; }
        [ProtoMember(11)] public  GetPkgUrlReq?  GetMqqappUrlReq { get; set; }
    } 

    [ProtoContract]
    internal class GetAppinfoRsp{
        [ProtoMember(1)] public  Qqconnect.Appinfo?  Appinfo { get; set; }
    } 

    [ProtoContract]
    internal class GetPkgUrlRsp{
        [ProtoMember(1)] public  int  AppVersion { get; set; }
        [ProtoMember(2)] public  string  PkgUrl { get; set; }
    } 
}

[ProtoContract]
internal class Oidb0xb60  {
    [ProtoContract]
    internal class GetPrivilegeReq{
        [ProtoMember(1)] public  int  Appid { get; set; }
        [ProtoMember(2)] public  int  AppType { get; set; }
    } 

    [ProtoContract]
    internal class CheckUrlReq{
        [ProtoMember(1)] public  int  Appid { get; set; }
        [ProtoMember(2)] public  int  AppType { get; set; }
        [ProtoMember(3)] public  string  Url { get; set; }
    } 

    [ProtoContract]
    internal class ClientInfo{
        [ProtoMember(1)] public  int  Platform { get; set; }
        [ProtoMember(2)] public  string  SdkVersion { get; set; }
        [ProtoMember(3)] public  string  AndroidPackageName { get; set; }
        [ProtoMember(4)] public  string  AndroidSignature { get; set; }
        [ProtoMember(5)] public  string  IosBundleId { get; set; }
        [ProtoMember(6)] public  string  PcSign { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  string  Wording { get; set; }
        [ProtoMember(10)] public  GetPrivilegeRsp?  GetPrivilegeRsp { get; set; }
        [ProtoMember(11)] public  CheckUrlRsp?  CheckUrlRsp { get; set; }
    } 

    [ProtoContract]
    internal class CheckUrlRsp{
        [ProtoMember(1)] public  bool  IsAuthed { get; set; }
        [ProtoMember(2)] public  int  NextReqDuration { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  ClientInfo?  ClientInfo { get; set; }
        [ProtoMember(10)] public  GetPrivilegeReq?  GetPrivilegeReq { get; set; }
        [ProtoMember(11)] public  CheckUrlReq?  CheckUrlReq { get; set; }
    } 

    [ProtoContract]
    internal class GetPrivilegeRsp{
        [ProtoMember(1)] public  List<int>  ApiGroups { get; set; }
        [ProtoMember(2)] public  int  NextReqDuration { get; set; }
        [ProtoMember(3)] public  List<string>  ApiNames { get; set; }
    } 
}

[ProtoContract]
internal class Cmd0x5fc  {
    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  long  LastEventId { get; set; }
        [ProtoMember(2)] public  long  ReadEventId { get; set; }
        [ProtoMember(3)] public  int  FetchCount { get; set; }
        [ProtoMember(4)] public  long  LastNearbyEventId { get; set; }
        [ProtoMember(5)] public  long  ReadNearbyEventId { get; set; }
        [ProtoMember(6)] public  int  FetchNearbyEventCount { get; set; }
        [ProtoMember(7)] public  long  LastFeedEventId { get; set; }
        [ProtoMember(8)] public  long  ReadFeedEventId { get; set; }
        [ProtoMember(9)] public  int  FetchFeedEventCount { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  List<AppointDefine.DateEvent>  MsgEventList { get; set; }
        [ProtoMember(2)] public  List<AppointDefine.AppointID>  ActAppointIds { get; set; }
        [ProtoMember(3)] public  long  MaxEventId { get; set; }
        [ProtoMember(4)] public  string  ErrorTips { get; set; }
        [ProtoMember(5)] public  List<AppointDefine.NearbyEvent>  MsgNearbyEventList { get; set; }
        [ProtoMember(6)] public  List<AppointDefine.FeedEvent>  MsgFeedEventList { get; set; }
        [ProtoMember(7)] public  long  MaxFreshEventId { get; set; }
    } 
}

[ProtoContract]
internal class Oidb0xc33  {
    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  int  Result { get; set; }
        [ProtoMember(2)] public  int  NextGap { get; set; }
        [ProtoMember(3)] public  int  NewUser { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody 
}

[ProtoContract]
internal class Oidb0xc0b  {
    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  int  IsOpenCoinEntry { get; set; }
        [ProtoMember(2)] public  int  CanGetCoinCount { get; set; }
        [ProtoMember(3)] public  byte[]  CoinIconUrl { get; set; }
        [ProtoMember(5)] public  long  LastCompletedTaskStamp { get; set; }
        [ProtoMember(6)] public  List<KanDianCMSActivityInfo>  CmsWording { get; set; }
        [ProtoMember(7)] public  long  LastCmsActivityStamp { get; set; }
        [ProtoMember(8)] public  KanDianCoinRemind?  MsgKandianCoinRemind { get; set; }
        [ProtoMember(9)] public  KanDianTaskRemind?  MsgKandianTaskRemind { get; set; }
    } 

    [ProtoContract]
    internal class KanDianCoinRemind{
        [ProtoMember(1)] public  byte[]  Wording { get; set; }
    } 

    [ProtoContract]
    internal class KanDianTaskRemind{
        [ProtoMember(1)] public  byte[]  Wording { get; set; }
        [ProtoMember(2)] public  byte[]  JumpUrl { get; set; }
        [ProtoMember(3)] public  int  TaskType { get; set; }
    } 

    [ProtoContract]
    internal class KanDianCMSActivityInfo{
        [ProtoMember(1)] public  long  ActivityId { get; set; }
        [ProtoMember(2)] public  byte[]  Wording { get; set; }
        [ProtoMember(3)] public  byte[]  PictureUrl { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  long  Uin { get; set; }
    } 
}

[ProtoContract]
internal class Cmd0xc85  {
    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(101)] public  long  FromUin { get; set; }
        [ProtoMember(102)] public  long  ToUin { get; set; }
        [ProtoMember(103)] public  int  Op { get; set; }
        [ProtoMember(104)] public  int  IntervalDays { get; set; }
    } 

    [ProtoContract]
    internal class InteractionDetailInfo{
        [ProtoMember(101)] public  int  ContinuousRecordDays { get; set; }
        [ProtoMember(102)] public  int  SendDayTime { get; set; }
        [ProtoMember(103)] public  int  RecvDayTime { get; set; }
        [ProtoMember(104)] public  string  SendRecord { get; set; }
        [ProtoMember(105)] public  string  RecvRecord { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(101)] public  int  Result { get; set; }
        [ProtoMember(102)] public  int  RecentInteractionTime { get; set; }
        [ProtoMember(103)] public  InteractionDetailInfo?  InteractionDetailInfo { get; set; }
    } 
}

[ProtoContract]
internal class Cmd0x7ce  {
    [ProtoContract]
    internal class AppintDetail{
        [ProtoMember(1)] public  AppointDefine.PublisherInfo?  MsgPublisherInfo { get; set; }
        [ProtoMember(2)] public  AppointDefine.AppointInfo?  MsgAppointsInfo { get; set; }
        [ProtoMember(3)] public  int  Score { get; set; }
        [ProtoMember(4)] public  int  JoinOver { get; set; }
        [ProtoMember(5)] public  int  JoinNext { get; set; }
        [ProtoMember(6)] public  List<AppointDefine.StrangerInfo>  MsgStrangerInfo { get; set; }
        [ProtoMember(7)] public  int  ViewOver { get; set; }
        [ProtoMember(8)] public  int  ViewNext { get; set; }
        [ProtoMember(9)] public  List<AppointDefine.StrangerInfo>  MsgVistorInfo { get; set; }
        [ProtoMember(10)] public  int  MeJoin { get; set; }
        [ProtoMember(12)] public  int  CanProfile { get; set; }
        [ProtoMember(13)] public  string  ProfileErrmsg { get; set; }
        [ProtoMember(14)] public  int  CanAio { get; set; }
        [ProtoMember(15)] public  string  AioErrmsg { get; set; }
        [ProtoMember(16)] public  byte[]  SigC2C { get; set; }
        [ProtoMember(17)] public  long  Uin { get; set; }
        [ProtoMember(18)] public  int  Limited { get; set; }
        [ProtoMember(19)] public  List<AppointDefine.DateComment>  MsgCommentList { get; set; }
        [ProtoMember(20)] public  int  CommentOver { get; set; }
        [ProtoMember(23)] public  int  MeInvited { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  List<AppintDetail>  MsgAppointsInfo { get; set; }
        [ProtoMember(2)] public  int  SecureFlag { get; set; }
        [ProtoMember(3)] public  string  SecureTips { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  List<AppointDefine.AppointID>  AppointIds { get; set; }
        [ProtoMember(2)] public  int  JoinStart { get; set; }
        [ProtoMember(3)] public  int  JoinWant { get; set; }
        [ProtoMember(4)] public  int  ViewStart { get; set; }
        [ProtoMember(5)] public  int  ViewWant { get; set; }
        [ProtoMember(6)] public  AppointDefine.LBSInfo?  MsgLbsInfo { get; set; }
        [ProtoMember(7)] public  List<Long>  Uint64Uins { get; set; }
        [ProtoMember(8)] public  int  ViewCommentCount { get; set; }
        [ProtoMember(100)] public  long  RequestUin { get; set; }
    } 
}

[ProtoContract]
internal class Cmd0x7db  {
    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  string  Wording { get; set; }
        [ProtoMember(2)] public  AppointDefine.AppointInfo?  MsgAppointInfo { get; set; }
        [ProtoMember(3)] public  byte[]  SigC2C { get; set; }
        [ProtoMember(4)] public  int  AppointAction { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  AppointDefine.AppointID?  MsgAppointId { get; set; }
        [ProtoMember(2)] public  int  AppointAction { get; set; }
        [ProtoMember(3)] public  int  Overwrite { get; set; }
        [ProtoMember(4)] public  List<AppointDefine.AppointID>  MsgAppointIds { get; set; }
    } 
}

[ProtoContract]
internal class Oidb0xc6c  {
    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  long  Uin { get; set; }
        [ProtoMember(2)] public  List<GroupInfo>  MsgGroupInfo { get; set; }
    } 

    [ProtoContract]
    internal class GroupInfo{
        [ProtoMember(1)] public  long  GroupUin { get; set; }
        [ProtoMember(2)] public  long  GroupCode { get; set; }
    } 

    [ProtoContract]
    internal class RspBody 
}

[ProtoContract]
internal class Oidb0xc05  {
    [ProtoContract]
    internal class GetAuthAppListReq{
        [ProtoMember(1)] public  int  Start { get; set; }
        [ProtoMember(2)] public  int  Limit { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  string  Wording { get; set; }
        [ProtoMember(10)] public  GetCreateAppListRsp?  GetCreateAppListRsp { get; set; }
        [ProtoMember(11)] public  GetAuthAppListRsp?  GetAuthAppListRsp { get; set; }
    } 

    [ProtoContract]
    internal class GetCreateAppListRsp{
        [ProtoMember(1)] public  int  TotalCount { get; set; }
        [ProtoMember(2)] public  List<Qqconnect.Appinfo>  Appinfos { get; set; }
    } 

    [ProtoContract]
    internal class GetAuthAppListRsp{
        [ProtoMember(1)] public  int  TotalCount { get; set; }
        [ProtoMember(2)] public  List<Qqconnect.Appinfo>  Appinfos { get; set; }
        [ProtoMember(3)] public  int  CurIndex { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(10)] public  GetCreateAppListReq?  GetCreateAppListReq { get; set; }
        [ProtoMember(11)] public  GetAuthAppListReq?  GetAuthAppListReq { get; set; }
    } 

    [ProtoContract]
    internal class GetCreateAppListReq{
        [ProtoMember(1)] public  int  Start { get; set; }
        [ProtoMember(2)] public  int  Limit { get; set; }
    } 
}

[ProtoContract]
internal class Cmd0x7da  {
    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  List<AppointDefine.AppointID>  MsgAppointIds { get; set; }
        [ProtoMember(2)] public  int  AppointOperation { get; set; }
        [ProtoMember(3)] public  int  OperationReason { get; set; }
        [ProtoMember(4)] public  int  Overwrite { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  string  Wording { get; set; }
        [ProtoMember(2)] public  List<AppointDefine.AppointInfo>  MsgAppointInfo { get; set; }
        [ProtoMember(3)] public  int  OperationReason { get; set; }
    } 
}

[ProtoContract]
internal class Qqconnect  {
    [ProtoContract]
    internal class MobileAppInfo{
        [ProtoMember(11)] public  List<AndroidAppInfo>  AndroidAppInfo { get; set; }
        [ProtoMember(12)] public  List<IOSAppInfo>  IosAppInfo { get; set; }
    } 

    [ProtoContract]
    internal class TemplateMsgConfig{
        [ProtoMember(1)] public  long  ServiceMsgUin { get; set; }
        [ProtoMember(2)] public  long  PublicMsgUin { get; set; }
        [ProtoMember(3)] public  long  CampMsgUin { get; set; }
    } 

    [ProtoContract]
    internal class Appinfo{
        [ProtoMember(1)] public  int  Appid { get; set; }
        [ProtoMember(2)] public  int  AppType { get; set; }
        [ProtoMember(3)] public  int  Platform { get; set; }
        [ProtoMember(4)] public  string  AppName { get; set; }
        [ProtoMember(5)] public  string  AppKey { get; set; }
        [ProtoMember(6)] public  int  AppState { get; set; }
        [ProtoMember(7)] public  string  IphoneUrlScheme { get; set; }
        [ProtoMember(8)] public  string  AndroidPackName { get; set; }
        [ProtoMember(9)] public  string  IconUrl { get; set; }
        [ProtoMember(10)] public  string  SourceUrl { get; set; }
        [ProtoMember(11)] public  string  IconSmallUrl { get; set; }
        [ProtoMember(12)] public  string  IconMiddleUrl { get; set; }
        [ProtoMember(13)] public  TencentDocsAppinfo?  TencentDocsAppinfo { get; set; }
        [ProtoMember(21)] public  long  DeveloperUin { get; set; }
        [ProtoMember(22)] public  int  AppClass { get; set; }
        [ProtoMember(23)] public  int  AppSubclass { get; set; }
        [ProtoMember(24)] public  string  Remark { get; set; }
        [ProtoMember(25)] public  string  IconMiniUrl { get; set; }
        [ProtoMember(26)] public  long  AuthTime { get; set; }
        [ProtoMember(27)] public  string  AppUrl { get; set; }
        [ProtoMember(28)] public  string  UniversalLink { get; set; }
        [ProtoMember(29)] public  int  QqconnectFeature { get; set; }
        [ProtoMember(30)] public  int  IsHatchery { get; set; }
        [ProtoMember(31)] public  List<Long>  TestUinList { get; set; }
        [ProtoMember(100)] public  TemplateMsgConfig?  TemplateMsgConfig { get; set; }
        [ProtoMember(101)] public  MiniAppInfo?  MiniAppInfo { get; set; }
        [ProtoMember(102)] public  WebAppInfo?  WebAppInfo { get; set; }
        [ProtoMember(103)] public  MobileAppInfo?  MobileAppInfo { get; set; }
    } 

    [ProtoContract]
    internal class ConnectClientInfo{
        [ProtoMember(1)] public  int  Platform { get; set; }
        [ProtoMember(2)] public  string  SdkVersion { get; set; }
        [ProtoMember(3)] public  string  SystemName { get; set; }
        [ProtoMember(4)] public  string  SystemVersion { get; set; }
        [ProtoMember(21)] public  string  AndroidPackageName { get; set; }
        [ProtoMember(22)] public  string  AndroidSignature { get; set; }
        [ProtoMember(31)] public  string  IosBundleId { get; set; }
        [ProtoMember(32)] public  string  IosDeviceId { get; set; }
        [ProtoMember(33)] public  string  IosAppToken { get; set; }
        [ProtoMember(41)] public  string  PcSign { get; set; }
    } 

    [ProtoContract]
    internal class TencentDocsAppinfo{
        [ProtoMember(1)] public  string  OpenTypes { get; set; }
        [ProtoMember(2)] public  string  Opts { get; set; }
        [ProtoMember(3)] public  string  Ejs { get; set; }
        [ProtoMember(4)] public  string  CallbackUrlTest { get; set; }
        [ProtoMember(5)] public  string  CallbackUrl { get; set; }
        [ProtoMember(6)] public  string  Domain { get; set; }
        [ProtoMember(7)] public  string  UserinfoCallback { get; set; }
        [ProtoMember(8)] public  string  UserinfoCallbackTest { get; set; }
    } 

    [ProtoContract]
    internal class WebAppInfo{
        [ProtoMember(1)] public  string  WebsiteUrl { get; set; }
        [ProtoMember(2)] public  string  Provider { get; set; }
        [ProtoMember(3)] public  string  Icp { get; set; }
        [ProtoMember(4)] public  string  CallbackUrl { get; set; }
    } 

    [ProtoContract]
    internal class IOSAppInfo{
        [ProtoMember(1)] public  string  BundleId { get; set; }
        [ProtoMember(2)] public  string  UrlScheme { get; set; }
        [ProtoMember(3)] public  string  StoreId { get; set; }
    } 

    [ProtoContract]
    internal class MsgUinInfo{
        [ProtoMember(1)] public  long  Uin { get; set; }
        [ProtoMember(2)] public  int  MsgType { get; set; }
        [ProtoMember(3)] public  int  Appid { get; set; }
        [ProtoMember(4)] public  int  AppType { get; set; }
        [ProtoMember(5)] public  int  Ctime { get; set; }
        [ProtoMember(6)] public  int  Mtime { get; set; }
        [ProtoMember(7)] public  int  MpType { get; set; }
        [ProtoMember(100)] public  string  Nick { get; set; }
        [ProtoMember(101)] public  string  FaceUrl { get; set; }
    } 

    [ProtoContract]
    internal class MiniAppInfo{
        [ProtoMember(1)] public  long  SuperUin { get; set; }
        [ProtoMember(11)] public  int  OwnerType { get; set; }
        [ProtoMember(12)] public  string  OwnerName { get; set; }
        [ProtoMember(13)] public  int  OwnerIdCardType { get; set; }
        [ProtoMember(14)] public  string  OwnerIdCard { get; set; }
        [ProtoMember(15)] public  int  OwnerStatus { get; set; }
    } 

    [ProtoContract]
    internal class AndroidAppInfo{
        [ProtoMember(1)] public  string  PackName { get; set; }
        [ProtoMember(2)] public  string  PackSign { get; set; }
        [ProtoMember(3)] public  string  ApkDownUrl { get; set; }
    } 
}

[ProtoContract]
internal class Sync  {
    [ProtoContract]
    internal class SyncAppointmentReq{
        [ProtoMember(1)] public  long  Uin { get; set; }
        [ProtoMember(2)] public  AppointDefine.AppointContent?  MsgAppointment { get; set; }
        [ProtoMember(3)] public  AppointDefine.GPS?  MsgGpsInfo { get; set; }
    } 

    [ProtoContract]
    internal class SyncAppointmentRsp{
        [ProtoMember(1)] public  int  Result { get; set; }
    } 
}

[ProtoContract]
internal class Oidb0xc26  {
    [ProtoContract]
    internal class RgoupLabel{
        [ProtoMember(1)] public  byte[]  Name { get; set; }
        [ProtoMember(2)] public  int  EnumType { get; set; }
        [ProtoMember(3)] public  RgroupColor?  TextColor { get; set; }
        [ProtoMember(4)] public  RgroupColor?  EdgingColor { get; set; }
        [ProtoMember(5)] public  int  LabelAttr { get; set; }
        [ProtoMember(6)] public  int  LabelType { get; set; }
    } 

    [ProtoContract]
    internal class AddFriendSource{
        [ProtoMember(1)] public  int  Source { get; set; }
        [ProtoMember(2)] public  int  SubSource { get; set; }
    } 

    [ProtoContract]
    internal class Label{
        [ProtoMember(1)] public  byte[]  Name { get; set; }
        [ProtoMember(2)] public  Color?  TextColor { get; set; }
        [ProtoMember(3)] public  Color?  EdgingColor { get; set; }
        [ProtoMember(4)] public  int  LabelType { get; set; }
    } 

    [ProtoContract]
    internal class EntryDelay{
        [ProtoMember(1)] public  int  EmEntry { get; set; }
        [ProtoMember(2)] public  int  Delay { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  List<MayKnowPerson>  MsgPersons { get; set; }
        [ProtoMember(2)] public  List<int>  EntryInuse { get; set; }
        [ProtoMember(3)] public  List<int>  EntryClose { get; set; }
        [ProtoMember(4)] public  int  NextGap { get; set; }
        [ProtoMember(5)] public  int  Timestamp { get; set; }
        [ProtoMember(6)] public  int  MsgUp { get; set; }
        [ProtoMember(7)] public  List<EntryDelay>  EntryDelays { get; set; }
        [ProtoMember(8)] public  int  ListSwitch { get; set; }
        [ProtoMember(9)] public  int  AddPageListSwitch { get; set; }
        [ProtoMember(10)] public  int  EmRspDataType { get; set; }
        [ProtoMember(11)] public  List<RecommendInfo>  MsgRgroupItems { get; set; }
        [ProtoMember(12)] public  bool  BoolIsNewuser { get; set; }
        [ProtoMember(13)] public  List<TabInfo>  MsgTables { get; set; }
        [ProtoMember(14)] public  byte[]  Cookies { get; set; }
    } 

    [ProtoContract]
    internal class TabInfo{
        [ProtoMember(1)] public  int  TabId { get; set; }
        [ProtoMember(2)] public  int  RecommendCount { get; set; }
        [ProtoMember(3)] public  byte[]  TableName { get; set; }
        [ProtoMember(4)] public  byte[]  IconUrlSelect { get; set; }
        [ProtoMember(5)] public  byte[]  IconUrlUnselect { get; set; }
        [ProtoMember(6)] public  Color?  BackgroundColorSelect { get; set; }
        [ProtoMember(7)] public  Color?  BackgroundColorUnselect { get; set; }
    } 

    [ProtoContract]
    internal class MayKnowPerson{
        [ProtoMember(1)] public  long  Uin { get; set; }
        [ProtoMember(2)] public  AddFriendSource?  MsgIosSource { get; set; }
        [ProtoMember(3)] public  AddFriendSource?  MsgAndroidSource { get; set; }
        [ProtoMember(4)] public  byte[]  Reason { get; set; }
        [ProtoMember(5)] public  byte[]  Additive { get; set; }
        [ProtoMember(6)] public  byte[]  Nick { get; set; }
        [ProtoMember(7)] public  byte[]  Remark { get; set; }
        [ProtoMember(8)] public  byte[]  Country { get; set; }
        [ProtoMember(9)] public  byte[]  Province { get; set; }
        [ProtoMember(10)] public  byte[]  City { get; set; }
        [ProtoMember(11)] public  int  Age { get; set; }
        [ProtoMember(12)] public  byte[]  Catelogue { get; set; }
        [ProtoMember(13)] public  byte[]  Alghrithm { get; set; }
        [ProtoMember(14)] public  byte[]  Richbuffer { get; set; }
        [ProtoMember(15)] public  int  Qzone { get; set; }
        [ProtoMember(16)] public  int  Gender { get; set; }
        [ProtoMember(17)] public  byte[]  MobileName { get; set; }
        [ProtoMember(18)] public  string  Token { get; set; }
        [ProtoMember(19)] public  int  OnlineState { get; set; }
        [ProtoMember(20)] public  List<Label>  MsgLabels { get; set; }
        [ProtoMember(21)] public  int  Sourceid { get; set; }
    } 

    [ProtoContract]
    internal class RecommendInfo{
        [ProtoMember(1)] public  byte[]  Woring { get; set; }
        [ProtoMember(2)] public  List<RgroupInfo>  MsgGroups { get; set; }
    } 

    [ProtoContract]
    internal class RgroupInfo{
        [ProtoMember(1)] public  long  GroupCode { get; set; }
        [ProtoMember(2)] public  long  OwnerUin { get; set; }
        [ProtoMember(3)] public  byte[]  GroupName { get; set; }
        [ProtoMember(4)] public  byte[]  GroupMemo { get; set; }
        [ProtoMember(5)] public  int  MemberNum { get; set; }
        [ProtoMember(6)] public  List<RgoupLabel>  GroupLabel { get; set; }
        [ProtoMember(7)] public  int  GroupFlagExt { get; set; }
        [ProtoMember(8)] public  int  GroupFlag { get; set; }
        [ProtoMember(9)] public  int  Source { get; set; }
        [ProtoMember(10)] public  RgoupLabel?  TagWording { get; set; }
        [ProtoMember(11)] public  byte[]  Algorithm { get; set; }
        [ProtoMember(12)] public  byte[]  JoinGroupAuth { get; set; }
        [ProtoMember(13)] public  int  Activity { get; set; }
        [ProtoMember(14)] public  int  MemberMaxNum { get; set; }
        [ProtoMember(15)] public  int  Int32UinPrivilege { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  List<Long>  FilterUins { get; set; }
        [ProtoMember(2)] public  int  PhoneBook { get; set; }
        [ProtoMember(3)] public  List<Long>  ExpectedUins { get; set; }
        [ProtoMember(4)] public  int  EmEntry { get; set; }
        [ProtoMember(5)] public  int  FetchRgroup { get; set; }
        [ProtoMember(6)] public  int  TabId { get; set; }
        [ProtoMember(7)] public  int  Want { get; set; }
        [ProtoMember(8)] public  byte[]  Cookies { get; set; }
    } 

    [ProtoContract]
    internal class RgroupColor{
        [ProtoMember(1)] public  int  R { get; set; }
        [ProtoMember(2)] public  int  G { get; set; }
        [ProtoMember(3)] public  int  B { get; set; }
    } 

    [ProtoContract]
    internal class Color{
        [ProtoMember(1)] public  int  R { get; set; }
        [ProtoMember(2)] public  int  G { get; set; }
        [ProtoMember(3)] public  int  B { get; set; }
    } 
}

[ProtoContract]
internal class Cmd0xac6  {
    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  List<OperateResult>  Results { get; set; }
        [ProtoMember(4)] public  int  MetalCount { get; set; }
        [ProtoMember(5)] public  int  MetalTotal { get; set; }
        [ProtoMember(9)] public  int  Int32NewCount { get; set; }
        [ProtoMember(10)] public  int  Int32UpgradeCount { get; set; }
        [ProtoMember(11)] public  string  PromptParams { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  List<MedalReport>  Medals { get; set; }
        [ProtoMember(2)] public  int  Clean { get; set; }
    } 

    [ProtoContract]
    internal class MedalReport{
        [ProtoMember(1)] public  int  Id { get; set; }
        [ProtoMember(2)] public  int  Level { get; set; }
    } 

    [ProtoContract]
    internal class OperateResult{
        [ProtoMember(1)] public  int  Id { get; set; }
        [ProtoMember(2)] public  int  Int32Result { get; set; }
        [ProtoMember(3)] public  string  Errmsg { get; set; }
    } 
}

[ProtoContract]
internal class Oidb0xd32  {
    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  string  Openid { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  byte[]  Xmitinfo { get; set; }
    } 

    [ProtoContract]
    internal class XmitInfo{
        [ProtoMember(1)] public  string  Signature { get; set; }
        [ProtoMember(2)] public  string  Appid { get; set; }
        [ProtoMember(3)] public  string  Groupid { get; set; }
        [ProtoMember(4)] public  string  Nonce { get; set; }
        [ProtoMember(5)] public  int  Timestamp { get; set; }
    } 
}

[ProtoContract]
internal class Cmd0x7cf  {
    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  int  Stamp { get; set; }
        [ProtoMember(2)] public  int  Start { get; set; }
        [ProtoMember(3)] public  int  Want { get; set; }
        [ProtoMember(4)] public  int  ReqValidOnly { get; set; }
        [ProtoMember(5)] public  List<AppointDefine.AppointID>  MsgAppointIds { get; set; }
        [ProtoMember(6)] public  int  AppointOperation { get; set; }
        [ProtoMember(100)] public  long  RequestUin { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  int  Stamp { get; set; }
        [ProtoMember(2)] public  int  Over { get; set; }
        [ProtoMember(3)] public  int  Next { get; set; }
        [ProtoMember(4)] public  List<AppointDefine.AppointInfo>  MsgAppointsInfo { get; set; }
        [ProtoMember(5)] public  int  UnreadCount { get; set; }
    } 
}

[ProtoContract]
internal class Cmd0xac7  {
    [ProtoContract]
    internal class DeviceInfo{
        [ProtoMember(1)] public  long  Din { get; set; }
        [ProtoMember(2)] public  byte[]  Name { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  byte[]  Extd { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  int  Cmd { get; set; }
        [ProtoMember(2)] public  long  Din { get; set; }
        [ProtoMember(3)] public  byte[]  Extd { get; set; }
        [ProtoMember(4)] public  BinderSig?  MsgBinderSig { get; set; }
    } 

    [ProtoContract]
    internal class ReceiveMessageDevices{
        [ProtoMember(1)] public  List<DeviceInfo>  Devices { get; set; }
    } 

    [ProtoContract]
    internal class BinderSig{
        [ProtoMember(1)] public  int  Type { get; set; }
        [ProtoMember(2)] public  long  Uin { get; set; }
        [ProtoMember(3)] public  byte[]  Sig { get; set; }
    } 
}

[ProtoContract]
internal class Cmd0x5fa  {
    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  List<AppointDefine.StrangerInfo>  MsgStrangerInfo { get; set; }
        [ProtoMember(2)] public  int  ReachStart { get; set; }
        [ProtoMember(3)] public  int  ReachEnd { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  AppointDefine.AppointID?  AppointIds { get; set; }
        [ProtoMember(2)] public  int  ReferIdx { get; set; }
        [ProtoMember(3)] public  int  GetReferRec { get; set; }
        [ProtoMember(4)] public  int  ReqNextCount { get; set; }
        [ProtoMember(5)] public  int  ReqPrevCount { get; set; }
    } 
}

[ProtoContract]
internal class FavoriteCKVData  {
    [ProtoContract]
    internal class PicInfo{
        [ProtoMember(1)] public  byte[]  Uri { get; set; }
        [ProtoMember(2)] public  byte[]  Md5 { get; set; }
        [ProtoMember(3)] public  byte[]  Sha1 { get; set; }
        [ProtoMember(4)] public  byte[]  Name { get; set; }
        [ProtoMember(5)] public  byte[]  Note { get; set; }
        [ProtoMember(6)] public  int  Width { get; set; }
        [ProtoMember(7)] public  int  Height { get; set; }
        [ProtoMember(8)] public  int  Size { get; set; }
        [ProtoMember(9)] public  int  Type { get; set; }
        [ProtoMember(10)] public  Author?  MsgOwner { get; set; }
        [ProtoMember(11)] public  byte[]  PicId { get; set; }
    } 

    [ProtoContract]
    internal class KandianFavoriteItem{
        [ProtoMember(1)] public  KandianFavoriteBizData?  MsgFavoriteExtInfo { get; set; }
        [ProtoMember(2)] public  List<byte[]>  BytesCid { get; set; }
        [ProtoMember(3)] public  int  Type { get; set; }
        [ProtoMember(4)] public  int  Status { get; set; }
        [ProtoMember(5)] public  Author?  MsgAuthor { get; set; }
        [ProtoMember(6)] public  long  CreateTime { get; set; }
        [ProtoMember(7)] public  long  FavoriteTime { get; set; }
        [ProtoMember(8)] public  long  ModifyTime { get; set; }
        [ProtoMember(9)] public  long  DataSyncTime { get; set; }
        [ProtoMember(10)] public  FavoriteSummary?  MsgFavoriteSummary { get; set; }
    } 

    [ProtoContract]
    internal class LinkSummary{
        [ProtoMember(1)] public  byte[]  Uri { get; set; }
        [ProtoMember(2)] public  byte[]  Title { get; set; }
        [ProtoMember(3)] public  byte[]  Publisher { get; set; }
        [ProtoMember(4)] public  byte[]  Brief { get; set; }
        [ProtoMember(5)] public  List<PicInfo>  MsgPicInfo { get; set; }
        [ProtoMember(6)] public  byte[]  Type { get; set; }
        [ProtoMember(7)] public  byte[]  ResourceUri { get; set; }
    } 

    [ProtoContract]
    internal class UserFavoriteList{
        [ProtoMember(1)] public  long  Uin { get; set; }
        [ProtoMember(2)] public  long  ModifyTs { get; set; }
        [ProtoMember(100)] public  List<FavoriteItem>  MsgFavoriteItems { get; set; }
    } 

    [ProtoContract]
    internal class FavoriteSummary{
        [ProtoMember(2)] public  LinkSummary?  MsgLinkSummary { get; set; }
    } 

    [ProtoContract]
    internal class FavoriteItem{
        [ProtoMember(1)] public  int  FavoriteSource { get; set; }
        [ProtoMember(100)] public  KandianFavoriteItem?  MsgKandianFavoriteItem { get; set; }
    } 

    [ProtoContract]
    internal class Author{
        [ProtoMember(1)] public  int  Type { get; set; }
        [ProtoMember(2)] public  long  NumId { get; set; }
        [ProtoMember(3)] public  byte[]  StrId { get; set; }
        [ProtoMember(4)] public  long  GroupId { get; set; }
        [ProtoMember(5)] public  byte[]  GroupName { get; set; }
    } 

    [ProtoContract]
    internal class KandianFavoriteBizData{
        [ProtoMember(1)] public  byte[]  Rowkey { get; set; }
        [ProtoMember(2)] public  int  Type { get; set; }
        [ProtoMember(3)] public  int  VideoDuration { get; set; }
        [ProtoMember(4)] public  int  PicNum { get; set; }
        [ProtoMember(5)] public  long  AccountId { get; set; }
        [ProtoMember(6)] public  byte[]  AccountName { get; set; }
        [ProtoMember(7)] public  int  VideoType { get; set; }
        [ProtoMember(8)] public  long  FeedsId { get; set; }
        [ProtoMember(9)] public  int  FeedsType { get; set; }
    } 
}

[ProtoContract]
internal class Cmd0x5ff  {
    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  string  ErrorTips { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  AppointDefine.AppointID?  MsgAppointId { get; set; }
        [ProtoMember(2)] public  string  CommentId { get; set; }
    } 
}

[ProtoContract]
internal class Oidb0xccd  {
    [ProtoContract]
    internal class Result{
        [ProtoMember(1)] public  int  Appid { get; set; }
        [ProtoMember(2)] public  int  Errcode { get; set; }
        [ProtoMember(3)] public  string  Errmsg { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  long  Int64Uin { get; set; }
        [ProtoMember(2)] public  List<int>  Appids { get; set; }
        [ProtoMember(3)] public  int  Platform { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  int  Errcode { get; set; }
        [ProtoMember(2)] public  List<Result>  Results { get; set; }
    } 
}

[ProtoContract]
internal class Oidb0xc36  {
    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  List<Long>  Uint64Uins { get; set; }
    } 

    [ProtoContract]
    internal class RspBody 
}

[ProtoContract]
internal class Oidb0x87c  {
    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  string  Country { get; set; }
        [ProtoMember(2)] public  string  Telephone { get; set; }
        [ProtoMember(3)] public  string  SmsCode { get; set; }
        [ProtoMember(4)] public  byte[]  Guid { get; set; }
        [ProtoMember(5)] public  int  EnumButype { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  string  Country { get; set; }
        [ProtoMember(2)] public  string  Telephone { get; set; }
        [ProtoMember(3)] public  int  KeyType { get; set; }
        [ProtoMember(4)] public  byte[]  Key { get; set; }
        [ProtoMember(5)] public  byte[]  Guid { get; set; }
    } 
}

[ProtoContract]
internal class Cmd0xbf2  {
    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  List<PhoneAddrBook>  PhoneAddrBook { get; set; }
        [ProtoMember(2)] public  int  End { get; set; }
        [ProtoMember(3)] public  long  NextIndex { get; set; }
    } 

    [ProtoContract]
    internal class PhoneAddrBook{
        [ProtoMember(1)] public  string  Phone { get; set; }
        [ProtoMember(2)] public  string  Nick { get; set; }
        [ProtoMember(3)] public  string  HeadUrl { get; set; }
        [ProtoMember(4)] public  string  LongNick { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  long  Uin { get; set; }
        [ProtoMember(2)] public  long  StartIndex { get; set; }
        [ProtoMember(3)] public  long  Num { get; set; }
    } 
}

[ProtoContract]
internal class Cmd0x6cd  {
    [ProtoContract]
    internal class RedpointInfo{
        [ProtoMember(1)] public  int  Taskid { get; set; }
        [ProtoMember(2)] public  long  CurSeq { get; set; }
        [ProtoMember(3)] public  long  PullSeq { get; set; }
        [ProtoMember(4)] public  long  ReadSeq { get; set; }
        [ProtoMember(5)] public  int  PullTimes { get; set; }
        [ProtoMember(6)] public  int  LastPullTime { get; set; }
        [ProtoMember(7)] public  int  Int32RemainedTime { get; set; }
        [ProtoMember(8)] public  int  LastRecvTime { get; set; }
        [ProtoMember(9)] public  long  FromId { get; set; }
        [ProtoMember(10)] public  int  EnumRedpointType { get; set; }
        [ProtoMember(11)] public  RepointExtraInfo?  MsgRedpointExtraInfo { get; set; }
        [ProtoMember(12)] public  string  ConfigVersion { get; set; }
        [ProtoMember(13)] public  int  DoActivity { get; set; }
        [ProtoMember(14)] public  List<MessageRec>  MsgUnreadMsg { get; set; }
    } 

    [ProtoContract]
    internal class PullRedpointReq{
        [ProtoMember(1)] public  int  Taskid { get; set; }
        [ProtoMember(2)] public  long  LastPullSeq { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  List<RedpointInfo>  MsgRedpoint { get; set; }
        [ProtoMember(2)] public  List<PullRedpointReq>  UnfinishedRedpoint { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  List<PullRedpointReq>  LastPullRedpoint { get; set; }
        [ProtoMember(2)] public  List<PullRedpointReq>  UnfinishedRedpoint { get; set; }
        [ProtoMember(3)] public  PullRedpointReq?  MsgPullSingleTask { get; set; }
        [ProtoMember(4)] public  int  RetMsgRec { get; set; }
    } 

    [ProtoContract]
    internal class MessageRec{
        [ProtoMember(1)] public  long  Seq { get; set; }
        [ProtoMember(2)] public  int  Time { get; set; }
        [ProtoMember(3)] public  byte[]  Content { get; set; }
    } 

    [ProtoContract]
    internal class RepointExtraInfo{
        [ProtoMember(1)] public  int  Count { get; set; }
        [ProtoMember(2)] public  string  IconUrl { get; set; }
        [ProtoMember(3)] public  string  Tips { get; set; }
        [ProtoMember(4)] public  byte[]  Data { get; set; }
    } 
}

[ProtoContract]
internal class Oidb0xd55  {
    [ProtoContract]
    internal class CheckUserRsp{
        [ProtoMember(1)] public  long  OpenidUin { get; set; }
    } 

    [ProtoContract]
    internal class CheckMiniAppRsp 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  long  Appid { get; set; }
        [ProtoMember(2)] public  int  AppType { get; set; }
        [ProtoMember(3)] public  int  SrcId { get; set; }
        [ProtoMember(4)] public  string  RawUrl { get; set; }
        [ProtoMember(11)] public  CheckAppSignReq?  CheckAppSignReq { get; set; }
        [ProtoMember(12)] public  CheckUserReq?  CheckUserReq { get; set; }
        [ProtoMember(13)] public  CheckMiniAppReq?  CheckMiniAppReq { get; set; }
    } 

    [ProtoContract]
    internal class CheckAppSignReq{
        [ProtoMember(1)] public  Qqconnect.ConnectClientInfo?  ClientInfo { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  string  Wording { get; set; }
        [ProtoMember(11)] public  CheckAppSignRsp?  CheckAppSignRsp { get; set; }
        [ProtoMember(12)] public  CheckUserRsp?  CheckUserRsp { get; set; }
        [ProtoMember(13)] public  CheckMiniAppRsp?  CheckMiniAppRsp { get; set; }
    } 

    [ProtoContract]
    internal class CheckUserReq{
        [ProtoMember(1)] public  string  Openid { get; set; }
        [ProtoMember(2)] public  int  NeedCheckSameUser { get; set; }
    } 

    [ProtoContract]
    internal class CheckMiniAppReq{
        [ProtoMember(1)] public  long  MiniAppAppid { get; set; }
        [ProtoMember(2)] public  int  NeedCheckBind { get; set; }
    } 

    [ProtoContract]
    internal class CheckAppSignRsp{
        [ProtoMember(1)] public  string  IosAppToken { get; set; }
        [ProtoMember(2)] public  string  IosUniversalLink { get; set; }
        [ProtoMember(11)] public  int  OptimizeSwitch { get; set; }
    } 
}

[ProtoContract]
internal class Cmd0x8b4  {
    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  long  Gc { get; set; }
        [ProtoMember(2)] public  long  Guin { get; set; }
        [ProtoMember(3)] public  int  Flag { get; set; }
        [ProtoMember(21)] public  long  DstUin { get; set; }
        [ProtoMember(22)] public  int  Start { get; set; }
        [ProtoMember(23)] public  int  Cnt { get; set; }
        [ProtoMember(24)] public  byte[]  Tag { get; set; }
    } 

    [ProtoContract]
    internal class GroupInfo{
        [ProtoMember(1)] public  long  Gc { get; set; }
        [ProtoMember(2)] public  string  GroupName { get; set; }
        [ProtoMember(3)] public  string  FaceUrl { get; set; }
        [ProtoMember(4)] public  int  SetDisplayTime { get; set; }
        // @SerialId(5)] public groupLabel: List<GroupLabel.Label> = emptyList(),
        [ProtoMember(6)] public  byte[]  TextIntro { get; set; }
        [ProtoMember(7)] public  byte[]  RichIntro { get; set; }
    } 

    [ProtoContract]
    internal class TagInfo{
        [ProtoMember(1)] public  long  DstUin { get; set; }
        [ProtoMember(2)] public  int  Start { get; set; }
        [ProtoMember(3)] public  int  Cnt { get; set; }
        [ProtoMember(4)] public  int  Timestamp { get; set; }
        [ProtoMember(5)] public  int  _0x7ddSeq { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  int  Result { get; set; }
        [ProtoMember(2)] public  int  Flag { get; set; }
        [ProtoMember(21)] public  byte[]  Tag { get; set; }
        [ProtoMember(22)] public  List<GroupInfo>  GroupInfo { get; set; }
        [ProtoMember(23)] public  List<byte[]>  TextLabel { get; set; }
    } 
}

[ProtoContract]
internal class Cmd0x682  {
    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  List<ChatInfo>  MsgChatinfo { get; set; }
    } 

    [ProtoContract]
    internal class ChatInfo{
        [ProtoMember(1)] public  long  Touin { get; set; }
        [ProtoMember(2)] public  int  Chatflag { get; set; }
        [ProtoMember(3)] public  int  Goldflag { get; set; }
        [ProtoMember(4)] public  int  Totalexpcount { get; set; }
        [ProtoMember(5)] public  int  Curexpcount { get; set; }
        [ProtoMember(6)] public  int  TotalFlag { get; set; }
        [ProtoMember(7)] public  int  CurdayFlag { get; set; }
        [ProtoMember(8)] public  byte[]  ExpressTipsMsg { get; set; }
        [ProtoMember(9)] public  byte[]  ExpressMsg { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  List<Long>  Uint64Touinlist { get; set; }
    } 
}

[ProtoContract]
internal class Cmd0x6f5  {
    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  string  QqVersion { get; set; }
        [ProtoMember(2)] public  int  QqPlatform { get; set; }
    } 

    [ProtoContract]
    internal class TaskInfo{
        [ProtoMember(1)] public  int  TaskId { get; set; }
        [ProtoMember(2)] public  int  Appid { get; set; }
        [ProtoMember(3)] public  int  PassthroughLevel { get; set; }
        [ProtoMember(4)] public  int  ShowLevel { get; set; }
        [ProtoMember(5)] public  int  Extra { get; set; }
        [ProtoMember(6)] public  int  Priority { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  string  ConfigVersion { get; set; }
        [ProtoMember(2)] public  List<TaskInfo>  TaskInfo { get; set; }
    } 
}

[ProtoContract]
internal class Oidb0xb7e  {
    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  List<DiandianTopConfig>  TopItem { get; set; }
    } 

    [ProtoContract]
    internal class DiandianTopConfig{
        [ProtoMember(1)] public  byte[]  JumpUrl { get; set; }
        [ProtoMember(2)] public  byte[]  Title { get; set; }
        [ProtoMember(3)] public  byte[]  SubTitle { get; set; }
        [ProtoMember(4)] public  byte[]  SubTitleColor { get; set; }
        [ProtoMember(5)] public  byte[]  PicUrl { get; set; }
        [ProtoMember(6)] public  int  Type { get; set; }
        [ProtoMember(7)] public  int  TopicId { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody 
}

[ProtoContract]
internal class Oidb0xc2f  {
    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  GetFollowUserRecommendListRsp?  MsgGetFollowUserRecommendListRsp { get; set; }
    } 

    [ProtoContract]
    internal class GetFollowUserRecommendListReq{
        [ProtoMember(1)] public  long  FollowedUin { get; set; }
    } 

    [ProtoContract]
    internal class RecommendAccountInfo{
        [ProtoMember(1)] public  long  Uin { get; set; }
        [ProtoMember(2)] public  int  AccountType { get; set; }
        [ProtoMember(3)] public  byte[]  NickName { get; set; }
        [ProtoMember(4)] public  byte[]  HeadImgUrl { get; set; }
        [ProtoMember(5)] public  int  IsVip { get; set; }
        [ProtoMember(6)] public  int  IsStar { get; set; }
        [ProtoMember(7)] public  byte[]  RecommendReason { get; set; }
    } 

    [ProtoContract]
    internal class GetFollowUserRecommendListRsp{
        [ProtoMember(1)] public  List<RecommendAccountInfo>  MsgRecommendList { get; set; }
        [ProtoMember(2)] public  byte[]  JumpUrl { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  GetFollowUserRecommendListReq?  MsgGetFollowUserRecommendListReq { get; set; }
    } 
}

[ProtoContract]
internal class Cmd0x7ca  {
    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  AppointDefine.AppointID?  MsgAppointId { get; set; }
        [ProtoMember(2)] public  long  Tinyid { get; set; }
        [ProtoMember(3)] public  int  OpType { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  byte[]  SigC2C { get; set; }
        [ProtoMember(2)] public  long  PeerUin { get; set; }
        [ProtoMember(3)] public  string  ErrorWording { get; set; }
        [ProtoMember(4)] public  int  OpType { get; set; }
    } 
}

[ProtoContract]
internal class Cmd0xd40  {
    [ProtoContract]
    internal class DeviceInfo{
        [ProtoMember(1)] public  int  Os { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  DeviceInfo?  Dev { get; set; }
        [ProtoMember(2)] public  int  Src { get; set; }
        [ProtoMember(3)] public  int  Event { get; set; }
        [ProtoMember(4)] public  int  Redtype { get; set; }
    } 

    [ProtoContract]
    internal class RspBody 
}

[ProtoContract]
internal class Cmd0x6ce  {
    [ProtoContract]
    internal class RspBody 

    [ProtoContract]
    internal class ReadRedpointReq{
        [ProtoMember(1)] public  int  Taskid { get; set; }
        [ProtoMember(2)] public  long  ReadSeq { get; set; }
        [ProtoMember(3)] public  int  Appid { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  List<ReadRedpointReq>  MsgReadReq { get; set; }
    } 
}

[ProtoContract]
internal class Cmd0xed3  {
    [ProtoContract]
    internal class RspBody 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  long  ToUin { get; set; }
        [ProtoMember(2)] public  long  GroupCode { get; set; }
        [ProtoMember(3)] public  int  MsgSeq { get; set; }
        [ProtoMember(4)] public  int  MsgRandom { get; set; }
        [ProtoMember(5)] public  long  AioUin { get; set; }
    } 
}
