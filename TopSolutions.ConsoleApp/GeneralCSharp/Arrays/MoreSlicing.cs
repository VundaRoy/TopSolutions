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
            Console.WriteLine("Start slice: ");
            var start = Console.ReadLine();
            Console.WriteLine("End slice: ");
            var end = Console.ReadLine();
            var res = SliceBetween(Convert.ToInt16(start), Convert.ToInt16(end), arr);

            string resultString = string.Join(", ", res);
            Console.WriteLine($"Sliced between {start} and {end} is " +
                $"{resultString}");
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
    }
}
