namespace TopSolutions.ConsoleApp.Patterns.NullObject.Basic
{
    public class NullCar : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Drive the null car.");
        }

        public void Stop()
        {
            Console.WriteLine("Stop the null car.");
        }
    }
}
