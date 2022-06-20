using System.Collections.Generic;

namespace Orka.Core;

public class Utils
{
    public static byte[] PackUniRequestData(byte[] data)
    {
        var r = new List<byte> { 0x0A };
        r.AddRange(data);
        r.Add(0x0B);
        return r.ToArray();
    }
}
