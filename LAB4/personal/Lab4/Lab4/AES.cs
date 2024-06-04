using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Lab4
{
    internal class AES
    {
        AesCryptoServiceProvider aess;

        public AES(string key)
        {
            aess = new AesCryptoServiceProvider();
            aess.KeySize = 256;
            aess.BlockSize = 128;
            aess.IV = new byte[16] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            aess.Key = System.Text.ASCIIEncoding.ASCII.GetBytes(key);
            aess.Mode = CipherMode.CBC; //cipher block chaining
            aess.Padding = PaddingMode.PKCS7;
        }

        public byte[] Encrypt(string plaintext)
        {
            ICryptoTransform trans = aess.CreateEncryptor();
            byte[] enBytes = trans.TransformFinalBlock(ASCIIEncoding.ASCII.GetBytes(plaintext), 0, plaintext.Length);
            return enBytes;
        }

        public string Decrypt(byte[] ciphertext)
        {
            byte[] deBytes;
            try
            {
                ICryptoTransform trans = aess.CreateDecryptor();
                deBytes = trans.TransformFinalBlock(ciphertext, 0, ciphertext.Length);
            }
            catch (CryptographicException ex)
            {
                // Handle the exception and return an appropriate error message
                return $"Decryption failed: {ex.Message}";
            }
            catch (Exception)
            {
                // Handle any other exceptions and rethrow them
                throw;
            }
            return ASCIIEncoding.ASCII.GetString(deBytes);
        }
    }
}