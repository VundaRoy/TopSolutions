using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.OOP.Polymorphism
{
    
    public class Source
    {
        public virtual void PrintSourceOfTruth(string variable)
        {
            Console.WriteLine($"The primary source of truth is {variable} ");
        }
    }
    public class Override : Source
    {
        public override void PrintSourceOfTruth(string variable)
        {
            base.PrintSourceOfTruth(variable);
            Console.WriteLine($"The secondary truth is also a {variable}");
        }
    }
    public class MainOverride
    {
        public static void Main(string[] args)
        {
            Override source = new();
            source.PrintSourceOfTruth("Torah");

            Source myTruth = new Override();
            myTruth.PrintSourceOfTruth("New testament");
            Source source1 = new Source();
            source1.PrintSourceOfTruth("Avesta");
        }
    }
}
