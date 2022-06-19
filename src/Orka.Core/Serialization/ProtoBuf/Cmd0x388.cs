using System.Collections.Generic;
using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

[ProtoContract]
internal class Cmd0x388
{
    [ProtoContract]
    internal class DelImgReq
    {
        [ProtoMember(1)] public long SrcUin { get; set; }
        [ProtoMember(2)] public long DstUin { get; set; }
        [ProtoMember(3)] public int ReqTerm { get; set; }
        [ProtoMember(4)] public int ReqPlatformType { get; set; }
        [ProtoMember(5)] public int BuType { get; set; }
        [ProtoMember(6)] public byte[] BuildVer { get; set; }
        [ProtoMember(7)] public byte[] FileResid { get; set; }
        [ProtoMember(8)] public int PicWidth { get; set; }
        [ProtoMember(9)] public int PicHeight { get; set; }
    }

    [ProtoContract]
    internal class DelImgRsp
    {
        [ProtoMember(1)] public int Result { get; set; }
        [ProtoMember(2)] public byte[] FailMsg { get; set; }
        [ProtoMember(3)] public byte[] FileResid { get; set; }
    }

    [ProtoContract]
    internal class ExpRoamExtendInfo
    {
        [ProtoMember(1)] public byte[] Resid { get; set; }
    }

    [ProtoContract]
    internal class ExpRoamPicInfo
    {
        [ProtoMember(1)] public int ShopFlag { get; set; }
        [ProtoMember(2)] public int PkgId { get; set; }
        [ProtoMember(3)] public byte[] PicId { get; set; }
    }

    [ProtoContract]
    internal class ExtensionCommPicTryUp
    {
        [ProtoMember(1)] public List<byte[]> BytesExtinfo { get; set; }
    }

    [ProtoContract]
    internal class ExtensionExpRoamTryUp
    {
        [ProtoMember(1)] public List<ExpRoamPicInfo> MsgExproamPicInfo { get; set; }
    }

    [ProtoContract]
    internal class GetImgUrlReq
    {
        [ProtoMember(1)] public long GroupCode { get; set; }
        [ProtoMember(2)] public long DstUin { get; set; }
        [ProtoMember(3)] public long Fileid { get; set; }
        [ProtoMember(4)] public byte[] FileMd5 { get; set; }
        [ProtoMember(5)] public int UrlFlag { get; set; }
        [ProtoMember(6)] public int UrlType { get; set; }
        [ProtoMember(7)] public int ReqTerm { get; set; }
        [ProtoMember(8)] public int ReqPlatformType { get; set; }
        [ProtoMember(9)] public int InnerIp { get; set; }
        [ProtoMember(10)] public int BuType { get; set; }
        [ProtoMember(11)] public byte[] BuildVer { get; set; }
        [ProtoMember(12)] public long FileId { get; set; }
        [ProtoMember(13)] public long FileSize { get; set; }
        [ProtoMember(14)] public int OriginalPic { get; set; }
        [ProtoMember(15)] public int RetryReq { get; set; }
        [ProtoMember(16)] public int FileHeight { get; set; }
        [ProtoMember(17)] public int FileWidth { get; set; }
        [ProtoMember(18)] public int PicType { get; set; }
        [ProtoMember(19)] public int PicUpTimestamp { get; set; }
        [ProtoMember(20)] public int ReqTransferType { get; set; }
    }

    [ProtoContract]
    internal class GetImgUrlRsp
    {
        [ProtoMember(1)] public long Fileid { get; set; }
        [ProtoMember(2)] public byte[] FileMd5 { get; set; }
        [ProtoMember(3)] public int Result { get; set; }
        [ProtoMember(4)] public byte[] FailMsg { get; set; }
        [ProtoMember(5)] public ImgInfo? MsgImgInfo { get; set; }
        [ProtoMember(6)] public List<byte[]> BytesThumbDownUrl { get; set; }
        [ProtoMember(7)] public List<byte[]> BytesOriginalDownUrl { get; set; }
        [ProtoMember(8)] public List<byte[]> BytesBigDownUrl { get; set; }
        [ProtoMember(9)] public List<int> Uint32DownIp { get; set; }
        [ProtoMember(10)] public List<int> Uint32DownPort { get; set; }
        [ProtoMember(11)] public byte[] DownDomain { get; set; }
        [ProtoMember(12)] public byte[] ThumbDownPara { get; set; }
        [ProtoMember(13)] public byte[] OriginalDownPara { get; set; }
        [ProtoMember(14)] public byte[] BigDownPara { get; set; }
        [ProtoMember(15)] public long FileId { get; set; }
        [ProtoMember(16)] public int AutoDownType { get; set; }
        [ProtoMember(17)] public List<int> Uint32OrderDownType { get; set; }
        [ProtoMember(19)] public byte[] BigThumbDownPara { get; set; }
        [ProtoMember(20)] public int HttpsUrlFlag { get; set; }
        [ProtoMember(26)] public List<IPv6Info> MsgDownIp6 { get; set; }
        [ProtoMember(27)] public byte[] ClientIp6 { get; set; }
    }

    [ProtoContract]
    internal class GetPttUrlReq
    {
        [ProtoMember(1)] public long GroupCode { get; set; }
        [ProtoMember(2)] public long DstUin { get; set; }
        [ProtoMember(3)] public long Fileid { get; set; }
        [ProtoMember(4)] public byte[] FileMd5 { get; set; }
        [ProtoMember(5)] public int ReqTerm { get; set; }
        [ProtoMember(6)] public int ReqPlatformType { get; set; }
        [ProtoMember(7)] public int InnerIp { get; set; }
        [ProtoMember(8)] public int BuType { get; set; }
        [ProtoMember(9)] public byte[] BuildVer { get; set; }
        [ProtoMember(10)] public long FileId { get; set; }
        [ProtoMember(11)] public byte[] FileKey { get; set; }
        [ProtoMember(12)] public int Codec { get; set; }
        [ProtoMember(13)] public int BuId { get; set; }
        [ProtoMember(14)] public int ReqTransferType { get; set; }
        [ProtoMember(15)] public int IsAuto { get; set; }
    }

    [ProtoContract]
    internal class GetPttUrlRsp
    {
        [ProtoMember(1)] public long Fileid { get; set; }
        [ProtoMember(2)] public byte[] FileMd5 { get; set; }
        [ProtoMember(3)] public int Result { get; set; }
        [ProtoMember(4)] public byte[] FailMsg { get; set; }
        [ProtoMember(5)] public List<byte[]> BytesDownUrl { get; set; }
        [ProtoMember(6)] public List<int> Uint32DownIp { get; set; }
        [ProtoMember(7)] public List<int> Uint32DownPort { get; set; }
        [ProtoMember(8)] public byte[] DownDomain { get; set; }
        [ProtoMember(9)] public byte[] DownPara { get; set; }
        [ProtoMember(10)] public long FileId { get; set; }
        [ProtoMember(11)] public int TransferType { get; set; }
        [ProtoMember(12)] public int AllowRetry { get; set; }
        [ProtoMember(26)] public List<IPv6Info> MsgDownIp6 { get; set; }
        [ProtoMember(27)] public byte[] ClientIp6 { get; set; }
        [ProtoMember(28)] public string StrDomain { get; set; }
    }

    [ProtoContract]
    internal class ImgInfo
    {
        [ProtoMember(1)] public byte[] FileMd5 { get; set; }
        [ProtoMember(2)] public int FileType { get; set; }
        [ProtoMember(3)] public long FileSize { get; set; }
        [ProtoMember(4)] public int FileWidth { get; set; }
        [ProtoMember(5)] public int FileHeight { get; set; }
    }


    [ProtoContract]
    internal class IPv6Info
    {
        [ProtoMember(1)] public byte[] Ip6 { get; set; }
        [ProtoMember(2)] public int Port { get; set; }
    }

    [ProtoContract]
    internal class PicSize
    {
        [ProtoMember(1)] public int Original { get; set; }
        [ProtoMember(2)] public int Thumb { get; set; }
        [ProtoMember(3)] public int High { get; set; }
    }

    [ProtoContract]
    internal class ReqBody
    {
        [ProtoMember(1)] public int NetType { get; set; }
        [ProtoMember(2)] public int Subcmd { get; set; }
        [ProtoMember(3)] public List<TryUpImgReq> MsgTryupImgReq { get; set; }
        [ProtoMember(4)] public List<GetImgUrlReq> MsgGetimgUrlReq { get; set; }
        [ProtoMember(5)] public List<TryUpPttReq> MsgTryupPttReq { get; set; }
        [ProtoMember(6)] public List<Cmd0x388.GetPttUrlReq> MsgGetpttUrlReq { get; set; }
        [ProtoMember(7)] public int CommandId { get; set; }
        [ProtoMember(8)] public List<Cmd0x352.DelImgReq> MsgDelImgReq { get; set; }
        [ProtoMember(1001)] public byte[] Extension { get; set; }
    }

    [ProtoContract]
    internal class RspBody
    {
        [ProtoMember(1)] public int ClientIp { get; set; }
        [ProtoMember(2)] public int Subcmd { get; set; }
        [ProtoMember(3)] public List<TryUpImgRsp> MsgTryupImgRsp { get; set; }
        [ProtoMember(4)] public List<Cmd0x352.GetImgUrlRsp> MsgGetimgUrlRsp { get; set; }
        [ProtoMember(5)] public List<TryUpPttRsp> MsgTryupPttRsp { get; set; }
        [ProtoMember(6)] public List<Cmd0x388.GetPttUrlRsp> MsgGetpttUrlRsp { get; set; }
        [ProtoMember(7)] public List<Cmd0x352.DelImgRsp> MsgDelImgRsp { get; set; }
    }

    [ProtoContract]
    internal class TryUpImgReq
    {
        [ProtoMember(1)] public long GroupCode { get; set; }
        [ProtoMember(2)] public long SrcUin { get; set; }
        [ProtoMember(3)] public long FileId { get; set; }
        [ProtoMember(4)] public byte[] FileMd5 { get; set; }
        [ProtoMember(5)] public long FileSize { get; set; }
        [ProtoMember(6)] public string FileName { get; set; }
        [ProtoMember(7)] public int SrcTerm { get; set; }
        [ProtoMember(8)] public int PlatformType { get; set; }
        /**
         * if uinType = 1 then 1 else2
         *
        UIN_QQ = new UINTYPE(0, 0, "UIN_QQ");
        UIN_EMAIL = new UINTYPE(1, 1, "UIN_EMAIL");
        UIN_MOBILE = new UINTYPE(2, 2, "UIN_MOBILE");
         */
        [ProtoMember(9)] public int BuType { get; set; }
        [ProtoMember(10)] public int PicWidth { get; set; }
        [ProtoMember(11)] public int PicHeight { get; set; }
        [ProtoMember(12)] public int PicType { get; set; }
        [ProtoMember(13)] public string BuildVer { get; set; }
        [ProtoMember(14)] public int InnerIp { get; set; }
        [ProtoMember(15)] public int AppPicType { get; set; }
        [ProtoMember(16)] public int OriginalPic { get; set; }
        [ProtoMember(17)] public byte[] FileIndex { get; set; }
        [ProtoMember(18)] public long DstUin { get; set; }
        [ProtoMember(19)] public int SrvUpload { get; set; }
        [ProtoMember(20)] public byte[] TransferUrl { get; set; }
    }

    [ProtoContract]
    internal class TryUpImgRsp
    {
        [ProtoMember(1)] public long FileId { get; set; }
        [ProtoMember(2)] public int Result { get; set; }
        [ProtoMember(3)] public string FailMsg { get; set; }
        [ProtoMember(4)] public bool BoolFileExit { get; set; }
        [ProtoMember(5)] public Cmd0x352.ImgInfo? MsgImgInfo { get; set; }
        [ProtoMember(6)] public List<int> Uint32UpIp { get; set; }
        [ProtoMember(7)] public List<int> Uint32UpPort { get; set; }
        [ProtoMember(8)] public byte[] UpUkey { get; set; }
        [ProtoMember(9)] public long Fileid { get; set; }
        [ProtoMember(10)] public long UpOffset { get; set; }
        [ProtoMember(11)] public long BlockSize { get; set; }
        [ProtoMember(12)] public bool BoolNewBigChan { get; set; }
        [ProtoMember(26)] public List<IPv6Info> MsgUpIp6 { get; set; }
        [ProtoMember(27)] public byte[] ClientIp6 { get; set; }
        [ProtoMember(1001)] public TryUpInfo4Busi? MsgInfo4busi { get; set; }
    }

    [ProtoContract]
    internal class TryUpInfo4Busi
    {
        [ProtoMember(1)] public byte[] DownDomain { get; set; }
        [ProtoMember(2)] public byte[] ThumbDownUrl { get; set; }
        [ProtoMember(3)] public byte[] OriginalDownUrl { get; set; }
        [ProtoMember(4)] public byte[] BigDownUrl { get; set; }
        [ProtoMember(5)] public byte[] FileResid { get; set; }
    }

    [ProtoContract]
    internal class TryUpPttReq
    {
        [ProtoMember(1)] public long GroupCode { get; set; }
        [ProtoMember(2)] public long SrcUin { get; set; }
        [ProtoMember(3)] public long FileId { get; set; }
        [ProtoMember(4)] public byte[] FileMd5 { get; set; }
        [ProtoMember(5)] public long FileSize { get; set; }
        [ProtoMember(6)] public byte[] FileName { get; set; }
        [ProtoMember(7)] public int SrcTerm { get; set; }
        [ProtoMember(8)] public int PlatformType { get; set; }
        [ProtoMember(9)] public int BuType { get; set; }
        [ProtoMember(10)] public byte[] BuildVer { get; set; }
        [ProtoMember(11)] public int InnerIp { get; set; }
        [ProtoMember(12)] public int VoiceLength { get; set; }
        [ProtoMember(13)] public bool BoolNewUpChan { get; set; }
        [ProtoMember(14)] public int Codec { get; set; }
        [ProtoMember(15)] public int VoiceType { get; set; }
        [ProtoMember(16)] public int BuId { get; set; }
    }

    [ProtoContract]
    internal class TryUpPttRsp
    {
        [ProtoMember(1)] public long FileId { get; set; }
        [ProtoMember(2)] public int Result { get; set; }
        [ProtoMember(3)] public byte[]? FailMsg { get; set; }
        [ProtoMember(4)] public bool BoolFileExit { get; set; }
        [ProtoMember(5)] public List<int> Uint32UpIp { get; set; }
        [ProtoMember(6)] public List<int> Uint32UpPort { get; set; }
        [ProtoMember(7)] public byte[] UpUkey { get; set; }
        [ProtoMember(8)] public long Fileid { get; set; }
        [ProtoMember(9)] public long UpOffset { get; set; }
        [ProtoMember(10)] public long BlockSize { get; set; }
        [ProtoMember(11)] public byte[] FileKey { get; set; }
        [ProtoMember(12)] public int ChannelType { get; set; }
        [ProtoMember(26)] public List<IPv6Info> MsgUpIp6 { get; set; }
        [ProtoMember(27)] public byte[] ClientIp6 { get; set; }
    }
}
