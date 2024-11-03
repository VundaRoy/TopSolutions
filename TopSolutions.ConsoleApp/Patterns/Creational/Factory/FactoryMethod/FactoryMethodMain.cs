namespace TopSolutions.ConsoleApp.Patterns.Creational.Factory.FactoryMethod
{
    public class FactoryMethodMain
    {
        static void Main(string[] args)
        {
            IDelivery delivery = new PackAndSendFactory().CreateDelivery();
            if (delivery != null)
            {
                Console.WriteLine("Deliverer is " + delivery.GetDeliveryDetails());
                Console.WriteLine("Cost is " + delivery.GetPrice());
                Console.WriteLine("Hours to deliver is " + delivery.GetHoursEstimate());
            }
            else
            {
                Console.WriteLine("Invalid delivery");
            }
        }
    }
}
