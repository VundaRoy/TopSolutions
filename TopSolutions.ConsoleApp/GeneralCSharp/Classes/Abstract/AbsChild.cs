using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Classes.Abstract
{
    public class AbsChild : AbsParent
    {
        public override void Mul(int x, int y)
        {
            Console.WriteLine($"Multiplication of {x} and {y} is : {x * y}");
        }
        public override void Div(int x, int y)
        {
            if (y != 0)
                Console.WriteLine($"Division of {x} and {y} is : {x / y}");
            else
                Console.WriteLine("Division by zero is not allowed.");
        }
    }
}
