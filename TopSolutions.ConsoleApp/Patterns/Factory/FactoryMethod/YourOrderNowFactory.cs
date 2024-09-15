﻿    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Factory.FactoryMethod
{
    public class YourOrderNowFactory : DeliveryFactory
    {
        protected override IDelivery MakeDelivery()
        {
            IDelivery delivery = new YourOrderNow();
            return delivery;
        }
    }
}