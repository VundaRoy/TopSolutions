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
        private const string SecretKey = "2r.A46C]fO";
        public static void Main(string[] args)
        {
            //DecryptNew();
            DecryptOld();
            //EncryptNew();

        }

        public static void DecryptOld()
        {
            var val = HardSaltStatic.DecryptString("C5oILR2V9aZUV7cKZg6mvnGxOo7hDZlCN+21poPz0Thup4uiJF/RHs0dB7mi17wBy/4NNO903KDadik=", SecretKey);
            var val1 = HardSaltStatic.DecryptString("xD58QAmxUQ4BOY1wP77TObixSwI6VI4LGvuhZMvC1NP34HG7tMcYPy5X2wOiM1V6m8/GRmsUZ6SZt0Ou+ThdIGNlBgSB4Bowv4+JLm41AIHb0VJ5xXpperzDJirxO+kpGtvx630w4Lxc7YhXBfLhEGGwwby64PAOInB8KOfz4ac==", SecretKey);

        }

        public static void DecryptNew()
        {
            var val = CryptoStatic.DecryptString("C5oILR2V9aZUVxOo7hDZlCN+21poPz0Thup4uiJF/RHs0dB7mi17wBy/4NNO903KDadik=", SecretKey);
            //var val1 = CryptoStatic.DecryptString("xD58QAmxUQ4BOY1wP77TObixSMcYPy5X2wOiM1V6m8/GRmsUZ6SZt0Ou+ThdIGNlBgSB4Bowv4+JLm41AIHb0VJ5xXpperzDJirxO+kpGtvx630w4Lxc7YhXBfLhEGGwwby64PAOInB8KOfz4ac=", SecretKey);

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
