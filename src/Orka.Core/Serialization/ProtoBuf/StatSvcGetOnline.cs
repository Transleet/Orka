using System.Collections.Generic;
using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

internal class StatSvcGetOnline {
    [ProtoContract]
    internal class Instance{
        [ProtoMember(1)] public  int  InstanceId { get; set; }
        [ProtoMember(2)] public  int  ClientType { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  long  Uin { get; set; }
        [ProtoMember(2)] public  int  Appid { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  int  ErrorCode { get; set; }
        [ProtoMember(2)] public  string  ErrorMsg { get; set; }
        [ProtoMember(3)] public  long  Uin { get; set; }
        [ProtoMember(4)] public  int  Appid { get; set; }
        [ProtoMember(5)] public  int  TimeInterval { get; set; }
        [ProtoMember(6)] public  List<StatSvcGetOnline.Instance>  MsgInstances { get; set; }
    } 
}
