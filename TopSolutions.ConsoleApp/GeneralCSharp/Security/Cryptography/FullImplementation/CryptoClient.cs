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
        private const string SecretKey = "Fleton&&8*";
        public static void Main(string[] args)
        {
            DecryptOld();
            EncryptNew();

        }

        public static void DecryptOld()
        {
            var val = HardSaltStatic.DecryptString("GJP/SgJIcTJanweKJryeMMO6sVU=", SecretKey);
            var val1 = HardSaltStatic.DecryptString("C5oILR2V9a4NNO903KDadik=", SecretKey);

        }

        public static void EncryptNew()
        {
            var GoogleMapScriptURL = CryptoStatic.EncryptString("keynoteaddress", SecretKey);
            var GoogleMapScriptKey = CryptoStatic.EncryptString("AIzaSyCCASWnfOt5kbKNzKTo0_F63AaBLZ5ad6E", SecretKey);

        }

        public static string DecryptNew(string text)
        {
            return CryptoStatic.DecryptString(text, SecretKey);
        }
    }
}
