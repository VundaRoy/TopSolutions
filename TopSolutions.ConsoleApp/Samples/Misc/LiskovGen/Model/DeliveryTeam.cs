using TopSolutions.ConsoleApp.Samples.Misc.LiskovGen.Contract;

namespace TopSolutions.ConsoleApp.Samples.Misc.LiskovGen.Model
{
    public class DeliveryTeam : IDelivery
    {
        public void CollectOrder()
        {
            Console.WriteLine("Get order from HQ");
        }

        public void DriveCourier(string title)
        {
            Console.WriteLine("Drive courier to destination as "+ title);
        }

        public void DeliverGoods()
        {
            Console.WriteLine("Load delivery to destination");
        }
    }
}
