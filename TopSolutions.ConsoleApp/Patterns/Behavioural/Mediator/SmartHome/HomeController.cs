using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Mediator.SmartHome
{
    public class HomeController : IHomeController
    {
        public void Notify(Component sender, string eventInfo)
        {
            if (sender is Window && eventInfo == "opened")
            {
                Console.WriteLine("Turning off heater...");
                Console.WriteLine("Turning off lights...");
            }
            if(sender is Window && eventInfo == "closed")
            {
                Console.WriteLine("Heater is off...");
                Console.WriteLine("Lights are off...");
            }
            // Add more interactions as needed...
        }
    }
}
