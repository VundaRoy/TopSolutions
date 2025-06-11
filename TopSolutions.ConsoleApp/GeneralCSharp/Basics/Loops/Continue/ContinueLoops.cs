using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Basics.Loops.Continue
{
    public class ContinueLoops
    {
        public static void Main(string[] args)
        {
            int i = 0, j = 0;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (j == 2)
                    {
                        Console.WriteLine($"Inner loop for i is {i} and j is {j}");
                        Console.WriteLine("continue on");
                        continue;
                    }
                    else if (j == 4)
                    {
                        Console.WriteLine($"j is {j} therefore leaving j loop");
                        break;
                    }
                }
                Console.WriteLine($"Outer loop for i is {i} and j is {j}");
            }
        }
    }
}
