using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.OOP.Polymorphism;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Factory.Vehicle.Vehicles
{
    public class TwoWheeler : Vehicle
    {
        public string Name { get; set; }
        public override void Drive()
        {
            Console.WriteLine($"{Name} is driving on two wheels.");
        }

        public override void Stop()
        {
            Console.WriteLine($"{Name} has stopped.");
        }
    }
}
