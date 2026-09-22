namespace TopSolutions.ConsoleApp.SOLID.DIP.RealWorld.FactoryModel.Banking
{
    public class CommBank : IBank
    {
        public decimal Balance { get; private set; }
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"[CommBank] API connected. Processing payment of {amount}.");
            Balance -= amount;
            Console.WriteLine($"[CommBank] Payment of {amount} processed successfully. Please check your account for the updated balance.");
        }

        public void GetTotalBalance()
        {
            Console.WriteLine($"[CommBank] API connected. Retrieving total balance. ${Balance}");
        }
    }
}
