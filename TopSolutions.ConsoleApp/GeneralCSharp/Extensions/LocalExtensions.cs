using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Extensions
{
    public static class LocalExtensions
    {
        public static string AppendDisclosure(this string text) 
        { 
            return text + " By the way I deny all links to this statement"; 
        
        }
        public static string AppendDisclosureExtra(this string text, string extraText)
        {
            return text + " By the way I deny all links to this statement "+ extraText;

        }
        public static string CapsLockTheThing(this string text) 
        {
            return text + " when caps is " + text.ToUpper();
        }
    }
}
