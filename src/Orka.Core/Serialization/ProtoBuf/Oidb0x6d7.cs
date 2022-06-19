using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

internal class Oidb0x6d7  {
    [ProtoContract]
    internal class CreateFolderReqBody{
        [ProtoMember(1)] public  long  GroupCode { get; set; }
        [ProtoMember(2)] public  int  AppId { get; set; }
        [ProtoMember(3)] public  string  ParentFolderId { get; set; }
        [ProtoMember(4)] public  string  FolderName { get; set; }
    } 

    [ProtoContract]
    internal class CreateFolderRspBody{
        [ProtoMember(1)] public  int  Int32RetCode { get; set; }
        [ProtoMember(2)] public  string  RetMsg { get; set; }
        [ProtoMember(3)] public  string  ClientWording { get; set; }
        [ProtoMember(4)] public  GroupFileCommon.FolderInfo?  FolderInfo { get; set; }
    } , CheckableStruct

    [ProtoContract]
    internal class DeleteFolderReqBody{
        [ProtoMember(1)] public  long  GroupCode { get; set; }
        [ProtoMember(2)] public  int  AppId { get; set; }
        [ProtoMember(3)] public  string  FolderId { get; set; }
    } 

    [ProtoContract]
    internal class DeleteFolderRspBody:CheckableStruct
    {
        [ProtoMember(1)] public  int  Int32RetCode { get; set; }
        [ProtoMember(2)] public  string  RetMsg { get; set; }
        [ProtoMember(3)] public  string  ClientWording { get; set; }
    }

    [ProtoContract]
    internal class MoveFolderReqBody{
        [ProtoMember(1)] public  long  GroupCode { get; set; }
        [ProtoMember(2)] public  int  AppId { get; set; }
        [ProtoMember(3)] public  string  FolderId { get; set; }
        [ProtoMember(4)] public  string  ParentFolderId { get; set; }
        [ProtoMember(5)] public  string  DestFolderId { get; set; }
    } 

    [ProtoContract]
    internal class MoveFolderRspBody{
        [ProtoMember(1)] public  int  Int32RetCode { get; set; }
        [ProtoMember(2)] public  string  RetMsg { get; set; }
        [ProtoMember(3)] public  string  ClientWording { get; set; }
        [ProtoMember(4)] public  GroupFileCommon.FolderInfo?  FolderInfo { get; set; }
    } , CheckableStruct

    [ProtoContract]
    internal class RenameFolderReqBody{
        [ProtoMember(1)] public  long  GroupCode { get; set; }
        [ProtoMember(2)] public  int  AppId { get; set; }
        [ProtoMember(3)] public  string  FolderId { get; set; }
        [ProtoMember(4)] public  string  NewFolderName { get; set; }
    } 

    [ProtoContract]
    internal class RenameFolderRspBody{
        [ProtoMember(1)] public  int  Int32RetCode { get; set; }
        [ProtoMember(2)] public  string  RetMsg { get; set; }
        [ProtoMember(3)] public  string  ClientWording { get; set; }
        [ProtoMember(4)] public  GroupFileCommon.FolderInfo?  FolderInfo { get; set; }
    } , CheckableStruct

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  CreateFolderReqBody?  CreateFolderReq { get; set; }
        [ProtoMember(2)] public  DeleteFolderReqBody?  DeleteFolderReq { get; set; }
        [ProtoMember(3)] public  RenameFolderReqBody?  RenameFolderReq { get; set; }
        [ProtoMember(4)] public  MoveFolderReqBody?  MoveFolderReq { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  CreateFolderRspBody?  CreateFolderRsp { get; set; }
        [ProtoMember(2)] public  DeleteFolderRspBody?  DeleteFolderRsp { get; set; }
        [ProtoMember(3)] public  RenameFolderRspBody?  RenameFolderRsp { get; set; }
        [ProtoMember(4)] public  MoveFolderRspBody?  MoveFolderRsp { get; set; }
    } 
}
