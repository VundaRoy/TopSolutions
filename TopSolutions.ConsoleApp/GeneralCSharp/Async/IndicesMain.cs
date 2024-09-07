using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Async
{
    public class IndicesMain
    {
        static async Task Main(string[] args)
        {
            var states = new string[]
            {
                "Himachal Pradesh",
                "Uttar Pradesh",
                "Andhra Pradesh",
                "Goa",
                "Telangana",
                "Mizoram",
                "Nagaland",
                "Manipur",
                "Rajasthan"
            };
            Index i1 = 3, i2 = 4;
            Console.WriteLine($"{states[i1]}");
            Console.WriteLine($"{states[i2]}");
        }
    }
}
