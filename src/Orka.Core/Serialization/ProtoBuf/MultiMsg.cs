using System.Collections.Generic;
using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

[ProtoContract]
internal class MultiMsg  {
    [ProtoContract]
    internal class ExternMsg{
        [ProtoMember(1)] public  int  ChannelType { get; set; }
    } 

    [ProtoContract]
    internal class MultiMsgApplyDownReq{
        [ProtoMember(1)] public  string  MsgResid { get; set; }
        [ProtoMember(2)] public  int  MsgType { get; set; }
        [ProtoMember(3)] public  long  SrcUin { get; set; }
    } 

    [ProtoContract]
    internal class MultiMsgApplyDownRsp{
        [ProtoMember(1)] public  int  Result { get; set; }
        [ProtoMember(2)] public  string  ThumbDownPara { get; set; }
        [ProtoMember(3)] public  byte[]  MsgKey { get; set; }
        [ProtoMember(4)] public  List<int>  Uint32DownIp { get; set; }
        [ProtoMember(5)] public  List<int>  Uint32DownPort { get; set; }
        [ProtoMember(6)] public  string  MsgResid { get; set; }
        [ProtoMember(7)] public  ExternMsg?  MsgExternInfo { get; set; }
        [ProtoMember(8)] public  List<byte[]>  BytesDownIpV6 { get; set; }
        [ProtoMember(9)] public  List<int>  Uint32DownV6Port { get; set; }
    } 

    [ProtoContract]
    internal class MultiMsgApplyUpReq{
        [ProtoMember(1)] public  long  DstUin { get; set; }
        [ProtoMember(2)] public  long  MsgSize { get; set; }
        [ProtoMember(3)] public  byte[]  MsgMd5 { get; set; }
        [ProtoMember(4)] public  int  MsgType { get; set; }
        [ProtoMember(5)] public  int  ApplyId { get; set; }
    } 

    [ProtoContract]
    internal class MultiMsgApplyUpRsp{
        [ProtoMember(1)] public  int  Result { get; set; }
        [ProtoMember(2)] public  string  MsgResid { get; set; }
        [ProtoMember(3)] public  byte[]  MsgUkey { get; set; }
        [ProtoMember(4)] public  List<int>  Uint32UpIp { get; set; }
        [ProtoMember(5)] public  List<int>  Uint32UpPort { get; set; }
        [ProtoMember(6)] public  long  BlockSize { get; set; }
        [ProtoMember(7)] public  long  UpOffset { get; set; }
        [ProtoMember(8)] public  int  ApplyId { get; set; }
        [ProtoMember(9)] public  byte[]  MsgKey { get; set; }
        [ProtoMember(10)] public  byte[]  MsgSig { get; set; }
        [ProtoMember(11)] public  ExternMsg?  MsgExternInfo { get; set; }
        [ProtoMember(12)] public  List<byte[]>  BytesUpIpV6 { get; set; }
        [ProtoMember(13)] public  List<int>  Uint32UpV6Port { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  int  Subcmd { get; set; }
        [ProtoMember(2)] public  int  TermType { get; set; }
        [ProtoMember(3)] public  int  PlatformType { get; set; }
        [ProtoMember(4)] public  int  NetType { get; set; }
        [ProtoMember(5)] public  string  BuildVer { get; set; }
        [ProtoMember(6)] public  List<MultiMsg.MultiMsgApplyUpReq>  MultimsgApplyupReq { get; set; }
        [ProtoMember(7)] public  List<MultiMsg.MultiMsgApplyDownReq>  MultimsgApplydownReq { get; set; }
        [ProtoMember(8)] public  int  BuType { get; set; }
        [ProtoMember(9)] public  int  ReqChannelType { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  int  Subcmd { get; set; }
        [ProtoMember(2)] public  List<MultiMsg.MultiMsgApplyUpRsp>  MultimsgApplyupRsp { get; set; }
        [ProtoMember(3)] public  List<MultiMsg.MultiMsgApplyDownRsp>  MultimsgApplydownRsp { get; set; }
    } 
}
