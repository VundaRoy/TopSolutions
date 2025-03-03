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
        private const string SecretKey = "C1v1c3Y#";
        public static void Main(string[] args)
        {
            DecryptNew();
            //DecryptOld();
            //EncryptNew();

        }

        public static void DecryptOld()
        {
            var val = HardSaltStatic.DecryptString("xD58QAmxUQ4BOY1wP77TObixSwI6VI4LGvuhZMvC1NP34HG7tMcYPy5X2wOiM1V66cQtrCXl3Qzy84W6NZ8XlmsN9QHvqNFom9aK2y07HA2q3c7773xUnivamOU6rrDzL5spYLiikOE2W4/Bnh4fQWwX9QlD2aApwlWqY1Hk5NI=", SecretKey);
            var val1 = HardSaltStatic.DecryptString("xD58QAmxUQ4BOY1wP77TObixSwI6VI4LGvuhZMvC1NP34HG7tMcYPy5X2wOiM1V6m8/GRmsUZ6SZt0Ou+ThdIGNlBgSB4Bowv4+JLm41AIHb0VJ5xXpperzDJirxO+kpGtvx630w4Lxc7YhXBfLhEGGwwby64PAOInB8KOfz4ac==", SecretKey);

        }

        public static void DecryptNew()
        {
            var val = CryptoStatic.DecryptString("xD58QAmxUQ4BOY1wP77TObixSwcYPy5X2wOiM1V66cQtrCXl3Qzy84W6NZ8XlmsN9QHvqNFom9aK2y07HA2q3c7773xUnivamOU6rrDzL5spYLiikOE2W4/Bnh4fQWwX9QlD2aApwlWqY1Hk5NI=", SecretKey);
            var val1 = CryptoStatic.DecryptString("xD58QAmxUQ4BOY1wP77TObixSMcYPy5X2wOiM1V6m8/GRmsUZ6SZt0Ou+ThdIGNlBgSB4Bowv4+JLm41AIHb0VJ5xXpperzDJirxO+kpGtvx630w4Lxc7YhXBfLhEGGwwby64PAOInB8KOfz4ac=", SecretKey);

        }
        public static void EncryptNew()
        {
            var GoogleMapScriptURL = CryptoStatic.EncryptString("Server=healtAdapter;passwJLdLu", SecretKey);
            var GoogleMapScriptKey = CryptoStatic.EncryptString("Server=healtviceAdapter;pDsWnJLdLu", SecretKey);

        }

        public static string DecryptNew(string text)
        {
            return CryptoStatic.DecryptString(text, SecretKey);
        }
    }
}
