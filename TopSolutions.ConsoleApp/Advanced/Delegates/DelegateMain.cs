using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.Advanced.Delegates
{
    internal class DelegateMain
    {
        //Delegate sample
        delegate void Calculate(int a, int b);
        public static void Main()
        {
            //lambda expression for delegate
            Calculate add = (a, b) => Console.WriteLine($"Addition: {a + b}");
            //subtract method for delegate
            Calculate minus = (a, b) => Console.WriteLine($"Subtraction: {a - b}");
            //divide method for delegate
            Calculate divide = (a, b) => Console.WriteLine($"Division: {a / b}");
            //multiply method for delegate
            Calculate multiply = (a, b) => Console.WriteLine($"Multiplication: {a * b}");
            //running the delegate methods
            add(10, 5);
            minus(10, 5);
            divide(10, 5);
            multiply(10, 5);
        }
    }
}
