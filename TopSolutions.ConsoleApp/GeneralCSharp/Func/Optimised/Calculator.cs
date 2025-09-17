using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Func.Optimised
{
    public static class Calculator
    {
        public static double Add(int a, int b) => a + b;
        public static double Subtract(int a, int b) => a - b;
        public static double Multiply(int a, int b) => a * b;
        public static double Divide(int a, int b) => a / b;
        public static double PowerOf(int a, int b) => Math.Pow(a, b);
        public static double SquareRoot(int a) => Math.Sqrt(a);
        public static double Rounded(double a) => Math.Round(a);
    }
}
