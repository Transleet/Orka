using System.Collections.Generic;
using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

[ProtoContract]
internal class Oidb0xeac  {
    [ProtoContract]
    internal class ArkMsg{
        [ProtoMember(1)] public  string  AppName { get; set; }
        [ProtoMember(2)] public  string  Json { get; set; }
    } 

    [ProtoContract]
    internal class BatchReqBody{
        [ProtoMember(1)] public  long  GroupCode { get; set; }
        [ProtoMember(2)] public  List<Oidb0xeac.MsgInfo>  Msgs { get; set; }
    } 

    [ProtoContract]
    internal class BatchRspBody{
        [ProtoMember(1)] public  string  Wording { get; set; }
        [ProtoMember(2)] public  int  ErrorCode { get; set; }
        [ProtoMember(3)] public  int  SuccCnt { get; set; }
        [ProtoMember(4)] public  List<Oidb0xeac.MsgProcessInfo>  MsgProcInfos { get; set; }
        [ProtoMember(5)] public  int  DigestTime { get; set; }
    } 

    [ProtoContract]
    internal class DigestMsg{
        [ProtoMember(1)] public  long  GroupCode { get; set; }
        [ProtoMember(2)] public  int  MsgSeq { get; set; }
        [ProtoMember(3)] public  int  MsgRandom { get; set; }
        [ProtoMember(4)] public  List<Oidb0xeac.MsgElem>  MsgContent { get; set; }
        [ProtoMember(5)] public  long  TextSize { get; set; }
        [ProtoMember(6)] public  long  PicSize { get; set; }
        [ProtoMember(7)] public  long  VideoSize { get; set; }
        [ProtoMember(8)] public  long  SenderUin { get; set; }
        [ProtoMember(9)] public  int  SenderTime { get; set; }
        [ProtoMember(10)] public  long  AddDigestUin { get; set; }
        [ProtoMember(11)] public  int  AddDigestTime { get; set; }
        [ProtoMember(12)] public  int  StartTime { get; set; }
        [ProtoMember(13)] public  int  LatestMsgSeq { get; set; }
        [ProtoMember(14)] public  int  OpType { get; set; }
    } 

    [ProtoContract]
    internal class FaceMsg{
        [ProtoMember(1)] public  int  Index { get; set; }
        [ProtoMember(2)] public  string  Text { get; set; }
    } 

    [ProtoContract]
    internal class GroupFileMsg{
        [ProtoMember(1)] public  byte[]  FileName { get; set; }
        [ProtoMember(2)] public  int  BusId { get; set; }
        [ProtoMember(3)] public  string  FileId { get; set; }
        [ProtoMember(4)] public  long  FileSize { get; set; }
        [ProtoMember(5)] public  long  DeadTime { get; set; }
        [ProtoMember(6)] public  byte[]  FileSha1 { get; set; }
        [ProtoMember(7)] public  byte[]  Ext { get; set; }
        [ProtoMember(8)] public  byte[]  FileMd5 { get; set; }
    } 

    [ProtoContract]
    internal class ImageMsg{
        [ProtoMember(1)] public  string  Md5 { get; set; }
        [ProtoMember(2)] public  string  Uuid { get; set; }
        [ProtoMember(3)] public  int  ImgType { get; set; }
        [ProtoMember(4)] public  int  FileSize { get; set; }
        [ProtoMember(5)] public  int  Width { get; set; }
        [ProtoMember(6)] public  int  Height { get; set; }
        [ProtoMember(101)] public  int  FileId { get; set; }
        [ProtoMember(102)] public  int  ServerIp { get; set; }
        [ProtoMember(103)] public  int  ServerPort { get; set; }
        [ProtoMember(104)] public  string  FilePath { get; set; }
        [ProtoMember(201)] public  string  ThumbUrl { get; set; }
        [ProtoMember(202)] public  string  OriginalUrl { get; set; }
        [ProtoMember(203)] public  string  ResaveUrl { get; set; }
    } 

    [ProtoContract]
    internal class MsgElem{
        [ProtoMember(1)] public  int  MsgType { get; set; }
        [ProtoMember(11)] public  Oidb0xeac.TextMsg?  TextMsg { get; set; }
        [ProtoMember(12)] public  Oidb0xeac.FaceMsg?  FaceMsg { get; set; }
        [ProtoMember(13)] public  Oidb0xeac.ImageMsg?  ImageMsg { get; set; }
        [ProtoMember(14)] public  Oidb0xeac.GroupFileMsg?  GroupFileMsg { get; set; }
        [ProtoMember(15)] public  Oidb0xeac.ShareMsg?  ShareMsg { get; set; }
        [ProtoMember(16)] public  Oidb0xeac.RichMsg?  RichMsg { get; set; }
        [ProtoMember(17)] public  Oidb0xeac.ArkMsg?  ArkMsg { get; set; }
    } 

    [ProtoContract]
    internal class MsgInfo{
        [ProtoMember(1)] public  int  MsgSeq { get; set; }
        [ProtoMember(2)] public  int  MsgRandom { get; set; }
    } 

    [ProtoContract]
    internal class MsgProcessInfo{
        [ProtoMember(1)] public  Oidb0xeac.MsgInfo?  Msg { get; set; }
        [ProtoMember(2)] public  int  ErrorCode { get; set; }
        [ProtoMember(3)] public  long  DigestUin { get; set; }
        [ProtoMember(4)] public  int  DigestTime { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  long  GroupCode { get; set; }
        [ProtoMember(2)] public  int  MsgSeq { get; set; }
        [ProtoMember(3)] public  int  MsgRandom { get; set; }
    } 

    [ProtoContract]
    internal class RichMsg{
        [ProtoMember(1)] public  int  ServiceId { get; set; }
        [ProtoMember(2)] public  string  Xml { get; set; }
        [ProtoMember(3)] public  string  LongMsgResid { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  string  Wording { get; set; }
        [ProtoMember(2)] public  long  DigestUin { get; set; }
        [ProtoMember(3)] public  int  DigestTime { get; set; }
        [ProtoMember(4)] public  Oidb0xeac.DigestMsg?  Msg { get; set; }
        [ProtoMember(10)] public  int  ErrorCode { get; set; }
    } 

    [ProtoContract]
    internal class ShareMsg{
        [ProtoMember(1)] public  string  Type { get; set; }
        [ProtoMember(2)] public  string  Title { get; set; }
        [ProtoMember(3)] public  string  Summary { get; set; }
        [ProtoMember(4)] public  string  Brief { get; set; }
        [ProtoMember(5)] public  string  Url { get; set; }
        [ProtoMember(6)] public  string  PictureUrl { get; set; }
        [ProtoMember(7)] public  string  Action { get; set; }
        [ProtoMember(8)] public  string  Source { get; set; }
        [ProtoMember(9)] public  string  SourceUrl { get; set; }
    } 

    [ProtoContract]
    internal class TextMsg{
        [ProtoMember(1)] public  byte[]  Str { get; set; }
    } 
}
