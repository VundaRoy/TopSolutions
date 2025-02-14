using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Mediator.SmartHome
{
    public class SmartHomeMain
    {
        public static void Main()
        {
            // Usage
            var homeController = new HomeController();
            var window = new Window(homeController);
            var heater = new Heater(homeController);
            CoffeeMaker coffee;
            SmartTV smartTV;
            window.Open();  // This should notify the controller to turn off heater and lights
            window.Close();
            
            Console.ReadKey();
            Console.WriteLine("What else do you want to start? 1 - TV, 2 - Coffee");
            string option = Console.ReadLine();
            if(option == "1")
            {
                smartTV = new SmartTV(homeController);
                smartTV.TurnOn();
            }
            else
            {
                coffee = new CoffeeMaker(homeController);
                coffee.TurnOn();
            }

        }
    }
}
