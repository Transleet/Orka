using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

[ProtoContract]
internal class BdhExtinfo
{
    [ProtoContract]
    internal class CommFileExtReq
    {
        [ProtoMember(1)] public int ActionType { get; set; }
        [ProtoMember(2)] public byte[] Uuid { get; set; }
    }

    [ProtoContract]
    internal class CommFileExtRsp
    {
        [ProtoMember(1)] public int Int32Retcode { get; set; }
        [ProtoMember(2)] public byte[] DownloadUrl { get; set; }
    }

    [ProtoContract]
    internal class PicInfo
    {
        [ProtoMember(1)] public int Idx { get; set; }
        [ProtoMember(2)] public int Size { get; set; }
        [ProtoMember(3)] public byte[] BinMd5 { get; set; }
        [ProtoMember(4)] public int Type { get; set; }
    }

    [ProtoContract]
    internal class QQVoiceExtReq
    {
        [ProtoMember(1)] public byte[] Qid { get; set; }
        [ProtoMember(2)] public int Fmt { get; set; }
        [ProtoMember(3)] public int Rate { get; set; }
        [ProtoMember(4)] public int Bits { get; set; }
        [ProtoMember(5)] public int Channel { get; set; }
        [ProtoMember(6)] public int Pinyin { get; set; }
    }

    [ProtoContract]
    internal class QQVoiceExtRsp
    {
        [ProtoMember(1)] public byte[] Qid { get; set; }
        [ProtoMember(2)] public int Int32Retcode { get; set; }
        [ProtoMember(3)] public List<QQVoiceResult> MsgResult { get; set; }
    }

    [ProtoContract]
    internal class QQVoiceResult
    {
        [ProtoMember(1)] public byte[] Text { get; set; }
        [ProtoMember(2)] public byte[] Pinyin { get; set; }
        [ProtoMember(3)] public int Source { get; set; }
    }

    [ProtoContract]
    internal class ShortVideoReqExtInfo
    {
        [ProtoMember(1)] public int Cmd { get; set; }
        [ProtoMember(2)] public long SessionId { get; set; }
        [ProtoMember(3)] public PicInfo? MsgThumbinfo { get; set; }
        [ProtoMember(4)] public VideoInfo? MsgVideoinfo { get; set; }
        [ProtoMember(5)] public ShortVideoSureReqInfo? MsgShortvideoSureReq { get; set; }
        [ProtoMember(6)] public bool BoolIsMergeCmdBeforeData { get; set; }
    }

    [ProtoContract]
    internal class ShortVideoRspExtInfo
    {
        [ProtoMember(1)] public int Cmd { get; set; }
        [ProtoMember(2)] public long SessionId { get; set; }
        [ProtoMember(3)] public int Int32Retcode { get; set; }
        [ProtoMember(4)] public byte[] Errinfo { get; set; }
        [ProtoMember(5)] public PicInfo? MsgThumbinfo { get; set; }
        [ProtoMember(6)] public VideoInfo? MsgVideoinfo { get; set; }
        [ProtoMember(7)] public ShortVideoSureRspInfo? MsgShortvideoSureRsp { get; set; }
        [ProtoMember(8)] public int RetryFlag { get; set; }
    }

    [ProtoContract]
    internal class ShortVideoSureReqInfo
    {
        [ProtoMember(1)] public long Fromuin { get; set; }
        [ProtoMember(2)] public int ChatType { get; set; }
        [ProtoMember(3)] public long Touin { get; set; }
        [ProtoMember(4)] public long GroupCode { get; set; }
        [ProtoMember(5)] public int ClientType { get; set; }
        [ProtoMember(6)] public PicInfo? MsgThumbinfo { get; set; }
        [ProtoMember(7)] public List<VideoInfo> MsgMergeVideoinfo { get; set; }
        [ProtoMember(8)] public List<VideoInfo> MsgDropVideoinfo { get; set; }
        [ProtoMember(9)] public int BusinessType { get; set; }
        [ProtoMember(10)] public int SubBusinessType { get; set; }
    }

    [ProtoContract]
    internal class ShortVideoSureRspInfo
    {
        [ProtoMember(1)] public byte[] Fileid { get; set; }
        [ProtoMember(2)] public byte[] Ukey { get; set; }
        [ProtoMember(3)] public VideoInfo? MsgVideoinfo { get; set; }
        [ProtoMember(4)] public int MergeCost { get; set; }
    }

    [ProtoContract]
    internal class StoryVideoExtReq
    {

    }

    [ProtoContract]
    internal class StoryVideoExtRsp
    {
        [ProtoMember(1)] public int Int32Retcode { get; set; }
        [ProtoMember(2)] public byte[] Msg { get; set; }
        [ProtoMember(3)] public byte[] CdnUrl { get; set; }
        [ProtoMember(4)] public byte[] FileKey { get; set; }
        [ProtoMember(5)] public byte[] FileId { get; set; }
    }

    [ProtoContract]
    internal class UploadPicExtInfo
    {
        [ProtoMember(1)] public byte[] FileResid { get; set; }
        [ProtoMember(2)] public byte[] DownloadUrl { get; set; }
        [ProtoMember(3)] public byte[] ThumbDownloadUrl { get; set; }
    }

    [ProtoContract]
    internal class VideoInfo
    {
        [ProtoMember(1)] public int Idx { get; set; }
        [ProtoMember(2)] public int Size { get; set; }
        [ProtoMember(3)] public byte[] BinMd5 { get; set; }
        [ProtoMember(4)] public int Format { get; set; }
        [ProtoMember(5)] public int ResLen { get; set; }
        [ProtoMember(6)] public int ResWidth { get; set; }
        [ProtoMember(7)] public int Time { get; set; }
        [ProtoMember(8)] public long Starttime { get; set; }
        [ProtoMember(9)] public int IsAudio { get; set; }
    }
}

[ProtoContract]
internal class CSDataHighwayHead
{
    [ProtoContract]
    internal class C2CCommonExtendinfo
    {
        [ProtoMember(1)] public int InfoId { get; set; }
        [ProtoMember(2)] public FilterExtendinfo? MsgFilterExtendinfo { get; set; }
    }

    [ProtoContract]
    internal class DataHighwayHead
    {
        [ProtoMember(1)] public int Version { get; set; }
        [ProtoMember(2)] public string Uin { get; set; }
        [ProtoMember(3)] public string Command { get; set; }
        [ProtoMember(4)] public int Seq { get; set; }
        [ProtoMember(5)] public int? RetryTimes { get; set; }
        [ProtoMember(6)] public int? Appid { get; set; }
        [ProtoMember(7)] public int? Dataflag { get; set; }
        [ProtoMember(8)] public int? CommandId { get; set; }
        [ProtoMember(9)] public string BuildVer { get; set; }
        [ProtoMember(10)] public int LocaleId { get; set; }
        [ProtoMember(11)] public int EnvId { get; set; }
    }

    [ProtoContract]
    internal class DataHole
    {
        [ProtoMember(1)] public long Begin { get; set; }
        [ProtoMember(2)] public long End { get; set; }
    }

    [ProtoContract]
    internal class FilterExtendinfo
    {
        [ProtoMember(1)] public int FilterFlag { get; set; }
        [ProtoMember(2)] public ImageFilterRequest? MsgImageFilterRequest { get; set; }
    }

    [ProtoContract]
    internal class FilterStyle
    {
        [ProtoMember(1)] public int StyleId { get; set; }
        [ProtoMember(2)] public byte[] StyleName { get; set; }
    }

    [ProtoContract]
    internal class ImageFilterRequest
    {
        [ProtoMember(1)] public byte[] SessionId { get; set; }
        [ProtoMember(2)] public int ClientIp { get; set; }
        [ProtoMember(3)] public long Uin { get; set; }
        [ProtoMember(4)] public FilterStyle? Style { get; set; }
        [ProtoMember(5)] public int Width { get; set; }
        [ProtoMember(6)] public int Height { get; set; }
        [ProtoMember(7)] public byte[] ImageData { get; set; }
    }

    [ProtoContract]
    internal class ImageFilterResponse
    {
        [ProtoMember(1)] public int RetCode { get; set; }
        [ProtoMember(2)] public byte[] ImageData { get; set; }
        [ProtoMember(3)] public int CostTime { get; set; }
    }

    [ProtoContract]
    internal class LoginSigHead
    {
        [ProtoMember(1)] public int LoginsigType { get; set; }
        [ProtoMember(2)] public byte[] Loginsig { get; set; }
    }

    [ProtoContract]
    internal class NewServiceTicket
    {
        [ProtoMember(1)] public byte[] Signature { get; set; }
        [ProtoMember(2)] public byte[] Ukey { get; set; }
    }

    [ProtoContract]
    internal class PicInfoExt
    {
        [ProtoMember(1)] public int PicWidth { get; set; }
        [ProtoMember(2)] public int PicHeight { get; set; }
        [ProtoMember(3)] public int PicFlag { get; set; }
        [ProtoMember(4)] public int BusiType { get; set; }
        [ProtoMember(5)] public int SrcTerm { get; set; }
        [ProtoMember(6)] public int PlatType { get; set; }
        [ProtoMember(7)] public int NetType { get; set; }
        [ProtoMember(8)] public int ImgType { get; set; }
        [ProtoMember(9)] public int AppPicType { get; set; }
    }

    [ProtoContract]
    internal class PicRspExtInfo
    {
        [ProtoMember(1)] public byte[] Skey { get; set; }
        [ProtoMember(2)] public int ClientIp { get; set; }
        [ProtoMember(3)] public long UpOffset { get; set; }
        [ProtoMember(4)] public long BlockSize { get; set; }
    }

    [ProtoContract]
    internal class QueryHoleRsp
    {
        [ProtoMember(1)] public int Result { get; set; }
        [ProtoMember(2)] public List<DataHole> DataHole { get; set; }
        [ProtoMember(3)] public bool BoolCompFlag { get; set; }
    }

    [ProtoContract]
    internal class ReqDataHighwayHead
    {
        [ProtoMember(1)] public DataHighwayHead? MsgBasehead { get; set; }
        [ProtoMember(2)] public SegHead? MsgSeghead { get; set; }
        [ProtoMember(3)] public byte[]? ReqExtendinfo { get; set; }
        [ProtoMember(4)] public long Timestamp { get; set; }
        [ProtoMember(5)] public LoginSigHead? MsgLoginSigHead { get; set; }
    }

    [ProtoContract]
    internal class RspBody
    {
        [ProtoMember(1)] public QueryHoleRsp? MsgQueryHoleRsp { get; set; }
    }

    [ProtoContract]
    internal class RspDataHighwayHead
    {
        [ProtoMember(1)] public DataHighwayHead? MsgBasehead { get; set; }
        [ProtoMember(2)] public SegHead? MsgSeghead { get; set; }
        [ProtoMember(3)] public int ErrorCode { get; set; }
        [ProtoMember(4)] public int AllowRetry { get; set; }
        [ProtoMember(5)] public int Cachecost { get; set; }
        [ProtoMember(6)] public int Htcost { get; set; }
        [ProtoMember(7)] public byte[] RspExtendinfo { get; set; }
        [ProtoMember(8)] public long Timestamp { get; set; }
        [ProtoMember(9)] public long Range { get; set; }
        [ProtoMember(10)] public int IsReset { get; set; }
    }

    [ProtoContract]
    internal class SegHead
    {
        [ProtoMember(1)] public int Serviceid { get; set; }
        [ProtoMember(2)] public long Filesize { get; set; }
        [ProtoMember(3)] public long Dataoffset { get; set; }
        [ProtoMember(4)] public int Datalength { get; set; }
        [ProtoMember(5)] public int? Rtcode { get; set; }
        [ProtoMember(6)] public byte[] Serviceticket { get; set; }
        [ProtoMember(7)] public int? Flag { get; set; }
        [ProtoMember(8)] public byte[] Md5 { get; set; }
        [ProtoMember(9)] public byte[] FileMd5 { get; set; }
        [ProtoMember(10)] public int CacheAddr { get; set; }
        [ProtoMember(11)] public int QueryTimes { get; set; }
        [ProtoMember(12)] public int UpdateCacheip { get; set; }
    }
}

[ProtoContract]
internal class HwConfigPersistentPB
{
    [ProtoContract]
    internal class HwConfigItemPB
    {
        [ProtoMember(1)] public string Key { get; set; }
        [ProtoMember(2)] public List<HwEndPointPB> EndPointList { get; set; }
    }

    [ProtoContract]
    internal class HwConfigPB
    {
        [ProtoMember(1)] public List<HwConfigItemPB> ConfigItemList { get; set; }
        [ProtoMember(2)] public List<HwNetSegConfPB> NetSegConfList { get; set; }
        [ProtoMember(3)] public List<HwNetSegConfPB> ShortVideoNetConf { get; set; }
        [ProtoMember(4)] public List<HwConfigItemPB> ConfigItemListIp6 { get; set; }
    }

    [ProtoContract]
    internal class HwEndPointPB
    {
        [ProtoMember(1)] public string Host { get; set; }
        [ProtoMember(2)] public int Int32Port { get; set; }
        [ProtoMember(3)] public long Int64Timestampe { get; set; }
    }

    [ProtoContract]
    internal class HwNetSegConfPB
    {
        [ProtoMember(1)] public long Int64NetType { get; set; }
        [ProtoMember(2)] public long Int64SegSize { get; set; }
        [ProtoMember(3)] public long Int64SegNum { get; set; }
        [ProtoMember(4)] public long Int64CurConnNum { get; set; }
    }
}

[ProtoContract]
internal class HwSessionInfoPersistentPB
{
    [ProtoContract]
    internal class HwSessionInfoPB
    {
        [ProtoMember(1)] public byte[] HttpconnSigSession { get; set; }
        [ProtoMember(2)] public byte[] SessionKey { get; set; }
    }
}

[ProtoContract]
internal class Subcmd0x501
{
    [ProtoContract]
    internal class ReqBody
    {
        [ProtoMember(1281)] public SubCmd0x501ReqBody? MsgSubcmd0x501ReqBody { get; set; }
    }

    [ProtoContract]
    internal class RspBody
    {
        [ProtoMember(1281)] public SubCmd0x501Rspbody? MsgSubcmd0x501RspBody { get; set; }
    }

    [ProtoContract]
    internal class SubCmd0x501ReqBody
    {
        [ProtoMember(1)] public long Uin { get; set; }
        [ProtoMember(2)] public int IdcId { get; set; }
        [ProtoMember(3)] public int Appid { get; set; }
        [ProtoMember(4)] public int LoginSigType { get; set; }
        [ProtoMember(5)] public byte[] LoginSigTicket { get; set; }
        [ProtoMember(6)] public int RequestFlag { get; set; }
        [ProtoMember(7)] public List<int> Uint32ServiceTypes { get; set; }
        [ProtoMember(8)] public int Bid { get; set; }
        [ProtoMember(9)] public int Term { get; set; }
        [ProtoMember(10)] public int Plat { get; set; }
        [ProtoMember(11)] public int Net { get; set; }
        [ProtoMember(12)] public int Caller { get; set; }
    }

    [ProtoContract]
    internal class SubCmd0x501Rspbody
    {
        [ProtoMember(1)] public byte[] HttpconnSigSession { get; set; }
        [ProtoMember(2)] public byte[] SessionKey { get; set; }
        [ProtoMember(3)] public List<SrvAddrs> MsgHttpconnAddrs { get; set; }
        [ProtoMember(4)] public int PreConnection { get; set; }
        [ProtoMember(5)] public int CsConn { get; set; }
        [ProtoMember(6)] public IpLearnConf? MsgIpLearnConf { get; set; }
        [ProtoMember(7)] public DynTimeOutConf? MsgDynTimeoutConf { get; set; }
        [ProtoMember(8)] public OpenUpConf? MsgOpenUpConf { get; set; }
        [ProtoMember(9)] public DownloadEncryptConf? MsgDownloadEncryptConf { get; set; }
        [ProtoMember(10)] public ShortVideoConf? MsgShortVideoConf { get; set; }
        [ProtoMember(11)] public PTVConf? MsgPtvConf { get; set; }
        [ProtoMember(12)] public int ShareType { get; set; }
        [ProtoMember(13)] public int ShareChannel { get; set; }
        [ProtoMember(14)] public int FmtPolicy { get; set; }
        [ProtoMember(15)] public int BigdataPolicy { get; set; }
        [ProtoMember(16)] public int ConnAttemptDelay { get; set; }
    }

    [ProtoContract]
    internal class DownloadEncryptConf
    {
        [ProtoMember(1)] public bool BoolEnableEncryptRequest { get; set; }
        [ProtoMember(2)] public bool BoolEnableEncryptedPic { get; set; }
        [ProtoMember(3)] public int CtrlFlag { get; set; }
    }

    [ProtoContract]
    internal class DynTimeOutConf
    {
        [ProtoMember(1)] public int Tbase2g { get; set; }
        [ProtoMember(2)] public int Tbase3g { get; set; }
        [ProtoMember(3)] public int Tbase4g { get; set; }
        [ProtoMember(4)] public int TbaseWifi { get; set; }
        [ProtoMember(5)] public int Torg2g { get; set; }
        [ProtoMember(6)] public int Torg3g { get; set; }
        [ProtoMember(7)] public int Torg4g { get; set; }
        [ProtoMember(8)] public int TorgWifi { get; set; }
        [ProtoMember(9)] public int MaxTimeout { get; set; }
        [ProtoMember(10)] public int EnableDynTimeout { get; set; }
        [ProtoMember(11)] public int MaxTimeout2g { get; set; }
        [ProtoMember(12)] public int MaxTimeout3g { get; set; }
        [ProtoMember(13)] public int MaxTimeout4g { get; set; }
        [ProtoMember(14)] public int MaxTimeoutWifi { get; set; }
        [ProtoMember(15)] public int HbTimeout2g { get; set; }
        [ProtoMember(16)] public int HbTimeout3g { get; set; }
        [ProtoMember(17)] public int HbTimeout4g { get; set; }
        [ProtoMember(18)] public int HbTimeoutWifi { get; set; }
        [ProtoMember(19)] public int HbTimeoutDefault { get; set; }
    }

    [ProtoContract]
    internal class Ip6Addr
    {
        [ProtoMember(1)] public int Type { get; set; }
        [ProtoMember(2)] public byte[] Ip6 { get; set; }
        [ProtoMember(3)] public int Port { get; set; }
        [ProtoMember(4)] public int Area { get; set; }
        [ProtoMember(5)] public int SameIsp { get; set; }
    }

    [ProtoContract]
    internal class IpAddr
    {
        [ProtoMember(1)] public int Type { get; set; }
        [ProtoMember(2)] public int Ip { get; set; }
        [ProtoMember(3)] public int Port { get; set; }
        [ProtoMember(4)] public int Area { get; set; }
        [ProtoMember(5)] public int SameIsp { get; set; }
    }


    [ProtoContract]
    internal class IpLearnConf
    {
        [ProtoMember(1)] public int RefreshCachedIp { get; set; }
        [ProtoMember(2)] public int EnableIpLearn { get; set; }
    }

    [ProtoContract]
    internal class NetSegConf
    {
        [ProtoMember(1)] public int NetType { get; set; }
        [ProtoMember(2)] public int Segsize { get; set; }
        [ProtoMember(3)] public int Segnum { get; set; }
        [ProtoMember(4)] public int Curconnnum { get; set; }
    }

    [ProtoContract]
    internal class OpenUpConf
    {
        [ProtoMember(1)] public bool BoolEnableOpenup { get; set; }
        [ProtoMember(2)] public int PreSendSegnum { get; set; }
        [ProtoMember(3)] public int PreSendSegnum3g { get; set; }
        [ProtoMember(4)] public int PreSendSegnum4g { get; set; }
        [ProtoMember(5)] public int PreSendSegnumWifi { get; set; }
    }

    [ProtoContract]
    internal class PTVConf
    {
        [ProtoMember(1)] public int ChannelType { get; set; }
        [ProtoMember(2)] public List<NetSegConf> MsgNetsegconf { get; set; }
        [ProtoMember(3)] public bool BoolOpenHardwareCodec { get; set; }
    }

    [ProtoContract]
    internal class ShortVideoConf
    {
        [ProtoMember(1)] public int ChannelType { get; set; }
        [ProtoMember(2)] public List<NetSegConf> MsgNetsegconf { get; set; }
        [ProtoMember(3)] public bool BoolOpenHardwareCodec { get; set; }
        [ProtoMember(4)] public bool BoolSendAheadSignal { get; set; }
    }

    [ProtoContract]
    internal class SrvAddrs
    {
        [ProtoMember(1)] public int ServiceType { get; set; }
        [ProtoMember(2)] public List<IpAddr> MsgAddrs { get; set; }
        [ProtoMember(3)] public int FragmentSize { get; set; }
        [ProtoMember(4)] public List<NetSegConf> MsgNetsegconf { get; set; }
        [ProtoMember(5)] public List<Ip6Addr> MsgAddrsV6 { get; set; }
    }
}
