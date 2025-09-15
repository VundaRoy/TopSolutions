using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Func
{
    public class Calculator
    {
        public double Add(int a, int b) => a + b;
        public double Subtract(int a, int b) => a - b;
        public double Multiply(int a, int b) => a * b;
        public double Divide(int a, int b) => a / b;
        public double PowerOf(int a, int b) => Math.Pow(a, b);
    }
}
