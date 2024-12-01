using TopSolutions.ConsoleApp.Patterns.Creational.Factory.Simple.FactoryClass;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Factory.Simple
{
    public class MainCook
    {        
        const string AsianIngredients =  "Bok choi, celery, carrot, onions";
        const string LatinIngredients = "Habichuela, Tamale, Yucca";
        
        static void Main(string[] args)
        {
            string type = "Asian";
            var cook = CookFactory.GetCookType(type);

            if (cook != null)
            {
                cook.CookFood(AsianIngredients);
                cook.ServerFood();
                type = "Latin";
                cook = CookFactory.GetCookType(type);
                cook.CookFood(LatinIngredients);
                cook.ServerFood();
            }

        }

    }
}
