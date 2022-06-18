namespace Orka.Core.Serialization.Jce.Structs;

internal class SvcRespParam : IJceStruct
{
    [JceMember(0)] public int PCStat { get; set; }
    [JceMember(1)] public int IsSupportC2CRoamMsg { get; set; }
    [JceMember(2)] public int IsSupportDataLine { get; set; }
    [JceMember(3)] public int IsSupportPrintable { get; set; }
    [JceMember(4)] public int IsSupportViewPCFile { get; set; }
    [JceMember(5)] public int PcVersion { get; set; }
    [JceMember(6)] public long RoamFlag { get; set; }
    [JceMember(7)] public JceList<OnlineInfo> OnlineInfos { get; set; }
    [JceMember(8)] public int PCClientType { get; set; }
}
