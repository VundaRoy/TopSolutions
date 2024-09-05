using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Factory.FactoryDesign
{
    public interface IVegetarianRecipe
    {
        bool GetValidIngredients(List<string> listOfIngredients);
        void PrepareIngredients();
        void CookIngredients();
        void PresentDish();
    }
}
