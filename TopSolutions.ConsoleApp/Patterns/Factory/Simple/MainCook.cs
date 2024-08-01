using TopSolutions.ConsoleApp.Patterns.Factory.Simple.FactoryClass;

namespace TopSolutions.ConsoleApp.Patterns.Factory.Simple
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
