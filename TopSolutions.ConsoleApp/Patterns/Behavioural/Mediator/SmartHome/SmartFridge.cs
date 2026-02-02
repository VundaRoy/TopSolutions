using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Mediator.SmartHome
{
    public class SmartFridge : Component
    {
        public SmartFridge(IHomeController controller) : base(controller) { }
        public void TurnOn()
        {
            Console.WriteLine("Smart Fridge turned on.");
            _controller.Notify(this, "On");
        }
       public void SetTemperature(int temperature)
        {
            Console.WriteLine($"Smart Fridge temperature set to {temperature}°C.");
        }   
        public void CheckSupplies()
        {
            Console.WriteLine("Checking fridge supplies...");
        }
        public void OrderSupplies()
        {
            Console.WriteLine("Ordering supplies for the fridge...");
        }
    }
}
