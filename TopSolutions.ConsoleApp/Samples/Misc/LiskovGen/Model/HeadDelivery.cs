using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.Samples.Misc.LiskovGen.Contract;

namespace TopSolutions.ConsoleApp.Samples.Misc.LiskovGen.Model
{
    public class HeadDelivery : IManager
    {
        public void AssignTasks()
        {
            Console.WriteLine("Assign courier tasks");
        }

        public void CollectOrder()
        {
            Console.WriteLine("Collect order and sign off");
        }

        public void DeliverGoods()
        {
            Console.WriteLine("Deliver goods");
        }

        public void DriveCourier(string title)
        {
            Console.WriteLine("Courier driver by " + title);
        }

        public void PlanWeeklyTask()
        {
            Console.WriteLine("Draw upcoming tasks for drivers");
        }
    }
}
