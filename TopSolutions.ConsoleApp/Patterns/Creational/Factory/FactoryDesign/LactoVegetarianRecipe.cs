using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Factory.FactoryDesign
{
    public class LactoVegetarianRecipe : IVegetarianRecipe
    {
        string result = "";
        public void CookIngredients()
        {
            Console.WriteLine("Cooking Lacto-Vegetarian style. Temper with mustard seed and vegie oil");
        }
        public string GetValidationResults()
        {
            return result;
        }
        public bool GetValidIngredients(List<string> listOfIngredients)
        {
            var nonCompliantIngredients = new List<string> { "meat", "seafood", "egg" };
            foreach (var item in listOfIngredients)
            {
                Console.WriteLine(item);
                if (item != null && nonCompliantIngredients.Contains(item, StringComparer.OrdinalIgnoreCase))
                {
                    result = "Not Lacto-Vegetarian compliant. Ingredient contains " + item;
                    return false;
                }
            }
            return true;
        }
        public void PrepareIngredients()
        {
            Console.WriteLine("Making Lacto-Vegetarian cuisine great");
        }
        public void PresentDish()
        {
            Console.WriteLine("Presenting the most dairy friendly dish");
        }
    }
        
}
