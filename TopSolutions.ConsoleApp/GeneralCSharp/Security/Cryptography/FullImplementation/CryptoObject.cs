using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Security.Cryptography.FullImplementation
{
    public class CryptoObject
    {

        private const int SaltSize = 16;
        private byte[] saltBytes;
        public CryptoObject()
        {
            saltBytes = GenerateRandomNumberForSaltOrIv(SaltSize);
        }
        public string EncryptString(string stringToEncrypt, string secretKey)
        {

            // Get the bytes of the string
            byte[] bytesToBeEncrypted = Encoding.UTF8.GetBytes(stringToEncrypt);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(secretKey);

            // Hash the password with SHA256
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesEncrypted = AES_Encrypt(bytesToBeEncrypted, passwordBytes);

            string result = Convert.ToBase64String(bytesEncrypted);

            return result;
        }
        public string DecryptString(string stringToDecrypt, string secretKey)
        {
            // Get the bytes of the string
            byte[] bytesToBeDecrypted = Convert.FromBase64String(stringToDecrypt);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(secretKey);
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesDecrypted = AES_Decrypt(bytesToBeDecrypted, passwordBytes);

            string result = Encoding.UTF8.GetString(bytesDecrypted);

            return result;
        }
        private byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] encryptedBytes = null;

            using (MemoryStream ms = new MemoryStream())
            {
                //write salt to beginning of stream
                ms.Write(saltBytes, 0, saltBytes.Length);

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
        private byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] decryptedBytes = null;

            using (MemoryStream ms = new MemoryStream(bytesToBeDecrypted))
            {
                //byte[] salt = new byte[SaltSize];
                ms.Read(saltBytes, 0, SaltSize); // Read the salt from the beginning

                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        using (MemoryStream msDecrypt = new MemoryStream())
                        {
                            cs.CopyTo(msDecrypt);
                            decryptedBytes = msDecrypt.ToArray();
                        }
                    }
                }
            }

            return decryptedBytes;
        }
        /// <summary>
        /// Generates a random number for salt or IV.
        /// </summary>
        /// <param name="length">The length of the random number.</param>
        /// <returns>The generated random number.</returns>
        private byte[] GenerateRandomNumberForSaltOrIv(int length)
        {
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                byte[] salt = new byte[length];
                rng.GetBytes(salt);
                return salt;
            }
        }
    }
}

