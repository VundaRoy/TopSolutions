using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Factory.FactoryDesign
{
    public class SattvicRecipe : IVegetarianRecipe
    {
        public void CookIngredients()
        {
            Console.WriteLine("Cooking sattvic style. Temper with hing, mustard seed and oil");
        }

        public bool GetValidIngredients(List<string> listOfIngredients)
        {
            foreach (var item in listOfIngredients) 
            { 
                Console.WriteLine(item);
                //validate for onion and garlic
                if (item != null)
                {
                    if(item.Equals("onion", StringComparison.OrdinalIgnoreCase) || item.Equals("garlic", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Not sattvic compliant. Ingredient contains " + item);
                        return false;
                    }
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
