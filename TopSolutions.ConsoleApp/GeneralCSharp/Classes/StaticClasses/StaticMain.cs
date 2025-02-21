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
            var lazyS = MyStaticLazy.EncryptString("veryGood", "UIO#$");
            var decl = MyStaticLazy.DecryptString(lazyS, "UIO#$");
            var enc = MyStatic.EncryptString("walterZinda", "CASI@");
            var dec = MyStatic.DecryptString(enc, "CASI@");
            //var anotherDec = MyStatic.DecryptString(enc, "CASI*9"); will fail

        }
    }
}
