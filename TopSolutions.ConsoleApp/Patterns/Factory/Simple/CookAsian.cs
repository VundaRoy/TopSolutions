using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Factory.Simple
{
    public class CookAsian : Cook
    {
        public CookAsian() 
        {
            Console.WriteLine("Welcome to Asian cuisine");
        }
        public void StirFry()
        {
            Console.WriteLine("start stir fry");
        }
    }
}
