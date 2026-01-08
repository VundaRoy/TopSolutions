using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Factory.Vehicle.Vehicles
{
    public class HeavyVehicle : Vehicle 
    {
        public string Name { get; set; }
        public override void Drive()
        {
            Console.WriteLine($"{Name} is driving as a heavy vehicle.");
        }
        public override void Stop()
        {
            Console.WriteLine($"{Name} has stopped.");
        }
    }
}
