using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.OOP.Interface;

namespace TopSolutions.ConsoleApp.OOP.Classes
{
    public class Recipe : IRecipe
    {
        public Recipe()
        {
            Console.WriteLine("Starting recipe..");
        }

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public List<Ingredient> GetIngredients(Ingredient ingredient)
        {
            throw new NotImplementedException();
        }
    }
}
 