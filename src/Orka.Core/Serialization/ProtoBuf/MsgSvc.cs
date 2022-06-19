using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

[ProtoContract]
internal class MsgSvc
{
    [ProtoContract]
    internal class Grp
    {
        [ProtoMember(1)] public long GroupCode { get; set; }
    }

    [ProtoContract]
    internal class PbGetMsgResp
    {
        [ProtoMember(1)] public int Result { get; set; }
        [ProtoMember(2)] public string Errmsg { get; set; }
        [ProtoMember(3)] public byte[]? SyncCookie { get; set; }
        [ProtoMember(4)] public SyncFlag SyncFlag { get; set; }
        [ProtoMember(5)] public List<MsgComm.UinPairMsg> UinPairMsgs { get; set; }
        [ProtoMember(6)] public long BindUin { get; set; }
        [ProtoMember(7)] public int MsgRspType { get; set; }
        [ProtoMember(8)] public byte[] PubAccountCookie { get; set; }
        [ProtoMember(9)] public bool IsPartialSync { get; set; }
        [ProtoMember(10)] public byte[] MsgCtrlBuf { get; set; }
    }

    [ProtoContract]
    internal class PbGroupMsgWithDrawReq
    {
        [ProtoMember(1)] public int SubCmd { get; set; }
        [ProtoMember(2)] public int GroupType { get; set; }
        [ProtoMember(3)] public long GroupCode { get; set; }
        [ProtoMember(4)] public List<MessageInfo> MsgList { get; set; }
        [ProtoMember(5)] public byte[] Userdef { get; set; }
    }
    [ProtoContract]
    internal class MessageInfo
    {
        [ProtoMember(1)] public int MsgSeq { get; set; }
        [ProtoMember(2)] public int MsgRandom { get; set; }
        [ProtoMember(3)] public int MsgType { get; set; }
    }
}

[ProtoContract]
internal class PbGroupReadedReportReq
{
    [ProtoMember(1)] public long GroupCode { get; set; }
    [ProtoMember(2)] public long LastReadSeq { get; set; }
}

[ProtoContract]
internal class BusinessWPATmp
{
    [ProtoMember(1)] public long ToUin { get; set; }
    [ProtoMember(2)] public byte[] Sig { get; set; }
    [ProtoMember(3)] public byte[] Sigt { get; set; }
}

[ProtoContract]
internal class C2C
{
    [ProtoMember(1)] public long ToUin { get; set; }
}

[ProtoContract]
internal class PbGetGroupMsgReq
{
    [ProtoMember(1)] public long GroupCode { get; set; }
    [ProtoMember(2)] public long BeginSeq { get; set; }
    [ProtoMember(3)] public long EndSeq { get; set; }
    [ProtoMember(4)] public int Filter { get; set; }
    [ProtoMember(5)] public long MemberSeq { get; set; }
    [ProtoMember(6)] public bool PublicGroup { get; set; }
    [ProtoMember(7)] public int ShieldFlag { get; set; }
    [ProtoMember(8)] public int SaveTrafficFlag { get; set; }
}

[ProtoContract]
internal class PbBindUinMsgReadedConfirmReq
{
    [ProtoMember(1)] public byte[] SyncCookie { get; set; }
    [ProtoMember(2)] public long BindUin { get; set; }
}

[ProtoContract]
internal class AccostTmp
{
    [ProtoMember(1)] public long ToUin { get; set; }
    [ProtoMember(2)] public byte[] Sig { get; set; }
    [ProtoMember(3)] public bool Reply { get; set; }
}

[ProtoContract]
internal class PbDiscussReadedReportResp
{
    [ProtoMember(1)] public int Result { get; set; }
    [ProtoMember(2)] public string Errmsg { get; set; }
    [ProtoMember(3)] public long ConfUin { get; set; }
    [ProtoMember(4)] public long MemberSeq { get; set; }
    [ProtoMember(5)] public long ConfSeq { get; set; }
}

[ProtoContract]
internal class NearByAssistantTmp
{
    [ProtoMember(1)] public long ToUin { get; set; }
    [ProtoMember(2)] public byte[] Sig { get; set; }
    [ProtoMember(3)] public bool Reply { get; set; }
}

[ProtoContract]
internal class MsgSendInfo
{
    [ProtoMember(1)] public int Receiver { get; set; }
}

[ProtoContract]
internal class PubGroupTmp
{
    [ProtoMember(1)] public long ToUin { get; set; }
    [ProtoMember(2)] public byte[] Sig { get; set; }
    [ProtoMember(3)] public long GroupUin { get; set; }
}

[ProtoContract]
internal class AddressListTmp
{
    [ProtoMember(1)] public string FromPhone { get; set; }
    [ProtoMember(2)] public string ToPhone { get; set; }
    [ProtoMember(3)] public long ToUin { get; set; }
    [ProtoMember(4)] public byte[] Sig { get; set; }
    [ProtoMember(5)] public int FromContactSize { get; set; }
}

[ProtoContract]
internal class DisTmp
{
    [ProtoMember(1)] public long DisUin { get; set; }
    [ProtoMember(2)] public long ToUin { get; set; }
}

[ProtoContract]
internal class PbMsgWithDrawResp
{
    [ProtoMember(1)] public List<PbC2CMsgWithDrawResp> C2cWithDraw { get; set; }
    [ProtoMember(2)] public List<PbGroupMsgWithDrawResp> GroupWithDraw { get; set; }
}

[ProtoContract]
internal class AuthTmp
{
    [ProtoMember(1)] public long ToUin { get; set; }
    [ProtoMember(2)] public byte[] Sig { get; set; }
}

[ProtoContract]
internal class PbMsgWithDrawReq
{
    [ProtoMember(1)] public List<PbC2CMsgWithDrawReq> C2cWithDraw { get; set; }
    [ProtoMember(2)] public List<MsgSvc.PbGroupMsgWithDrawReq> GroupWithDraw { get; set; }
}

internal enum SyncFlag
{
    START,
    CONTINUE,
    STOP
}

[ProtoContract]
internal class PbGetMsgReq
{
    [ProtoMember(1)] public SyncFlag SyncFlag { get; set; }
    [ProtoMember(2)] public byte[] SyncCookie { get; set; }
    [ProtoMember(3)] public int RambleFlag { get; set; }
    [ProtoMember(4)] public int LatestRambleNumber { get; set; }
    [ProtoMember(5)] public int OtherRambleNumber { get; set; }
    [ProtoMember(6)] public int OnlineSyncFlag { get; set; }
    [ProtoMember(7)] public int ContextFlag { get; set; }
    [ProtoMember(8)] public int WhisperSessionId { get; set; }
    [ProtoMember(9)] public int MsgReqType { get; set; }
    [ProtoMember(10)] public byte[] PubaccountCookie { get; set; }
    [ProtoMember(11)] public byte[] MsgCtrlBuf { get; set; }
    [ProtoMember(12)] public byte[] ServerBuf { get; set; }
}

[ProtoContract]
internal class PbGetOneDayRoamMsgReq
{
    [ProtoMember(1)] public long PeerUin { get; set; }
    [ProtoMember(2)] public long LastMsgtime { get; set; }
    [ProtoMember(3)] public long Random { get; set; }
    [ProtoMember(4)] public int ReadCnt { get; set; }
}

[ProtoContract]
internal class GrpTmp
{
    [ProtoMember(1)] public long GroupUin { get; set; }
    [ProtoMember(2)] public long ToUin { get; set; }
}

[ProtoContract]
internal class PbGetDiscussMsgResp
{
    [ProtoMember(1)] public int Result { get; set; }
    [ProtoMember(2)] public string Errmsg { get; set; }
    [ProtoMember(3)] public long DiscussUin { get; set; }
    [ProtoMember(4)] public long ReturnEndSeq { get; set; }
    [ProtoMember(5)] public long ReturnBeginSeq { get; set; }
    [ProtoMember(6)] public List<MsgComm.Msg> Msg { get; set; }
    [ProtoMember(7)] public long LastGetTime { get; set; }
    [ProtoMember(8)] public long DiscussInfoSeq { get; set; }
}

[ProtoContract]
internal class CommTmp
{
    [ProtoMember(1)] public long ToUin { get; set; }
    [ProtoMember(2)] public int C2cType { get; set; }
    [ProtoMember(3)] public int SvrType { get; set; }
    [ProtoMember(4)] public byte[] Sig { get; set; }
    [ProtoMember(5)] public byte[] Reserved { get; set; }
}

[ProtoContract]
internal class PbGroupMsgWithDrawResp
{
    [ProtoMember(1)] public int Result { get; set; }
    [ProtoMember(2)] public string Errmsg { get; set; }
    [ProtoMember(3)] public int SubCmd { get; set; }
    [ProtoMember(4)] public int GroupType { get; set; }
    [ProtoMember(5)] public long GroupCode { get; set; }
    [ProtoMember(6)] public List<MessageResult> FailedMsgList { get; set; }
    [ProtoMember(7)] public byte[] Userdef { get; set; }
}
[ProtoContract]
internal class MessageResult
{
    [ProtoMember(1)] public int Result { get; set; }
    [ProtoMember(2)] public int MsgSeq { get; set; }
    [ProtoMember(3)] public int MsgTime { get; set; }
    [ProtoMember(4)] public int MsgRandom { get; set; }
    [ProtoMember(5)] public byte[] ErrMsg { get; set; }
    [ProtoMember(6)] public int MsgType { get; set; }
} 
}

[ProtoContract]
internal class PbC2CReadedReportResp
{
    [ProtoMember(1)] public int Result { get; set; }
    [ProtoMember(2)] public string Errmsg { get; set; }
    [ProtoMember(3)] public byte[] SyncCookie { get; set; }
}

[ProtoContract]
internal class PbC2CUnReadMsgNumReq

[ProtoContract]
internal class PbC2CMsgWithDrawReq
{
    [ProtoMember(1)] public List<ImReceipt.MsgInfo> MsgInfo { get; set; }
    [ProtoMember(2)] public int LongMessageFlag { get; set; }
    [ProtoMember(3)] public byte[] Reserved { get; set; }
    [ProtoMember(4)] public int SubCmd { get; set; }
}
{
    [ProtoContract]
    internal class ImReceipt.MsgInfo
{
    [ProtoMember(1)] public long FromUin { get; set; }
    [ProtoMember(2)] public long ToUin { get; set; }
    [ProtoMember(3)] public int MsgSeq { get; set; }
    [ProtoMember(4)] public long MsgUid { get; set; }
    [ProtoMember(5)] public long MsgTime { get; set; }
    [ProtoMember(6)] public int MsgRandom { get; set; }
    [ProtoMember(7)] public int PkgNum { get; set; }
    [ProtoMember(8)] public int PkgIndex { get; set; }
    [ProtoMember(9)] public int DivSeq { get; set; }
    [ProtoMember(10)] public int MsgType { get; set; }
    [ProtoMember(20)] public RoutingHead? RoutingHead { get; set; }
}
}

[ProtoContract]
internal class PbDelRoamMsgResp
{
    [ProtoMember(1)] public int Result { get; set; }
    [ProtoMember(2)] public string Errmsg { get; set; }
}

[ProtoContract]
internal class Dis
{
    [ProtoMember(1)] public long DisUin { get; set; }
}

[ProtoContract]
internal class TransSvrInfo
{
    [ProtoMember(1)] public int SubType { get; set; }
    [ProtoMember(2)] public int Int32RetCode { get; set; }
    [ProtoMember(3)] public byte[] ErrMsg { get; set; }
    [ProtoMember(4)] public byte[] TransInfo { get; set; }
}

[ProtoContract]
internal class PbPullGroupMsgSeqResp
{
    [ProtoMember(1)] public int Result { get; set; }
    [ProtoMember(2)] public string Errmsg { get; set; }
    [ProtoMember(3)] public List<GroupInfoResp> GroupInfoResp { get; set; }
}
{
    [ProtoContract]
    internal class GroupInfoResp
{
    [ProtoMember(1)] public long GroupCode { get; set; }
    [ProtoMember(2)] public long MemberSeq { get; set; }
    [ProtoMember(3)] public long GroupSeq { get; set; }
}
}

[ProtoContract]
internal class PbSendMsgReq
{
    [ProtoMember(1)] public RoutingHead? RoutingHead { get; set; }
    [ProtoMember(2)] public MsgComm.ContentHead? ContentHead { get; set; }
    [ProtoMember(3)] public ImMsgBody.MsgBody MsgBody { get; set; }
    [ProtoMember(4)] public int MsgSeq { get; set; }
    [ProtoMember(5)] public int MsgRand { get; set; }
    [ProtoMember(6)] public byte[] SyncCookie { get; set; }
    [ProtoMember(7)] public MsgComm.AppShareInfo? AppShare { get; set; }
    [ProtoMember(8)] public int MsgVia { get; set; }
    [ProtoMember(9)] public int DataStatist { get; set; }
    [ProtoMember(10)] public MultiMsgAssist? MultiMsgAssist { get; set; }
    [ProtoMember(11)] public PbInputNotifyInfo? InputNotifyInfo { get; set; }
    [ProtoMember(12)] public MsgCtrl.MsgCtrl? MsgCtrl { get; set; }
    [ProtoMember(13)] public ImReceipt.ReceiptReq? ReceiptReq { get; set; }
    [ProtoMember(14)] public int MultiSendSeq { get; set; }
}

[ProtoContract]
internal class TransMsg
{
    [ProtoMember(1)] public long ToUin { get; set; }
    [ProtoMember(2)] public int C2cCmd { get; set; }
}

[ProtoContract]
internal class PbDeleteMsgResp
{
    [ProtoMember(1)] public int Result { get; set; }
    [ProtoMember(2)] public string Errmsg { get; set; }
}

[ProtoContract]
internal class PbSearchRoamMsgInCloudResp
{
    [ProtoMember(1)] public List<MsgComm.Msg> Msg { get; set; }
    [ProtoMember(2)] public byte[] SerializeRspbody { get; set; }
}

[ProtoContract]
internal class PbInputNotifyInfo
{
    [ProtoMember(1)] public long ToUin { get; set; }
    [ProtoMember(2)] public int Ime { get; set; }
    [ProtoMember(3)] public int NotifyFlag { get; set; }
    [ProtoMember(4)] public byte[] PbReserve { get; set; }
    [ProtoMember(5)] public byte[] IosPushWording { get; set; }
}

[ProtoContract]
internal class PbUnReadMsgSeqResp
{
    [ProtoMember(1)] public PbC2CUnReadMsgNumResp? C2cUnreadInfo { get; set; }
    [ProtoMember(2)] public List<PbBindUinUnReadMsgNumResp> BinduinUnreadInfo { get; set; }
    [ProtoMember(3)] public PbPullGroupMsgSeqResp? GroupUnreadInfo { get; set; }
    [ProtoMember(4)] public PbPullDiscussMsgSeqResp? DiscussUnreadInfo { get; set; }
    [ProtoMember(5)] public PbThirdQQUnReadMsgNumResp? ThirdqqUnreadInfo { get; set; }
}

[ProtoContract]
internal class PbDeleteMsgReq
{
    [ProtoMember(1)] public List<MsgItem> MsgItems { get; set; }
}
{
    [ProtoContract]
    internal class MsgItem
{
    [ProtoMember(1)] public long FromUin { get; set; }
    [ProtoMember(2)] public long ToUin { get; set; }
    [ProtoMember(3)] public int MsgType { get; set; }
    [ProtoMember(4)] public int MsgSeq { get; set; }
    [ProtoMember(5)] public long MsgUid { get; set; }
    [ProtoMember(7)] public byte[] Sig { get; set; }
} 
}

[ProtoContract]
internal class MultiMsgAssist
{
    [ProtoMember(1)] public List<RoutingHead> RepeatedRouting { get; set; }
    [ProtoMember(2)] public int MsgUse { get; set; }
    [ProtoMember(3)] public long TempId { get; set; }
    [ProtoMember(4)] public long VedioLen { get; set; }
    [ProtoMember(5)] public byte[] RedbagId { get; set; }
    [ProtoMember(6)] public long RedbagAmount { get; set; }
    [ProtoMember(7)] public int HasReadbag { get; set; }
    [ProtoMember(8)] public int HasVedio { get; set; }
}

[ProtoContract]
internal class PbMsgReadedReportReq
{
    [ProtoMember(1)] public List<PbGroupReadedReportReq> GrpReadReport { get; set; }
    [ProtoMember(2)] public List<PbDiscussReadedReportReq> DisReadReport { get; set; }
    [ProtoMember(3)] public PbC2CReadedReportReq? C2cReadReport { get; set; }
    [ProtoMember(4)] public PbBindUinMsgReadedConfirmReq? BindUinReadReport { get; set; }
}

[ProtoContract]
internal class PbGetOneDayRoamMsgResp
{
    [ProtoMember(1)] public int Result { get; set; }
    [ProtoMember(2)] public string Errmsg { get; set; }
    [ProtoMember(3)] public long PeerUin { get; set; }
    [ProtoMember(4)] public long LastMsgtime { get; set; }
    [ProtoMember(5)] public long Random { get; set; }
    [ProtoMember(6)] public List<MsgComm.Msg> Msg { get; set; }
    [ProtoMember(7)] public int Iscomplete { get; set; }
}

[ProtoContract]
internal class PbBindUinGetMsgReq
{
    [ProtoMember(1)] public long BindUin { get; set; }
    [ProtoMember(2)] public byte[] BindUinSig { get; set; }
    [ProtoMember(3)] public int SyncFlag { get; set; }
    [ProtoMember(4)] public byte[] SyncCookie { get; set; }
}

[ProtoContract]
internal class NearByDatingTmp
{
    [ProtoMember(1)] public long ToUin { get; set; }
    [ProtoMember(2)] public byte[] Sig { get; set; }
    [ProtoMember(3)] public bool Reply { get; set; }
}

[ProtoContract]
internal class BsnsTmp
{
    [ProtoMember(1)] public long ToUin { get; set; }
    [ProtoMember(2)] public byte[] Sig { get; set; }
}

[ProtoContract]
internal class RoutingHead
{
    [ProtoMember(1)] public C2C? C2c { get; set; }
    [ProtoMember(2)] public MsgSvc.Grp? Grp { get; set; }
    [ProtoMember(3)] public GrpTmp? GrpTmp { get; set; }
    [ProtoMember(4)] public Dis? Dis { get; set; }
    [ProtoMember(5)] public DisTmp? DisTmp { get; set; }
    [ProtoMember(6)] public WPATmp? WpaTmp { get; set; }
    [ProtoMember(7)] public SecretFileHead? SecretFile { get; set; }
    [ProtoMember(8)] public PublicPlat? PublicPlat { get; set; }
    [ProtoMember(9)] public TransMsg? TransMsg { get; set; }
    [ProtoMember(10)] public AddressListTmp? AddressList { get; set; }
    [ProtoMember(11)] public RichStatusTmp? RichStatusTmp { get; set; }
    [ProtoMember(12)] public TransCmd? TransCmd { get; set; }
    [ProtoMember(13)] public AccostTmp? AccostTmp { get; set; }
    [ProtoMember(14)] public PubGroupTmp? PubGroupTmp { get; set; }
    [ProtoMember(15)] public Trans0x211? Trans0x211 { get; set; }
    [ProtoMember(16)] public BusinessWPATmp? BusinessWpaTmp { get; set; }
    [ProtoMember(17)] public AuthTmp? AuthTmp { get; set; }
    [ProtoMember(18)] public BsnsTmp? BsnsTmp { get; set; }
    [ProtoMember(19)] public QQQueryBusinessTmp? QqQuerybusinessTmp { get; set; }
    [ProtoMember(20)] public NearByDatingTmp? NearbyDatingTmp { get; set; }
    [ProtoMember(21)] public NearByAssistantTmp? NearbyAssistantTmp { get; set; }
    [ProtoMember(22)] public CommTmp? CommTmp { get; set; }
}

[ProtoContract]
internal class TransResp
{
    [ProtoMember(1)] public int Result { get; set; }
    [ProtoMember(2)] public string Errmsg { get; set; }
    [ProtoMember(3)] public int RespTag { get; set; }
    [ProtoMember(4)] public byte[] RespBuff { get; set; }
}

[ProtoContract]
internal class PbSendMsgResp
{
    [ProtoMember(1)] public int Result { get; set; }
    [ProtoMember(2)] public string Errmsg { get; set; }
    [ProtoMember(3)] public int SendTime { get; set; }
    [ProtoMember(4)] public int SvrbusyWaitTime { get; set; }
    [ProtoMember(5)] public MsgSendInfo? MsgSendInfo { get; set; }
    [ProtoMember(6)] public int Errtype { get; set; }
    [ProtoMember(7)] public TransSvrInfo? TransSvrInfo { get; set; }
    [ProtoMember(8)] public ImReceipt.ReceiptResp? ReceiptResp { get; set; }
    [ProtoMember(9)] public int TextAnalysisResult { get; set; }
} , Packet

    [ProtoContract]
internal class PbBindUinUnReadMsgNumResp
{
    [ProtoMember(1)] public int Result { get; set; }
    [ProtoMember(2)] public string Errmsg { get; set; }
    [ProtoMember(3)] public long BindUin { get; set; }
    [ProtoMember(4)] public int MsgNum { get; set; }
}

[ProtoContract]
internal class PbGetDiscussMsgReq
{
    [ProtoMember(1)] public long DiscussUin { get; set; }
    [ProtoMember(2)] public long EndSeq { get; set; }
    [ProtoMember(3)] public long BeginSeq { get; set; }
    [ProtoMember(4)] public long LastGetTime { get; set; }
    [ProtoMember(5)] public long DiscussInfoSeq { get; set; }
    [ProtoMember(6)] public int Filter { get; set; }
    [ProtoMember(7)] public long MemberSeq { get; set; }
}

[ProtoContract]
internal class PbC2CMsgWithDrawResp
{
    [ProtoMember(1)] public int Result { get; set; }
    [ProtoMember(2)] public string Errmsg { get; set; }
    [ProtoMember(3)] public List<MsgStatus> MsgStatus { get; set; }
    [ProtoMember(4)] public int SubCmd { get; set; }
}
{
    [ProtoContract]
    internal class MsgStatus
{
    [ProtoMember(1)] public PbC2CMsgWithDrawReq.MsgInfo? MsgInfo { get; set; }
    [ProtoMember(2)] public int Status { get; set; }
} 
}

[ProtoContract]
internal class SecretFileHead
{
    [ProtoMember(1)] public SubMsgType0xc1.MsgBody? SecretFileMsg { get; set; }
    //    [ProtoMember(2)] public  SubMsgType0x1a.MsgBody?  SecretFileStatus { get; set; }
}

[ProtoContract]
internal class PbGetRoamMsgReq
{
    [ProtoMember(1)] public long PeerUin { get; set; }
    [ProtoMember(2)] public long LastMsgtime { get; set; }
    [ProtoMember(3)] public long Random { get; set; }
    [ProtoMember(4)] public int ReadCnt { get; set; }
    [ProtoMember(5)] public int CheckPwd { get; set; }
    [ProtoMember(6)] public byte[] Sig { get; set; }
    [ProtoMember(7)] public byte[] Pwd { get; set; }
    [ProtoMember(8)] public int Subcmd { get; set; }
    [ProtoMember(9)] public long BeginMsgtime { get; set; }
    [ProtoMember(10)] public int ReqType { get; set; }
}

[ProtoContract]
internal class TransCmd
{
    [ProtoMember(1)] public long ToUin { get; set; }
    [ProtoMember(2)] public int MsgType { get; set; }
}

[ProtoContract]
internal class PbMsgReadedReportResp
{
    [ProtoMember(1)] public List<PbGroupReadedReportResp> GrpReadReport { get; set; }
    [ProtoMember(2)] public List<PbDiscussReadedReportResp> DisReadReport { get; set; }
    [ProtoMember(3)] public PbC2CReadedReportResp? C2cReadReport { get; set; }
    [ProtoMember(4)] public PbBindUinMsgReadedConfirmResp? BindUinReadReport { get; set; }
}

[ProtoContract]
internal class PbThirdQQUnReadMsgNumResp
{
    [ProtoMember(1)] public int Result { get; set; }
    [ProtoMember(2)] public string Errmsg { get; set; }
    [ProtoMember(3)] public List<ThirdQQRespInfo> ThirdqqRespInfo { get; set; }
    [ProtoMember(4)] public int Interval { get; set; }
}
{
    [ProtoContract]
    internal class ThirdQQRespInfo
{
    [ProtoMember(1)] public long ThirdUin { get; set; }
    [ProtoMember(2)] public byte[] ThirdUinCookie { get; set; }
    [ProtoMember(3)] public int MsgNum { get; set; }
    [ProtoMember(4)] public int MsgFlag { get; set; }
    [ProtoMember(5)] public int RedbagTime { get; set; }
    [ProtoMember(6)] public int Status { get; set; }
    [ProtoMember(7)] public int LastMsgTime { get; set; }
} 
}

[ProtoContract]
internal class RichStatusTmp
{
    [ProtoMember(1)] public long ToUin { get; set; }
    [ProtoMember(2)] public byte[] Sig { get; set; }
}

[ProtoContract]
internal class QQQueryBusinessTmp
{
    [ProtoMember(1)] public long ToUin { get; set; }
    [ProtoMember(2)] public byte[] Sig { get; set; }
}

[ProtoContract]
internal class PbDelRoamMsgReq
{
    [ProtoMember(1)] public C2CMsg? C2cMsg { get; set; }
    [ProtoMember(2)] public GrpMsg? GrpMsg { get; set; }
    [ProtoMember(3)] public DisMsg? DisMsg { get; set; }
}
{
    [ProtoContract]
    internal class GrpMsg
{
    [ProtoMember(1)] public long GroupCode { get; set; }
    [ProtoMember(2)] public long MsgSeq { get; set; }
}

[ProtoContract]
internal class C2CMsg
{
    [ProtoMember(1)] public long FromUin { get; set; }
    [ProtoMember(2)] public long PeerUin { get; set; }
    [ProtoMember(3)] public int MsgTime { get; set; }
    [ProtoMember(4)] public int MsgRandom { get; set; }
    [ProtoMember(5)] public int MsgSeq { get; set; }
}

[ProtoContract]
internal class DisMsg
{
    [ProtoMember(1)] public long DiscussUin { get; set; }
    [ProtoMember(2)] public long MsgSeq { get; set; }
} 
}

[ProtoContract]
internal class PbUnReadMsgSeqReq
{
    [ProtoMember(1)] public PbC2CUnReadMsgNumReq? C2cUnreadInfo { get; set; }
    [ProtoMember(2)] public List<PbBindUinUnReadMsgNumReq> BinduinUnreadInfo { get; set; }
    [ProtoMember(3)] public PbPullGroupMsgSeqReq? GroupUnreadInfo { get; set; }
    [ProtoMember(4)] public PbPullDiscussMsgSeqReq? DiscussUnreadInfo { get; set; }
    [ProtoMember(5)] public PbThirdQQUnReadMsgNumReq? ThirdqqUnreadInfo { get; set; }
}

[ProtoContract]
internal class PbPullDiscussMsgSeqResp
{
    [ProtoMember(1)] public int Result { get; set; }
    [ProtoMember(2)] public string Errmsg { get; set; }
    [ProtoMember(3)] public List<DiscussInfoResp> DiscussInfoResp { get; set; }
}
{
    [ProtoContract]
    internal class DiscussInfoResp
{
    [ProtoMember(1)] public long ConfUin { get; set; }
    [ProtoMember(2)] public long MemberSeq { get; set; }
    [ProtoMember(3)] public long ConfSeq { get; set; }
} 
}

[ProtoContract]
internal class PbPullDiscussMsgSeqReq
{
    [ProtoMember(1)] public List<DiscussInfoReq> DiscussInfoReq { get; set; }
}
{
    [ProtoContract]
    internal class DiscussInfoReq
{
    [ProtoMember(1)] public long ConfUin { get; set; }
    [ProtoMember(2)] public long LastSeq { get; set; }
} 
}

[ProtoContract]
internal class WPATmp
{
    [ProtoMember(1)] public long ToUin { get; set; }
    [ProtoMember(2)] public byte[] Sig { get; set; }
}

[ProtoContract]
internal class PublicPlat
{
    [ProtoMember(1)] public long ToUin { get; set; }
    [ProtoMember(2)] public byte[] Sig { get; set; }
}

[ProtoContract]
internal class PbBindUinMsgReadedConfirmResp
{
    [ProtoMember(1)] public int Result { get; set; }
    [ProtoMember(2)] public string Errmsg { get; set; }
    [ProtoMember(3)] public byte[] SyncCookie { get; set; }
    [ProtoMember(4)] public long BindUin { get; set; }
}

[ProtoContract]
internal class PbGetRoamMsgResp
{
    [ProtoMember(1)] public int Result { get; set; }
    [ProtoMember(2)] public string Errmsg { get; set; }
    [ProtoMember(3)] public long PeerUin { get; set; }
    [ProtoMember(4)] public long LastMsgtime { get; set; }
    [ProtoMember(5)] public long Random { get; set; }
    [ProtoMember(6)] public List<MsgComm.Msg> Msg { get; set; }
    [ProtoMember(7)] public byte[] Sig { get; set; }
} , CheckableResponseB()

    [ProtoContract]
internal class PbDiscussReadedReportReq
{
    [ProtoMember(1)] public long ConfUin { get; set; }
    [ProtoMember(2)] public long LastReadSeq { get; set; }
}

[ProtoContract]
internal class PbC2CReadedReportReq
{
    [ProtoMember(1)] public byte[] SyncCookie { get; set; }
    [ProtoMember(2)] public List<UinPairReadInfo> PairInfo { get; set; }
}
{
    [ProtoContract]
    internal class UinPairReadInfo
{
    [ProtoMember(1)] public long PeerUin { get; set; }
    [ProtoMember(2)] public int LastReadTime { get; set; }
    [ProtoMember(3)] public byte[] CrmSig { get; set; }
} 
}

[ProtoContract]
internal class Trans0x211
{
    [ProtoMember(1)] public long ToUin { get; set; }
    [ProtoMember(2)] public int CcCmd { get; set; }
    [ProtoMember(3)] public ImMsgHead.InstCtrl? InstCtrl { get; set; }
    [ProtoMember(4)] public byte[] Sig { get; set; }
    [ProtoMember(5)] public int C2cType { get; set; }
    [ProtoMember(6)] public int ServiceType { get; set; }
}

[ProtoContract]
internal class PbSearchRoamMsgInCloudReq
{
    [ProtoMember(1)] public byte[] SerializeReqbody { get; set; }
}

[ProtoContract]
internal class PbBindUinUnReadMsgNumReq
{
    [ProtoMember(1)] public long BindUin { get; set; }
    [ProtoMember(2)] public byte[] SyncCookie { get; set; }
}

[ProtoContract]
internal class PbC2CUnReadMsgNumResp
{
    [ProtoMember(1)] public int Result { get; set; }
    [ProtoMember(2)] public string Errmsg { get; set; }
    [ProtoMember(3)] public int MsgNum { get; set; }
}

[ProtoContract]
internal class PbPullGroupMsgSeqReq
{
    [ProtoMember(1)] public List<GroupInfoReq> GroupInfoReq { get; set; }
}
{
    [ProtoContract]
    internal class GroupInfoReq
{
    [ProtoMember(1)] public long GroupCode { get; set; }
    [ProtoMember(2)] public long LastSeq { get; set; }
} 
}

[ProtoContract]
internal class TransReq
{
    [ProtoMember(1)] public int Command { get; set; }
    [ProtoMember(2)] public int ReqTag { get; set; }
    [ProtoMember(3)] public byte[] ReqBuff { get; set; }
}

[ProtoContract]
internal class PbGroupReadedReportResp
{
    [ProtoMember(1)] public int Result { get; set; }
    [ProtoMember(2)] public string Errmsg { get; set; }
    [ProtoMember(3)] public long GroupCode { get; set; }
    [ProtoMember(4)] public long MemberSeq { get; set; }
    [ProtoMember(5)] public long GroupMsgSeq { get; set; }
}

[ProtoContract]
internal class PbGetGroupMsgResp
{
    [ProtoMember(1)] public int Result { get; set; }
    [ProtoMember(2)] public string Errmsg { get; set; }
    [ProtoMember(3)] public long GroupCode { get; set; }
    [ProtoMember(4)] public long ReturnBeginSeq { get; set; }
    [ProtoMember(5)] public long ReturnEndSeq { get; set; }
    [ProtoMember(6)] public List<MsgComm.Msg> Msg { get; set; }
}

[ProtoContract]
internal class PbThirdQQUnReadMsgNumReq
{
    [ProtoMember(1)] public List<ThirdQQReqInfo> ThirdqqReqInfo { get; set; }
    [ProtoMember(2)] public int Source { get; set; }
}
{
    [ProtoContract]
    internal class ThirdQQReqInfo
{
    [ProtoMember(1)] public long ThirdUin { get; set; }
    [ProtoMember(2)] public byte[] ThirdUinSig { get; set; }
    [ProtoMember(3)] public byte[] ThirdUinCookie { get; set; }
} 
}
}

[ProtoContract]
internal class MsgCtrl
{
    [ProtoContract]
    internal class MsgCtrl
    {
        [ProtoMember(1)] public int MsgFlag { get; set; }
        [ProtoMember(2)] public ResvResvInfo? ResvResvInfo { get; set; }
    }

    [ProtoContract]
    internal class ResvResvInfo
    {
        [ProtoMember(1)] public int Flag { get; set; }
        [ProtoMember(2)] public byte[] Reserv1 { get; set; }
        [ProtoMember(3)] public long Reserv2 { get; set; }
        [ProtoMember(4)] public long Reserv3 { get; set; }
        [ProtoMember(5)] public int CreateTime { get; set; }
        [ProtoMember(6)] public int PicHeight { get; set; }
        [ProtoMember(7)] public int PicWidth { get; set; }
        [ProtoMember(8)] public int ResvFlag { get; set; }
    }
}

[ProtoContract]
internal class SubMsgType0xc1
{
    [ProtoContract]
    internal class NotOnlineImage
    {
        [ProtoMember(1)] public byte[] FilePath { get; set; }
        [ProtoMember(2)] public int FileLen { get; set; }
        [ProtoMember(3)] public byte[] DownloadPath { get; set; }
        [ProtoMember(4)] public byte[] OldVerSendFile { get; set; }
        [ProtoMember(5)] public int ImgType { get; set; }
        [ProtoMember(6)] public byte[] PreviewsImage { get; set; }
        [ProtoMember(7)] public byte[] PicMd5 { get; set; }
        [ProtoMember(8)] public int PicHeight { get; set; }
        [ProtoMember(9)] public int PicWidth { get; set; }
        [ProtoMember(10)] public byte[] ResId { get; set; }
        [ProtoMember(11)] public byte[] Flag { get; set; }
        [ProtoMember(12)] public string DownloadUrl { get; set; }
        [ProtoMember(13)] public int Original { get; set; }
    }

    [ProtoContract]
    internal class MsgBody
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
        [ProtoMember(12)] public NotOnlineImage? NotOnlineImage { get; set; }
    }
}

/*
[ProtoContract]
internal class SubMsgType0x1a {
    [ProtoContract]
    internal class MsgBody{
        [ProtoMember(1)] public  byte[]  FileKey { get; set; }
        [ProtoMember(2)] public  int  FromUin_int32 { get; set; }
        [ProtoMember(3)] public  int  ToUin_int32 { get; set; }
        [ProtoMember(4)] public  int  Status { get; set; }
        [ProtoMember(5)] public  int  Ttl { get; set; }
        [ProtoMember(6)] public  String  IngDesc { get; set; }
        [ProtoMember(7)] public  int  Type { get; set; }
        [ProtoMember(8)] public  int  CaptureTimes { get; set; }
        [ProtoMember(9)] public  long  FromUin { get; set; }
        [ProtoMember(10)] public  long  ToUin { get; set; }
    } 
}*/
