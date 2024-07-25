using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Samples.Misc.LiskovVio
{
    public class Driver
    {
        public void CollectOrder()
        {
            Console.WriteLine("Get order from HQ");
        }

        public void DriveCourier(string title)
        {
            Console.WriteLine("Drive courier to destination as " + title);
        }

        public void DeliverGoods()
        {
            Console.WriteLine("Load delivery to destination");
        }

        public void CheckFuel(string Id)
        {
            Console.WriteLine("Check fuel by " + Id);
        }
    }
}
