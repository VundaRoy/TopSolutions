using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Structural.Decorator.Car
{
    public class DecoratorCarInstance
    {
        public static void Main(string[] args)
        {
            var factory = new CarFactory();

            // Plain BMW without engine
            ICar bmwCar1 = new BMWCar();
            bmwCar1.ManufactureCar();
            Console.WriteLine(bmwCar1 + "\n");

            // BMW with Diesel Engine
            var carWithDieselEngine = factory.CreateDecoratedCar<DieselCarDecorator>();
            carWithDieselEngine.ManufactureCar();
            Console.WriteLine();

            // BMW with Petrol Engine
            var carWithPetrolEngine = factory.CreateDecoratedCar<PetrolCarDecorator>();
            carWithPetrolEngine.ManufactureCar();

            // BMW Hybrid
            var carHybrid = factory.CreateDecoratedCar<HybridCarDecorator>();
            carHybrid.ManufactureCar();
            carHybrid.ManageBattery();
            carHybrid.MonitorFuelEfficiency();

            // BMW Electric
            var bmwElec = factory.CreateDecoratedCar<ElectricCarDecorator>();
            bmwElec.ManufactureCar();
            bmwElec.MonitorBatteryHealth();

            Console.ReadKey();
        }
    }
    class CarFactory
    {
        public T CreateDecoratedCar<T>() where T : class
        {
            ICar bmwCar = new BMWCar();
            return (T)Activator.CreateInstance(typeof(T), bmwCar);
        }
    }
}
