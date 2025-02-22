using System;
using System.Text;
using System.Security.Cryptography;

class CryptoUtil
{
    public string ComputeMd5Hash(string input)
    {
        using (MD5 md5 = MD5.Create())
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            foreach (byte b in hashBytes)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }
    }

    public string ComputeSha1Hash(string input)
    {
        using (SHA1 sha1 = SHA1.Create())
        {

            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = sha1.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            foreach (byte b in hashBytes)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }
    }
}