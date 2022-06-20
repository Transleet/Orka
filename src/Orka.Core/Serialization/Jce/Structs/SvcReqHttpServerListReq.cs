namespace Orka.Core.Serialization.Jce.Structs;

public class SvcReqHttpServerListReq : IJceStruct
{
    public SvcReqHttpServerListReq(long l1, long l2, byte b1, string s1, int i1, int i2, string s2, long l3, long l4, long l5, long l6, byte b2, long l7, byte b3)
    {
        L1 = l1;
        L2 = l2;
        B1 = b1;
        S1 = s1;
        I1 = i1;
        I2 = i2;
        S2 = s2;
        L3 = l3;
        L4 = l4;
        L5 = l5;
        L6 = l6;
        B2 = b2;
        L7 = l7;
        B3 = b3;
    }

    [JceMember(1)] public long L1 { get; set; }
    [JceMember(2)] public long L2 { get; set; }
    [JceMember(3)] public byte B1 { get; set; }
    [JceMember(4)] public string S1 { get; set; } = null!;
    [JceMember(5)] public int I1 { get; set; }
    [JceMember(6)] public int I2 { get; set; }
    [JceMember(7)] public string S2 { get; set; } = null!;
    [JceMember(8)] public long L3 { get; set; }
    [JceMember(9)] public long L4 { get; set; }
    [JceMember(10)] public long L5 { get; set; }
    [JceMember(11)] public long L6 { get; set; }
    [JceMember(12)] public byte B2 { get; set; }
    [JceMember(13)] public long L7 { get; set; }
    [JceMember(14)] public byte B3 { get; set; }
}
