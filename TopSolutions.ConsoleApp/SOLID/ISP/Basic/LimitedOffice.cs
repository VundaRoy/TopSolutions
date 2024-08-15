namespace TopSolutions.ConsoleApp.SOLID.ISP.Basic
{
    public class LimitedOffice : ICoffeeDispenser
    {
        public string CheckDispenser(int DispenserId)
        {
            return "Coffee dispenser " + DispenserId + " is fine";
        }

        public void MakeCoffee(int CoffeeId)
        {
            Console.WriteLine("Making coffee");
        }
    }
}
