using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Security.Cryptography.FullImplementation
{
    //WMW1zpqiN1ysvvieezLSMpfTuCEKCcsPghhSyyMuFaw=     hawaiiFiveo
    //i6jyc8d72QS5xHYJVrpeqnHTtsPA6Nbyvf2WtamtBDE=     businessAsUsual
    //wBkROuHP28KNTfz3f8BlyXPiQnXO4zYaRiUOWt10XtQ=     businessAsUsual II
    public class CryptoClient
    {
        private const string SecretKey = "rhine$t0ne";
        public static void Main(string[] args)
        {
            //object ttest
            var client = new CryptoObject();
            //var enc = client.EncryptString("hawaiiFiveo", SecretKey);

            var hawaiiObj = client.DecryptString("WMW1zpqiN1ysvvieezLSMpfTuCEKCcsPghhSyyMuFaw=", SecretKey);
            var busObj = client.DecryptString("i6jyc8d72QS5xHYJVrpeqnHTtsPA6Nbyvf2WtamtBDE=", SecretKey);
            var busObj2 = client.DecryptString("wBkROuHP28KNTfz3f8BlyXPiQnXO4zYaRiUOWt10XtQ=", SecretKey);

            //static test
            //var encStatic = CryptoStatic.EncryptString("businessAsUsual", SecretKey);

            // var decStatic = CryptoStatic.DecryptString(encStatic, SecretKey);

            var hawaii = CryptoStatic.DecryptString("WMW1zpqiN1ysvvieezLSMpfTuCEKCcsPghhSyyMuFaw=", SecretKey);
            var busi = CryptoStatic.DecryptString("i6jyc8d72QS5xHYJVrpeqnHTtsPA6Nbyvf2WtamtBDE=", SecretKey);
            var busi2 = CryptoStatic.DecryptString("wBkROuHP28KNTfz3f8BlyXPiQnXO4zYaRiUOWt10XtQ=", SecretKey);
        }
    }
}
