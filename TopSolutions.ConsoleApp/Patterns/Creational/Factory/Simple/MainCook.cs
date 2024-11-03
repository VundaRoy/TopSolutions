using TopSolutions.ConsoleApp.Patterns.Creational.Factory.Simple.FactoryClass;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Factory.Simple
{
    public class MainCook
    {
        static void Main(string[] args)
        {
            var cook = CookFactory.GetCookType("Asian");

            if (cook != null)
            {
                cook.CookFood();
                cook.ServerFood();
            }

        }
    }
}
