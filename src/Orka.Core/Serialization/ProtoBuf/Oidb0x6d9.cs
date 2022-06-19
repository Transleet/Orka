using System.Collections.Generic;
using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

internal class Oidb0x6d9
{
    [ProtoContract]
    internal class CopyFromReqBody
    {
        [ProtoMember(1)] public long GroupCode { get; set; }
        [ProtoMember(2)] public int AppId { get; set; }
        [ProtoMember(3)] public int SrcBusId { get; set; }
        [ProtoMember(4)] public byte[] SrcParentFolder { get; set; }
        [ProtoMember(5)] public byte[] SrcFilePath { get; set; }
        [ProtoMember(6)] public int DstBusId { get; set; }
        [ProtoMember(7)] public byte[] DstFolderId { get; set; }
        [ProtoMember(8)] public long FileSize { get; set; }
        [ProtoMember(9)] public string LocalPath { get; set; }
        [ProtoMember(10)] public string FileName { get; set; }
        [ProtoMember(11)] public long SrcUin { get; set; }
        [ProtoMember(12)] public byte[] Md5 { get; set; }
    }

    [ProtoContract]
    internal class CopyFromRspBody
    {
        [ProtoMember(1)] public int Int32RetCode { get; set; }
        [ProtoMember(2)] public string RetMsg { get; set; }
        [ProtoMember(3)] public string ClientWording { get; set; }
        [ProtoMember(4)] public byte[] SaveFilePath { get; set; }
        [ProtoMember(5)] public int BusId { get; set; }
    }

    [ProtoContract]
    internal class CopyToReqBody
    {
        [ProtoMember(1)] public long GroupCode { get; set; }
        [ProtoMember(2)] public int AppId { get; set; }
        [ProtoMember(3)] public int SrcBusId { get; set; }
        [ProtoMember(4)] public string SrcFileId { get; set; }
        [ProtoMember(5)] public int DstBusId { get; set; }
        [ProtoMember(6)] public long DstUin { get; set; }
        [ProtoMember(40)] public string NewFileName { get; set; }
        [ProtoMember(100)] public byte[] TimCloudPdirKey { get; set; }
        [ProtoMember(101)] public byte[] TimCloudPpdirKey { get; set; }
        [ProtoMember(102)] public byte[] TimCloudExtensionInfo { get; set; }
        [ProtoMember(103)] public int TimFileExistOption { get; set; }
    }

    [ProtoContract]
    internal class CopyToRspBody
    {
        [ProtoMember(1)] public int Int32RetCode { get; set; }
        [ProtoMember(2)] public string RetMsg { get; set; }
        [ProtoMember(3)] public string ClientWording { get; set; }
        [ProtoMember(4)] public string SaveFilePath { get; set; }
        [ProtoMember(5)] public int BusId { get; set; }
        [ProtoMember(40)] public string FileName { get; set; }
    }

    [ProtoContract]
    internal class FeedsReqBody
    {
        [ProtoMember(1)] public long GroupCode { get; set; }
        [ProtoMember(2)] public int AppId { get; set; }
        [ProtoMember(3)] public List<GroupFileCommon.FeedsInfo> FeedsInfoList { get; set; }
        [ProtoMember(4)] public int MultiSendSeq { get; set; }
    }

    [ProtoContract]
    internal class FeedsRspBody
    {
        [ProtoMember(1)] public int Int32RetCode { get; set; }
        [ProtoMember(2)] public string RetMsg { get; set; }
        [ProtoMember(3)] public string ClientWording { get; set; }
        [ProtoMember(4)] public List<GroupFileCommon.FeedsResult> FeedsResultList { get; set; }
        [ProtoMember(5)] public int SvrbusyWaitTime { get; set; }
    }

    [ProtoContract]
    internal class ReqBody
    {
        [ProtoMember(1)] public TransFileReqBody? TransFileReq { get; set; }
        [ProtoMember(2)] public CopyFromReqBody? CopyFromReq { get; set; }
        [ProtoMember(3)] public CopyToReqBody? CopyToReq { get; set; }
        [ProtoMember(5)] public FeedsReqBody? FeedsInfoReq { get; set; }
    }

    [ProtoContract]
    internal class RspBody
    {
        [ProtoMember(1)] public TransFileRspBody? TransFileRsp { get; set; }
        [ProtoMember(2)] public CopyFromRspBody? CopyFromRsp { get; set; }
        [ProtoMember(3)] public CopyToRspBody? CopyToRsp { get; set; }
        [ProtoMember(5)] public FeedsRspBody? FeedsInfoRsp { get; set; }
    }

    [ProtoContract]
    internal class TransFileReqBody
    {
        [ProtoMember(1)] public long GroupCode { get; set; }
        [ProtoMember(2)] public int AppId { get; set; }
        [ProtoMember(3)] public int BusId { get; set; }
        [ProtoMember(4)] public string FileId { get; set; }
    }

    [ProtoContract]
    internal class TransFileRspBody
    {
        [ProtoMember(1)] public int Int32RetCode { get; set; }
        [ProtoMember(2)] public string RetMsg { get; set; }
        [ProtoMember(3)] public string ClientWording { get; set; }
        [ProtoMember(4)] public int SaveBusId { get; set; }
        [ProtoMember(5)] public string SaveFilePath { get; set; }
    }
}
