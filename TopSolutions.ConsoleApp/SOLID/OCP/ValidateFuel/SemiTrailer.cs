using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.OCP.ValidateFuel
{
    public class SemiTrailer : IValidateFuel
    {
        public string GetFuelTypeBaseOnVehicleType(string vehicleType)
        {
            if (vehicleType == "SemiTrailer")
            {
                return "Diesel";
            }
            else
            {
                return "Unleaded";
            }
        }
    
    }
}
