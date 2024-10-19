using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Factory.FactoryDesign
{
    public class VegetarianRecipeFactory
    {
        public static IVegetarianRecipe GetRecipe(string vegetarianType)
        {
            IVegetarianRecipe vegetarianRecipe = GetSpecificRecipe(vegetarianType);
            return vegetarianRecipe;

        }

        private static IVegetarianRecipe GetSpecificRecipe(string vegetarianType)
        {
            IVegetarianRecipe vegetarianRecipe = null;
            if (vegetarianType == "Sattvic")
            {
                vegetarianRecipe = new SattvicRecipe();
            }
            else if (vegetarianType == "Vegan")
            {
                vegetarianRecipe = new VeganRecipe();
            }

            return vegetarianRecipe;
        }
    }
}
