using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Func.Optimised
{
    public class OptimisedLambda
    {
        static List<Func<int, int, double>> opsList = new()
    {
        Calculator.Add,
        Calculator.Subtract,
        Calculator.Multiply,
        Calculator.Divide,
        Calculator.PowerOf
    };

        static List<Func<int, double>> opsListOne = new()
    {
        Calculator.SquareRoot
    };

        static List<Func<double, double>> opsListDouble = new()
    {
        Calculator.Rounded
    };

        static void Main(string[] args)
        {
            OptimisedLambda mt = new();

            Console.WriteLine("Enter first number:");
            if (!int.TryParse(Console.ReadLine(), out int first))
            {
                Console.WriteLine("Invalid input for first number.");
                return;
            }

            Console.WriteLine("Enter second number:");
            if (!int.TryParse(Console.ReadLine(), out int second))
            {
                Console.WriteLine("Invalid input for second number.");
                return;
            }

            mt.PrintBinaryOperationResults(opsList, first, second);

            foreach (var value in new[] { first, second })
            {
                mt.PrintUnaryOperationResults(opsListOne, value);
            }

            Console.WriteLine("Enter number to round:");
            if (!double.TryParse(Console.ReadLine(), out double round))
            {
                Console.WriteLine("Invalid input for rounding.");
                return;
            }

            mt.PrintDoubleOperationResults(opsListDouble, round);
        }

        private void PrintBinaryOperationResults(List<Func<int, int, double>> opList, int first, int second)
        {
            foreach (var op in opList)
            {
                Console.WriteLine($"{op.Method.Name} result: {op(first, second)}");
            }
        }

        private void PrintUnaryOperationResults(List<Func<int, double>> opList, int value)
        {
            foreach (var op in opList)
            {
                Console.WriteLine($"{op.Method.Name} result: {op(value)}");
            }
        }

        private void PrintDoubleOperationResults(List<Func<double, double>> opList, double value)
        {
            foreach (var op in opList)
            {
                Console.WriteLine($"{op.Method.Name} result: {op(value)}");
            }
        }
    }
}
