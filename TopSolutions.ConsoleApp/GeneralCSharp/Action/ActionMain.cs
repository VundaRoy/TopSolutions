using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Action
{
    public class ActionMain
    {        
        public static string result;
        public static Action<string> PleaseGet = (param) => result = "Please get " + param;
        public static void Main(string[] args)
        {
            PleaseGet("bread");
            Console.WriteLine($"After plea we get: {result}");
            Action<string, string> JoinWithUnd = (param1, param2) => result = param1 + " und " + param2;
            JoinWithUnd("Wiefel", "Jarhren");
            Console.WriteLine($"JoinWithUnd={result}");
            Action<string> Append_s = (param1) => result = param1 + "'s";
            Append_s("Lake Geneva");
            Console.WriteLine($"Append with s looks like {result}");
        }
    }
}
