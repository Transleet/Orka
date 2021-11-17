namespace Orka;

internal static class Utils
{
    public static byte[] GetRandomBytes(this Random random, int length)
    {
        byte[] arr = GC.AllocateUninitializedArray<byte>(4);
        random.NextBytes(arr);
        return arr;
    }
}
