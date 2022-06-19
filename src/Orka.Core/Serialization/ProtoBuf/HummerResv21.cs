using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

internal class HummerResv21
{
    [ProtoContract]
    internal class FileImgInfo
    {
        [ProtoMember(1)] public int FileWidth { get; set; }
        [ProtoMember(2)] public int FileHeight { get; set; }
    }

    [ProtoContract]
    internal class ForwardExtFileInfo
    {
        [ProtoMember(1)] public int FileType { get; set; }
        [ProtoMember(2)] public long SenderUin { get; set; }
        [ProtoMember(3)] public long ReceiverUin { get; set; }
        [ProtoMember(4)] public string FileUuid { get; set; }
        [ProtoMember(5)] public string FileName { get; set; }
        [ProtoMember(6)] public long FileSize { get; set; }
        [ProtoMember(7)] public byte[] FileSha1 { get; set; }
        [ProtoMember(8)] public byte[] FileMd5 { get; set; }
        [ProtoMember(9)] public long Int64DeadTime { get; set; }
        [ProtoMember(10)] public int ImgWidth { get; set; }
        [ProtoMember(11)] public int ImgHeight { get; set; }
        [ProtoMember(12)] public long VideoDuration { get; set; }
        [ProtoMember(13)] public int BusId { get; set; }
    }

    [ProtoContract]
    internal class ResvAttr
    {
        [ProtoMember(1)] public FileImgInfo? FileImageInfo { get; set; }
        [ProtoMember(2)] public ForwardExtFileInfo? ForwardExtFileInfo { get; set; }
    }

    [ProtoContract]
    internal class XtfSenderInfo
    {
        [ProtoMember(1)] public int LanIp { get; set; }
        [ProtoMember(2)] public int LanPort { get; set; }
        [ProtoMember(3)] public long LanSrkey { get; set; }
    }
}
