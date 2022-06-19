using System.Collections.Generic;
using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

internal class Oidb0x6d6  {
    [ProtoContract]
    internal class DeleteFileReqBody{
        [ProtoMember(1)] public  long  GroupCode { get; set; }
        [ProtoMember(2)] public  int  AppId { get; set; }
        [ProtoMember(3)] public  int  BusId { get; set; }
        [ProtoMember(4)] public  string  ParentFolderId { get; set; }
        [ProtoMember(5)] public  string  FileId { get; set; }
        [ProtoMember(6)] public  int  MsgdbSeq { get; set; }
        [ProtoMember(7)] public  int  MsgRand { get; set; }
    } 

    [ProtoContract]
    internal class DeleteFileRspBody{
        /**
         * -103: file not exist
         */
        [ProtoMember(1)] public  int  Int32RetCode { get; set; }
        [ProtoMember(2)] public  string  RetMsg { get; set; }
        [ProtoMember(3)] public  string  ClientWording { get; set; }
    } , CheckableStruct

    [ProtoContract]
    internal class DownloadFileReqBody{
        [ProtoMember(1)] public  long  GroupCode { get; set; }
        [ProtoMember(2)] public  int  AppId { get; set; }
        [ProtoMember(3)] public  int  BusId { get; set; }
        [ProtoMember(4)] public  string  FileId { get; set; }
        [ProtoMember(5)] public  bool  BoolThumbnailReq { get; set; }
        [ProtoMember(6)] public  int  UrlType { get; set; }
        [ProtoMember(7)] public  bool  BoolPreviewReq { get; set; }
        [ProtoMember(8)] public  int  Src { get; set; }
    } 

    [ProtoContract]
    internal class DownloadFileRspBody{
        [ProtoMember(1)] public  int  Int32RetCode { get; set; }
        [ProtoMember(2)] public  string  RetMsg { get; set; }
        [ProtoMember(3)] public  string  ClientWording { get; set; }
        [ProtoMember(4)] public  string  DownloadIp { get; set; }
        [ProtoMember(5)] public  byte[]  DownloadDns { get; set; }
        [ProtoMember(6)] public  byte[]  DownloadUrl { get; set; }
        [ProtoMember(7)] public  byte[]  Sha { get; set; }
        [ProtoMember(8)] public  byte[]  Sha3 { get; set; }
        [ProtoMember(9)] public  byte[]  Md5 { get; set; }
        [ProtoMember(10)] public  string  CookieVal { get; set; }
        [ProtoMember(11)] public  string  SaveFileName { get; set; }
        [ProtoMember(12)] public  int  PreviewPort { get; set; }
        [ProtoMember(13)] public  string  DownloadDnsHttps { get; set; }
        [ProtoMember(14)] public  int  PreviewPortHttps { get; set; }
    } , CheckableStruct

    [ProtoContract]
    internal class MoveFileReqBody{
        [ProtoMember(1)] public  long  GroupCode { get; set; }
        [ProtoMember(2)] public  int  AppId { get; set; }
        [ProtoMember(3)] public  int  BusId { get; set; }
        [ProtoMember(4)] public  string  FileId { get; set; }
        [ProtoMember(5)] public  string  ParentFolderId { get; set; }
        [ProtoMember(6)] public  string  DestFolderId { get; set; }
    } 

    [ProtoContract]
    internal class MoveFileRspBody{
        [ProtoMember(1)] public  int  Int32RetCode { get; set; }
        [ProtoMember(2)] public  string  RetMsg { get; set; }
        [ProtoMember(3)] public  string  ClientWording { get; set; }
        [ProtoMember(4)] public  string  ParentFolderId { get; set; }
    } , CheckableStruct

    [ProtoContract]
    internal class RenameFileReqBody{
        [ProtoMember(1)] public  long  GroupCode { get; set; }
        [ProtoMember(2)] public  int  AppId { get; set; }
        [ProtoMember(3)] public  int  BusId { get; set; }
        [ProtoMember(4)] public  string  FileId { get; set; }
        [ProtoMember(5)] public  string  ParentFolderId { get; set; }
        [ProtoMember(6)] public  string  NewFileName { get; set; }
    } 

    [ProtoContract]
    internal class RenameFileRspBody{
        [ProtoMember(1)] public  int  Int32RetCode { get; set; }
        [ProtoMember(2)] public  string  RetMsg { get; set; }
        [ProtoMember(3)] public  string  ClientWording { get; set; }
    } , CheckableStruct

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  UploadFileReqBody?  UploadFileReq { get; set; }
        [ProtoMember(2)] public  ResendReqBody?  ResendFileReq { get; set; }
        [ProtoMember(3)] public  DownloadFileReqBody?  DownloadFileReq { get; set; }
        [ProtoMember(4)] public  DeleteFileReqBody?  DeleteFileReq { get; set; }
        [ProtoMember(5)] public  RenameFileReqBody?  RenameFileReq { get; set; }
        [ProtoMember(6)] public  MoveFileReqBody?  MoveFileReq { get; set; }
    } 

    [ProtoContract]
    internal class ResendReqBody{
        [ProtoMember(1)] public  long  GroupCode { get; set; }
        [ProtoMember(2)] public  int  AppId { get; set; }
        [ProtoMember(3)] public  int  BusId { get; set; }
        [ProtoMember(4)] public  string  FileId { get; set; }
        [ProtoMember(5)] public  byte[]  Sha { get; set; }
    } 

    [ProtoContract]
    internal class ResendRspBody{
        [ProtoMember(1)] public  int  Int32RetCode { get; set; }
        [ProtoMember(2)] public  string  RetMsg { get; set; }
        [ProtoMember(3)] public  string  ClientWording { get; set; }
        [ProtoMember(4)] public  string  UploadIp { get; set; }
        [ProtoMember(5)] public  byte[]  FileKey { get; set; }
        [ProtoMember(6)] public  byte[]  CheckKey { get; set; }
    } , CheckableStruct

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  UploadFileRspBody?  UploadFileRsp { get; set; }
        [ProtoMember(2)] public  ResendRspBody?  ResendFileRsp { get; set; }
        [ProtoMember(3)] public  DownloadFileRspBody?  DownloadFileRsp { get; set; }
        [ProtoMember(4)] public  DeleteFileRspBody?  DeleteFileRsp { get; set; }
        [ProtoMember(5)] public  RenameFileRspBody?  RenameFileRsp { get; set; }
        [ProtoMember(6)] public  MoveFileRspBody?  MoveFileRsp { get; set; }
    } 

    [ProtoContract]
    internal class UploadFileReqBody{
        [ProtoMember(1)] public  long  GroupCode { get; set; }
        [ProtoMember(2)] public  int  AppId { get; set; }
        [ProtoMember(3)] public  int  BusId { get; set; }
        [ProtoMember(4)] public  int  Entrance { get; set; }
        [ProtoMember(5)] public  string  ParentFolderId { get; set; }
        [ProtoMember(6)] public  string  FileName { get; set; }
        [ProtoMember(7)] public  string  LocalPath { get; set; }
        [ProtoMember(8)] public  long  FileSize { get; set; }
        [ProtoMember(9)] public  byte[]  Sha { get; set; }
        [ProtoMember(10)] public  byte[]  Sha3 { get; set; }
        [ProtoMember(11)] public  byte[]  Md5 { get; set; }
        [ProtoMember(15)] public  bool  BoolSupportMultiUpload { get; set; }
    } 

    [ProtoContract]
    internal class UploadFileRspBody{
        [ProtoMember(1)] public  int  Int32RetCode { get; set; }
        [ProtoMember(2)] public  string  RetMsg { get; set; }
        [ProtoMember(3)] public  string  ClientWording { get; set; }
        [ProtoMember(4)] public  string  UploadIp { get; set; }
        [ProtoMember(5)] public  string  ServerDns { get; set; }
        [ProtoMember(6)] public  int  BusId { get; set; }
        [ProtoMember(7)] public  string  FileId { get; set; }
        [ProtoMember(8)] public  byte[]  FileKey { get; set; }
        [ProtoMember(9)] public  byte[]  CheckKey { get; set; }
        [ProtoMember(10)] public  bool  BoolFileExist { get; set; }
        [ProtoMember(12)] public  List<string>  UploadIpLanV4 { get; set; }
        [ProtoMember(13)] public  List<string>  UploadIpLanV6 { get; set; }
        [ProtoMember(14)] public  int  UploadPort { get; set; }
    } , CheckableStruct
}
