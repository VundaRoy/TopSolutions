using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Samples.Misc.LiskovVio
{
    public class HeadDelivery : Driver
    {
        public void AssignTasks()
        {
            Console.WriteLine("Assign courier tasks");
        }
        public void PlanWeeklyTask()
        {
            Console.WriteLine("Draw upcoming tasks for drivers");
        }
    }
}
