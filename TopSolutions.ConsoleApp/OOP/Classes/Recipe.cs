using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.OOP.Abstract;
using TopSolutions.ConsoleApp.OOP.Interface;

namespace TopSolutions.ConsoleApp.OOP.Classes
{
    public class Recipe :  CookIngredients, IRecipe
    {
        public Recipe()
        {
            Console.WriteLine("Starting recipe..");
        }

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void EnterIngredientQuantity(string ingredient)
        {
            throw new NotImplementedException();
        }

        public List<Ingredient> GetIngredients(Ingredient ingredient)
        {
            throw new NotImplementedException();
        }
        public override int GetQuantityOfIngredient(string ingredient, int recommendedQty = 0)
        {
            var qty = base.GetQuantityOfIngredient(ingredient);
            if (qty > 0 && recommendedQty > qty)
            {
                return qty*2;
            }
            return qty;

        }
    }
}
 