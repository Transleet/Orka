using System.Collections.Generic;
using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

[ProtoContract]
internal class Oidb0x769  {
    [ProtoContract]
    internal class Camera{
        [ProtoMember(1)] public  long  Primary { get; set; }
        [ProtoMember(2)] public  long  Secondary { get; set; }
        [ProtoMember(3)] public  bool  Flash { get; set; }
    } 

    [ProtoContract]
    internal class Config{
        [ProtoMember(1)] public  int  Type { get; set; }
        [ProtoMember(2)] public  int  Version { get; set; }
        [ProtoMember(3)] public  List<string>  ContentList { get; set; }
        [ProtoMember(4)] public  string  DebugMsg { get; set; }
        [ProtoMember(5)] public  List<Content>  MsgContentList { get; set; }
    } 

    [ProtoContract]
    internal class ConfigSeq{
        [ProtoMember(1)] public  int  Type { get; set; }
        [ProtoMember(2)] public  int  Version { get; set; }
    } 

    [ProtoContract]
    internal class Content{
        [ProtoMember(1)] public  int  TaskId { get; set; }
        [ProtoMember(2)] public  int  Compress { get; set; }
        [ProtoMember(10)] public  byte[]  Content { get; set; }
    } 

    [ProtoContract]
    internal class CPU{
        [ProtoMember(1)] public  string  Model { get; set; }
        [ProtoMember(2)] public  int  Cores { get; set; }
        [ProtoMember(3)] public  int  Frequency { get; set; }
    } 

    [ProtoContract]
    internal class DeviceInfo{
        [ProtoMember(1)] public  string  Brand { get; set; }
        [ProtoMember(2)] public  string  Model { get; set; }
        [ProtoMember(3)] public  OS?  Os { get; set; }
        [ProtoMember(4)] public  CPU?  Cpu { get; set; }
        [ProtoMember(5)] public  Memory?  Memory { get; set; }
        [ProtoMember(6)] public  Storage?  Storage { get; set; }
        [ProtoMember(7)] public  Screen?  Screen { get; set; }
        [ProtoMember(8)] public  Camera?  Camera { get; set; }
    } 

    [ProtoContract]
    internal class Memory{
        [ProtoMember(1)] public  long  Total { get; set; }
        [ProtoMember(2)] public  long  Process { get; set; }
    } 

    [ProtoContract]
    internal class OS{
        //1 IOS | 2 ANDROID | 3 OTHER
        [ProtoMember(1)] public  int  Type { get; set; }
        [ProtoMember(2)] public  string  Version { get; set; }
        [ProtoMember(3)] public  string  Sdk { get; set; }
        [ProtoMember(4)] public  string  Kernel { get; set; }
        [ProtoMember(5)] public  string  Rom { get; set; }
    } 

    [ProtoContract]
    internal class QueryUinPackageUsageReq{
        [ProtoMember(1)] public  int  Type { get; set; }
        [ProtoMember(2)] public  long  UinFileSize { get; set; }
    } 

    [ProtoContract]
    internal class QueryUinPackageUsageRsp{
        [ProtoMember(1)] public  int  Status { get; set; }
        [ProtoMember(2)] public  long  LeftUinNum { get; set; }
        [ProtoMember(3)] public  long  MaxUinNum { get; set; }
        [ProtoMember(4)] public  int  Proportion { get; set; }
        [ProtoMember(10)] public  List<UinPackageUsedInfo>  UinPackageUsedList { get; set; }
    } 

    [ProtoContract]
    internal class ReqBody{
        [ProtoMember(1)] public  List<ConfigSeq>  ConfigList { get; set; }
        [ProtoMember(2)] public  DeviceInfo?  MsgDeviceInfo { get; set; }
        [ProtoMember(3)] public  string  Info { get; set; }
        [ProtoMember(4)] public  string  Province { get; set; }
        [ProtoMember(5)] public  string  City { get; set; }
        [ProtoMember(6)] public  int  ReqDebugMsg { get; set; }
        [ProtoMember(101)] public  QueryUinPackageUsageReq?  QueryUinPackageUsageReq { get; set; }
    } 

    [ProtoContract]
    internal class RspBody{
        [ProtoMember(1)] public  int  Result { get; set; }
        [ProtoMember(2)] public  List<Config>  ConfigList { get; set; }
        [ProtoMember(101)] public  QueryUinPackageUsageRsp?  QueryUinPackageUsageRsp { get; set; }
    } 

    [ProtoContract]
    internal class Screen{
        [ProtoMember(1)] public  string  Model { get; set; }
        [ProtoMember(2)] public  int  Width { get; set; }
        [ProtoMember(3)] public  int  Height { get; set; }
        [ProtoMember(4)] public  int  Dpi { get; set; }
        [ProtoMember(5)] public  bool  MultiTouch { get; set; }
    } 

    [ProtoContract]
    internal class Storage{
        [ProtoMember(1)] public  long  Builtin { get; set; }
        [ProtoMember(2)] public  long  External { get; set; }
    } 

    [ProtoContract]
    internal class UinPackageUsedInfo{
        [ProtoMember(1)] public  int  RuleId { get; set; }
        [ProtoMember(2)] public  string  Author { get; set; }
        [ProtoMember(3)] public  string  Url { get; set; }
        [ProtoMember(4)] public  long  UinNum { get; set; }
    } 
}
