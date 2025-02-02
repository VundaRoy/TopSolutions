using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Factory.FactoryDesign
{
    public class FactoryDesignMain
    {
        const string VEGAN = "Vegan";
        const string SATTVIC = "Sattvic";

        static void Main(string[] args)
        {
            IVegetarianRecipe vegetarianRecipe = VegetarianRecipeFactory.GetRecipe("Sattvic");
            //validate sattvic recipe ingredients

            List<string> ingredients1 = new() { "dal", "ghee", "carrot", "dhaniya", "taro" };
            VerifyIngredients(vegetarianRecipe, ingredients1, SATTVIC, "ingredients1");
            //VerifyIngredients(vegetarianRecipe, ingredients1, VEGAN, "ingredients1");

            List<string> ingredients2 = new() { "dal", "ghee", "carrot", "dhaniya", "garlic", "tomato", "corn" };
            //VerifyIngredients(vegetarianRecipe, ingredients2, SATTVIC, "ingredients2");
            VerifyIngredients(vegetarianRecipe, ingredients2, VEGAN, "ingredients2");

        }
        static void VerifyIngredients(IVegetarianRecipe vegetarianRecipe, List<string> ingredients, string FoodType, string ListName)
        {
            Console.WriteLine($"Verifying if the ingredients are {FoodType} compliant");
            Console.WriteLine($"You entered these ingredients {string.Join(", ", ingredients)} for {ListName}");
            Console.WriteLine($"The {ListName} compliancy with {FoodType} is {vegetarianRecipe.GetValidIngredients(ingredients)}");
        }
    }
}
