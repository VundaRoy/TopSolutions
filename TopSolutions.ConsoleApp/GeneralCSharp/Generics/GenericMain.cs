using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Generics
{
    public class GenericMain
    {
        static void Main(string[] args)
        {
            bool isEqual = GenericCalculator.AreEqual<double>(10.5, 20.5);
            EvaluateAndPrint(isEqual, "10.5 and 20.5");
            isEqual = GenericCalculator.AreEqual<string>("ABC", "ABC");
            EvaluateAndPrint(isEqual, "ABC and ABC");

        }

        static void EvaluateAndPrint(bool isEqual, string comparison)
        {
            Console.Write("For " + comparison + " ");
            if (isEqual)
            {
                Console.WriteLine("Both are Equal");
            }
            else
            {
                Console.WriteLine("Both are Not Equal");
            }
            Console.ReadKey();
        }
    }
}
