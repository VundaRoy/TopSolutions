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
            isEqual = GenericCalculator.AreEqual<int>(122, 123);
            EvaluateAndPrint(isEqual, "122 and 123");
            //two different types
            isEqual = GenericCalculator.AreTwoTypesEqual<int, float>(22, 22f);
            EvaluateAndPrint(isEqual, "22 and 22f");
            isEqual = GenericCalculator.AreTwoTypesEqual<int, float>(22, 22);
            EvaluateAndPrint(isEqual, "22 (int) and 22 (float)");
            //Add two numbers using generic method
            double result = GenericCalculator.Add<double>(10.5, 20.5);
            Console.WriteLine("Addition of 10.5 and 20.5 is " + result);
            //add two integers using generic method
            int result1 = GenericCalculator.Add<int>(10, 20);
            Console.WriteLine("Addition of 10 and 20 is " + result1);
            //subtract two numbers using generic method
            result = GenericCalculator.Subtract<double>(20.5, 10.5);
            Console.WriteLine("Subtraction of 20.5 and 10.5 is " + result);

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
           // Console.ReadKey();
        }
    }
}
