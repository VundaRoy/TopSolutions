using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.OOP.Interface;

namespace TopSolutions.ConsoleApp.OOP.Classes
{
    public class Ingredient : IIngredient
    {
        IIngredient _ingredient;

        public string Name { get; set; }

        public string Description { get; set; }

        public IngredientType Type {get; set;}
    }
}
