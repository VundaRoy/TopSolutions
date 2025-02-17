using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Security.Cryptography
{
    public class CryptoSample
    {
        private const int KeySize = 32; // AES Key size is 256 bits (32 bytes)
        private const int IvSize = 16;
        private const int SaltSize = 16;
        private const int Iterations = 100000; // Number of iterations for PBKDF2
        string password = "securepassword"; // Password to derive the key from

        public string Encrypt(string originalText)
        {
            string encryptedText;

            using (Aes aes = Aes.Create())
            {
                aes.KeySize = 256;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                byte[] salt = GenerateRandomNumberForSaltOrIv(SaltSize); // Generate a new random Salt for each encryption

                aes.Key = DeriveKeyFromPassword(password, salt, Iterations);
                aes.IV = GenerateRandomNumberForSaltOrIv(IvSize); // Generate a new random IV for each encryption

                // Encrypt the text with salt
                using (MemoryStream ms = new MemoryStream())
                {
                    // Write salt and IV to the beginning of the stream
                    ms.Write(salt, 0, salt.Length); // Prepend salt to the output
                    ms.Write(aes.IV, 0, aes.IV.Length); // Prepend IV to the output

                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(originalText);
                        }
                    }

                    encryptedText = Convert.ToBase64String(ms.ToArray());
                }
            }

            Console.WriteLine($" - Encrypted Text: {encryptedText}");

            return encryptedText;
        }
        public string Decrypt(string encryptedText)
        {

            Console.WriteLine($"Encrypted Text: {encryptedText}");

            // Decrypt the text
            string decryptedText;
            using (Aes aes = Aes.Create())
            {
                aes.KeySize = 256;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                byte[] encryptedData = Convert.FromBase64String(encryptedText);

                using (MemoryStream ms = new MemoryStream(encryptedData))
                {
                    byte[] salt = new byte[SaltSize];
                    ms.Read(salt, 0, SaltSize); // Read the salt from the beginning

                    byte[] iv = new byte[IvSize];
                    ms.Read(iv, 0, IvSize); // Read the IV

                    aes.Key = DeriveKeyFromPassword(password, salt, Iterations);
                    aes.IV = iv;

                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader(cs))
                        {
                            decryptedText = sr.ReadToEnd();
                        }
                    }
                }
            }

            Console.WriteLine($" - Decrypted Text: {decryptedText}");

            return decryptedText;
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

        /// <summary>
        /// Derives a key from a password and salt using PBKDF2.
        /// </summary>
        /// <param name="password">The password to derive the key from.</param>
        /// <param name="salt">The salt used in the key derivation.</param>
        /// <param name="iterations">The number of iterations for PBKDF2.</param>
        /// <returns>The derived key.</returns>
        private byte[] DeriveKeyFromPassword(string password, byte[] salt, int iterations)
        {
            using (var keyDerivation = new Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA256))
            {
                return keyDerivation.GetBytes(KeySize);
            }
        }
    }
}

