using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Facade.Basic
{
    public class FacadeClientMain
    {
        static void Main(string[] args)
        {
            //The Client will use the Facade Interface instead of the Subsystems
            Order order = new();
            order.PlaceOrder();
            Console.Read();
        }
    }
}
