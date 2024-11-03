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
            var airplane1 = new Airplane("FL123", controlTower);
            var airplane2 = new Airplane("FL456", controlTower);
            var airplane3 = new Airplane("FJ522", controlTower);
            airplane1.RequestLanding();
            airplane2.RequestLanding();
            airplane3.RequestLanding();
            // Only one plane should land as we only have one runway. 
            // The other should wait for an available runway.
            Console.ReadKey();
        }
    }
}
