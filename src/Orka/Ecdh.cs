using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Orka;
internal class Ecdh
{
    private readonly ECPrivateKeyParameters _privateKey;

    private readonly byte[] _remotePublicKey = Convert.FromHexString(
        "04EBCA94D733E399B2DB96EACDD3F69A8BB0F74224E2B44E3357812211D2E62EFBC91BB553098E25E33A799ADC7F76FEB208DA7C6522CDB0719A305180CC54A82E");

    public Ecdh()
    {
        ECDomainParameters ecDomain = new(NistNamedCurves.GetByName("P-256"));
        ECKeyPairGenerator generator = (ECKeyPairGenerator)GeneratorUtilities.GetKeyPairGenerator("ECDH");
        generator.Init(new ECKeyGenerationParameters(ecDomain, new SecureRandom()));
        AsymmetricCipherKeyPair localKeyPair = generator.GenerateKeyPair();
        ECPublicKeyParameters localPublicKey = (ECPublicKeyParameters)localKeyPair.Public;
        PublicKey = localPublicKey.Q.GetEncoded();
        _privateKey = (ECPrivateKeyParameters)localKeyPair.Private;
        IBasicAgreement aKeyAgree = AgreementUtilities.GetBasicAgreement("ECDH");
        aKeyAgree.Init(localKeyPair.Private);
        ShareKey = CalculateAgreement(_remotePublicKey);
    }

    public byte[] ShareKey { get; set; }
    public byte[] PublicKey { get; set; }

    public byte[] CalculateAgreement(byte[] otherPartyPublicKey)
    {
        X9ECParameters? p256 = NistNamedCurves.GetByName("P-256");
        ECDomainParameters ecDomain = new(p256);
        ECPublicKeyParameters otherPublicKey = new("ECDH", p256.Curve.DecodePoint(otherPartyPublicKey), ecDomain);
        IBasicAgreement keyAgree = AgreementUtilities.GetBasicAgreement("ECDH");
        keyAgree.Init(_privateKey);
        BigInteger sharedSecret = keyAgree.CalculateAgreement(otherPublicKey);
        byte[] sharedSecretBytes = sharedSecret.ToByteArray();
        return MD5.HashData(sharedSecretBytes[..16]);
    }
}
