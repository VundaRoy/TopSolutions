using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Factory.FactoryMethod
{
    public abstract class DeliveryFactory
    {
        protected abstract IDelivery MakeDelivery();
        public IDelivery CreateDelivery()
        {
            IDelivery delivery = this.MakeDelivery();
            return delivery;
        }
    }
}
