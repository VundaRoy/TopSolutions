using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Mediator.SmartHome
{
    public class Heater : Component
    {
        // Constructor to set the mediator (home controller) for the heater component
        public Heater(IHomeController controller) : base(controller) { }
        public void TurnOn()
        {
            Console.WriteLine("Heater turned on.");
        }
    }
}
