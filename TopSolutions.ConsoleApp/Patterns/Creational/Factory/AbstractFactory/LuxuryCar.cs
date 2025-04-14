using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Factory.AbstractFactory
{
    public class LuxuryCar : ICar
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching Luxury car Details..");
        }
    }
}
