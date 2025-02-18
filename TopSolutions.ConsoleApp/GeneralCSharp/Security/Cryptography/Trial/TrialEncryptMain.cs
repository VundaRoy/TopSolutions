using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Security.Cryptography.Trial
{
    public class TrialEncryptMain
    {
        public static void Main()
        {
            TrialEncryption trialEncryption = new TrialEncryption();
            byte[] bytesTobeEncrypted = Encoding.UTF8.GetBytes("stringToEncrypt");
            byte[] passwordBytes = Encoding.UTF8.GetBytes("secret");
            var enc = trialEncryption.Encrypt(bytesTobeEncrypted, passwordBytes);
            var dec = trialEncryption.Decrypt(enc,passwordBytes);
            string decryptedString = Encoding.UTF8.GetString(dec);
            bool areSame = "stringToEncrypt".Equals(decryptedString);
        }
    }
}
