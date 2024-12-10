using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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
          Overload ov = new Overload(); 
            ov.StationName("A");
            var station = ov.StationName('C');
            Console.WriteLine(station);
        }
    }
}
