namespace TopSolutions.ConsoleApp.Patterns.Creational.Factory.FactoryMethod
{
    public class BeRightBackFactroy : DeliveryFactory
    {
        protected override IDelivery MakeDelivery()
        {
            IDelivery delivery = new PackAndSend();
            return delivery;
        }
    }
}
