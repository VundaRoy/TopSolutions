using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Factory.FactoryDesign
{
    public class SattvicRecipe : IVegetarianRecipe
    {
        public void CookIngredients()
        {
            Console.WriteLine("Cooking sattvic style. Temper with hing, mustard seed and oil");
        }

        public bool GetValidIngredients(List<string> listOfIngredients)
        {
            var nonCompliantIngredients = new List<string> { "onion", "garlic", "turnips", "leek", "shallots", "mushrooms", "meat", "seafood", "egg" };

            foreach (var item in listOfIngredients)
            {
                Console.WriteLine(item);
                if (item != null && nonCompliantIngredients.Contains(item, StringComparer.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Not sattvic compliant. Ingredient contains " + item);
                    return false;
                }

            }
            return true;
        }

        public void PrepareIngredients()
        {
            Console.WriteLine("Making sattvic your goal");
        }

        public void PresentDish()
        {
            Console.WriteLine("Your favorite sattvic dish is ready");
        }
    }
}
