namespace TopSolutions.ConsoleApp.Samples.Misc.Variance.Contracts
{
    public interface IUser<out T> where T : class
    {
        void Notify<TE>(string user);
    }
}
