using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Basics.ReferenceType
{
    public class RefOutExamples
    {
        //using ref and out keywords
        public static void Main()
        {
            int a = 5;
            int b;
            Console.WriteLine("Using ref keyword:");
            Console.WriteLine($"Before modification: a = {a}");
            ModifyRef(ref a);
            Console.WriteLine($"After modification: a = {a}");
            Console.WriteLine("\nUsing out keyword:");
            InitializeOut(out b);
            Console.WriteLine($"After initialization: b = {b}");
        }
        public static void ModifyRef(ref int number)
        {
            number += 10; // Modifies the original variable
        }
        public static void InitializeOut(out int number)
        {
            number = 20; // Must assign a value before exiting the method
        }
    }
}
