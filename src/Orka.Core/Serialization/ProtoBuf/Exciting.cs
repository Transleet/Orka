using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

[ProtoContract]
internal class GroupFileUploadExt{
    [ProtoMember(1)] public  int U1 { get; set; }
    [ProtoMember(2)] public  int U2 { get; set; }
    [ProtoMember(100)] public  GroupFileUploadEntry Entry { get; set; }
    [ProtoMember(3)] public  int U3 { get; set; }
} 

[ProtoContract]
internal class GroupFileUploadEntry{
    [ProtoMember(100)] public  ExcitingBusiInfo Business { get; set; }
    [ProtoMember(200)] public  ExcitingFileEntry FileEntry { get; set; }
    [ProtoMember(300)] public  ExcitingClientInfo ClientInfo { get; set; }
    [ProtoMember(400)] public  ExcitingFileNameInfo FileNameInfo { get; set; }
    [ProtoMember(500)] public  ExcitingHostConfig Host { get; set; }
} 

[ProtoContract]
internal class ExcitingBusiInfo{
    [ProtoMember(1)] public  int BusId { get; set; }
    [ProtoMember(100)] public  long SenderUin { get; set; }
    [ProtoMember(200)] public  long ReceiverUin { get; set; }
    [ProtoMember(400)] public  long GroupCode { get; set; }
} 

[ProtoContract]
internal class ExcitingFileEntry{
    [ProtoMember(100)] public  long FileSize { get; set; }
    [ProtoMember(200)] public  byte[] Md5 { get; set; }
    [ProtoMember(300)] public  byte[] Sha1 { get; set; }
    [ProtoMember(600)] public  byte[] FileId { get; set; }
    [ProtoMember(700)] public  byte[] UploadKey { get; set; }
} 


[ProtoContract]
internal class ExcitingClientInfo{
    [ProtoMember(100)] public  int ClientType { get; set; }
    [ProtoMember(200)] public  string AppId { get; set; }
    [ProtoMember(300)] public  int TerminalType { get; set; }
    [ProtoMember(400)] public  string ClientVer { get; set; }
    [ProtoMember(600)] public  int Unknown { get; set; }
} 

[ProtoContract]
internal class ExcitingFileNameInfo{
    [ProtoMember(100)] public  string Filename { get; set; }
} 

[ProtoContract]
internal class ExcitingHostConfig{
    [ProtoMember(200)] public  List<ExcitingHostInfo> Hosts { get; set; }
} 

[ProtoContract]
internal class ExcitingHostInfo{
    [ProtoMember(1)] public  ExcitingUrlInfo Url { get; set; }
    [ProtoMember(2)] public  int Port { get; set; }
} 

[ProtoContract]
internal class ExcitingUrlInfo{
    [ProtoMember(1)] public  int Unknown { get; set; }
    [ProtoMember(2)] public  string Host { get; set; }
}
