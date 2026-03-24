namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Mediator.ATC
{
    public class ClientATCMain
    {
        public static void Main()
        {
            IControlTower controlTower = new ControlTower();
            // Register two runways
            controlTower.RegisterRunway(new Runway("R1"));
            controlTower.RegisterRunway(new Runway("R2"));
            controlTower.RegisterRunway(new Runway("R3"));
            controlTower.RegisterRunway(new Runway("R4"));

            var listOfPlanes = CreateAirplanes(controlTower);
            foreach (var plane in listOfPlanes)
            {
                plane.RequestLanding();
            }
            Console.ReadKey();
        }
        public static List<Airplane> CreateAirplanes(IControlTower controlTower) => new()
        {
                new("FL123", controlTower),
                new("FL456", controlTower),
                new("FJ522", controlTower),
                new("CA100", controlTower),
                new("MH105", controlTower),
                new("BA200", controlTower),
                new("AF330", controlTower)
            };
    }
}
