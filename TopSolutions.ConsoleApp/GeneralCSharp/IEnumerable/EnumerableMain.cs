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
            List<string> Month = new()
            {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };
            //create IEnumerable of string
            IEnumerable<string> iEnumerableOfString = (IEnumerable<string>)Month;
            foreach (string AllMonths in iEnumerableOfString)
            {
                Console.WriteLine(AllMonths);
            }
        }
    }
}
