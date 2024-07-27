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
        public string Name => throw new NotImplementedException();

        public string Description => throw new NotImplementedException();

        public IngredientType Type => throw new NotImplementedException();
    }
}
