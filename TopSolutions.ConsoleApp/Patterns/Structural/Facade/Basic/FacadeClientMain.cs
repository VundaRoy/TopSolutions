using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Structural.Facade.Basic
{
    public class FacadeClientMain
    {
        static void Main(string[] args)
        {
            //The Client will use the Facade Interface instead of the Subsystems
            OrderFacade order = new();
            order.PlaceOrder();
            Console.Read();
        }
    }
}
