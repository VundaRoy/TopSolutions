using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Security.Cryptography
{
    public class CryptoMain
    {
        //Jj5aN9iygPemU15MtXlcnYCIX7dgLWdrQtBcMAFazaPUSMFvJof0IbFssP9acs3t
        //WMW1zpqiN1ysvvieezLSMpfTuCEKCcsPghhSyyMuFaw=
        public static void Main(string[] args)
        {
            CryptoSample cs = new CryptoSample();

            //start decrypt
            var dec = cs.Decrypt("WMW1zpqiN1ysvvieezLSMpfTuCEKCcsPghhSyyMuFaw=");
            string input = "TobeEncrypted";

            var encrypted = cs.Encrypt(input);
            Console.WriteLine("After encryption " + encrypted);

            var decrypted = cs.Decrypt(encrypted);
            Console.WriteLine("After decryption " + decrypted);
        }
    }
}
