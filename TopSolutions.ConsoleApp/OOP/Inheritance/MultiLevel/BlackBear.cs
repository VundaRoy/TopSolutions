using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.OOP.Inheritance.MultiLevel
{
    public class BlackBear : Bear
    {
        public void Climbing()
        {
            Console.WriteLine("Black Bear is climbing trees");
        }
        public void Foraging()
        {
            Console.WriteLine("Black Bear is foraging for food");
        }
        public void Hibernation()
        {
            Console.WriteLine("Black Bear is hibernating");
        }
    }
}
