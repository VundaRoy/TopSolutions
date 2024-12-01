using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.Patterns.Creational.Factory.Simple.Contract;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Factory.Simple
{
    public class CookAsian : ICook
    {
        public CookAsian()
        {
            Console.WriteLine("Welcome to Asian cuisine");
        }

        public void CookFood(string ingredient)
        {
            Console.WriteLine($"Ready to stir fry {ingredient}");
        }

        public void GetIngredients()
        {
            Console.WriteLine("Dice and slice veges");
        }

        public void PrepareIngredients()
        {
            Console.WriteLine("Pour oil and temper spices");
        }

        public void ServerFood()
        {
            Console.WriteLine("Bring out the pandan leaves");
        }
        public string GetProfile(string name)
        {
            return "Asian cook";
        }


    }
}
