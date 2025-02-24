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
        private const string SecretKey = "2rquantO";
        public static void Main(string[] args)
        {
            var url = HardSaltStatic.DecryptString("j+JHHY0V9TYFVwScbUyJSu7", SecretKey);
           
        }
        
    }
}
