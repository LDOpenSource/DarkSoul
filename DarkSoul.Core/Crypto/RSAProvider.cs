using DarkSoul.Core.Instance;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.OpenSsl;
using System;
using System.IO;
using System.Linq;

namespace DarkSoul.Core.Crypto
{
    public class RSAProvider : Singleton<RSAProvider>
    {
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        #region RSA

        public RSAProvider()
        {
            RsaPublicKey = RsaEncryptWithPrivate();
        }

        public readonly string Salt = RandomString(32);
        private byte[] RsaPublicKey;

        public byte[] GetRSAPublicKey() => RsaPublicKey;

        public string GetSalt()
        {
            return Salt;
        }

        public byte[] RsaEncryptWithPrivate()
        {
            var publicKey = @"-----BEGIN PUBLIC KEY-----
MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQCB37S6s7qBiND8N7njOFJRhrAB
QoIKWeMqSZpkJj90+E1Dw+h6nCliAoJMxB1mWJxY6VLvN8muOCjTndYGRcIOLV5H
da/DaTn4yGIPq01Z47XkplIaozHjpk+6R7bAYUJVraeG2mh5Y61B6ChoHuIexdD+
q49DGoK7379HMW6WQQIDAQAB
-----END PUBLIC KEY-----";
            var privateKey = @"-----BEGIN RSA PRIVATE KEY-----
MIIEpAIBAAKCAQEAqAD3jeC9g3F9Dv5joMQWfqS6t+ZVVbYd5a3MnUZu/Gay9nHK
N+EJbaefNKAxaUphZ/jifxChXvV9kwJEfdpk1fmtmCOYjpcmdEKrisUQUw3mIXYb
kz4p/fu6c5GASsWS7dFUTYcHsjY9ts3aD9TKQAP7QVOcgXVKXl+Hy0iV+IV+DqKe
nx5jYwekxHxOoT+FKE16lcFDaWAVw7XDRXBuw+nMhuvawrCKmTRIdHfLzsbe0KtY
kqiSr7GncKwjm0I/hex0iKToxp2tQNXgtRxP27LFEfGjlabaJpOQKUG+rjyujbQm
g1+CLfjSW0iSW/QQiYSSTl0bN0N7iFqdr/0ptQIDAQABAoIBADrqs+YOhYd+GjRS
5A9yFM1u6Ygqf4yiZFOyoooZNDzRqzsf5qG4Cn1pBj0HXKynCAfVUWDsLRtHDjWq
2ugj2a7sc4NiIFMJENQ+uTfeKf5mZmkfqUX2y/Uk/VsgEJSoOwGpol3Z18oYmYXt
JObeYdsXSlq7fqwrvNvhtpaEqwtO+8cyrJCrNmP4r7yWTLCYskIT8lgO+4Q8HSVn
fgMfPF7lM5ZAU0w3wlRHlmvEcKMyKQ3mVeTOkQoThve0pJPHmn+1pOySSS8ESibb
nAPJQrFMbPtzB2u57o9w9KLZ0LD9xB1hw4wKSFa6kDY8CFV9hFP7RO0Ih7jzSqpC
0bawirUCgYEA1OMZ5b1zZ3NeBTSEy7Rsi8Gi8atgcmlmUM/WRINz1UxloBCVEIqm
MXJBnwT9x0wG57AbOlUEDCqhbHd2B1Y9rZ7NeiwR1E645D3JmQgx26O9CyvUk4my
xvnXWl7RSwOTh+mVuFEQJP4YixbtmOescV1sRXqBjqMDFLpZ/y/WcvsCgYEAygbw
Qj1gAlPmCuzI8t6vUirnqL0YitXDpG7exxMEjAg8EVWl4/+2J/aePsdcvZ3/TuNa
BRlnSWrCOc0j1wExRwZz1iAIlaEDK2ue1TXI40mDWehAhLz0PSFEi+rH6vEQK9oy
zcpuxVVb2fcsPcuWGIANMiWnqCRXWf0z5AXBtw8CgYEAtEsNMLts1C0pcEEVQiuw
TgAVDpT0XpES/Ne4AFhPrlJAMvo4NEUoEPJRzun8P2AM7QUBWjqL7f3grirSA86u
965pGNHf2607+ti1NmxxRTF7tc1OABF7HfaTws5QdDY4KL/Tc8D7akjj4k/tszRp
n6zeOE1TEcjOoCxecbdC6CcCgYAT9cmJEd1JfZaN38Ue0ceKm7iVoFErbmFM/rM+
AfACEdI1eDvSofISUrhhxXqxNUoDNk0vkcn1o/makl0HIhQHS2job/PJLMZOZOyl
bhHx+tJicKLnOm/7Fi1akZC88qJBYuaAFI8LKhrQFy6k0Fd9BjHHkZbV8vk6Z9zX
m4X/GwKBgQC9P3w98smzp+N7x6xjqxv5AmFJJvG/Pl4ZtZy0rm8H6CPTnSvnpdVo
0BMIosR9q64vU2h+ioE5g0aHoAIZEgKU78QyX0l7D2KSHnjUo+aQQHpjUdhuoXXN
ITLSLe3/vLKh4dpptg609Z+gnRWBl9rqdAJq6osd5vk/nUYGr8EQbg==
-----END RSA PRIVATE KEY-----";

            var partial =
                publicKey.Remove(publicKey.IndexOf("-----END PUBLIC KEY-----", StringComparison.Ordinal))
                    .Remove(0, "-----BEGIN PUBLIC KEY-----\n".Length);

            var bytesToEncrypt = Convert.FromBase64String(partial);


            var encryptEngine = new Pkcs1Encoding(new RsaEngine());

            using (var txtreader = new StringReader(privateKey))
            {
                var keyPair = (AsymmetricCipherKeyPair)new PemReader(txtreader).ReadObject();

                encryptEngine.Init(true, keyPair.Private);
            }

            var encrypted = encryptEngine.ProcessBlock(bytesToEncrypt, 0, bytesToEncrypt.Length);
            return encrypted;
        }

        public byte[] RsaDecryptWithPrivate(byte[] base64Input)
        {
            var privateKey = @"-----BEGIN RSA PRIVATE KEY-----
MIICXQIBAAKBgQCB37S6s7qBiND8N7njOFJRhrABQoIKWeMqSZpkJj90+E1Dw+h6
nCliAoJMxB1mWJxY6VLvN8muOCjTndYGRcIOLV5Hda/DaTn4yGIPq01Z47XkplIa
ozHjpk+6R7bAYUJVraeG2mh5Y61B6ChoHuIexdD+q49DGoK7379HMW6WQQIDAQAB
AoGABBal5r0+9TI4iwIZl9u3arHb41RDyf3hqvyBb97s3zqsWwJlNIvrORbFYZOI
becC+AETX2zBDHsf3OaSfOTQCqz7s7Nzy4xXagmCceZdxgxRYtUBqUUxkIL3NV8J
Nwo+yWj7qBHNkp0WGunRNxrLu6aPtlk6DlemfhMEDfkiAWECQQC3BW8D9n71Zwo8
Nx+Zj6sGDks02RqBdrORnRIFDrUyIJKz6SSkp8Dt7PEtJu8vEdMTEWGz6R+6Iynk
khuc/FGRAkEAtakO5dXeXHhJzhLoZkhLioLmCBxqUZ3wz1q3vZDoff41ORxyr+U+
FAoNVOpfHElobwAV9Np6NZm42Wzbhc6hsQJBAKRx0GbqIvbSZ2LlUJJEgTFGxJIu
g99RTVUHoTpEFdB9bfMTB2aeh/3/iE++jOhpBpM6aeQiEezITYrfMMpj99ECQHRA
oDwNRaO/htvN1dO+6DjX1AXUyWU5weWwlG1H0sDucXj+75YJClUgqa9x3TPo9mAy
mdp8BkFPArCBrWpP9cECQQC0KVkbdP4QHrSC7+kwr4/lSFVUlus/I86rtY8WrtF2
7FDnsx8U4XhxTpIUWTOW1bkv0wKsXTyOXR4HYZCtCnxv
-----END RSA PRIVATE KEY-----";
            var bytesToDecrypt = base64Input;

            var decryptEngine = new Pkcs1Encoding(new RsaEngine());

            using (var txtreader = new StringReader(privateKey))
            {
                var keyPair = (AsymmetricCipherKeyPair)new PemReader(txtreader).ReadObject();

                decryptEngine.Init(false, keyPair.Private);
            }

            var decrypted = decryptEngine.ProcessBlock(bytesToDecrypt, 0, bytesToDecrypt.Length);
            return decrypted;
        }

        #endregion RSA
    }
}
