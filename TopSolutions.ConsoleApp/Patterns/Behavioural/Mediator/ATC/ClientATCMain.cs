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
            
            var listOfPlanes = new ClientATCMain().CreateAirplanes(controlTower);
            foreach (var plane in listOfPlanes)
            {
                plane.RequestLanding();
            }
            Console.ReadKey();
        }
        public List<Airplane> CreateAirplanes(IControlTower controlTower)
        {
            return new List<Airplane>
            {
                new Airplane("FL123", controlTower),
                new Airplane("FL456", controlTower),
                new Airplane("FJ522", controlTower),
                new Airplane("CA100", controlTower),
                new Airplane("MH105", controlTower)
            };
        }
    }
}
