using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Factory.FactoryDesign
{
    public class VeganRecipe : IVegetarianRecipe
    {
        public void CookIngredients()
        {
            Console.WriteLine("Making vegan dish, simple as nature");
        }

        public bool GetValidIngredients(List<string> listOfIngredients)
        {
            foreach (var item in listOfIngredients)
            {
                Console.WriteLine(item);
                //validate for onion and garlic
                if (item != null)
                {
                    if (item.Equals("milk", StringComparison.OrdinalIgnoreCase) || item.Equals("honey", StringComparison.OrdinalIgnoreCase)
                        || item.Equals("butter", StringComparison.OrdinalIgnoreCase)|| item.Equals("cheese", StringComparison.OrdinalIgnoreCase)
                        || item.Equals("ghee", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Not vegan compliant. Ingredient contains " + item );
                        return false;
                    }
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
