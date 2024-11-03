using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.Patterns.Creational.Factory.Simple.Contract;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Factory.Simple
{
    public class Cook : ICook
    {
        public void CookFood()
        {
            Console.WriteLine("Cook away!");
        }

        public void GetIngredients()
        {
            Console.WriteLine("Gather all the stuff");
        }

        public void PrepareIngredients()
        {
            Console.WriteLine("Organise stuff");
        }

        public void ServerFood()
        {
            Console.WriteLine("Serve food");
        }
        public string GetProfile(string name)
        {
            return "general cook";
        }
    }
}
