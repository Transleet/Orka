using System.Collections.Generic;
using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

[ProtoContract]
internal class Cmd0x352
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
    internal class GetImgUrlReq
    {
        [ProtoMember(1)] public long SrcUin { get; set; }
        [ProtoMember(2)] public long DstUin { get; set; }
        [ProtoMember(3)] public byte[] FileResid { get; set; }
        [ProtoMember(4)] public int UrlFlag { get; set; }
        [ProtoMember(6)] public int UrlType { get; set; }
        [ProtoMember(7)] public int ReqTerm { get; set; }
        [ProtoMember(8)] public int ReqPlatformType { get; set; }
        [ProtoMember(9)] public int SrcFileType { get; set; }
        [ProtoMember(10)] public int InnerIp { get; set; }
        [ProtoMember(11)] public bool BoolAddressBook { get; set; }
        [ProtoMember(12)] public int BuType { get; set; }
        [ProtoMember(13)] public byte[] BuildVer { get; set; }
        [ProtoMember(14)] public int PicUpTimestamp { get; set; }
        [ProtoMember(15)] public int ReqTransferType { get; set; }
    }

    [ProtoContract]
    internal class GetImgUrlRsp
    {
        [ProtoMember(1)] public byte[] FileResid { get; set; }
        [ProtoMember(2)] public int ClientIp { get; set; }
        [ProtoMember(3)] public int Result { get; set; }
        [ProtoMember(4)] public byte[] FailMsg { get; set; }
        [ProtoMember(5)] public List<byte[]> BytesThumbDownUrl { get; set; }
        [ProtoMember(6)] public List<byte[]> BytesOriginalDownUrl { get; set; }
        [ProtoMember(7)] public ImgInfo? MsgImgInfo { get; set; }
        [ProtoMember(8)] public List<int> Uint32DownIp { get; set; }
        [ProtoMember(9)] public List<int> Uint32DownPort { get; set; }
        [ProtoMember(10)] public byte[] ThumbDownPara { get; set; }
        [ProtoMember(11)] public byte[] OriginalDownPara { get; set; }
        [ProtoMember(12)] public byte[] DownDomain { get; set; }
        [ProtoMember(13)] public List<byte[]> BytesBigDownUrl { get; set; }
        [ProtoMember(14)] public byte[] BigDownPara { get; set; }
        [ProtoMember(15)] public byte[] BigThumbDownPara { get; set; }
        [ProtoMember(16)] public int HttpsUrlFlag { get; set; }
        [ProtoMember(26)] public List<IPv6Info> MsgDownIp6 { get; set; }
        [ProtoMember(27)] public byte[] ClientIp6 { get; set; }
    }

    [ProtoContract]
    internal class ImgInfo
    {
        [ProtoMember(1)] public byte[] FileMd5 { get; set; }
        [ProtoMember(2)] public int FileType { get; set; }
        [ProtoMember(3)] public long FileSize { get; set; }
        [ProtoMember(4)] public int FileWidth { get; set; }
        [ProtoMember(5)] public int FileHeight { get; set; }
        [ProtoMember(6)] public long FileFlag { get; set; }
        [ProtoMember(7)] public int FileCutPos { get; set; }
    }

    [ProtoContract]
    internal class IPv6Info
    {
        [ProtoMember(1)] public byte[] Ip6 { get; set; }
        [ProtoMember(2)] public int Port { get; set; }
    }

    [ProtoContract]
    internal class ReqBody
    {
        [ProtoMember(1)] public int Subcmd { get; set; }
        [ProtoMember(2)] public List<TryUpImgReq> MsgTryupImgReq { get; set; }
        [ProtoMember(3)] public List<GetImgUrlReq> MsgGetimgUrlReq { get; set; }
        [ProtoMember(4)] public List<DelImgReq> MsgDelImgReq { get; set; }
        [ProtoMember(10)] public int NetType { get; set; }
    }

    [ProtoContract]
    internal class RspBody
    {
        [ProtoMember(1)] public int Subcmd { get; set; }
        [ProtoMember(2)] public List<TryUpImgRsp> MsgTryupImgRsp { get; set; }
        [ProtoMember(3)] public List<GetImgUrlRsp> MsgGetimgUrlRsp { get; set; }
        [ProtoMember(4)] public bool BoolNewBigchan { get; set; }
        [ProtoMember(5)] public List<DelImgRsp> MsgDelImgRsp { get; set; }
        [ProtoMember(10)] public string? FailMsg { get; set; }
    }

    [ProtoContract]
    internal class TryUpImgReq
    {
        [ProtoMember(1)] public long SrcUin { get; set; }
        [ProtoMember(2)] public long DstUin { get; set; }
        [ProtoMember(3)] public long FileId { get; set; }
        [ProtoMember(4)] public byte[] FileMd5 { get; set; }
        [ProtoMember(5)] public long FileSize { get; set; }
        [ProtoMember(6)] public string FileName { get; set; }
        [ProtoMember(7)] public int SrcTerm { get; set; }
        [ProtoMember(8)] public int PlatformType { get; set; }
        [ProtoMember(9)] public int InnerIP { get; set; }
        [ProtoMember(10)] public bool AddressBook { get; set; }
        [ProtoMember(11)] public int Retry { get; set; }
        [ProtoMember(12)] public int BuType { get; set; }
        [ProtoMember(13)] public bool ImgOriginal { get; set; }
        [ProtoMember(14)] public int ImgWidth { get; set; }
        [ProtoMember(15)] public int ImgHeight { get; set; }
        /**
         * ImgType:
         *  JPG:    1000
         *  PNG:    1001
         *  WEBP:   1002
         *  BMP:    1005
         *  GIG:    2000
         *  APNG:   2001
         *  SHARPP: 1004
         */
        [ProtoMember(16)] public int ImgType { get; set; }
        [ProtoMember(17)] public string BuildVer { get; set; }
        [ProtoMember(18)] public byte[] FileIndex { get; set; }
        [ProtoMember(19)] public int FileStoreDays { get; set; }
        [ProtoMember(20)] public int StepFlag { get; set; }
        [ProtoMember(21)] public bool RejectTryFast { get; set; }
        [ProtoMember(22)] public int SrvUpload { get; set; }
        [ProtoMember(23)] public byte[] TransferUrl { get; set; }
    }

    [ProtoContract]
    internal class TryUpImgRsp
    {
        [ProtoMember(1)] public long FileId { get; set; }
        [ProtoMember(2)] public int ClientIp { get; set; }
        [ProtoMember(3)] public int Result { get; set; }
        [ProtoMember(4)] public string FailMsg { get; set; }
        [ProtoMember(5)] public bool BoolFileExit { get; set; }
        [ProtoMember(6)] public ImgInfo? MsgImgInfo { get; set; }
        [ProtoMember(7)] public List<int> Uint32UpIp { get; set; }
        [ProtoMember(8)] public List<int> Uint32UpPort { get; set; }
        [ProtoMember(9)] public byte[] UpUkey { get; set; }
        [ProtoMember(10)] public string UpResid { get; set; }
        [ProtoMember(11)] public string UpUuid { get; set; }
        [ProtoMember(12)] public long UpOffset { get; set; }
        [ProtoMember(13)] public long BlockSize { get; set; }
        [ProtoMember(14)] public byte[] EncryptDstip { get; set; }
        [ProtoMember(15)] public int Roamdays { get; set; }
        [ProtoMember(26)] public List<IPv6Info> MsgUpIp6 { get; set; }
        [ProtoMember(27)] public byte[] ClientIp6 { get; set; }
        [ProtoMember(60)] public byte[] ThumbDownPara { get; set; }
        [ProtoMember(61)] public byte[] OriginalDownPara { get; set; }
        [ProtoMember(62)] public byte[] DownDomain { get; set; }
        [ProtoMember(64)] public byte[] BigDownPara { get; set; }
        [ProtoMember(65)] public byte[] BigThumbDownPara { get; set; }
        [ProtoMember(66)] public int HttpsUrlFlag { get; set; }
        [ProtoMember(1001)] public TryUpInfo4Busi? MsgInfo4busi { get; set; }
    }

    [ProtoContract]
    internal class TryUpInfo4Busi
    {
        [ProtoMember(1)] public byte[] FileResid { get; set; }
        [ProtoMember(2)] public byte[] DownDomain { get; set; }
        [ProtoMember(3)] public byte[] ThumbDownUrl { get; set; }
        [ProtoMember(4)] public byte[] OriginalDownUrl { get; set; }
        [ProtoMember(5)] public byte[] BigDownUrl { get; set; }
    }
}
