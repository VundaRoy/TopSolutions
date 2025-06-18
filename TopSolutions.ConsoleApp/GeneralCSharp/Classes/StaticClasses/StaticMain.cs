using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Classes.StaticClasses
{
    public class StaticMain
    {
        public static void Main(string[] args)
        {
            var cert = MyStatic.EncryptString("38ffc81822620d7bc239fefafd5b781d56185edb", "2r.A46CxrqJNE#3TKZ3:w]fO");
            var caching = MyStatic.EncryptString("0oa7q0e59fUAbTOIt5d7", "2r.A46CxrqJNE#3TKZ3:w]fO");
        }
    }
}
