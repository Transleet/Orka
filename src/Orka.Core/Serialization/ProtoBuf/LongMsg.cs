using System.Collections.Generic;
using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

internal class LongMsg  {
    [ProtoContract]
    internal class MsgDeleteReq{
        [ProtoMember(1)] public  byte[]  MsgResid { get; set; }
        [ProtoMember(2)] public  int  MsgType { get; set; }
    } 

    [ProtoContract]
    internal class MsgDeleteRsp{
        [ProtoMember(1)] public  int  Result { get; set; }
        [ProtoMember(2)] public  byte[]  MsgResid { get; set; }
    } 

    [ProtoContract]
    internal class MsgDownReq{
        [ProtoMember(1)] public  int  SrcUin { get; set; }
        [ProtoMember(2)] public  byte[]  MsgResid { get; set; }
        [ProtoMember(3)] public  int  MsgType { get; set; }
        [ProtoMember(4)] public  int  NeedCache { get; set; }
    } 

    [ProtoContract]
    internal class MsgDownRsp{
        [ProtoMember(1)] public  int  Result { get; set; }
        [ProtoMember(2)] public  byte[]  MsgResid { get; set; }
        [ProtoMember(3)] public  byte[]  MsgContent { get; set; }
    } 

    [ProtoContract]
    internal class MsgUpReq{
        [ProtoMember(1)] public  int  MsgType { get; set; }
        [ProtoMember(2)] public  long  DstUin { get; set; }
        [ProtoMember(3)] public  int  MsgId { get; set; }
        [ProtoMember(4)] public  byte[]  MsgContent { get; set; }
        [ProtoMember(5)] public  int  StoreType { get; set; }
        [ProtoMember(6)] public  byte[]  MsgUkey { get; set; }
        [ProtoMember(7)] public  int  NeedCache { get; set; }
    } 

    [ProtoContract]
    internal class MsgUpRsp{
        [ProtoMember(1)] public  int  Result { get; set; }
        [ProtoMember(2)] public  int  MsgId { get; set; }
        [ProtoMember(3)] public  byte[]  MsgResid { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  int  Subcmd { get; set; }
        [ProtoMember(2)] public  int  TermType { get; set; }
        [ProtoMember(3)] public  int  PlatformType { get; set; }
        [ProtoMember(4)] public  List<LongMsg.MsgUpReq>  MsgUpReq { get; set; }
        [ProtoMember(5)] public  List<LongMsg.MsgDownReq>  MsgDownReq { get; set; }
        [ProtoMember(6)] public  List<LongMsg.MsgDeleteReq>  MsgDelReq { get; set; }
        [ProtoMember(10)] public  int  AgentType { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  int  Subcmd { get; set; }
        [ProtoMember(2)] public  List<LongMsg.MsgUpRsp>  MsgUpRsp { get; set; }
        [ProtoMember(3)] public  List<LongMsg.MsgDownRsp>  MsgDownRsp { get; set; }
        [ProtoMember(4)] public  List<LongMsg.MsgDeleteRsp>  MsgDelRsp { get; set; }
    } 
}
