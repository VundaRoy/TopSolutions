using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Basics.Checked
{
    public class CheckedMain
    {
        static void Main(string[] args)
        {
            //With checked
             const int a = 2147483647; //const will result in compile time error for checked
             const int b = 2147483647;
            
            //unchecked
            //int d = a + b;
            int d = unchecked(a + b);
            Console.WriteLine(d);
            Console.ReadLine();

            int c = unchecked(a + b);//checked will error out
            Console.WriteLine(c);
        }
    }
}
