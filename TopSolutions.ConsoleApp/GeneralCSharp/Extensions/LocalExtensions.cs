using System;
using System.Collections.Generic;
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
    }
}
