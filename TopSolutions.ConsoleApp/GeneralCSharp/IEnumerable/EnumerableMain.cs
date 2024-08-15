using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.IEnumerable
{
    public class EnumerableMain
    {
        static void Main(string[] args)
        {
            List<string> Month = new List<string>();
            Month.Add("January");
            Month.Add("February");
            Month.Add("March");
            Month.Add("April");
            Month.Add("May");
            Month.Add("June");
            Month.Add("July");
            Month.Add("August");
            Month.Add("September");
            Month.Add("October");
            Month.Add("November");
            Month.Add("December");
            //create IEnumerable of string
            IEnumerable<string> iEnumerableOfString = (IEnumerable<string>)Month;
            foreach (string AllMonths in iEnumerableOfString)
            {
                Console.WriteLine(AllMonths);
            }
        }
    }
}
