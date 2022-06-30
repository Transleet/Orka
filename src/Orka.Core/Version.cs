namespace Orka.Core;

public class Version
{
    public byte[] Incremental { get; set; }
    public byte[] Release { get; set; }
    public byte[] CodeName { get; set; }
    public uint Sdk { get; set; }
}
