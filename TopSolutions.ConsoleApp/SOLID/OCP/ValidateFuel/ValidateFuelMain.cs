using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.OCP.ValidateFuel
{
    public class ValidateFuelMain
    {
        public static void Main()
        {
            // Create instances of the vehicle types
            FuelService fuelService = new FuelService(new SedanVehicle());
            // Get fuel type for a sedan
            string sedanFuelType = fuelService.GetFuelTypeBaseOnVehicleType("Sedan");
            Console.WriteLine($"Fuel type for Sedan: {sedanFuelType}");
            // Create an instance for a truck vehicle type
            fuelService = new FuelService(new SemiTrailer());
            // Get fuel type for a truck
            string truckFuelType = fuelService.GetFuelTypeBaseOnVehicleType("SemiTrailer");
        }
    }
}
