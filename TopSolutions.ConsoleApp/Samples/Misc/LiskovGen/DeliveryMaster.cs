using TopSolutions.ConsoleApp.Samples.Misc.LiskovGen.Contract;
using TopSolutions.ConsoleApp.Samples.Misc.LiskovGen.Model;

namespace TopSolutions.ConsoleApp.Samples.Misc.LiskovGen
{
    public class DeliveryMaster
    {
        public void Render()
        {
            Driver driver = new Driver();
            driver.DriveCourier("driver");
            driver.CheckFleetFuel();

            HeadDelivery headDelivery = new HeadDelivery();
            headDelivery.DriveCourier("head delivery");
            

            GraduateDriver graduateDriver = new GraduateDriver();
            graduateDriver.CheckFleetFuel();

            IDelivery del = new Driver();

            IDelivery grad = new GraduateDriver();
            
            IDelivery mgr = new HeadDelivery();
            
            IDriver driver1 = new Driver();
            
        }

    }
}
