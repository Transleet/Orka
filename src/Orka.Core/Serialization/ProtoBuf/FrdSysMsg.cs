using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

internal class FrdSysMsg {
    [ProtoContract]
    internal class AddFrdSNInfo{
        [ProtoMember(1)] public  int  NotSeeDynamic { get; set; }
        [ProtoMember(2)] public  int  SetSn { get; set; }
    } 

    [ProtoContract]
    internal class AddFriendVerifyInfo{
        [ProtoMember(1)] public  int  Type { get; set; }
        [ProtoMember(2)] public  string  Url { get; set; }
        [ProtoMember(3)] public  string  VerifyInfo { get; set; }
    } 

    [ProtoContract]
    internal class AddtionInfo{
        [ProtoMember(1)] public  int  Poke { get; set; }
        [ProtoMember(2)] public  int  Format { get; set; }
        [ProtoMember(3)] public  string  EntityCategory { get; set; }
        [ProtoMember(4)] public  string  EntityName { get; set; }
        [ProtoMember(5)] public  string  EntityUrl { get; set; }
    } 

    [ProtoContract]
    internal class DiscussInfo{
        [ProtoMember(1)] public  long  DiscussUin { get; set; }
        [ProtoMember(2)] public  string  DiscussName { get; set; }
        [ProtoMember(3)] public  string  DiscussNick { get; set; }
    } 

    [ProtoContract]
    internal class EimInfo{
        [ProtoMember(1)] public  long  EimFuin { get; set; }
        [ProtoMember(2)] public  string  EimId { get; set; }
        [ProtoMember(3)] public  string  EimTelno { get; set; }
        [ProtoMember(4)] public  long  GroupId { get; set; }
    } 

    [ProtoContract]
    internal class FriendHelloInfo{
        [ProtoMember(1)] public  string  SourceName { get; set; }
    } 

    [ProtoContract]
    internal class FriendMiscInfo{
        [ProtoMember(1)] public  string  FromuinNick { get; set; }
    } 

    [ProtoContract]
    internal class FriendSysMsg{
        [ProtoMember(11)] public  GroupInfoExt?  MsgGroupExt { get; set; }
        [ProtoMember(12)] public  InviteInfo?  MsgIntiteInfo { get; set; }
        [ProtoMember(13)] public  SchoolInfo?  MsgSchoolInfo { get; set; }
        [ProtoMember(100)] public  int  DoubtFlag { get; set; }
    } 

    [ProtoContract]
    internal class GroupInfo{
        [ProtoMember(1)] public  long  GroupUin { get; set; }
        [ProtoMember(2)] public  string  GroupName { get; set; }
        [ProtoMember(3)] public  string  GroupNick { get; set; }
    } 

    [ProtoContract]
    internal class GroupInfoExt{
        [ProtoMember(1)] public  int  NotifyType { get; set; }
        [ProtoMember(2)] public  long  GroupCode { get; set; }
        [ProtoMember(3)] public  int  FromGroupadmlist { get; set; }
    } 

    [ProtoContract]
    internal class InviteInfo{
        [ProtoMember(1)] public  long  RecommendUin { get; set; }
    } 

    [ProtoContract]
    internal class MsgEncodeFlag{
        [ProtoMember(1)] public  int  IsUtf8 { get; set; }
    } 

    [ProtoContract]
    internal class SchoolInfo{
        [ProtoMember(1)] public  string  SchoolId { get; set; }
        [ProtoMember(2)] public  string  SchoolName { get; set; }
    } 

    [ProtoContract]
    internal class TongXunLuNickInfo{
        [ProtoMember(1)] public  long  Fromuin { get; set; }
        [ProtoMember(2)] public  long  Touin { get; set; }
        [ProtoMember(3)] public  string  TongxunluNickname { get; set; }
    } 
}
