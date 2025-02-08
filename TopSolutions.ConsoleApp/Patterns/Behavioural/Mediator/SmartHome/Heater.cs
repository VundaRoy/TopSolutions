using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Mediator.SmartHome
{
    public class Heater : Component
    {
        public Heater(IHomeController controller) : base(controller) { }
        public void TurnOn()
        {
            Console.WriteLine("Heater turned on.");
        }
    }
}
