using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.OOP.Classes;

namespace TopSolutions.ConsoleApp.OOP.Interface
{
    public interface IRecipe
    {
        string Name { get; set; }
        string Description { get; set; }
       
        List<Ingredient> GetIngredients(string ingredientEntry);

    }
}
