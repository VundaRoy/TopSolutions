using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Factory.Simple.Contract
{
    public interface ICook
    {
        void GetIngredients();
        void PrepareIngredients();
        void CookFood(string ingredient);
        void ServerFood();
        string GetProfile(string name);

    }
}
