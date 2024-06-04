using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq.Expressions;
using Microsoft.IdentityModel.Tokens;

namespace Lab4_group
{
    internal class RSAA
    {
        RSACryptoServiceProvider rsa;

        public RSAA()
        {
            rsa = new RSACryptoServiceProvider();
        }

        public byte[] Encryption(string plaintext, string manv)
        {
            //read the pemfile
            try
            {
                string filePath = manv + "pub.pem";
                string pub = File.ReadAllText(filePath);
                rsa.ImportFromPem(pub);

                // Encrypt some data using the public key
                byte[] dataToEncrypt = Encoding.UTF8.GetBytes(plaintext);
                byte[] result = rsa.Encrypt(dataToEncrypt, RSAEncryptionPadding.Pkcs1);
                return result;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public string Decryption(byte[] ciphertext, string manv)
        {
            byte[] deBytes;
            try
            {
                string filePath = manv + "priv.pem";
                string privkey = File.ReadAllText(filePath);
                rsa.ImportFromPem(privkey);

                deBytes = rsa.Decrypt(ciphertext, RSAEncryptionPadding.Pkcs1);
                string result = Encoding.UTF8.GetString(deBytes);
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
