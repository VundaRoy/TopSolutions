using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Security.Cryptography.FullImplementation
{
    //WMW1zpqiN1ysvvieezLSMpfTuCEKCcsPghhSyyMuFaw=
    public class CryptoClient
    {
        private const string SecretKey = "rhine$t0ne";
        public static void Main(string[] args)
        {
            var client = new CryptoObject();
            //var enc = client.EncryptString("hawaiiFiveo", SecretKey);

            var dec = client.DecryptString("WMW1zpqiN1ysvvieezLSMpfTuCEKCcsPghhSyyMuFaw=", SecretKey);
        }
    }
}
