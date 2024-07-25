using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Samples.Misc.LiskovGen.Contract
{
    public interface IDelivery
    {
        void CollectOrder();
        void DeliverGoods();
        void DriveCourier(string title);

    }
}
