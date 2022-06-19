using System.Collections.Generic;
using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

[ProtoContract]
internal class MsgComm
{
    [ProtoContract]
    internal class AppShareInfo
    {
        [ProtoMember(1)] public int AppshareId { get; set; }
        [ProtoMember(2)] public byte[] AppshareCookie { get; set; }
        [ProtoMember(3)] public PluginInfo? AppshareResource { get; set; }
    }

    [ProtoContract]
    internal class C2CTmpMsgHead
    {
        [ProtoMember(1)] public int C2cType { get; set; }
        [ProtoMember(2)] public int ServiceType { get; set; }
        [ProtoMember(3)] public long GroupUin { get; set; }
        [ProtoMember(4)] public long GroupCode { get; set; }
        [ProtoMember(5)] public byte[] Sig { get; set; }
        [ProtoMember(6)] public int SigType { get; set; }
        [ProtoMember(7)] public string FromPhone { get; set; }
        [ProtoMember(8)] public string ToPhone { get; set; }
        [ProtoMember(9)] public int LockDisplay { get; set; }
        [ProtoMember(10)] public int DirectionFlag { get; set; }
        [ProtoMember(11)] public byte[] Reserved { get; set; }
    }

    [ProtoContract]
    internal class ContentHead
    {
        [ProtoMember(1)] public int PkgNum { get; set; }
        [ProtoMember(2)] public int PkgIndex { get; set; }
        [ProtoMember(3)] public int DivSeq { get; set; }
        [ProtoMember(4)] public int AutoReply { get; set; }
    }

    [ProtoContract]
    internal class DiscussInfo
    {
        [ProtoMember(1)] public long DiscussUin { get; set; }
        [ProtoMember(2)] public int DiscussType { get; set; }
        [ProtoMember(3)] public long DiscussInfoSeq { get; set; }
        [ProtoMember(4)] public byte[] DiscussRemark { get; set; }
        [ProtoMember(5)] public byte[] DiscussName { get; set; }
    }

    [ProtoContract]
    internal class ExtGroupKeyInfo
    {
        [ProtoMember(1)] public int CurMaxSeq { get; set; }
        [ProtoMember(2)] public long CurTime { get; set; }
    }

    [ProtoContract]
    internal class GroupInfo
    {
        [ProtoMember(1)] public long GroupCode { get; set; }
        [ProtoMember(2)] public int GroupType { get; set; }
        [ProtoMember(3)] public long GroupInfoSeq { get; set; }
        [ProtoMember(4)] public string GroupCard { get; set; }
        [ProtoMember(5)] public byte[] GroupRank { get; set; }
        [ProtoMember(6)] public int GroupLevel { get; set; }
        [ProtoMember(7)] public int GroupCardType { get; set; }
        [ProtoMember(8)] public byte[] GroupName { get; set; }
    }

    [ProtoContract]
    internal class Msg
    {
        [ProtoMember(1)] public MsgHead MsgHead { get; set; }
        [ProtoMember(2)] public ContentHead? ContentHead { get; set; }
        [ProtoMember(3)] public ImMsgBody.MsgBody MsgBody { get; set; }
        [ProtoMember(4)] public AppShareInfo? AppshareInfo { get; set; }
    }

    [ProtoContract]
    internal class MsgHead
    {
        [ProtoMember(1)] public long FromUin { get; set; }
        [ProtoMember(2)] public long ToUin { get; set; }
        [ProtoMember(3)] public int MsgType { get; set; }
        [ProtoMember(4)] public int C2cCmd { get; set; }
        [ProtoMember(5)] public int MsgSeq { get; set; }
        [ProtoMember(6)] public int MsgTime { get; set; }
        [ProtoMember(7)] public long MsgUid { get; set; }
        [ProtoMember(8)] public C2CTmpMsgHead? C2cTmpMsgHead { get; set; }
        [ProtoMember(9)] public GroupInfo? GroupInfo { get; set; }
        /**
         * 1: 群消息 by pc tim
         * 1001: 群消息 sent by android phone
         *
         *
         * 3116: music share, ANDROID_PHONE 发送
         */
        [ProtoMember(10)] public int FromAppid { get; set; }
        [ProtoMember(11)] public int FromInstid { get; set; }
        [ProtoMember(12)] public int UserActive { get; set; }
        [ProtoMember(13)] public DiscussInfo? DiscussInfo { get; set; }
        [ProtoMember(14)] public string FromNick { get; set; }
        [ProtoMember(15)] public long AuthUin { get; set; }
        [ProtoMember(16)] public string AuthNick { get; set; }
        [ProtoMember(17)] public int MsgFlag { get; set; }
        [ProtoMember(18)] public string AuthRemark { get; set; }
        [ProtoMember(19)] public string GroupName { get; set; }
        [ProtoMember(20)] public MutilTransHead? MutiltransHead { get; set; }
        [ProtoMember(21)] public ImMsgHead.InstCtrl? MsgInstCtrl { get; set; }
        [ProtoMember(22)] public int PublicAccountGroupSendFlag { get; set; }
        [ProtoMember(23)] public int WseqInC2cMsghead { get; set; }
        [ProtoMember(24)] public long Cpid { get; set; }
        [ProtoMember(25)] public ExtGroupKeyInfo? ExtGroupKeyInfo { get; set; }
        [ProtoMember(26)] public string MultiCompatibleText { get; set; }
        [ProtoMember(27)] public int AuthSex { get; set; }
        [ProtoMember(28)] public bool IsSrcMsg { get; set; }
    }

    [ProtoContract]
    internal class MsgType0x210
    {
        [ProtoMember(1)] public int SubMsgType { get; set; }
        [ProtoMember(2)] public byte[] MsgContent { get; set; }
    }

    [ProtoContract]
    internal class MutilTransHead
    {
        [ProtoMember(1)] public int Status { get; set; }
        [ProtoMember(2)] public int MsgId { get; set; }
    }

    [ProtoContract]
    internal class PluginInfo
    {
        [ProtoMember(1)] public int ResId { get; set; }
        [ProtoMember(2)] public string PkgName { get; set; }
        [ProtoMember(3)] public int NewVer { get; set; }
        [ProtoMember(4)] public int ResType { get; set; }
        [ProtoMember(5)] public int LanType { get; set; }
        [ProtoMember(6)] public int Priority { get; set; }
        [ProtoMember(7)] public string ResName { get; set; }
        [ProtoMember(8)] public string ResDesc { get; set; }
        [ProtoMember(9)] public string ResUrlBig { get; set; }
        [ProtoMember(10)] public string ResUrlSmall { get; set; }
        [ProtoMember(11)] public string ResConf { get; set; }
    }

    [ProtoContract]
    internal class Uin2Nick
    {
        [ProtoMember(1)] public long Uin { get; set; }
        [ProtoMember(2)] public string Nick { get; set; }
    }

    [ProtoContract]
    internal class UinPairMsg
    {
        [ProtoMember(1)] public int LastReadTime { get; set; }
        [ProtoMember(2)] public long PeerUin { get; set; }
        [ProtoMember(3)] public int MsgCompleted { get; set; }
        [ProtoMember(4)] public List<Msg> Msg { get; set; }
        [ProtoMember(5)] public int UnreadMsgNum { get; set; }
        [ProtoMember(8)] public int C2cType { get; set; }
        [ProtoMember(9)] public int ServiceType { get; set; }
        [ProtoMember(10)] public byte[] PbReserve { get; set; }
    }
}
