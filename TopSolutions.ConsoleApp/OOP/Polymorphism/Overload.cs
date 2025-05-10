namespace TopSolutions.ConsoleApp.OOP.Polymorphism
{
    public class Overload
    {
        public string StationName(char input)
        {
            return input switch
            {
                'A' => "Aberdeen",
                'B' => "Bernaby",
                'C' => "Cambridge",
                _ => "None"
            };
        }
        public void StationName(string input)
        {
            if (input[..1].Equals("A"))
            {
                Console.WriteLine("A stations selected");
            }
            else 
            {
                Console.WriteLine("Non-A station selected");
            }
        }

        public static void Main(string[] args) 
        { 
          Overload ov = new(); 
            ov.StationName("A");
            var station = ov.StationName('C');
            Console.WriteLine(station);
        }
    }
}
