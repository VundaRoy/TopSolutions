using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.OOP.Interface;

namespace TopSolutions.ConsoleApp.OOP.Classes
{
    public class CreateRecipe : ICreateRecipe
    {
        public List<Ingredient> GetIngredients(Ingredient item)
        {
            List<Ingredient> ingredientsList = new();
            //get ingredients

            var ingredient = new Ingredient()
            {
                Name = item.Name,
                Description = item.Description,
                Type = item.Type,

            };
            ingredientsList.Add(ingredient);
            return ingredientsList;
        }

       
        public void Method()
        {
            //Implement method

        }
    }
}
