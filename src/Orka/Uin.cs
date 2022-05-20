namespace Orka;

public readonly struct Uin
{
    private readonly long _value;
    public Uin(long value) => _value = value;
    public Uin(string value) => _value = long.Parse(value);

    
    public static implicit operator long(Uin value) => value._value;
    public static implicit operator uint(Uin value) => (uint)value._value;
    public static implicit operator int(Uin value) => (int)value._value;
    public static implicit operator Uin(long value) => new(value);
    public static implicit operator Uin(string value) => new(value);
    public override string ToString() => _value.ToString("D10");
    public byte[] ToByteArray() => Number.FromInt64(_value);
}
