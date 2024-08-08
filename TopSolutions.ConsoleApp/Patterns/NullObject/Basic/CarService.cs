namespace TopSolutions.ConsoleApp.Patterns.NullObject.Basic
{
    public class CarService
    {
        private readonly ICar _car;
        public CarService(ICar car)
        {
            _car = car;
        }
       
        public void Run()
        {
            Console.WriteLine($"Start run method. {nameof(ICar)}: {_car}");
            _car.Drive();
            _car.Stop();

            Console.WriteLine($"Complete run method. {nameof(ICar)}: {_car}");
            Console.WriteLine();
        }
    }
}
