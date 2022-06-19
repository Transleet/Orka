using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

internal class MsgType0x211
{
    [ProtoContract]
    internal class SubMsgType0x3
    {
        [ProtoContract]
        internal class FailNotify
        {
            [ProtoMember(1)] public int Sessionid { get; set; }
            [ProtoMember(2)] public int RetCode { get; set; }
            [ProtoMember(3)] public byte[] Reason { get; set; }
        }

        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public ProgressNotify? MsgProgressNotify { get; set; }
            [ProtoMember(2)] public FailNotify? MsgFailNotify { get; set; }
        }

        [ProtoContract]
        internal class ProgressNotify
        {
            [ProtoMember(1)] public int Sessionid { get; set; }
            [ProtoMember(2)] public byte[] Uuid { get; set; }
            [ProtoMember(3)] public int Progress { get; set; }
            [ProtoMember(4)] public int AverageSpeed { get; set; }
        }
    }


    [ProtoContract]
    internal class SubMsgType0x4
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public ImMsgBody.NotOnlineFile? MsgNotOnlineFile { get; set; }
            [ProtoMember(2)] public int MsgTime { get; set; }
            [ProtoMember(3)] public int OnlineFileForPolyToOffline { get; set; }
            [ProtoMember(4)] public HummerResv21.FileImgInfo? FileImageInfo { get; set; }
            [ProtoMember(5)] public HummerResv21.XtfSenderInfo? MsgXtfSenderInfo { get; set; }
            [ProtoMember(6)] public HummerResv21.ResvAttr? ResvAttr { get; set; }
        }
    }


    [ProtoContract]
    internal class SubMsgType0x5
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int Sessionid { get; set; }
        }
    }


    [ProtoContract]
    internal class SubMsgType0x7
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int SubCmd { get; set; }
            [ProtoMember(2)] public MsgHeader? MsgHeader { get; set; }
            [ProtoMember(3)] public List<FTNNotify> MsgSubcmd0x1FtnNotify { get; set; }
            [ProtoMember(4)] public List<NFCNotify> MsgSubcmd0x2NfcNotify { get; set; }
            [ProtoMember(5)] public List<FileControl> MsgSubcmd0x3Filecontrol { get; set; }
            [ProtoMember(6)] public GenericSubCmd? MsgSubcmd0x4Generic { get; set; }
            [ProtoMember(7)] public List<MoloNotify> MsgSubcmd0x5MoloNotify { get; set; }
            [ProtoMember(8)] public List<RNFCNotify> MsgSubcmd0x8RnfcNotify { get; set; }
            [ProtoMember(9)] public List<FTNNotify> MsgSubcmd0x9FtnThumbNotify { get; set; }
            [ProtoMember(10)] public List<NFCNotify> MsgSubcmd0xaNfcThumbNotify { get; set; }
            [ProtoMember(11)] public List<MpFileNotify> MsgSubcmd0xbMpfileNotify { get; set; }
            [ProtoMember(12)] public ProgressReq? MsgSubcmd0xcProgressReq { get; set; }
            [ProtoMember(13)] public ProgressRsp? MsgSubcmd0xdProgressRsp { get; set; }
        }

        [ProtoContract]
        internal class ActionInfo
        {
            [ProtoMember(1)] public string ServiceName { get; set; }
            [ProtoMember(2)] public byte[] Buf { get; set; }
        }

        [ProtoContract]
        internal class FileControl
        {
            [ProtoMember(1)] public long Sessionid { get; set; }
            [ProtoMember(2)] public int Operate { get; set; }
            [ProtoMember(3)] public int Seq { get; set; }
            [ProtoMember(4)] public int Code { get; set; }
            [ProtoMember(5)] public string Msg { get; set; }
            [ProtoMember(6)] public int GroupId { get; set; }
            [ProtoMember(7)] public int GroupCurindex { get; set; }
            [ProtoMember(8)] public int BatchID { get; set; }
        }

        [ProtoContract]
        internal class FTNNotify
        {
            [ProtoMember(1)] public long Sessionid { get; set; }
            [ProtoMember(2)] public string FileName { get; set; }
            [ProtoMember(3)] public string FileIndex { get; set; }
            [ProtoMember(4)] public byte[] FileMd5 { get; set; }
            [ProtoMember(5)] public string FileKey { get; set; }
            [ProtoMember(6)] public long FileLen { get; set; }
            [ProtoMember(7)] public byte[] OriginfileMd5 { get; set; }
            [ProtoMember(8)] public int Originfiletype { get; set; }
            [ProtoMember(9)] public int GroupId { get; set; }
            [ProtoMember(10)] public int GroupSize { get; set; }
            [ProtoMember(11)] public int GroupCurindex { get; set; }
            [ProtoMember(20)] public ActionInfo? MsgActionInfo { get; set; }
            [ProtoMember(21)] public int BatchID { get; set; }
            [ProtoMember(22)] public int Groupflag { get; set; }
        }

        [ProtoContract]
        internal class MsgItem
        {
            [ProtoMember(1)] public int Type { get; set; }
            [ProtoMember(2)] public string Text { get; set; }
        }

        [ProtoContract]
        internal class QQDataTextMsg
        {
            [ProtoMember(1)] public List<MsgItem> MsgItems { get; set; }
        }

        [ProtoContract]
        internal class WifiPhotoNoPush
        {
            [ProtoMember(1)] public byte[] Json { get; set; }
        }

        [ProtoContract]
        internal class WifiPhotoWithPush
        {
            [ProtoMember(1)] public byte[] Json { get; set; }
        }

        [ProtoContract]
        internal class GenericSubCmd
        {
            [ProtoMember(1)] public long Sessionid { get; set; }
            [ProtoMember(2)] public int Size { get; set; }
            [ProtoMember(3)] public int Index { get; set; }
            [ProtoMember(4)] public int Type { get; set; }
            [ProtoMember(5)] public byte[] Buf { get; set; }
            [ProtoMember(6)] public int SupportAuth { get; set; }
        }

        [ProtoContract]
        internal class MoloNotify
        {
            [ProtoMember(1)] public byte[] Buf { get; set; }
            [ProtoMember(2)] public int GroupId { get; set; }
            [ProtoMember(3)] public int GroupSize { get; set; }
            [ProtoMember(4)] public int GroupCurindex { get; set; }
        }

        [ProtoContract]
        internal class MpFileNotify
        {
            [ProtoMember(1)] public long Sessionid { get; set; }
            [ProtoMember(2)] public int Operate { get; set; }
            [ProtoMember(3)] public int Fixed32Ip { get; set; }
            [ProtoMember(4)] public int Port { get; set; }
            [ProtoMember(5)] public int Type { get; set; }
            [ProtoMember(6)] public int Power { get; set; }
            [ProtoMember(7)] public byte[] Json { get; set; }
        }

        [ProtoContract]
        internal class MsgHeader
        {
            [ProtoMember(1)] public int SrcAppId { get; set; }
            [ProtoMember(2)] public int SrcInstId { get; set; }
            [ProtoMember(3)] public int DstAppId { get; set; }
            [ProtoMember(4)] public int DstInstId { get; set; }
            [ProtoMember(5)] public long DstUin { get; set; }
            [ProtoMember(6)] public long SrcUin { get; set; }
            [ProtoMember(7)] public int SrcUinType { get; set; }
            [ProtoMember(8)] public int DstUinType { get; set; }
            [ProtoMember(9)] public int SrcTerType { get; set; }
            [ProtoMember(10)] public int DstTerType { get; set; }
        }

        [ProtoContract]
        internal class NFCNotify
        {
            [ProtoMember(1)] public long Sessionid { get; set; }
            [ProtoMember(2)] public string FileName { get; set; }
            [ProtoMember(3)] public byte[] FileMd5 { get; set; }
            [ProtoMember(4)] public int Fixed32Ip { get; set; }
            [ProtoMember(5)] public int Port { get; set; }
            [ProtoMember(6)] public byte[] UrlNotify { get; set; }
            [ProtoMember(7)] public byte[] Tokenkey { get; set; }
            [ProtoMember(8)] public long FileLen { get; set; }
            [ProtoMember(9)] public byte[] OriginfileMd5 { get; set; }
            [ProtoMember(10)] public int Originfiletype { get; set; }
            [ProtoMember(11)] public int GroupId { get; set; }
            [ProtoMember(12)] public int GroupSize { get; set; }
            [ProtoMember(13)] public int GroupCurindex { get; set; }
            [ProtoMember(20)] public ActionInfo? MsgActionInfo { get; set; }
            [ProtoMember(21)] public int BatchID { get; set; }
            [ProtoMember(22)] public int Groupflag { get; set; }
        }

        [ProtoContract]
        internal class ProgressReq
        {
            [ProtoMember(1)] public int Cmd { get; set; }
            [ProtoMember(2)] public long Cookie { get; set; }
            [ProtoMember(3)] public int InfoFlag { get; set; }
            [ProtoMember(4)] public List<long> Uint64Sessionid { get; set; }
        }

        [ProtoContract]
        internal class ProgressInfo
        {
            [ProtoMember(1)] public long Sessionid { get; set; }
            [ProtoMember(2)] public long Progress { get; set; }
            [ProtoMember(3)] public int Status { get; set; }
            [ProtoMember(4)] public long Filesize { get; set; }
            [ProtoMember(5)] public string Filename { get; set; }
            [ProtoMember(6)] public long Time { get; set; }
        }

        [ProtoContract]
        internal class ProgressRsp
        {
            [ProtoMember(1)] public int Cmd { get; set; }
            [ProtoMember(2)] public long Cookie { get; set; }
            [ProtoMember(3)] public int PackageCount { get; set; }
            [ProtoMember(4)] public int PackageIndex { get; set; }
            [ProtoMember(5)] public List<ProgressInfo> MsgProgressinfo { get; set; }
        }

        [ProtoContract]
        internal class RNFCNotify
        {
            [ProtoMember(1)] public long Sessionid { get; set; }
            [ProtoMember(2)] public byte[] Token { get; set; }
            [ProtoMember(3)] public int Fixed32Ip { get; set; }
            [ProtoMember(4)] public int Port { get; set; }
            [ProtoMember(5)] public long SvrTaskId { get; set; }
        }
    }



    [ProtoContract]
    internal class C2CType0x211SubC2CType0x8
    {
        [ProtoContract]
        internal class BusiReqHead
        {
            [ProtoMember(1)] public int Int32Version { get; set; }
            [ProtoMember(2)] public int Int32Seq { get; set; }
        }

        [ProtoContract]
        internal class BusiRespHead
        {
            [ProtoMember(1)] public int Int32Version { get; set; }
            [ProtoMember(2)] public int Int32Seq { get; set; }
            [ProtoMember(3)] public int Int32ReplyCode { get; set; }
            [ProtoMember(4)] public string Result { get; set; }
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
        internal class ConnType
        {
            [ProtoMember(1)] public int Type { get; set; }
            [ProtoMember(2)] public string Desription { get; set; }
        }

        [ProtoContract]
        internal class GPS
        {
            [ProtoMember(1)] public int Int32Lat { get; set; }
            [ProtoMember(2)] public int Int32Lon { get; set; }
            [ProtoMember(3)] public int Int32Alt { get; set; }
            [ProtoMember(4)] public int EType { get; set; }
        }

        [ProtoContract]
        internal class IPAddrInfo
        {
            [ProtoMember(1)] public int Int32Ip { get; set; }
            [ProtoMember(2)] public int Int32Mask { get; set; }
            [ProtoMember(3)] public int Int32Gateway { get; set; }
            [ProtoMember(4)] public int Int32Port { get; set; }
        }

        [ProtoContract]
        internal class JudgeResult
        {
            [ProtoMember(1)] public int Type { get; set; }
            [ProtoMember(2)] public string Ssid { get; set; }
            [ProtoMember(3)] public string Tips { get; set; }
            [ProtoMember(4)] public int Int32IdleTimeout { get; set; }
            [ProtoMember(5)] public int IdleWaiting { get; set; }
            [ProtoMember(6)] public int ForceWifi { get; set; }
            [ProtoMember(7)] public int FlagsWifipsw { get; set; }
            [ProtoMember(8)] public int FlagsNetcheck { get; set; }
        }

        [ProtoContract]
        internal class LBSInfo
        {
            [ProtoMember(1)] public GPS? MsgGps { get; set; }
            [ProtoMember(2)] public List<Wifi> MsgWifis { get; set; }
            [ProtoMember(3)] public List<Cell> MsgCells { get; set; }
        }

        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public int MsgType { get; set; }
            [ProtoMember(2)] public NotifyList? MsgCcNotifylist { get; set; }
            [ProtoMember(3)] public NearFieldAbiQuery? MsgCcnfAbiQuery { get; set; }
            [ProtoMember(4)] public PushJudgeResult? MsgCcPushJudgeResult { get; set; }
            [ProtoMember(5)] public NearFieldFileSendReq? MsgCcnfFilesendReq { get; set; }
            [ProtoMember(6)] public NearFieldFileStateSync? MsgCcnfFilestateSync { get; set; }
        }

        [ProtoContract]
        internal class NearFieldAbiQuery
        {
            [ProtoMember(1)] public long ToUin { get; set; }
            [ProtoMember(2)] public long FromUin { get; set; }
            [ProtoMember(3)] public bool BoolNeedTips { get; set; }
            [ProtoMember(4)] public int Int32Timeout { get; set; }
            [ProtoMember(5)] public byte[] Cookie { get; set; }
            [ProtoMember(6)] public int Int32PeerIp { get; set; }
            [ProtoMember(7)] public int Int32PeerPort { get; set; }
            [ProtoMember(8)] public byte[] PeerExtra { get; set; }
        }

        [ProtoContract]
        internal class NearFieldFileInfo
        {
            [ProtoMember(1)] public string FileName { get; set; }
            [ProtoMember(2)] public long FileSize { get; set; }
            [ProtoMember(3)] public string FileMd5 { get; set; }
            [ProtoMember(4)] public string FileUrl { get; set; }
            [ProtoMember(5)] public string FileThumbMd5 { get; set; }
            [ProtoMember(6)] public string FileThumbUrl { get; set; }
            [ProtoMember(7)] public long SessionId { get; set; }
            [ProtoMember(8)] public int Int32Timeout { get; set; }
            [ProtoMember(9)] public long GroupId { get; set; }
        }

        [ProtoContract]
        internal class NearFieldFileSendReq
        {
            [ProtoMember(1)] public long ToUin { get; set; }
            [ProtoMember(2)] public List<NearFieldFileInfo> MsgFileList { get; set; }
            [ProtoMember(3)] public int Int32Ip { get; set; }
            [ProtoMember(4)] public int Int32UdpPort { get; set; }
            [ProtoMember(5)] public string Ssid { get; set; }
            [ProtoMember(6)] public int Int32ConnWifiapTimeout { get; set; }
            [ProtoMember(7)] public int ForceWifi { get; set; }
            [ProtoMember(8)] public string Wifipsw { get; set; }
        }

        [ProtoContract]
        internal class NearFieldFileStateSync
        {
            [ProtoMember(1)] public int EType { get; set; }
            [ProtoMember(2)] public long SessionId { get; set; }
            [ProtoMember(3)] public long FromUin { get; set; }
            [ProtoMember(4)] public int Int32ErrorCode { get; set; }
        }

        [ProtoContract]
        internal class NearfieldInfo
        {
            [ProtoMember(1)] public LBSInfo? MsgLbsInfo { get; set; }
            [ProtoMember(2)] public ConnType? MsgConnType { get; set; }
            [ProtoMember(3)] public IPAddrInfo? MsgIpInfo { get; set; }
            [ProtoMember(4)] public WifiDetailInfo? MsgWifiDetail { get; set; }
            [ProtoMember(5)] public WifiAbility? MsgWifiAbi { get; set; }
            [ProtoMember(6)] public byte[] Extra { get; set; }
        }

        [ProtoContract]
        internal class NotifyList
        {
            [ProtoMember(1)] public int NotifyType { get; set; }
            [ProtoMember(2)] public List<UpdateInfo> MsgUpdateList { get; set; }
            [ProtoMember(3)] public int SessionId { get; set; }
        }

        [ProtoContract]
        internal class PushJudgeResult
        {
            [ProtoMember(1)] public BusiRespHead? MsgHead { get; set; }
            [ProtoMember(2)] public long ToUin { get; set; }
            [ProtoMember(3)] public JudgeResult? MsgResult { get; set; }
            [ProtoMember(4)] public int Int32PeerIp { get; set; }
            [ProtoMember(5)] public int Int32PeerPort { get; set; }
            [ProtoMember(6)] public byte[] PeerExtra { get; set; }
        }

        [ProtoContract]
        internal class ReqAIOJudge
        {
            [ProtoMember(1)] public BusiReqHead? MsgHead { get; set; }
            [ProtoMember(2)] public long ToUin { get; set; }
            [ProtoMember(3)] public NearfieldInfo? MsgNearfieldInfo { get; set; }
        }

        [ProtoContract]
        internal class ReqExit
        {
            [ProtoMember(1)] public BusiReqHead? MsgHead { get; set; }
            [ProtoMember(2)] public int SessionId { get; set; }
            [ProtoMember(3)] public NearfieldInfo? MsgNearfieldInfo { get; set; }
        }

        [ProtoContract]
        internal class ReqGetList
        {
            [ProtoMember(1)] public BusiReqHead? MsgHead { get; set; }
            [ProtoMember(2)] public NearfieldInfo? MsgNearfieldInfo { get; set; }
            [ProtoMember(3)] public int SessionId { get; set; }
            [ProtoMember(4)] public byte[] Cookie { get; set; }
        }

        [ProtoContract]
        internal class ReqReportNearFieldAbi
        {
            [ProtoMember(1)] public BusiReqHead? MsgHead { get; set; }
            [ProtoMember(2)] public long FromUin { get; set; }
            [ProtoMember(3)] public NearfieldInfo? MsgNearfieldInfo { get; set; }
            [ProtoMember(4)] public byte[] Cookie { get; set; }
        }

        [ProtoContract]
        internal class RespAIOJudge
        {
            [ProtoMember(1)] public BusiRespHead? MsgHead { get; set; }
            [ProtoMember(2)] public JudgeResult? MsgResult { get; set; }
            [ProtoMember(3)] public int Timeout { get; set; }
            [ProtoMember(4)] public long ToUin { get; set; }
            [ProtoMember(5)] public int Int32PeerIp { get; set; }
            [ProtoMember(6)] public int Int32PeerPort { get; set; }
            [ProtoMember(7)] public byte[] PeerExtra { get; set; }
        }

        [ProtoContract]
        internal class RespExit
        {
            [ProtoMember(1)] public BusiRespHead? MsgHead { get; set; }
        }

        [ProtoContract]
        internal class RespGetList
        {
            [ProtoMember(1)] public BusiRespHead? MsgHead { get; set; }
            [ProtoMember(2)] public List<UserProfile> MsgUserList { get; set; }
            [ProtoMember(3)] public int SessionId { get; set; }
            [ProtoMember(4)] public int Int32UpdateInterval { get; set; }
            [ProtoMember(5)] public byte[] Cookie { get; set; }
        }

        [ProtoContract]
        internal class UpdateInfo
        {
            [ProtoMember(1)] public int Type { get; set; }
            [ProtoMember(2)] public UserProfile? MsgUser { get; set; }
        }

        [ProtoContract]
        internal class UserAbility
        {
            [ProtoMember(1)] public int Int32SysQlver { get; set; }
            [ProtoMember(2)] public int Int32SysTerm { get; set; }
            [ProtoMember(3)] public int Int32SysApp { get; set; }
            [ProtoMember(10)] public int Int32AbsWifiHost { get; set; }
            [ProtoMember(11)] public int Int32AbsWifiClient { get; set; }
            [ProtoMember(12)] public int Int32AbsWifiForcedcreate { get; set; }
            [ProtoMember(13)] public int Int32AbsWifiForcedconnect { get; set; }
            [ProtoMember(14)] public int Int32AbsWifiPassword { get; set; }
            [ProtoMember(20)] public int Int32AbsNetReachablecheck { get; set; }
            [ProtoMember(21)] public int Int32AbsNetSpeedTest { get; set; }
            [ProtoMember(30)] public int Int32AbsUiPromptOnclick { get; set; }
            [ProtoMember(31)] public int Int32AbsUiPromptPassive { get; set; }
        }

        [ProtoContract]
        internal class UserExtraInfo
        {
            [ProtoMember(1)] public UserAbility? Ability { get; set; }
        }

        [ProtoContract]
        internal class UserProfile
        {
            [ProtoMember(1)] public long Uin { get; set; }
            [ProtoMember(2)] public int Int32FaceId { get; set; }
            [ProtoMember(3)] public int Int32Sex { get; set; }
            [ProtoMember(4)] public int Int32Age { get; set; }
            [ProtoMember(5)] public string Nick { get; set; }
            [ProtoMember(6)] public byte[] TmpTalkSig { get; set; }
            [ProtoMember(7)] public JudgeResult? MsgResult { get; set; }
            [ProtoMember(8)] public int Int32Ip { get; set; }
            [ProtoMember(9)] public int Int32Port { get; set; }
            [ProtoMember(10)] public byte[] Tip { get; set; }
            [ProtoMember(11)] public byte[] Extra { get; set; }
        }

        [ProtoContract]
        internal class Wifi
        {
            [ProtoMember(1)] public long Mac { get; set; }
            [ProtoMember(2)] public int Int32Rssi { get; set; }
        }

        [ProtoContract]
        internal class WifiAbility
        {
            [ProtoMember(1)] public bool BoolEstablishAbi { get; set; }
            [ProtoMember(2)] public bool BoolAutoConnectAbi { get; set; }
        }

        [ProtoContract]
        internal class WifiDetailInfo
        {
            [ProtoMember(1)] public bool BoolSelfEstablish { get; set; }
            [ProtoMember(2)] public string Ssid { get; set; }
            [ProtoMember(3)] public string Mac { get; set; }
        }
    }


    [ProtoContract]
    internal class C2CType0x211SubC2CType0x9
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public string Service { get; set; }
            [ProtoMember(2)] public int CMD { get; set; }
            [ProtoMember(3)] public MsgPrinter? MsgPrinter { get; set; }
        }

        [ProtoContract]
        internal class HPPrinterStateInfo
        {
            [ProtoMember(1)] public long PrinterDin { get; set; }
            [ProtoMember(2)] public string PrinterQrPicUrl { get; set; }
            [ProtoMember(3)] public string PrinterQrOpenUrl { get; set; }
            [ProtoMember(4)] public string PrinterTipUrl { get; set; }
        }

        [ProtoContract]
        internal class MsgPrinter
        {
            [ProtoMember(1)] public List<string> StringPrinter { get; set; }
            [ProtoMember(2)] public long PrintSessionId { get; set; }
            [ProtoMember(3)] public int PrintResult { get; set; }
            [ProtoMember(4)] public string ResultMsg { get; set; }
            [ProtoMember(5)] public List<long> Uint64SessionId { get; set; }
            [ProtoMember(6)] public List<SupportFileInfo> MsgSupportFileInfo { get; set; }
            [ProtoMember(7)] public HPPrinterStateInfo? HpPrinterStateInfo { get; set; }
        }

        [ProtoContract]
        internal class SupportFileInfo
        {
            [ProtoMember(1)] public string FileSuffix { get; set; }
            [ProtoMember(2)] public int Copies { get; set; }
            [ProtoMember(3)] public int Duplex { get; set; }
        }
    }



    [ProtoContract]
    internal class C2CType0x211SubC2CType0xb
    {
        [ProtoContract]
        internal class MsgBody
        {
            [ProtoMember(1)] public MsgHeader? MsgMsgHeader { get; set; }
            [ProtoMember(2)] public RejectNotify? MsgRejectMotify { get; set; }
        }

        [ProtoContract]
        internal class MsgHeader
        {
            [ProtoMember(1)] public int BodyType { get; set; }
            [ProtoMember(2)] public int SessionType { get; set; }
            [ProtoMember(3)] public long ToUin { get; set; }
            [ProtoMember(4)] public string ToMobile { get; set; }
            [ProtoMember(5)] public long RoomId { get; set; }
        }

        [ProtoContract]
        internal class RejectNotify
        {
            [ProtoMember(1)] public int EnumRejectReason { get; set; }
            [ProtoMember(2)] public string Msg { get; set; }
            [ProtoMember(3)] public string RingFilename { get; set; }
        }
    }
}
