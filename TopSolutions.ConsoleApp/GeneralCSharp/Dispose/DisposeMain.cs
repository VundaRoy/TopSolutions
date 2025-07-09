using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Dispose
{
    public class DisposeMain
    {
        public static void Main(string[] args)
        {
            using(var resourceHolder = new ResourceHolder())
            {
                Console.WriteLine("In the heart of it!");
            }
            var anotherResourceHolder = new ResourceHolder();
            anotherResourceHolder.Dispose();
            var finalResourceHolder = new ResourceHolder();
            Console.ReadKey();
        }
    }
}
