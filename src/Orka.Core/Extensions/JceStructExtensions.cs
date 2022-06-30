using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orka.Core.Serialization.Jce;

namespace Orka.Core.Extensions;

internal static class JceStructExtensions
{
    public static byte[] ToByteArray<T>(this T jceStruct) where T : class, IJceStruct
    {
        return JceSerializer.Serialize(jceStruct);
    }
}
