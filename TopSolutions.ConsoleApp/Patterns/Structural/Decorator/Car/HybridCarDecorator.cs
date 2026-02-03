using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Structural.Decorator.Car
{
    public class HybridCarDecorator : CarDecorator
    {
        public HybridCarDecorator(ICar car) : base(car)
        { 
        }
        public override ICar ManufactureCar()
        {
            car.ManufactureCar();
            AddEngine(car);
            return car;
            
        }
        public override void AddEngine(ICar car) 
        { 
            if(car is BMWCar bMWCar)
            {
                bMWCar.Engine = "Hybrid Engine";
                Console.WriteLine("Added hybrid engine to the car " + car);
            }
        }
        public void ManageBattery()
        {
            Console.WriteLine("Managing the hybrid car battery.");
        }
        public void MonitorFuelEfficiency()
        {
            Console.WriteLine("Monitoring fuel efficiency of the hybrid car.");
        }
    }
}
