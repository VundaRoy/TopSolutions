namespace TopSolutions.ConsoleApp.Patterns.Behavioural.NullObject.Basic
{
    public class BasicNullMain
    {
        public static void Main(string[] args)
        {
            var sedanCar = new SedanCar();
            var carService = new CarService(sedanCar);

            carService.Run();

            var nullCar = new NullCar();
            carService = new CarService(nullCar);

            carService.Run();

        }
    }
}
