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
            //var okta = MyStatic.EncryptString("https://dev-88232354.okta.com", "2r.A46CxrqJNE#3TKZ3:w]fO");
           // var org = MyStatic.EncryptString("https://dev-88232354.okta.com/oauth2/default", "2r.A46CxrqJNE#3TKZ3:w]fO");
           // var redirect = MyStatic.DecryptString("http://localhost:8085/NewHealthBoth.aspx", "2r.A46CxrqJNE#3TKZ3:w]fO");
            //var staff = MyStatic.DecryptString("InternalEnsureApiClient", "2r.A46CxrqJNE#3TKZ3:w]fO");
            var cert = MyStatic.EncryptString("38ffc81822620d7bc239fefafd5b781d56185edb", "2r.A46CxrqJNE#3TKZ3:w]fO");
            var caching = MyStatic.EncryptString("0oa7q0e59fUAbTOIt5d7", "2r.A46CxrqJNE#3TKZ3:w]fO");
            //var enc1 = MyStatic.EncryptString("r9mXKfIdufqzhz_bMTfbdLCQzzSE8iv8Xyyop4Mg", "2r.A46CxrqJNE#3TKZ3:w]fO");
            //var dec2 = MyStaticLazy.DecryptString(enc1, "2r.A46CxrqJNE#3TKZ3:w]fO");
            // var decl = MyStaticLazy.DecryptString("MvRMvf1vu4fZMY7KImR9J53ZY/J3u0kXktkugtakZ3k=", "2r.A46CxrqJNE#3TKZ3:w]fO");
            //var dec3 = MyStaticLazy.DecryptString("HahUbP36NrdsJXmePdD1fIGMdQVdjwqjJD9LJAX4vAU=", "2r.A46CxrqJNE#3TKZ3:w]fO");
            //var enc = MyStatic.EncryptString("MvRMvf1vu4fZMY7KImR9J53ZY/J3u0kXktkugtakZ3k=", "2r.A46CxrqJNE#3TKZ3:w]fO");
            //var dec = MyStatic.DecryptString(enc, "CASI@");
            //var anotherDec = MyStatic.DecryptString(enc, "CASI*9"); will fail

        }
    }
}
