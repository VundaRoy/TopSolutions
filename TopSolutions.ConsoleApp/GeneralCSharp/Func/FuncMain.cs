using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Func
{
    public class FuncMain
    {
        static void Main(string[] args)
        {
            var funcCalculator = new Calculator();

            Func<int, int, int> add = funcCalculator.Add;
            Func<int, int, int> subtract = funcCalculator.Subtract;
            Func<int, int, int> multiply = funcCalculator.Multiply;
            Func<int, int, int> divide = funcCalculator.Divide;
            Console.WriteLine($"Addition result: {add(4, 2)}");
            Console.WriteLine($"Subtraction result: {subtract(4, 2)}");

            //Func with multiple additions
            Func<int, int, int, int> addTwoNumbers = (x, y, z) => x + y + z ;
            Console.WriteLine(addTwoNumbers(4, 8, 9));
            //Func with test of equality
            Func<int, int, bool> areEqual = (x, y) => x == y;
            Console.WriteLine(areEqual(2000, 3000));


        }
    }
}
