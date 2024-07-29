using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.OOP.Interface;

namespace TopSolutions.ConsoleApp.OOP.Abstract
{
    public abstract class CookIngredients : IPreparationMethod
    {
        public void ManageIngredients()
        {
            Console.WriteLine("Get ingredients list");
        }

        public void ProcessIngredients()
        {
            //decide what to process - cook, defrost, keep for hours, marinate, etc etc
        }

        public void CookIngredient()
        {
            //method of cooking - fry, bake, boil, deep fry, served cold, served as is

        }

        public virtual int GetQuantityOfIngredient(string ingredient, int recommendedQty = 0)
        {
            if (string.IsNullOrEmpty(ingredient))
                return 0;
            else
            {
                return Convert.ToInt32(ingredient);
            }
        }

        public abstract void EnterIngredientQuantity(string ingredient);


    }
}
