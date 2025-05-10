using NPOI.HSSF.Record;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Arrays
{
    public class SliceSample
    {
        public static void Main(string[] args)
        {
            string sample = "Tamavua";
            Console.WriteLine($"The 2nd value of Tamavua is {GetValueBasedOnNumber(2, sample)}");
            Console.WriteLine($"The 3rd value of Tamavua is {GetValueBasedOnNumber(3, sample)}");
        }
        static string GetValueBasedOnNumber(int entry, string arrayString)
        {
            var resp = arrayString[..entry].ToString();
            return resp;
        }
    }
}
