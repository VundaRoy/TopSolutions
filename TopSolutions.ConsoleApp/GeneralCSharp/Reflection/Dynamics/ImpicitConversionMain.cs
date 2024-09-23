using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Reflection.Dynamics
{
    public class ImpicitConversionMain
    {
        static void Main(string[] args)
        {
            // int to double - implicit conversion
            int int1 = 500;
            double double1 = int1;
            Console.WriteLine($"int1 = {int1} & double1 = {double1}");

            // int to dynamic to double - implicit conversion
            int int3 = 100;
            dynamic dynamic1 = int3;
            double double2 = dynamic1;
            Console.WriteLine($"int3 = {int3} & dynamic1 = {dynamic1} & double2 = {double2}");

            // Even with dynamic an explicit cast is required when 
            // converting larger data types like double to int
            double double3 = 4000.22;
            dynamic dynamicDouble = double3;
            int int2 = (int)dynamicDouble;
            Console.WriteLine($"double2 = {double3} & dynamicDouble = {dynamicDouble} && int2 = {int2}");

            //Calling DisplayValue Function with different types of values
            Console.WriteLine("Calling parameter dynamic");
            DisplayValue("Dynamic in C#"); //String
            DisplayValue(true); //Boolean
            DisplayValue(5000); //Integer
            DisplayValue(111.50); //Double
            DisplayValue(DateTime.Now); //Date
            Console.ReadKey();
        }
        public static void DisplayValue(dynamic val)
        {
            Console.WriteLine(val);
        }
    }
}
