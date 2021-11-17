namespace Orka;

public readonly struct Uin
{
    private Uin(long value) => _value = value;
    private readonly long _value;
    public static implicit operator long(Uin value) => value._value;
    public static implicit operator uint(Uin value) => (uint)value._value;
    public static implicit operator int(Uin value) => (int)value._value;
    public static implicit operator Uin(long value) => new Uin(value);
    public override string ToString() => _value.ToString("D10");
    public byte[] ToByteArray() => Number.FromInt64(_value);
}
