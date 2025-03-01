using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.GeneralCSharp.Security.Cryptography.HardCoded;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Security.Cryptography.FullImplementation
{    
    public class CryptoClient
    {
        private const string SecretKey = "2i89)99oO";
        public static void Main(string[] args)
        {
            //DecryptOld();
            EncryptNew();

        }

        public static void DecryptOld()
        {
            var val = HardSaltStatic.DecryptString("sEdENI8tzK2OCMu8(BLlmLvCA8M0CBnfuXqIUWbtO2K&UiK8fqSs=", SecretKey);
            //var val1 = HardSaltStatic.DecryptString("C5oILR2V9a4NNO903KDadik=", SecretKey);

        }

        public static void EncryptNew()
        {
            var GoogleMapScriptURL = CryptoStatic.EncryptString("https:KhodnlthBoth.aspx", SecretKey);
            var GoogleMapScriptKey = CryptoStatic.EncryptString("https://healIa.aspx", SecretKey);

        }

        public static string DecryptNew(string text)
        {
            return CryptoStatic.DecryptString(text, SecretKey);
        }
    }
}
