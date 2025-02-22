using System;
using System.IO;
using System.Text;

public class EcbExample
{
    public byte[] EncryptEcb(string plainText, byte[] key)
    {
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Mode = System.Security.Cryptography.CipherMode.ECB;
            aesAlg.Padding = PaddingMode.PKCS7;
            aesAlg.Key = key;
            aesAlg.IV = new byte[aesAlg.BlockSize / 8];

            ICryptoTransform encryptor = aesAlg.CreateEncryptor();
            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt =
                    new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt =
                        new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }
                    return msEncrypt.ToArray();
                }
            }
        }
    }
}