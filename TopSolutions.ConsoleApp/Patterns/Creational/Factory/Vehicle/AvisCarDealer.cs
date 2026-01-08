using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Factory.Vehicle
{
    public class AvisCarDealer
    {
        private Vehicle _vehicle;
        public AvisCarDealer()
        {
            _vehicle = null;
        }
        public void BuildVehicle(VehicleType vehicleType)
        {
            IVehicleFactory factory = new VehicleFactory();
            _vehicle = factory.Build(vehicleType);
        }
        public Vehicle GetVehicle()
        {
            return _vehicle;
        }

    }
}
