using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.Patterns.Factory.Simple.FactoryClass;

namespace TopSolutions.ConsoleApp.Patterns.Factory.Simple
{
    public class MainCook
    {
        static void Main(string[] args)
        {
            var cook = CookFactory.GetCookType("Asian");

            if (cook != null) 
            {
                Console.WriteLine("Welcome statement " + cook.CookFood);
                Console.WriteLine("Ingredients" + cook.GetIngredients);
            }

        }
    }
}
