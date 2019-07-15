using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace ctiencrypt
{
    class AES256BitExpress
    {
        private const int _saltSize = 8;
        private static byte[] _emptyPasswordBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        private static SHA512 sha = SHA512.Create();

        public static string Encrypt(string text, byte[] pwdBytes1, byte[] pwdBytes2, byte[] pwdBytes3, byte[] pwdBytes4)
        {
            byte[] passwordBytes = CombinePassword(pwdBytes1, pwdBytes2, pwdBytes3, pwdBytes4);
            return Encrypt(text, passwordBytes);
        }

        public static string Encrypt(string text, byte[] passwordBytes)
        {
            byte[] originalBytes = Encoding.UTF8.GetBytes(text);

            // Compress the bytes
            originalBytes = Compressor.Compress(originalBytes);

            byte[] encryptedBytes = null;
            passwordBytes = sha.ComputeHash(passwordBytes);
            byte[] saltBytes = GetRandomBytes();

            byte[] bytesToBeEncrypted = new byte[saltBytes.Length + originalBytes.Length];

            for (int i = 0; i < saltBytes.Length; i++)
            {
                bytesToBeEncrypted[i] = saltBytes[i];
            }

            for (int i = 0; i < originalBytes.Length; i++)
            {
                bytesToBeEncrypted[i + saltBytes.Length] = originalBytes[i];
            }

            encryptedBytes = AES_Encrypt(bytesToBeEncrypted, passwordBytes);

            return Convert.ToBase64String(encryptedBytes);
        }

        public static string Decrypt(string decryptedText, byte[] pwdBytes1, byte[] pwdBytes2, byte[] pwdBytes3, byte[] pwdBytes4)
        {
            byte[] passwordBytes = CombinePassword(pwdBytes1, pwdBytes2, pwdBytes3, pwdBytes4);
            return Decrypt(decryptedText, passwordBytes);
        }

        public static string Decrypt(string decryptedText, byte[] passwordBytes)
        {
            byte[] bytesToBeDecrypted = Convert.FromBase64String(decryptedText);

            passwordBytes = sha.ComputeHash(passwordBytes);

            byte[] decryptedBytes = AES_Decrypt(bytesToBeDecrypted, passwordBytes);

            byte[] originalBytes = new byte[decryptedBytes.Length - _saltSize];

            for (int i = _saltSize; i < decryptedBytes.Length; i++)
            {
                originalBytes[i - _saltSize] = decryptedBytes[i];
            }

            originalBytes = Compressor.Decompress(originalBytes);

            return Encoding.UTF8.GetString(originalBytes);
        }

        public static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] encryptedBytes = null;
            byte[] saltBytes = passwordBytes;

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }

            return encryptedBytes;
        }

        public static byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] decryptedBytes = null;
            byte[] saltBytes = passwordBytes;

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                        cs.Close();
                    }
                    decryptedBytes = ms.ToArray();
                }
            }

            return decryptedBytes;
        }

        private static byte[] CombinePassword(byte[] pwdBytes1, byte[] pwdBytes2, byte[] pwdBytes3, byte[] pwdBytes4)
        {
            List<byte> lst = new List<byte>();

            if (pwdBytes1 == null)
                lst.AddRange(sha.ComputeHash(_emptyPasswordBytes));
            else
                lst.AddRange(sha.ComputeHash(pwdBytes1));

            if (pwdBytes2 == null)
                lst.AddRange(sha.ComputeHash(_emptyPasswordBytes));
            else
                lst.AddRange(sha.ComputeHash(pwdBytes2));

            if (pwdBytes3 == null)
                lst.AddRange(sha.ComputeHash(_emptyPasswordBytes));
            else
                lst.AddRange(sha.ComputeHash(pwdBytes3));

            if (pwdBytes4 == null)
                lst.AddRange(sha.ComputeHash(_emptyPasswordBytes));
            else
                lst.AddRange(sha.ComputeHash(pwdBytes4));

            return lst.ToArray();
        }

        public static byte[] GetRandomBytes()
        {
            byte[] ba = new byte[_saltSize];
            RNGCryptoServiceProvider.Create().GetBytes(ba);
            return ba;
        }
    }
}
