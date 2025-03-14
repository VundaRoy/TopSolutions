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
        public static void Main(string[] args)
        {
            Action<string, string> JoinWithUnd = (param1, param2) => result = param1 + " und " + param2;
            JoinWithUnd("Wiefel", "Jarhren");
            Console.WriteLine($"JoinWithUnd={result}");
        }
    }
}
