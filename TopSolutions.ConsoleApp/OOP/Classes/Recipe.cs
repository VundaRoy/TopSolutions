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
        string IRecipe.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IRecipe.Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        
        public List<Ingredient> GetIngredients(Ingredient ingredient)
        {
            throw new NotImplementedException();
        }
    }
}
 