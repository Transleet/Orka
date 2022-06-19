using System.Collections.Generic;
using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

[ProtoContract]
internal class Cmd0x346  {
    [ProtoContract]
    internal class AddrList{
        [ProtoMember(2)] public  List<string>  StrIp { get; set; }
        [ProtoMember(3)] public  string  StrDomain { get; set; }
        [ProtoMember(4)] public  int  Port { get; set; }
    } 

    [ProtoContract]
    internal class ApplyCleanTrafficReq {

    }

    [ProtoContract]
    internal class ApplyCleanTrafficRsp{
        [ProtoMember(10)] public  int  Int32RetCode { get; set; }
        [ProtoMember(20)] public  string  RetMsg { get; set; }
    } 

    [ProtoContract]
    internal class ApplyCopyFromReq{
        [ProtoMember(10)] public  long  SrcUin { get; set; }
        [ProtoMember(20)] public  long  SrcGroup { get; set; }
        [ProtoMember(30)] public  int  SrcSvcid { get; set; }
        [ProtoMember(40)] public  byte[]  SrcParentfolder { get; set; }
        [ProtoMember(50)] public  byte[]  SrcUuid { get; set; }
        [ProtoMember(60)] public  byte[]  FileMd5 { get; set; }
        [ProtoMember(70)] public  long  DstUin { get; set; }
        [ProtoMember(80)] public  long  FileSize { get; set; }
        [ProtoMember(90)] public  string  FileName { get; set; }
        [ProtoMember(100)] public  int  DangerLevel { get; set; }
        [ProtoMember(110)] public  long  TotalSpace { get; set; }
    } 

    [ProtoContract]
    internal class ApplyCopyFromRsp{
        [ProtoMember(10)] public  int  Int32RetCode { get; set; }
        [ProtoMember(20)] public  string  RetMsg { get; set; }
        [ProtoMember(30)] public  byte[]  Uuid { get; set; }
        [ProtoMember(40)] public  long  TotalSpace { get; set; }
    } 

    [ProtoContract]
    internal class ApplyCopyToReq{
        [ProtoMember(10)] public  long  DstId { get; set; }
        [ProtoMember(20)] public  long  DstUin { get; set; }
        [ProtoMember(30)] public  int  DstSvcid { get; set; }
        [ProtoMember(40)] public  long  SrcUin { get; set; }
        [ProtoMember(50)] public  long  FileSize { get; set; }
        [ProtoMember(60)] public  string  FileName { get; set; }
        [ProtoMember(70)] public  string  LocalFilepath { get; set; }
        [ProtoMember(80)] public  byte[]  Uuid { get; set; }
    } 

    [ProtoContract]
    internal class ApplyCopyToRsp{
        [ProtoMember(10)] public  int  Int32RetCode { get; set; }
        [ProtoMember(20)] public  string  RetMsg { get; set; }
        [ProtoMember(30)] public  string  FileKey { get; set; }
    } 

    [ProtoContract]
    internal class ApplyDownloadAbsReq{
        [ProtoMember(10)] public  long  Uin { get; set; }
        [ProtoMember(20)] public  byte[]  Uuid { get; set; }
    } 

    [ProtoContract]
    internal class ApplyDownloadAbsRsp{
        [ProtoMember(10)] public  int  Int32RetCode { get; set; }
        [ProtoMember(20)] public  string  RetMsg { get; set; }
        [ProtoMember(30)] public  Cmd0x346.DownloadInfo?  MsgDownloadInfo { get; set; }
    } 

    [ProtoContract]
    internal class ApplyDownloadReq{
        [ProtoMember(10)] public  long  Uin { get; set; }
        [ProtoMember(20)] public  byte[]  Uuid { get; set; }
        [ProtoMember(30)] public  int  OwnerType { get; set; }
        [ProtoMember(500)] public  int  ExtUintype { get; set; }
        [ProtoMember(501)] public  int  NeedHttpsUrl { get; set; }
    } 

    [ProtoContract]
    internal class ApplyDownloadRsp{
        [ProtoMember(10)] public  int  Int32RetCode { get; set; }
        [ProtoMember(20)] public  string  RetMsg { get; set; }
        [ProtoMember(30)] public  Cmd0x346.DownloadInfo?  MsgDownloadInfo { get; set; }
        [ProtoMember(40)] public  Cmd0x346.FileInfo?  MsgFileInfo { get; set; }
    } 

    [ProtoContract]
    internal class ApplyForwardFileReq{
        [ProtoMember(10)] public  long  SenderUin { get; set; }
        [ProtoMember(20)] public  long  RecverUin { get; set; }
        [ProtoMember(30)] public  byte[]  Uuid { get; set; }
        [ProtoMember(40)] public  int  DangerLevel { get; set; }
        [ProtoMember(50)] public  long  TotalSpace { get; set; }
    } 

    [ProtoContract]
    internal class ApplyForwardFileRsp{
        [ProtoMember(10)] public  int  Int32RetCode { get; set; }
        [ProtoMember(20)] public  string  RetMsg { get; set; }
        [ProtoMember(30)] public  long  TotalSpace { get; set; }
        [ProtoMember(40)] public  long  UsedSpace { get; set; }
        [ProtoMember(50)] public  byte[]  Uuid { get; set; }
    } 

    [ProtoContract]
    internal class ApplyGetTrafficReq {
     
    }

    [ProtoContract]
    internal class ApplyGetTrafficRsp{
        [ProtoMember(10)] public  int  Int32RetCode { get; set; }
        [ProtoMember(20)] public  string  RetMsg { get; set; }
        [ProtoMember(30)] public  long  UseFileSize { get; set; }
        [ProtoMember(40)] public  int  UseFileNum { get; set; }
        [ProtoMember(50)] public  long  AllFileSize { get; set; }
        [ProtoMember(60)] public  int  AllFileNum { get; set; }
    } 

    [ProtoContract]
    internal class ApplyListDownloadReq{
        [ProtoMember(10)] public  long  Uin { get; set; }
        [ProtoMember(20)] public  int  BeginIndex { get; set; }
        [ProtoMember(30)] public  int  ReqCount { get; set; }
    } 

    [ProtoContract]
    internal class ApplyListDownloadRsp{
        [ProtoMember(10)] public  int  Int32RetCode { get; set; }
        [ProtoMember(20)] public  string  RetMsg { get; set; }
        [ProtoMember(30)] public  int  TotalCount { get; set; }
        [ProtoMember(40)] public  int  BeginIndex { get; set; }
        [ProtoMember(50)] public  int  RspCount { get; set; }
        [ProtoMember(60)] public  int  IsEnd { get; set; }
        [ProtoMember(70)] public  List<Cmd0x346.FileInfo>  MsgFileList { get; set; }
    } 

    [ProtoContract]
    internal class ApplyUploadHitReq{
        [ProtoMember(10)] public  long  SenderUin { get; set; }
        [ProtoMember(20)] public  long  RecverUin { get; set; }
        [ProtoMember(30)] public  long  FileSize { get; set; }
        [ProtoMember(40)] public  string  FileName { get; set; }
        [ProtoMember(50)] public  byte[]  _10mMd5 { get; set; }
        [ProtoMember(60)] public  string  LocalFilepath { get; set; }
        [ProtoMember(70)] public  int  DangerLevel { get; set; }
        [ProtoMember(80)] public  long  TotalSpace { get; set; }
    } 

    [ProtoContract]
    internal class ApplyUploadHitReqV2{
        [ProtoMember(10)] public  long  SenderUin { get; set; }
        [ProtoMember(20)] public  long  RecverUin { get; set; }
        [ProtoMember(30)] public  long  FileSize { get; set; }
        [ProtoMember(40)] public  string  FileName { get; set; }
        [ProtoMember(50)] public  byte[]  _10mMd5 { get; set; }
        [ProtoMember(60)] public  byte[]  _3sha { get; set; }
        [ProtoMember(70)] public  byte[]  Sha { get; set; }
        [ProtoMember(80)] public  string  LocalFilepath { get; set; }
        [ProtoMember(90)] public  int  DangerLevel { get; set; }
        [ProtoMember(100)] public  long  TotalSpace { get; set; }
    } 

    [ProtoContract]
    internal class ApplyUploadHitReqV3{
        [ProtoMember(10)] public  long  SenderUin { get; set; }
        [ProtoMember(20)] public  long  RecverUin { get; set; }
        [ProtoMember(30)] public  long  FileSize { get; set; }
        [ProtoMember(40)] public  string  FileName { get; set; }
        [ProtoMember(50)] public  byte[]  _10mMd5 { get; set; }
        [ProtoMember(60)] public  byte[]  Sha { get; set; }
        [ProtoMember(70)] public  string  LocalFilepath { get; set; }
        [ProtoMember(80)] public  int  DangerLevel { get; set; }
        [ProtoMember(90)] public  long  TotalSpace { get; set; }
    } 

    [ProtoContract]
    internal class ApplyUploadHitRsp{
        [ProtoMember(10)] public  int  Int32RetCode { get; set; }
        [ProtoMember(20)] public  string  RetMsg { get; set; }
        [ProtoMember(30)] public  string  UploadIp { get; set; }
        [ProtoMember(40)] public  int  UploadPort { get; set; }
        [ProtoMember(50)] public  string  UploadDomain { get; set; }
        [ProtoMember(60)] public  byte[]  Uuid { get; set; }
        [ProtoMember(70)] public  byte[]  UploadKey { get; set; }
        [ProtoMember(80)] public  long  TotalSpace { get; set; }
        [ProtoMember(90)] public  long  UsedSpace { get; set; }
        [ProtoMember(100)] public  string  UploadDns { get; set; }
    } 

    [ProtoContract]
    internal class ApplyUploadHitRspV2{
        [ProtoMember(10)] public  int  Int32RetCode { get; set; }
        [ProtoMember(20)] public  string  RetMsg { get; set; }
        [ProtoMember(30)] public  string  UploadIp { get; set; }
        [ProtoMember(40)] public  int  UploadPort { get; set; }
        [ProtoMember(50)] public  string  UploadDomain { get; set; }
        [ProtoMember(60)] public  byte[]  Uuid { get; set; }
        [ProtoMember(70)] public  byte[]  UploadKey { get; set; }
        [ProtoMember(80)] public  long  TotalSpace { get; set; }
        [ProtoMember(90)] public  long  UsedSpace { get; set; }
        [ProtoMember(100)] public  int  UploadHttpsPort { get; set; }
        [ProtoMember(110)] public  string  UploadHttpsDomain { get; set; }
        [ProtoMember(120)] public  string  UploadDns { get; set; }
    } 

    [ProtoContract]
    internal class ApplyUploadHitRspV3{
        [ProtoMember(10)] public  int  Int32RetCode { get; set; }
        [ProtoMember(20)] public  string  RetMsg { get; set; }
        [ProtoMember(30)] public  string  UploadIp { get; set; }
        [ProtoMember(40)] public  int  UploadPort { get; set; }
        [ProtoMember(50)] public  string  UploadDomain { get; set; }
        [ProtoMember(60)] public  byte[]  Uuid { get; set; }
        [ProtoMember(70)] public  byte[]  UploadKey { get; set; }
        [ProtoMember(80)] public  long  TotalSpace { get; set; }
        [ProtoMember(90)] public  long  UsedSpace { get; set; }
        [ProtoMember(100)] public  string  UploadDns { get; set; }
    } 

    [ProtoContract]
    internal class ApplyUploadReq{
        [ProtoMember(10)] public  long  SenderUin { get; set; }
        [ProtoMember(20)] public  long  RecverUin { get; set; }
        [ProtoMember(30)] public  int  FileType { get; set; }
        [ProtoMember(40)] public  long  FileSize { get; set; }
        [ProtoMember(50)] public  byte[]  FileName { get; set; }
        [ProtoMember(60)] public  byte[]  _10mMd5 { get; set; }
        [ProtoMember(70)] public  string  LocalFilepath { get; set; }
        [ProtoMember(80)] public  int  DangerLevel { get; set; }
        [ProtoMember(90)] public  long  TotalSpace { get; set; }
    } 

    [ProtoContract]
    internal class ApplyUploadReqV2{
        [ProtoMember(10)] public  long  SenderUin { get; set; }
        [ProtoMember(20)] public  long  RecverUin { get; set; }
        [ProtoMember(30)] public  long  FileSize { get; set; }
        [ProtoMember(40)] public  string  FileName { get; set; }
        [ProtoMember(50)] public  byte[]  _10mMd5 { get; set; }
        [ProtoMember(60)] public  byte[]  _3sha { get; set; }
        [ProtoMember(70)] public  string  LocalFilepath { get; set; }
        [ProtoMember(80)] public  int  DangerLevel { get; set; }
        [ProtoMember(90)] public  long  TotalSpace { get; set; }
    } 

    [ProtoContract]
    internal class ApplyUploadReqV3{
        [ProtoMember(10)] public  long  SenderUin { get; set; }
        [ProtoMember(20)] public  long  RecverUin { get; set; }
        [ProtoMember(30)] public  long  FileSize { get; set; }
        [ProtoMember(40)] public  string  FileName { get; set; }
        [ProtoMember(50)] public  byte[]  _10mMd5 { get; set; }
        [ProtoMember(60)] public  byte[]  Sha { get; set; }
        [ProtoMember(70)] public  string  LocalFilepath { get; set; }
        [ProtoMember(80)] public  int  DangerLevel { get; set; }
        [ProtoMember(90)] public  long  TotalSpace { get; set; }
    } 

    [ProtoContract]
    internal class ApplyUploadRsp{
        [ProtoMember(10)] public  int  Int32RetCode { get; set; }
        [ProtoMember(20)] public  string  RetMsg { get; set; }
        [ProtoMember(30)] public  long  TotalSpace { get; set; }
        [ProtoMember(40)] public  long  UsedSpace { get; set; }
        [ProtoMember(50)] public  long  UploadedSize { get; set; }
        [ProtoMember(60)] public  string  UploadIp { get; set; }
        [ProtoMember(70)] public  string  UploadDomain { get; set; }
        [ProtoMember(80)] public  int  UploadPort { get; set; }
        [ProtoMember(90)] public  byte[]  Uuid { get; set; }
        [ProtoMember(100)] public  byte[]  UploadKey { get; set; }
        [ProtoMember(110)] public  bool  BoolFileExist { get; set; }
        [ProtoMember(120)] public  int  PackSize { get; set; }
        [ProtoMember(130)] public  List<string>  StrUploadipList { get; set; }
        [ProtoMember(140)] public  string  UploadDns { get; set; }
    } 

    [ProtoContract]
    internal class ApplyUploadRspV2{
        [ProtoMember(10)] public  int  Int32RetCode { get; set; }
        [ProtoMember(20)] public  string  RetMsg { get; set; }
        [ProtoMember(30)] public  long  TotalSpace { get; set; }
        [ProtoMember(40)] public  long  UsedSpace { get; set; }
        [ProtoMember(50)] public  long  UploadedSize { get; set; }
        [ProtoMember(60)] public  string  UploadIp { get; set; }
        [ProtoMember(70)] public  string  UploadDomain { get; set; }
        [ProtoMember(80)] public  int  UploadPort { get; set; }
        [ProtoMember(90)] public  byte[]  Uuid { get; set; }
        [ProtoMember(100)] public  byte[]  UploadKey { get; set; }
        [ProtoMember(110)] public  bool  BoolFileExist { get; set; }
        [ProtoMember(120)] public  int  PackSize { get; set; }
        [ProtoMember(130)] public  List<string>  StrUploadipList { get; set; }
        [ProtoMember(140)] public  int  HttpsvrApiVer { get; set; }
        [ProtoMember(141)] public  byte[]  Sha { get; set; }
        [ProtoMember(142)] public  int  UploadHttpsPort { get; set; }
        [ProtoMember(143)] public  string  UploadHttpsDomain { get; set; }
        [ProtoMember(150)] public  string  UploadDns { get; set; }
        [ProtoMember(160)] public  string  UploadLanip { get; set; }
    } 

    [ProtoContract]
    internal class ApplyUploadRspV3{
        [ProtoMember(10)] public  int  Int32RetCode { get; set; }
        [ProtoMember(20)] public  string  RetMsg { get; set; }
        [ProtoMember(30)] public  long  TotalSpace { get; set; }
        [ProtoMember(40)] public  long  UsedSpace { get; set; }
        [ProtoMember(50)] public  long  UploadedSize { get; set; }
        [ProtoMember(60)] public  string  UploadIp { get; set; }
        [ProtoMember(70)] public  string  UploadDomain { get; set; }
        [ProtoMember(80)] public  int  UploadPort { get; set; }
        [ProtoMember(90)] public  byte[]  Uuid { get; set; }
        [ProtoMember(100)] public  byte[]  UploadKey { get; set; }
        [ProtoMember(110)] public  bool  BoolFileExist { get; set; }
        [ProtoMember(120)] public  int  PackSize { get; set; }
        [ProtoMember(130)] public  List<string>  StrUploadipList { get; set; }
        [ProtoMember(140)] public  int  UploadHttpsPort { get; set; }
        [ProtoMember(150)] public  string  UploadHttpsDomain { get; set; }
        [ProtoMember(160)] public  string  UploadDns { get; set; }
        [ProtoMember(170)] public  string  UploadLanip { get; set; }
    } 

    [ProtoContract]
    internal class DeleteFileReq{
        [ProtoMember(10)] public  long  Uin { get; set; }
        [ProtoMember(20)] public  long  PeerUin { get; set; }
        [ProtoMember(30)] public  int  DeleteType { get; set; }
        [ProtoMember(40)] public  byte[]  Uuid { get; set; }
    } 

    [ProtoContract]
    internal class DeleteFileRsp{
        [ProtoMember(10)] public  int  Int32RetCode { get; set; }
        [ProtoMember(20)] public  string  RetMsg { get; set; }
    } 

    [ProtoContract]
    internal class DelMessageReq{
        [ProtoMember(1)] public  long  UinSender { get; set; }
        [ProtoMember(2)] public  long  UinReceiver { get; set; }
        [ProtoMember(10)] public  int  MsgTime { get; set; }
        [ProtoMember(20)] public  int  MsgRandom { get; set; }
        [ProtoMember(30)] public  int  MsgSeqNo { get; set; }
    } 

    [ProtoContract]
    internal class DownloadInfo{
        [ProtoMember(10)] public  byte[]  DownloadKey { get; set; }
        [ProtoMember(20)] public  string  DownloadIp { get; set; }
        [ProtoMember(30)] public  string  DownloadDomain { get; set; }
        [ProtoMember(40)] public  int  Port { get; set; }
        [ProtoMember(50)] public  string  DownloadUrl { get; set; }
        [ProtoMember(60)] public  List<string>  StrDownloadipList { get; set; }
        [ProtoMember(70)] public  string  Cookie { get; set; }
        [ProtoMember(80)] public  int  HttpsPort { get; set; }
        [ProtoMember(90)] public  string  HttpsDownloadDomain { get; set; }
        [ProtoMember(110)] public  string  DownloadDns { get; set; }
    } 

    [ProtoContract]
    internal class DownloadSuccReq{
        [ProtoMember(10)] public  long  Uin { get; set; }
        [ProtoMember(20)] public  byte[]  Uuid { get; set; }
    } 

    [ProtoContract]
    internal class DownloadSuccRsp{
        [ProtoMember(10)] public  int  Int32RetCode { get; set; }
        [ProtoMember(20)] public  string  RetMsg { get; set; }
        [ProtoMember(30)] public  int  Int32DownStat { get; set; }
    } 

    [ProtoContract]
    internal class ExtensionReq{
        [ProtoMember(1)] public  long  Id { get; set; }
        [ProtoMember(2)] public  long  Type { get; set; }
        [ProtoMember(3)] public  string  DstPhonenum { get; set; }
        [ProtoMember(4)] public  int  Int32PhoneConvertType { get; set; }
        [ProtoMember(20)] public  byte[]  Sig { get; set; }
        [ProtoMember(100)] public  long  RouteId { get; set; }
        [ProtoMember(90100)] public  Cmd0x346.DelMessageReq?  MsgDelMessageReq { get; set; }
        [ProtoMember(90200)] public  int  DownloadUrlType { get; set; }
        [ProtoMember(90300)] public  int  PttFormat { get; set; }
        [ProtoMember(90400)] public  int  IsNeedInnerIp { get; set; }
        [ProtoMember(90500)] public  int  NetType { get; set; }
        [ProtoMember(90600)] public  int  VoiceType { get; set; }
        [ProtoMember(90700)] public  int  FileType { get; set; }
        [ProtoMember(90800)] public  int  PttTime { get; set; }
        [ProtoMember(90900)] public  int  BdhCmdid { get; set; }
        [ProtoMember(91000)] public  int  ReqTransferType { get; set; }
        [ProtoMember(91100)] public  int  IsAuto { get; set; }
    } 

    [ProtoContract]
    internal class ExtensionRsp{
        [ProtoMember(1)] public  int  TransferType { get; set; }
        [ProtoMember(2)] public  int  ChannelType { get; set; }
        [ProtoMember(3)] public  int  AllowRetry { get; set; }
        [ProtoMember(4)] public  Cmd0x346.AddrList?  ServerAddrIpv6List { get; set; }
    } 

    [ProtoContract]
    internal class FileInfo{
        [ProtoMember(1)] public  long  Uin { get; set; }
        [ProtoMember(2)] public  int  DangerEvel { get; set; }
        [ProtoMember(3)] public  long  FileSize { get; set; }
        [ProtoMember(4)] public  int  LifeTime { get; set; }
        [ProtoMember(5)] public  int  UploadTime { get; set; }
        [ProtoMember(6)] public  byte[]  Uuid { get; set; }
        [ProtoMember(7)] public  string  FileName { get; set; }
        [ProtoMember(90)] public  int  AbsFileType { get; set; }
        [ProtoMember(100)] public  byte[]  _10mMd5 { get; set; }
        [ProtoMember(101)] public  byte[]  Sha { get; set; }
        [ProtoMember(110)] public  int  ClientType { get; set; }
        [ProtoMember(120)] public  long  OwnerUin { get; set; }
        [ProtoMember(121)] public  long  PeerUin { get; set; }
        [ProtoMember(130)] public  int  ExpireTime { get; set; }
    } 

    [ProtoContract]
    internal class FileQueryReq{
        [ProtoMember(10)] public  long  Uin { get; set; }
        [ProtoMember(20)] public  byte[]  Uuid { get; set; }
    } 

    [ProtoContract]
    internal class FileQueryRsp{
        [ProtoMember(10)] public  int  Int32RetCode { get; set; }
        [ProtoMember(20)] public  string  RetMsg { get; set; }
        [ProtoMember(30)] public  Cmd0x346.FileInfo?  MsgFileInfo { get; set; }
    } 

    [ProtoContract]
    internal class RecallFileReq{
        [ProtoMember(1)] public  long  Uin { get; set; }
        [ProtoMember(2)] public  byte[]  Uuid { get; set; }
    } 

    [ProtoContract]
    internal class RecallFileRsp{
        [ProtoMember(1)] public  int  Int32RetCode { get; set; }
        [ProtoMember(2)] public  string  RetMsg { get; set; }
    } 

    [ProtoContract]
    internal class RecvListQueryReq{
        [ProtoMember(1)] public  long  Uin { get; set; }
        [ProtoMember(2)] public  int  BeginIndex { get; set; }
        [ProtoMember(3)] public  int  ReqCount { get; set; }
    } 

    [ProtoContract]
    internal class RecvListQueryRsp{
        [ProtoMember(1)] public  int  Int32RetCode { get; set; }
        [ProtoMember(2)] public  string  RetMsg { get; set; }
        [ProtoMember(3)] public  int  FileTotCount { get; set; }
        [ProtoMember(4)] public  int  BeginIndex { get; set; }
        [ProtoMember(5)] public  int  RspFileCount { get; set; }
        [ProtoMember(6)] public  int  IsEnd { get; set; }
        [ProtoMember(7)] public  List<Cmd0x346.FileInfo>  MsgFileList { get; set; }
    } 

    [ProtoContract]
    internal class RenewFileReq{
        [ProtoMember(1)] public  long  Uin { get; set; }
        [ProtoMember(2)] public  byte[]  Uuid { get; set; }
        [ProtoMember(3)] public  int  AddTtl { get; set; }
    } 

    [ProtoContract]
    internal class RenewFileRsp{
        [ProtoMember(1)] public  int  Int32RetCode { get; set; }
        [ProtoMember(2)] public  string  RetMsg { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  int  Cmd { get; set; }
        [ProtoMember(2)] public  int  Seq { get; set; }
        [ProtoMember(3)] public  Cmd0x346.RecvListQueryReq?  MsgRecvListQueryReq { get; set; }
        [ProtoMember(4)] public  Cmd0x346.SendListQueryReq?  MsgSendListQueryReq { get; set; }
        [ProtoMember(5)] public  Cmd0x346.RenewFileReq?  MsgRenewFileReq { get; set; }
        [ProtoMember(6)] public  Cmd0x346.RecallFileReq?  MsgRecallFileReq { get; set; }
        [ProtoMember(7)] public  Cmd0x346.ApplyUploadReq?  MsgApplyUploadReq { get; set; }
        [ProtoMember(8)] public  Cmd0x346.ApplyUploadHitReq?  MsgApplyUploadHitReq { get; set; }
        [ProtoMember(9)] public  Cmd0x346.ApplyForwardFileReq?  MsgApplyForwardFileReq { get; set; }
        [ProtoMember(10)] public  Cmd0x346.UploadSuccReq?  MsgUploadSuccReq { get; set; }
        [ProtoMember(11)] public  Cmd0x346.DeleteFileReq?  MsgDeleteFileReq { get; set; }
        [ProtoMember(12)] public  Cmd0x346.DownloadSuccReq?  MsgDownloadSuccReq { get; set; }
        [ProtoMember(13)] public  Cmd0x346.ApplyDownloadAbsReq?  MsgApplyDownloadAbsReq { get; set; }
        [ProtoMember(14)] public  Cmd0x346.ApplyDownloadReq?  MsgApplyDownloadReq { get; set; }
        [ProtoMember(15)] public  Cmd0x346.ApplyListDownloadReq?  MsgApplyListDownloadReq { get; set; }
        [ProtoMember(16)] public  Cmd0x346.FileQueryReq?  MsgFileQueryReq { get; set; }
        [ProtoMember(17)] public  Cmd0x346.ApplyCopyFromReq?  MsgApplyCopyFromReq { get; set; }
        [ProtoMember(18)] public  Cmd0x346.ApplyUploadReqV2?  MsgApplyUploadReqV2 { get; set; }
        [ProtoMember(19)] public  Cmd0x346.ApplyUploadReqV3?  MsgApplyUploadReqV3 { get; set; }
        [ProtoMember(20)] public  Cmd0x346.ApplyUploadHitReqV2?  MsgApplyUploadHitReqV2 { get; set; }
        [ProtoMember(21)] public  Cmd0x346.ApplyUploadHitReqV3?  MsgApplyUploadHitReqV3 { get; set; }
        [ProtoMember(101)] public  int  BusinessId { get; set; }
        [ProtoMember(102)] public  int  ClientType { get; set; }
        [ProtoMember(90000)] public  Cmd0x346.ApplyCopyToReq?  MsgApplyCopyToReq { get; set; }
        [ProtoMember(90001)] public  Cmd0x346.ApplyCleanTrafficReq?  MsgApplyCleanTrafficReq { get; set; }
        [ProtoMember(90002)] public  Cmd0x346.ApplyGetTrafficReq?  MsgApplyGetTrafficReq { get; set; }
        [ProtoMember(99999)] public  Cmd0x346.ExtensionReq?  MsgExtensionReq { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  int  Cmd { get; set; }
        [ProtoMember(2)] public  int  Seq { get; set; }
        [ProtoMember(3)] public  Cmd0x346.RecvListQueryRsp?  MsgRecvListQueryRsp { get; set; }
        [ProtoMember(4)] public  Cmd0x346.SendListQueryRsp?  MsgSendListQueryRsp { get; set; }
        [ProtoMember(5)] public  Cmd0x346.RenewFileRsp?  MsgRenewFileRsp { get; set; }
        [ProtoMember(6)] public  Cmd0x346.RecallFileRsp?  MsgRecallFileRsp { get; set; }
        [ProtoMember(7)] public  Cmd0x346.ApplyUploadRsp?  MsgApplyUploadRsp { get; set; }
        [ProtoMember(8)] public  Cmd0x346.ApplyUploadHitRsp?  MsgApplyUploadHitRsp { get; set; }
        [ProtoMember(9)] public  Cmd0x346.ApplyForwardFileRsp?  MsgApplyForwardFileRsp { get; set; }
        [ProtoMember(10)] public  Cmd0x346.UploadSuccRsp?  MsgUploadSuccRsp { get; set; }
        [ProtoMember(11)] public  Cmd0x346.DeleteFileRsp?  MsgDeleteFileRsp { get; set; }
        [ProtoMember(12)] public  Cmd0x346.DownloadSuccRsp?  MsgDownloadSuccRsp { get; set; }
        [ProtoMember(13)] public  Cmd0x346.ApplyDownloadAbsRsp?  MsgApplyDownloadAbsRsp { get; set; }
        [ProtoMember(14)] public  Cmd0x346.ApplyDownloadRsp?  MsgApplyDownloadRsp { get; set; }
        [ProtoMember(15)] public  Cmd0x346.ApplyListDownloadRsp?  MsgApplyListDownloadRsp { get; set; }
        [ProtoMember(16)] public  Cmd0x346.FileQueryRsp?  MsgFileQueryRsp { get; set; }
        [ProtoMember(17)] public  Cmd0x346.ApplyCopyFromRsp?  MsgApplyCopyFromRsp { get; set; }
        [ProtoMember(18)] public  Cmd0x346.ApplyUploadRspV2?  MsgApplyUploadRspV2 { get; set; }
        [ProtoMember(19)] public  Cmd0x346.ApplyUploadRspV3?  MsgApplyUploadRspV3 { get; set; }
        [ProtoMember(20)] public  Cmd0x346.ApplyUploadHitRspV2?  MsgApplyUploadHitRspV2 { get; set; }
        [ProtoMember(21)] public  Cmd0x346.ApplyUploadHitRspV3?  MsgApplyUploadHitRspV3 { get; set; }
        [ProtoMember(90000)] public  Cmd0x346.ApplyCopyToRsp?  MsgApplyCopyToRsp { get; set; }
        [ProtoMember(90001)] public  Cmd0x346.ApplyCleanTrafficRsp?  MsgApplyCleanTrafficRsp { get; set; }
        [ProtoMember(90002)] public  Cmd0x346.ApplyGetTrafficRsp?  MsgApplyGetTrafficRsp { get; set; }
        [ProtoMember(99999)] public  Cmd0x346.ExtensionRsp?  MsgExtensionRsp { get; set; }
    } 

    [ProtoContract]
    internal class SendListQueryReq{
        [ProtoMember(1)] public  long  Uin { get; set; }
        [ProtoMember(2)] public  int  BeginIndex { get; set; }
        [ProtoMember(3)] public  int  ReqCount { get; set; }
    } 

    [ProtoContract]
    internal class SendListQueryRsp{
        [ProtoMember(1)] public  int  Int32RetCode { get; set; }
        [ProtoMember(2)] public  string  RetMsg { get; set; }
        [ProtoMember(3)] public  int  FileTotCount { get; set; }
        [ProtoMember(4)] public  int  BeginIndex { get; set; }
        [ProtoMember(5)] public  int  RspFileCount { get; set; }
        [ProtoMember(6)] public  int  IsEnd { get; set; }
        [ProtoMember(7)] public  long  TotLimit { get; set; }
        [ProtoMember(8)] public  long  UsedLimit { get; set; }
        [ProtoMember(9)] public  List<Cmd0x346.FileInfo>  MsgFileList { get; set; }
    } 

    [ProtoContract]
    internal class UploadSuccReq{
        [ProtoMember(10)] public  long  SenderUin { get; set; }
        [ProtoMember(20)] public  long  RecverUin { get; set; }
        [ProtoMember(30)] public  byte[]  Uuid { get; set; }
    } 

    [ProtoContract]
    internal class UploadSuccRsp{
        [ProtoMember(10)] public  int  Int32RetCode { get; set; }
        [ProtoMember(20)] public  string  RetMsg { get; set; }
        [ProtoMember(30)] public  Cmd0x346.FileInfo?  MsgFileInfo { get; set; }
    } 
}
