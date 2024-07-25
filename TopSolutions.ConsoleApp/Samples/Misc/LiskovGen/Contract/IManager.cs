namespace TopSolutions.ConsoleApp.Samples.Misc.LiskovGen.Contract
{
    public interface IManager :IDelivery
    {
        void AssignTasks();
        void PlanWeeklyTask();
    }
}