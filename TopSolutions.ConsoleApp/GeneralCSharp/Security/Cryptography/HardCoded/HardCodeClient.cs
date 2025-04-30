using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.GeneralCSharp.Security.Cryptography.FullImplementation;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Security.Cryptography.HardCoded
{
    public class HardCodeClient
    {
        private const string SecretKey = "a5!Iyasdf8LKJHa1234sas";
        public static void Main(string[] args)
        {
            var url = HardSaltStatic.DecryptString("CyfI3Riw5+XxfBc/MocV3UO081Hc+Hdmpp4tIakUq20WFWI+Gv9yPuWcuswsIPUzIs1axG74HBL1CJPg=", SecretKey);
           
        }
        
    }
}
