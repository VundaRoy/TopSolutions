using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Structural.Decorator.Coffee
{
    public class CoffeeMain 
    {
        public static void Main()
        {
            //Plain coffee
            ICoffee myCoffee = new PlainCoffee();
            Console.WriteLine($"{myCoffee.getDescription()} : ${myCoffee.getCost()}");
            //Coffee with milk
            myCoffee = new MilkDecorator(myCoffee);
            Console.WriteLine($"{myCoffee.getDescription()} : ${myCoffee.getCost()}");
            //Coffee with milk and sugar
            myCoffee = new SugarDecorator(myCoffee);
            Console.WriteLine($"{myCoffee.getDescription()} : ${myCoffee.getCost()}");
        }
    }
}
