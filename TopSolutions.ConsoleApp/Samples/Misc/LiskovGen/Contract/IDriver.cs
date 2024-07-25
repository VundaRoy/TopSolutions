namespace TopSolutions.ConsoleApp.Samples.Misc.LiskovGen.Contract
{
    public interface IDriver : IDelivery
    {
        void CheckFleetFuel();
        void CHeckTimesheets();
    }
}