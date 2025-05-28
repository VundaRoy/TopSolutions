using NPOI.OpenXmlFormats.Dml.Diagram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Arrays
{
    public class MoreSlicing
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 12, 22, 90, 6, 77, 122, 9, 23, 112 };
            Console.WriteLine(string.Join(", ", arr));
            Console.WriteLine("Start slice: ");
            var start = Console.ReadLine();
            Console.WriteLine("End slice: ");
            var end = Console.ReadLine();
            var res = SliceBetween(Convert.ToInt16(start), Convert.ToInt16(end), arr);

            string resultString = string.Join(", ", res);
            Console.WriteLine($"Sliced between {start} and {end} is " +
                $"{resultString}");
            res = LastThreeNumbers(arr);
            resultString = string.Join(", ", res);
            Console.WriteLine($"The last 3 numbers are {resultString}");
            var word = Console.ReadLine();
            if (word != null && word.Length > 3)
            {
                Console.WriteLine($"The word {word} between 2 and 4 is {SliceStringBetween(2, 4, word)}");
            }
            //Get last number
            Console.WriteLine($"The last number for the array i {GetLastNumber(arr)}.");
            //Skip the nth number
            Console.WriteLine("Enter the nth number to skip");
            var num = Console.ReadLine();
            Console.WriteLine($"The skipped number of {SkipNthNumber(arr,Convert.ToInt32(num))}");
        }

        static int[] SliceBetween(int start, int end, int[] arrayInt)
        {

            // Validate indices
            if (start < 0 || end > arrayInt.Length || start > end)
            {
                throw new ArgumentOutOfRangeException("Invalid start or end index.");
            }

            return arrayInt[start..end];
        }
        static string SliceStringBetween(int start, int end, string arrayString)
        {
            return arrayString[start..end];
        }
        static int[] LastThreeNumbers(int[] ints)
        {
            if(ints.Length >= 3)
            {
                return ints[^3..];
            }
            return ints;
        }
        static int[] SkipNthNumber(int[] ints, int nthValue)
        {
            if (ints.Length > nthValue)
            {
                return ints[nthValue..];
            }
            return ints;
        }
        static int[] GetLastNumber(int[] ints)
        {           
            return ints[^1..];
        }
    }
}
