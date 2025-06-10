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
            int i=0,  j = 0;
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"i : {i} j : {j}");
                    if (j > 3)
                    {
                        break;
                    }
                }
                Console.WriteLine($"Out of inner for-loop where i is {i} and j is {j}");
            }
            Console.WriteLine("Out of all loops.");
            Console.ReadKey();
        }
    }
}
