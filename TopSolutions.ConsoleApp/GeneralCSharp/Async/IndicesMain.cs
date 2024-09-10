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
            Index third = 2, fourth = 3, fifth = 4;
            Console.WriteLine($"{states[third]}");
            Console.WriteLine($"{states[fourth]}");
            Console.WriteLine($"{states[fifth]}");
        }
    }
}
