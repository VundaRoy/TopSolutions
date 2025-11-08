//using NPOI.HSSF.Record;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Collections.Arrays
{
    public class SliceSample
    {
        public static void Main(string[] args)
        {
            string sample = "Tamavua";
            Console.WriteLine($"The 2nd value of Tamavua is {GetValueBasedOnNumber(2, sample)}");
            Console.WriteLine($"The 3rd value of Tamavua is {GetValueBasedOnNumber(3, sample)}");
            Console.WriteLine("enter another string: ");
            sample = Console.ReadLine();
            Console.WriteLine("enter start: ");
            var start = Console.ReadLine();
            Console.WriteLine("enter end: ");
            var end = Console.ReadLine();
            
            Console.WriteLine($"The range gives {GetSliceRange(Convert.ToInt16(start), Convert.ToInt16(end), sample)}");
        }
        static string GetValueBasedOnNumber(int entry, string arrayString)
        {
            var resp = arrayString[..entry].ToString();
            return resp;
        }
        static string GetSliceRange(int start, int end, string arrayString)
        {
            if (arrayString.Length < end) { return $"Wrong entries for start({start}) and end({end})";  }
            return arrayString.Substring(start, end);
        }
    }
}
