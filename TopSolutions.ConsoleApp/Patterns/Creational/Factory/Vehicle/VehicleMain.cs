using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Factory.Vehicle
{
    internal class VehicleMain
    {
        public static void Main()
        {
            AvisCarDealer dealer = new AvisCarDealer();
            dealer.BuildVehicle(VehicleType.TwoWheeler);
            dealer.GetVehicle().Drive();
            //four wheeler
            dealer.BuildVehicle(VehicleType.FourWheeler);
            dealer.GetVehicle().Drive();
            //heavy vehicle
            dealer.BuildVehicle(VehicleType.HeavyVehicle);
            dealer.GetVehicle().Drive();
        }
    }
}
