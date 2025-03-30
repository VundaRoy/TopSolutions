using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Factory.FactoryDesign
{
    public class JainRecipe : IVegetarianRecipe
    {
        string result = "";
        public void CookIngredients()
        {
            Console.WriteLine("Cooking Jain style. Temper with hing and vegie oil");
        }

        public string GetValidationResults()
        {
            return result;
        }

        public bool GetValidIngredients(List<string> listOfIngredients)
        {
            var nonCompliantIngredients = new List<string> { "onion", "garlic", "turnips", "leek", "shallots", "mushrooms", "meat", "seafood", "egg" , "taro", "potatoes", "kumala"};

            foreach (var item in listOfIngredients)
            {
                Console.WriteLine(item);
                if (item != null && nonCompliantIngredients.Contains(item, StringComparer.OrdinalIgnoreCase))
                {
                    result = "Not Jain compliant. Ingredient contains " + item;
                    return false;
                }

            }
            return true;
        }

        public void PrepareIngredients()
        {
            Console.WriteLine("Making Jain cuisine great");
        }

        public void PresentDish()
        {
            Console.WriteLine("Presenting the most ahmimsa friendly dish");
        }
    }
}
