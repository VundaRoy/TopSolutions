namespace TopSolutions.ConsoleApp.SOLID.DIP.RealWorld.FactoryModel.Banking
{
    public class WestPac : IBank
    {        
        public decimal Balance { get; private set; }
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"[WestPac] API connected. Processing payment of {amount}.");
            Balance -= amount;
            Console.WriteLine($"[WestPac] Payment of {amount} processed successfully. Please check your account for the updated balance.");
        }

        public void GetTotalBalance()
        {
            Console.WriteLine($"[WestPac] API connected. Retrieving total balance. ${Balance}");
            Console.WriteLine("Disclaimer: WestPac may charge additional fees for certain transactions. Please check with your bank for more information.");
        }
    }
}
