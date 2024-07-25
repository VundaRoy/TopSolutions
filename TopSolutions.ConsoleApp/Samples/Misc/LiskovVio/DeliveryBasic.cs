using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Samples.Misc.LiskovVio
{
    public class DeliveryBasic
    {
        public void Render()
        {
            HeadDelivery headDeliver = new HeadDelivery();
            headDeliver.AssignTasks();

            GraduateDriver graduateDriver = new GraduateDriver();
            
            
            
            
        }
    }
}
