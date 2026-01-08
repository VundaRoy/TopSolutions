using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.Patterns.Creational.Factory.Vehicle.Vehicles;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Factory.Vehicle
{
    public class VehicleFactory : IVehicleFactory
    {
        public Vehicle Build(VehicleType vehicleType)
        {
            switch(vehicleType)
            {
                case VehicleType.TwoWheeler:
                    return new TwoWheeler();
                case VehicleType.FourWheeler:
                    return new FourWheeler();
                case VehicleType.HeavyVehicle:
                    return new HeavyVehicle();
                default:
                    throw new ArgumentException("Invalid vehicle type");
            }
        }
    }
}
