using System.Collections.Generic;
using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

internal class GroupFileCommon  {

    [ProtoContract]
    internal class FeedsInfo{
        [ProtoMember(1)] public  int  BusId { get; set; }
        [ProtoMember(2)] public  string  FileId { get; set; }
        [ProtoMember(3)] public  int  MsgRandom { get; set; }
        [ProtoMember(4)] public  byte[]  Ext { get; set; }
        [ProtoMember(5)] public  int  FeedFlag { get; set; }
        [ProtoMember(6)] public  MsgCtrl?  MsgCtrl { get; set; }
    } 

    [ProtoContract]
    internal class FeedsResult{
        [ProtoMember(1)] public  int  Int32RetCode { get; set; }
        [ProtoMember(2)] public  string  Detail { get; set; }
        [ProtoMember(3)] public  string  FileId { get; set; }
        [ProtoMember(4)] public  int  BusId { get; set; }
        [ProtoMember(5)] public  int  DeadTime { get; set; }
    } 

    [ProtoContract]
    internal class FileInfo{
        [ProtoMember(1)] public  string  FileId { get; set; }
        [ProtoMember(2)] public  string  FileName { get; set; }
        [ProtoMember(3)] public  long  FileSize { get; set; }
        [ProtoMember(4)] public  int  BusId { get; set; }
        [ProtoMember(5)] public  long  UploadedSize { get; set; }
        [ProtoMember(6)] public  int  UploadTime { get; set; }
        [ProtoMember(7)] public  int  DeadTime { get; set; }
        [ProtoMember(8)] public  int  ModifyTime { get; set; }
        [ProtoMember(9)] public  int  DownloadTimes { get; set; }
        [ProtoMember(10)] public  byte[]  Sha { get; set; }
        [ProtoMember(11)] public  byte[]  Sha3 { get; set; }
        [ProtoMember(12)] public  byte[]  Md5 { get; set; }
        [ProtoMember(13)] public  string  LocalPath { get; set; }
        [ProtoMember(14)] public  string  UploaderName { get; set; }
        [ProtoMember(15)] public  long  UploaderUin { get; set; }
        [ProtoMember(16)] public  string  ParentFolderId { get; set; }
        [ProtoMember(17)] public  int  SafeType { get; set; }
        [ProtoMember(20)] public  byte[]  FileBlobExt { get; set; }
        [ProtoMember(21)] public  long  OwnerUin { get; set; }
        [ProtoMember(22)] public  string  FeedId { get; set; }
        [ProtoMember(23)] public  byte[]  ReservedField { get; set; }
    } 

    [ProtoContract]
    internal class FileInfoTmem{
        [ProtoMember(1)] public  long  GroupCode { get; set; }
        [ProtoMember(2)] public  List<FileInfo>  Files { get; set; }
    } 

    [ProtoContract]
    internal class FileItem{
        [ProtoMember(1)] public  int  Type { get; set; }
        [ProtoMember(2)] public  FolderInfo?  FolderInfo { get; set; }
        [ProtoMember(3)] public  FileInfo?  FileInfo { get; set; }
    } 

    [ProtoContract]
    internal class FolderInfo{
        [ProtoMember(1)] public  string  FolderId { get; set; }
        [ProtoMember(2)] public  string  ParentFolderId { get; set; }
        [ProtoMember(3)] public  string  FolderName { get; set; }
        [ProtoMember(4)] public  int  CreateTime { get; set; }
        [ProtoMember(5)] public  int  ModifyTime { get; set; }
        [ProtoMember(6)] public  long  CreateUin { get; set; }
        [ProtoMember(7)] public  string  CreatorName { get; set; }
        [ProtoMember(8)] public  int  TotalFileCount { get; set; }
        [ProtoMember(9)] public  long  ModifyUin { get; set; }
        [ProtoMember(10)] public  string  ModifyName { get; set; }
        [ProtoMember(11)] public  long  UsedSpace { get; set; }
    } 

    [ProtoContract]
    internal class FolderInfoTmem{
        [ProtoMember(1)] public  long  GroupCode { get; set; }
        [ProtoMember(2)] public  List<FolderInfo>  Folders { get; set; }
    } 

    [ProtoContract]
    internal class OverwriteInfo{
        [ProtoMember(1)] public  string  FileId { get; set; }
        [ProtoMember(2)] public  int  DownloadTimes { get; set; }
    } 
}
