using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Factory.FactoryDesign
{
    public class VeganRecipe : IVegetarianRecipe
    {
        string result;
        public void CookIngredients()
        {
            Console.WriteLine("Making vegan dish, simple as nature");
        }

        public string GetValidationResults()
        {
            return result;
        }

        public bool GetValidIngredients(List<string> listOfIngredients)
        {
            var nonCompliantIngredients = new List<string> { "honey", "milk", "cheese", "butter", "ghee", "yoghurt", "condensed milk", "gelatin", "dairy", "lard", "meat", "seafood", "egg" };

            foreach (var item in listOfIngredients)
            {
                Console.WriteLine(item);
                if (item != null && nonCompliantIngredients.Contains(item, StringComparer.OrdinalIgnoreCase))
                {
                    result = "Not vegan compliant. Ingredient contains " + item;
                    return false;
                }

            }
            return true;
        }

        public void PrepareIngredients()
        {
            Console.WriteLine("Making vegan your style");
        }

        public void PresentDish()
        {
            Console.WriteLine("Enjoy your vegan dish");
        }
    }
}
