using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Mediator.SmartHome
{
    public class CoffeeMaker : Component
    {
        public CoffeeMaker(IHomeController controller) : base(controller)
        {
        }
        public void TurnOn()
        {
            Console.WriteLine("Coffee turned on.");
            _controller.Notify(this, "On");
        }
    }
}
