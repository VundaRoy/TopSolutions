using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.Patterns.Factory.FactoryMethod;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Factory.FactoryMethod
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
