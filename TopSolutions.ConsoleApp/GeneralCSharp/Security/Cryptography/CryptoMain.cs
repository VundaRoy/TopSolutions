using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Security.Cryptography
{
    public class CryptoMain
    {
        public static void Main(string[] args)
        {
            CryptoSample cs = new CryptoSample();
            string input = "TobeEncrypted";

            var encrypted = cs.Encrypt(input);
            Console.WriteLine("After encryption " + encrypted);

            var decrypted = cs.Decrypt(encrypted);
            Console.WriteLine("After decryption " + decrypted);
        }
    }
}
