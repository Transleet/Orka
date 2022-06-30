using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orka.Core.Serialization.Jce.Structs;

internal class FileStoragePushFSSvcList : IJceStruct
{
    [JceMember(0)] public JceList<FileStorageServerInfo> UploadList { get; set; }
    [JceMember(1)] public JceList<FileStorageServerInfo> PicDownloadList { get; set; }
    [JceMember(2)] public JceList<FileStorageServerInfo> GPicDownloadList { get; set; }
    [JceMember(3)] public JceList<FileStorageServerInfo> QZoneProxyServiceList { get; set; }
    [JceMember(4)] public JceList<FileStorageServerInfo> UrlEncodeServiceList { get; set; }
    [JceMember(5)] public BigDataChannel BigDataChannel { get; set; }
    [JceMember(6)] public JceList<FileStorageServerInfo> VipEmotionList { get; set; }
    [JceMember(7)] public JceList<FileStorageServerInfo> C2CPicDownList { get; set; }
    //[JceMember(8)] public FmtIPInfo FmtIPInfo { get; set; }
    //[JceMember(9)] public DomainIPChannel DomainIPChannel { get; set; }
    [JceMember(10)] public byte[] PttList { get; set; }
}
