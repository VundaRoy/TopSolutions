using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Factory.Simple
{
    public class CookLatin : Cook
    {
        public CookLatin()
        {
            Console.WriteLine("Welcome to Latino cuisine");
        }
        public void BoilBeans()
        {
            Console.WriteLine("Come habichuelas!");
        }
    }
}
