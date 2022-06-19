using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

internal class StatSvcSimpleGet {
    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  int  ErrorCode { get; set; }
        [ProtoMember(2)] public  string  Errmsg { get; set; }
        [ProtoMember(3)] public  int  HelloInterval { get; set; }
        [ProtoMember(4)] public  string  Clientip { get; set; }
        [ProtoMember(5)] public  int  ClientBatteyGetInterval { get; set; }
    } 
}
