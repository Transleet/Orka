using System.Collections.Generic;
using Org.BouncyCastle.Bcpg;
using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

[ProtoContract]
internal class OidbCmd0xb77  {
    [ProtoContract]
    internal class ArkJsonBody{
        [ProtoMember(10)] public  string  JsonStr { get; set; }
    } 

    [ProtoContract]
    internal class ArkMsgBody{
        [ProtoMember(1)] public  string  App { get; set; }
        [ProtoMember(2)] public  string  View { get; set; }
        [ProtoMember(3)] public  string  Prompt { get; set; }
        [ProtoMember(4)] public  string  Ver { get; set; }
        [ProtoMember(5)] public  string  Desc { get; set; }
        [ProtoMember(6)] public  int  FeatureId { get; set; }
        [ProtoMember(10)] public  string  Meta { get; set; }
        [ProtoMember(11)] public  string  MetaUrl1 { get; set; }
        [ProtoMember(12)] public  string  MetaUrl2 { get; set; }
        [ProtoMember(13)] public  string  MetaUrl3 { get; set; }
        [ProtoMember(14)] public  string  MetaText1 { get; set; }
        [ProtoMember(15)] public  string  MetaText2 { get; set; }
        [ProtoMember(16)] public  string  MetaText3 { get; set; }
        [ProtoMember(20)] public  string  Config { get; set; }
    } 

    [ProtoContract]
    internal class ArkV1MsgBody{
        [ProtoMember(1)] public  string  App { get; set; }
        [ProtoMember(2)] public  string  View { get; set; }
        [ProtoMember(3)] public  string  Prompt { get; set; }
        [ProtoMember(4)] public  string  Ver { get; set; }
        [ProtoMember(5)] public  string  Desc { get; set; }
        [ProtoMember(6)] public  int  FeatureId { get; set; }
        [ProtoMember(10)] public  string  Meta { get; set; }
        [ProtoMember(11)] public  List<TemplateItem>  Items { get; set; }
        [ProtoMember(20)] public  string  Config { get; set; }
    } 

    [ProtoContract]
    internal class ClientInfo{
        [ProtoMember(1)] public  int  Platform { get; set; }
        [ProtoMember(2)] public  string  SdkVersion { get; set; }
        [ProtoMember(3)] public  string  AndroidPackageName { get; set; }
        [ProtoMember(4)] public  string  AndroidSignature { get; set; }
        [ProtoMember(5)] public  string  IosBundleId { get; set; }
        [ProtoMember(6)] public  string  PcSign { get; set; }
    } 

    [ProtoContract]
    internal class ImageInfo{
        [ProtoMember(1)] public  string  Md5 { get; set; }
        [ProtoMember(2)] public  string  Uuid { get; set; }
        [ProtoMember(3)] public  int  ImgType { get; set; }
        [ProtoMember(4)] public  int  FileSize { get; set; }
        [ProtoMember(5)] public  int  Width { get; set; }
        [ProtoMember(6)] public  int  Height { get; set; }
        [ProtoMember(7)] public  int  Original { get; set; }
        [ProtoMember(101)] public  int  FileId { get; set; }
        [ProtoMember(102)] public  int  ServerIp { get; set; }
        [ProtoMember(103)] public  int  ServerPort { get; set; }
    } 

    [ProtoContract]
    internal class MiniAppMsgBody{
        [ProtoMember(1)] public  long  MiniAppAppid { get; set; }
        [ProtoMember(2)] public  string  MiniAppPath { get; set; }
        [ProtoMember(3)] public  string  WebPageUrl { get; set; }
        [ProtoMember(4)] public  int  MiniAppType { get; set; }
        [ProtoMember(5)] public  string  Title { get; set; }
        [ProtoMember(6)] public  string  Desc { get; set; }
        [ProtoMember(10)] public  string  JsonStr { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  long  Appid { get; set; }
        [ProtoMember(2)] public  int  AppType { get; set; }
        [ProtoMember(3)] public  int  MsgStyle { get; set; }
        [ProtoMember(4)] public  long  SenderUin { get; set; }
        [ProtoMember(5)] public  ClientInfo?  ClientInfo { get; set; }
        //  [ProtoMember(6)] public  String?  TextMsg { get; set; }
        [ProtoMember(7)] public  ExtInfo?  ExtInfo { get; set; }
        [ProtoMember(10)] public  int  SendType { get; set; }
        [ProtoMember(11)] public  long  RecvUin { get; set; }
        [ProtoMember(12)] public  RichMsgBody?  RichMsgBody { get; set; }
        [ProtoMember(13)] public  ArkMsgBody?  ArkMsgBody { get; set; }
        //  [ProtoMember(14)] public  String?  RecvOpenid { get; set; }
        [ProtoMember(15)] public  ArkV1MsgBody?  Arkv1MsgBody { get; set; }
        [ProtoMember(16)] public  ArkJsonBody?  ArkJsonBody { get; set; }
        [ProtoMember(17)] public  XmlMsgBody?  XmlMsgBody { get; set; }
        [ProtoMember(18)] public  MiniAppMsgBody?  MiniAppMsgBody { get; set; }
    } 

    [ProtoContract]
    internal class ExtInfo{
        [ProtoMember(1)] public  List<int>  CustomFeatureId { get; set; }
        [ProtoMember(2)] public  string  ApnsWording { get; set; }
        [ProtoMember(3)] public  int  GroupSaveDbFlag { get; set; }
        [ProtoMember(4)] public  int  ReceiverAppId { get; set; }
        [ProtoMember(5)] public  long  MsgSeq { get; set; }
    } 

    [ProtoContract]
    internal class RichMsgBody{
        [ProtoMember(1)] public  bool  UsingArk { get; set; }
        [ProtoMember(10)] public  string  Title { get; set; }
        [ProtoMember(11)] public  string  Summary { get; set; }
        [ProtoMember(12)] public  string  Brief { get; set; }
        [ProtoMember(13)] public  string  Url { get; set; }
        [ProtoMember(14)] public  string  PictureUrl { get; set; }
        [ProtoMember(15)] public  string  Action { get; set; }
        [ProtoMember(16)] public  string  MusicUrl { get; set; }
        [ProtoMember(21)] public  ImageInfo?  ImageInfo { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  string  Wording { get; set; }
        [ProtoMember(2)] public  int  JumpResult { get; set; }
        [ProtoMember(3)] public  string  JumpUrl { get; set; }
        [ProtoMember(4)] public  int  Level { get; set; }
        [ProtoMember(5)] public  int  SubLevel { get; set; }
        [ProtoMember(6)] public  string  DevelopMsg { get; set; }
    } 

    [ProtoContract]
    internal class TemplateItem{
        [ProtoMember(1)] public  string  Key { get; set; }
        [ProtoMember(2)] public  int  Type { get; set; }
        [ProtoMember(3)] public  string  Value { get; set; }
    } 

    [ProtoContract]
    internal class XmlMsgBody{
        [ProtoMember(11)] public  int  ServiceId { get; set; }
        [ProtoMember(12)] public  string  Xml { get; set; }
    } 
}
