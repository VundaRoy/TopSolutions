using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Structural.Decorator.Coffee
{
    public class PlainCoffee : ICoffee
    {
        public string getDescription()
        {
            return "Plain Coffee";
        }
        public double getCost()
        {
            return 2.0;
        }
    }
}
