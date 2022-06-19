using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

internal class Oidb0x6d8
{
    [ProtoContract]
    internal class FileTimeStamp
    {
        [ProtoMember(1)] public int UploadTime { get; set; }
        [ProtoMember(2)] public string FileId { get; set; }
    }

    [ProtoContract]
    internal class GetFileCountReqBody
    {
        [ProtoMember(1)] public long GroupCode { get; set; }
        [ProtoMember(2)] public int AppId { get; set; }
        [ProtoMember(3)] public int BusId { get; set; }
    }

    [ProtoContract]
    internal class GetFileCountRspBody
    {
        [ProtoMember(1)] public int Int32RetCode { get; set; }
        [ProtoMember(2)] public string RetMsg { get; set; }
        [ProtoMember(3)] public string ClientWording { get; set; }
        [ProtoMember(4)] public int AllFileCount { get; set; }
        [ProtoMember(5)] public bool BoolFileTooMany { get; set; }
        [ProtoMember(6)] public int LimitCount { get; set; }
        [ProtoMember(7)] public bool BoolIsFull { get; set; }
    }

    [ProtoContract]
    internal class GetFileInfoReqBody
    {
        [ProtoMember(1)] public long GroupCode { get; set; }
        [ProtoMember(2)] public int AppId { get; set; }
        [ProtoMember(3)] public int BusId { get; set; }
        [ProtoMember(4)] public string FileId { get; set; }
        [ProtoMember(5)] public int FieldFlag { get; set; }
    }

    [ProtoContract]
    internal class GetFileInfoRspBody
    {
        [ProtoMember(1)] public int Int32RetCode { get; set; }
        [ProtoMember(2)] public string RetMsg { get; set; }
        [ProtoMember(3)] public string ClientWording { get; set; }
        [ProtoMember(4)] public GroupFileCommon.FileInfo? FileInfo { get; set; }
    }

    [ProtoContract]
    internal class GetFileListReqBody
    {
        [ProtoMember(1)] public long GroupCode { get; set; }
        [ProtoMember(2)] public int AppId { get; set; }
        [ProtoMember(3)] public string FolderId { get; set; }
        [ProtoMember(4)] public FileTimeStamp? StartTimestamp { get; set; }
        [ProtoMember(5)] public int FileCount { get; set; }
        [ProtoMember(6)] public FileTimeStamp? MaxTimestamp { get; set; }
        [ProtoMember(7)] public int AllFileCount { get; set; }
        [ProtoMember(8)] public int ReqFrom { get; set; }
        [ProtoMember(9)] public int SortBy { get; set; }
        [ProtoMember(10)] public int FilterCode { get; set; }
        [ProtoMember(11)] public long Uin { get; set; }
        [ProtoMember(12)] public int FieldFlag { get; set; }
        [ProtoMember(13)] public int StartIndex { get; set; }
        [ProtoMember(14)] public byte[] Context { get; set; }
        [ProtoMember(15)] public int ClientVersion { get; set; }
        [ProtoMember(16)] public int WhiteList { get; set; }
        [ProtoMember(17)] public int SortOrder { get; set; }
        [ProtoMember(18)] public int ShowOnlinedocFolder { get; set; }
    }

    [ProtoContract]
    internal class GetFileListRspBody
    {
        [ProtoMember(1)] public int Int32RetCode { get; set; }
        [ProtoMember(2)] public string RetMsg { get; set; }
        [ProtoMember(3)] public string ClientWording { get; set; }
        [ProtoMember(4)] public bool BoolIsEnd { get; set; }
        [ProtoMember(5)] public List<Item> ItemList { get; set; }
        [ProtoMember(6)] public FileTimeStamp? MsgMaxTimestamp { get; set; }
        [ProtoMember(7)] public int AllFileCount { get; set; }
        [ProtoMember(8)] public int FilterCode { get; set; }
        [ProtoMember(11)] public bool BoolSafeCheckFlag { get; set; }
        [ProtoMember(12)] public int SafeCheckRes { get; set; }
        [ProtoMember(13)] public int NextIndex { get; set; }
        [ProtoMember(14)] public byte[] Context { get; set; }
        [ProtoMember(15)] public int Role { get; set; }
        [ProtoMember(16)] public int OpenFlag { get; set; }
    }

    [ProtoContract]
    internal class Item
    {
        [ProtoMember(1)] public int Type { get; set; }
        [ProtoMember(2)] public GroupFileCommon.FolderInfo? FolderInfo { get; set; }
        [ProtoMember(3)] public GroupFileCommon.FileInfo? FileInfo { get; set; }
    }


    [ProtoContract]
    internal class GetFilePreviewReqBody
    {
        [ProtoMember(1)] public long GroupCode { get; set; }
        [ProtoMember(2)] public int AppId { get; set; }
        [ProtoMember(3)] public int BusId { get; set; }
        [ProtoMember(4)] public string FileId { get; set; }
    }

    [ProtoContract]
    internal class GetFilePreviewRspBody
    {
        [ProtoMember(1)] public int Int32RetCode { get; set; }
        [ProtoMember(2)] public string RetMsg { get; set; }
        [ProtoMember(3)] public string ClientWording { get; set; }
        [ProtoMember(4)] public int Int32ServerIp { get; set; }
        [ProtoMember(5)] public int Int32ServerPort { get; set; }
        [ProtoMember(6)] public string DownloadDns { get; set; }
        [ProtoMember(7)] public byte[] DownloadUrl { get; set; }
        [ProtoMember(8)] public string CookieVal { get; set; }
        [ProtoMember(9)] public byte[] ReservedField { get; set; }
        [ProtoMember(10)] public byte[] DownloadDnsHttps { get; set; }
        [ProtoMember(11)] public int PreviewPortHttps { get; set; }
    }

    [ProtoContract]
    internal class GetSpaceReqBody
    {
        [ProtoMember(1)] public long GroupCode { get; set; }
        [ProtoMember(2)] public int AppId { get; set; }
    }

    [ProtoContract]
    internal class GetSpaceRspBody
    {
        [ProtoMember(1)] public int Int32RetCode { get; set; }
        [ProtoMember(2)] public string RetMsg { get; set; }
        [ProtoMember(3)] public string ClientWording { get; set; }
        [ProtoMember(4)] public long TotalSpace { get; set; }
        [ProtoMember(5)] public long UsedSpace { get; set; }
        [ProtoMember(6)] public bool BoolAllUpload { get; set; }
    }

    [ProtoContract]
    internal class ReqBody
    {
        [ProtoMember(1)] public Oidb0x6d8.GetFileInfoReqBody? FileInfoReq { get; set; }
        [ProtoMember(2)] public Oidb0x6d8.GetFileListReqBody? FileListInfoReq { get; set; }
        [ProtoMember(3)] public Oidb0x6d8.GetFileCountReqBody? GroupFileCntReq { get; set; }
        [ProtoMember(4)] public GetSpaceReqBody? GroupSpaceReq { get; set; }
        [ProtoMember(5)] public GetFilePreviewReqBody? FilePreviewReq { get; set; }
    }

    [ProtoContract]
    internal class RspBody
    {
        [ProtoMember(1)] public Oidb0x6d8.GetFileInfoRspBody? FileInfoRsp { get; set; }
        [ProtoMember(2)] public Oidb0x6d8.GetFileListRspBody? FileListInfoRsp { get; set; }
        [ProtoMember(3)] public Oidb0x6d8.GetFileCountRspBody? GroupFileCntRsp { get; set; }
        [ProtoMember(4)] public GetSpaceRspBody? GroupSpaceRsp { get; set; }
        [ProtoMember(5)] public GetFilePreviewRspBody? FilePreviewRsp { get; set; }
    }
}
