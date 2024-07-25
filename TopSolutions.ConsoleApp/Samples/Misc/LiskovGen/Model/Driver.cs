using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.Samples.Misc.LiskovGen.Contract;

namespace TopSolutions.ConsoleApp.Samples.Misc.LiskovGen.Model
{
    public class Driver : IDriver
    {
        public void CheckFleetFuel()
        {
            Console.WriteLine("Check fuel in fleet");
        }

        public void CHeckTimesheets()
        {
            throw new NotImplementedException();
        }

        public void CollectOrder()
        {
            Console.WriteLine("Collect order");
        }

        public void DeliverGoods()
        {
            Console.WriteLine("Deliver goods");
        }

        public void DriveCourier(string title)
        {
            Console.WriteLine("Courier driver by "+ title);
        }
    }
}
