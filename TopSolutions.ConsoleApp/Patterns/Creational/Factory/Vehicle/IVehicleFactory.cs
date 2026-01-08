using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Factory.Vehicle
{
    public interface IVehicleFactory
    {
        Vehicle Build(VehicleType vehicleType);
    }
}
