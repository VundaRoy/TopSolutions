using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Func
{
    public class MultiTaskLambda
    {
        static List<Func<int, int, double>> opsList;
        static void Main(string[] args)
        {
            var funcCalculator = new Calculator();
            CreateMathOpsList(funcCalculator);
            MultiTaskLambda mt = new();
            Console.WriteLine("Enter first number ");
            var first = Console.ReadLine();
            Console.WriteLine("Enter second number ");
            var second = Console.ReadLine();
            mt.ReturnAllFunctionsResults(opsList, Convert.ToInt32(first), Convert.ToInt32(second));

        }

        private static void CreateMathOpsList(Calculator funcCalculator)
        {
            opsList = new List<Func<int, int, double>>();
            Func<int, int, double> add = funcCalculator.Add;
            opsList.Add(add);
            Func<int, int, double> subtract = funcCalculator.Subtract;
            opsList.Add(subtract);
            Func<int, int, double> multiply = funcCalculator.Multiply;
            opsList.Add(multiply);
            Func<int, int, double> divide = funcCalculator.Divide;
            opsList.Add(divide);
            Func<int, int, double> powerOf = funcCalculator.PowerOf;
            opsList.Add(powerOf);
        }

        //Get back all combinations of two integers by math functions
        private void ReturnAllFunctionsResults(List<Func<int, int, double>> opList, int first, int second)
        {
            foreach(var op in opList)
            {
                Console.WriteLine($"{op.Method.Name} result: {op(first, second)}");
            }
            
        }

    }
}
