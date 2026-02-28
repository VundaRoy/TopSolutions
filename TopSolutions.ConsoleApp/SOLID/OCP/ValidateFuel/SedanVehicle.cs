using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.OCP.ValidateFuel
{
    public class SedanVehicle : IValidateFuel
    {
        public string GetFuelTypeBaseOnVehicleType(string vehicleType)
        {
            if (vehicleType == "Sedan")
            {
                return "Unleaded";
            }
            else
            {
                return "Unleaded";
            }
        }
    
    }
}
