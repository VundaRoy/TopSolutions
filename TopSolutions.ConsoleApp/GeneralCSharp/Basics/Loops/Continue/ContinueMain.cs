using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Basics.Loops.Continue
{
    public class ContinueMain
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine($"The count is {i}, Einstein, press any key to continue");
                    Console.ReadKey();
                    continue;
                }
                Console.WriteLine($"i : {i}");
            }

            Console.ReadKey();
        }
    }
}
