using NPOI.OpenXmlFormats.Dml.Diagram;

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
        public void StationName(int input)
        {
            switch(input){
                case int n when (n >= 1 && n <= 10):
                    Console.WriteLine("Southern lines");
                    break;
                case int n when (n>= 11 && n <= 20):
                    Console.WriteLine("Northern lines");
                    break;
                case int n when (n>= 21 && n <= 30):
                    Console.WriteLine("Western lines");
                    break;
                    default:
                    Console.WriteLine("Invalid line entered");
                    break ;
            }
        }

        public static void Main(string[] args) 
        { 
          Overload ov = new(); 
            ov.StationName("A");
            var station = ov.StationName('C');
            Console.WriteLine(station);
            //enter integer
            ov.StationName(2);
        }
    }
}
