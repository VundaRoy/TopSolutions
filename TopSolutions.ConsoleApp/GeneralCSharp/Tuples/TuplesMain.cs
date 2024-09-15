using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Tuples
{
    public class TuplesMain
    {
        static void Main(string[] args)
        {
            var values = new List<double>() { 10.85, 20.6, 30.3, 40.05, 50 };
            //Store the Result of Calulate Method in a variable of Tuple type 
            Tuple<int, double> t = Calculate(values);
            //Access the First value using Item1 and second value using Item2 properties
            Console.WriteLine($"There are {t.Item1} values and their sum is {t.Item2}");
            Console.ReadKey();

            static int square(int x) => x * x;
            Console.WriteLine("square of 7 is " + square(7) + " and square of 9 is " + square(9));
            static int sum(int x, int y, int z) => x + z + y;
            Console.WriteLine("Sum of 6,8 and 9 is " + sum(6, 7, 9));

            Func<int, double> circleArea = x => 3.14 * (x ^ 2);
            Console.WriteLine("Area of circle with radius of 5cm is :" + circleArea(5));

            Func<int, double> sphereVolume = x => (4 / 3) * 3.34 * (x ^ 3);
            Console.WriteLine("Sphere of radius 7cm has a volume of " + sphereVolume(7).ToString("#.###") + "cm cubed");
            Func<int, int, int, double> cuboidVolume = (x, y, z) => x * y * z;
            Console.WriteLine("A cuboid with dimensions 7,6,4 has a volume of " + cuboidVolume(7,6,4).ToString("#.###") + "cm cubed");
        }
        //Declaring the return type as Tuple<int, double>
        private static Tuple<int, double> Calculate(IEnumerable<double> values)
        {
            int count = 0;
            double sum = 0.0;
            foreach (var value in values)
            {
                count++;
                sum += value;
            }
            //Creating an object of Tuple class by calling the static Create method
            Tuple<int, double> t = Tuple.Create(count, sum);
            //Returning the tuple instance
            return t;
        }
    }
}
