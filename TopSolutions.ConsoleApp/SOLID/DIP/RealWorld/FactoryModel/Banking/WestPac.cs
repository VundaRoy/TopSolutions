namespace TopSolutions.ConsoleApp.SOLID.DIP.RealWorld.FactoryModel.Banking
{
    public class WestPac : IBank
    {        

        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"[WestPac] API connected. Processing payment of {amount}.");
        }

        public void GetTotalBalance()
        {
            Console.WriteLine($"[WestPac] API connected. Retrieving total balance.");
        }
    }
}
