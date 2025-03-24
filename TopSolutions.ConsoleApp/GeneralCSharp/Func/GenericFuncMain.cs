using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Func
{
    public class GenericFuncMain
    {

        public static void Main(string[] args)
        {
            Func<int, double, float, string> combined = CombineThree;
            string result = CombineThree(334, 66.7, 56.809f);
            Console.WriteLine(result);
            Func<string, string, char, string> comb1 = CombineThree;
            result = CombineThree("entebbe", "international", 'a' + 'b');
            Console.WriteLine(result);   
        }
        public static string CombineThree<T1, T2, T3>(T1 param1, T2 param2, T3 param3)
        {
            return $"Combined values: {param1}, {param2}, {param3}";
        }
    }
}
