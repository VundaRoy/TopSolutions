using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Factory.FactoryMethod
{
    public class PackAndSendFactory : DeliveryFactory
    {
        protected override IDelivery MakeDelivery()
        {
            IDelivery delivery = new PackAndSend();
            return delivery;
        }
    }
}
