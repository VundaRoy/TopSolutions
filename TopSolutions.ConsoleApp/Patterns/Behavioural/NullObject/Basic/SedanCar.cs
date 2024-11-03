namespace TopSolutions.ConsoleApp.Patterns.Behavioural.NullObject.Basic
{
    public class SedanCar : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Drive the sedan car.");
        }

        public void Stop()
        {
            Console.WriteLine("Stop the sedan car.");
        }
    }
}
