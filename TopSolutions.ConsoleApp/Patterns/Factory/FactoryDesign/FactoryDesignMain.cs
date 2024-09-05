using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Factory.FactoryDesign
{
    public class FactoryDesignMain
    {
        static void Main(string[] args) 
        {
            IVegetarianRecipe vegetarianRecipe = VegetarianRecipeFactory.GetRecipe("Sattvic");
            //validate sattvic recipe ingredients

            List<string> ingredients1 = new() { "dal", "ghee","carrot", "dhaniya","taro" };
            Console.WriteLine("Ingredients 1 is sattvic ? :" + vegetarianRecipe.GetValidIngredients(ingredients1).ToString());
           
        
        }
    }
}
