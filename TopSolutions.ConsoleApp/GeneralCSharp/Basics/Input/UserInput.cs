using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Basics.Input
{
    public class UserInput
    {
        public static void Main(string[] args)
        {
            string str; int userInput;
            Console.WriteLine("Enter a string - ");
            str = Console.ReadLine();
            Console.WriteLine($"You entered {str}");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();
            Console.Write("Input using Read() - ");
            userInput = Console.Read();
            Console.WriteLine("Ascii Value = {0}", userInput);
        }
    }
}
