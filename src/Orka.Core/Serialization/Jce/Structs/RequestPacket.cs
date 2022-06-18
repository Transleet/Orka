using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orka.Core.Serialization.Jce.Structs
{
    internal class RequestPacket:IJceStruct
    {
        [JceMember(1)]public short IVersion { get; set; }
        [JceMember(2)]public sbyte CPacketType { get; set; }
        [JceMember(3)]public int IMessageType { get; set; }
        [JceMember(4)]public int IRequestId { get; set; }
        [JceMember(5)]public string SServantName { get; set; }
        [JceMember(6)]public string SFuncName { get; set; }
        [JceMember(7)]public byte[] SBuffer { get; set; }
        [JceMember(8)]public int ITimeout { get; set; }
        [JceMember(9)]public JceMap Context { get; set; }
        [JceMember(10)]public JceMap Status { get; set; }

        protected bool Equals(RequestPacket other) => IVersion == other.IVersion && CPacketType == other.CPacketType && IMessageType == other.IMessageType && IRequestId == other.IRequestId && SServantName == other.SServantName && SFuncName == other.SFuncName && SBuffer.SequenceEqual(other.SBuffer) && ITimeout == other.ITimeout && Context.Cast<DictionaryEntry>().Union(other.Context.Cast<DictionaryEntry>()).Count()==Context.Count && Status.Cast<DictionaryEntry>().Union(other.Status.Cast<DictionaryEntry>()).Count()==Status.Count;

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return Equals((RequestPacket)obj);
        }

        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            hashCode.Add(IVersion);
            hashCode.Add(CPacketType);
            hashCode.Add(IMessageType);
            hashCode.Add(IRequestId);
            hashCode.Add(SServantName);
            hashCode.Add(SFuncName);
            hashCode.Add(SBuffer);
            hashCode.Add(ITimeout);
            hashCode.Add(Context);
            hashCode.Add(Status);
            return hashCode.ToHashCode();
        }
    }
}
