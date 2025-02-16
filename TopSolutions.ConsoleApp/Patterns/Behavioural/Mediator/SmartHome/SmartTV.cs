using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Mediator.SmartHome
{
    public class SmartTV : Component
    {
        public SmartTV(IHomeController controller) : base(controller)
        {
            Console.WriteLine("Powering up TV");

        }
        public void TurnOn()
        {
            Console.WriteLine("TV is on");
            _controller.Notify(this, "On");
            _controller.LogEvents("Smart TV");
        }
        public void TurnOff()
        {
            Console.WriteLine("TV is off");
            _controller.Notify(this, "Off");
        }
    }
}
