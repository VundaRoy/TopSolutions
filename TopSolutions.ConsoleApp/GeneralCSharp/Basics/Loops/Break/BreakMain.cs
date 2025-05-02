using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Basics.Loops.Break
{
    public class BreakMain
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"I : {i} J : {j}");
                    if (j > 3)
                    {
                        break;
                    }
                }
                Console.WriteLine("Out of inner for-loop");
            }
            Console.WriteLine("Out of all loops");
            Console.ReadKey();
        }
    }
}
