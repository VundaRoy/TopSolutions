using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Factory.FactoryMethod
{
    public class BeRightBackFactroy : DeliveryFactory
    {
        protected override IDelivery MakeDelivery()
        {
            IDelivery delivery = new PackAndSend();
            return delivery;
        }
    }
}
