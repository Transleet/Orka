using Xunit;

namespace Orka.Tests;

public class EcdhTests
{
    [Fact]
    public void EcdhTest1()
    {
        var alice = new Ecdh();
        var bob = new Ecdh();
        var share1 = bob.CalculateAgreement(alice.PublicKey);
        var share2 = alice.CalculateAgreement(bob.PublicKey);
        Assert.Equal(share1, share2);
    }
}
