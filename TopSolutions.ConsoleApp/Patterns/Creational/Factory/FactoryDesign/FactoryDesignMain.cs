using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Factory.FactoryDesign
{
    public class FactoryDesignMain
    {
        static void Main(string[] args)
        {
            IVegetarianRecipe vegetarianRecipe = VegetarianRecipeFactory.GetRecipe("Sattvic");
            //validate sattvic recipe ingredients

            List<string> ingredients1 = new() { "dal", "ghee", "carrot", "dhaniya", "taro" };
            Console.WriteLine("Ingredients 1 is sattvic ? :" + vegetarianRecipe.GetValidIngredients(ingredients1).ToString());
            List<string> ingredients2 = new() { "dal", "ghee", "carrot", "dhaniya", "garlic", "tomato", "corn" };
            List<string> ingredients3 = new() { "dal", "carrot", "dhaniya", "tomato", "corn" };
            Console.WriteLine("Ingredients 2 is sattvic ? :" + vegetarianRecipe.GetValidIngredients(ingredients2).ToString());
            //validate vegan
            IVegetarianRecipe vegetarianRecipe1 = VegetarianRecipeFactory.GetRecipe("Vegan");
            Console.WriteLine("Ingredients 1 is vegan compliant ? " + vegetarianRecipe1.GetValidIngredients(ingredients1).ToString());
            vegetarianRecipe.PrepareIngredients();
            vegetarianRecipe1.PrepareIngredients();
            //validate both vegan and sattvic
            IVegetarianRecipe sattvicVegan = VegetarianRecipeFactory.GetRecipe("Vegan");
            Console.WriteLine("Ingredients 3 is vegan compliant ? " + sattvicVegan.GetValidIngredients(ingredients3).ToString());
            Console.WriteLine("Ingredients 3 is sattvic compliant ? " + sattvicVegan.GetValidIngredients(ingredients3).ToString());
        }
    }
}
