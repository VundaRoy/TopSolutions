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
        static Action<string, string> JoinWith = (param1, param2) => result = param1 + " und " + param2;
        public static void Main(string[] args)
        {
            PleaseGet("bread");
            Console.WriteLine($"After plea we get: {result}");
            //Conjuction usage
            Console.WriteLine($"English join is : {GetJoinWith("me", "you", "and")}");
            Console.WriteLine($"German join is : {GetJoinWith("ich", "sie", "und")}");
            Console.WriteLine($"French join is : {GetJoinWith("moi", "toi", "et")}");

            Action<string> Append_s = (param1) => result = param1 + "'s";
            Append_s("Lake Geneva");
            Console.WriteLine($"Append with s looks like {result}");
        }
        public static string GetJoinWith(string first, string second, string conjunction)
        {
            JoinWith = (first, second) => result = first + conjunction + second;
            return result;
        }
    }
}
