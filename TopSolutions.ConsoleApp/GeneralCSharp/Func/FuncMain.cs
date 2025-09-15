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

            Func<int, int, double> add = funcCalculator.Add;
            Func<int, int, double> subtract = funcCalculator.Subtract;
            Func<int, int, double> multiply = funcCalculator.Multiply;
            Func<int, int, double> divide = funcCalculator.Divide;
            Func<int, int, double> powerOf = funcCalculator.PowerOf;
            Console.WriteLine($"Addition result: {add(410000, 255220)}");
            Console.WriteLine($"Subtraction result: {subtract(4, 2)}");
            Console.WriteLine($"10 to the power of 3 is {powerOf(10, 3)}");

            //Func with multiple additions
            Func<int, int, int, int> addTwoNumbers = (x, y, z) => x + y + z ;
            Console.WriteLine(addTwoNumbers(4, 8, 9));
            //Func with test of equality
            Func<int, int, bool> areEqual = (x, y) => x == y;
            Console.WriteLine(areEqual(2000, 3000));

            //func with areas
            Console.WriteLine($"Rectangle of width 3 and length 5 is {((Func<double, double, double>)((x,y) => x * y))(3, 5) } ");
            Func<double, double> GetCircleArea = (x) => 3.14 * Math.Pow(x,2);
            Console.WriteLine("Circle area of radius 3 is " + GetCircleArea(3));
            Console.WriteLine("Circle area of radius 30.5 is " + GetCircleArea(30.5));

            //Action
            Action<string> printResponse;
            printResponse = Console.WriteLine;
            printResponse("this is it!");
            //action lambda
            
            printResponse = p => Console.WriteLine(p);
            printResponse("c3po was my design");
            printResponse("and so what?");

        }
    }
}
