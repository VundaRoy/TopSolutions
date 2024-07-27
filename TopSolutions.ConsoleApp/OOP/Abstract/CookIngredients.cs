using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.OOP.Interface;

namespace TopSolutions.ConsoleApp.OOP.Abstract
{
    public abstract class CookIngredients : IPreparationMethod
    {
        public void ManageIngredients()
        {
            throw new NotImplementedException();
        }

        public void ProcessIngredients()
        {
            throw new NotImplementedException();
        }

        public void CookIngredient()
        {

        }
    }
}
