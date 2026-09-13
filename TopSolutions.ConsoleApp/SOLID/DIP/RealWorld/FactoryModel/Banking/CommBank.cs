namespace TopSolutions.ConsoleApp.SOLID.DIP.RealWorld.FactoryModel.Banking
{
    public class CommBank : IBank
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"[CommBank] API connected. Processing payment of {amount}.");
        }

        public void GetTotalBalance()
        {
            Console.WriteLine($"[CommBank] API connected. Retrieving total balance.");
        }
    }
}
