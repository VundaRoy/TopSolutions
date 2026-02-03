using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Structural.Decorator.Car
{
    public class ElectricCarDecorator : CarDecorator
    {
        public ElectricCarDecorator(ICar car) : base(car)
        {
        }
        public override ICar ManufactureCar()
        {
            car.ManufactureCar();
            AddEngine(car);
            return base.ManufactureCar();
        }
        public override void AddEngine(ICar car)
        {
            if (car is BMWCar BMWCar)
            {
                BMWCar.Engine = "Electric Engine";
                Console.WriteLine("ElectricCarDecorator added Electric Engine to the Car : " + car);
            }
        }
        public void MonitorBatteryHealth()
        {
            Console.WriteLine("Monitoring the electric car battery health.");
        }
    }
}
