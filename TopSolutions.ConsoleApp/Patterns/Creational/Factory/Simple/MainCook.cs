using TopSolutions.ConsoleApp.Patterns.Creational.Factory.Simple.FactoryClass;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Factory.Simple
{
    public class MainCook
    {
        const string AsianIngredients = "Bok choi, celery, carrot, onions";
        const string LatinIngredients = "Habichuela, Tamale, Yucca";

        static void Main(string[] args)
        {
           //Cook based on type
            var mainCook = new MainCook();
            mainCook.CookBasedOnType("Asian");
            mainCook.CookBasedOnType("Latin");

        }
        public void CookBasedOnType(string type)
        {
            var cook = CookFactory.GetCookType(type);
            if (cook != null)
            {
                cook.CookFood(AsianIngredients);
                cook.ServerFood();
            }

        }
    }
}
