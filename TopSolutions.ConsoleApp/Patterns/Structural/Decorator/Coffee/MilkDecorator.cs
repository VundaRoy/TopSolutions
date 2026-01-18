using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Structural.Decorator.Coffee
{
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee)
        {
        }
        public override string getDescription()
        {
            return _coffee.getDescription() + ", Milk";
        }
        public override double getCost()
        {
            return _coffee.getCost() + 0.5;
        }
    }
}
