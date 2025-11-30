using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Factory.FactoryDesign
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
            
            //convert to switch case 
            switch(vegetarianType){
                
                case "Sattvic":
                    vegetarianRecipe = new SattvicRecipe();
                    break;
                case "Vegan":
                    vegetarianRecipe = new VeganRecipe();
                    break;
                case "Jain":
                    vegetarianRecipe = new JainRecipe();
                    break;
                default:
                    throw new ArgumentException("Invalid vegetarian type");
            }


            return vegetarianRecipe;
        }
    }
}
