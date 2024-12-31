using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Template.House
{
    public class GreenHouse : HouseTemplate
    {
        protected override void BuildFoundation()
        {
            Console.WriteLine("Green house foundation - plain concrete layer");
        }

        protected override void BuildPillars()
        {
            Console.WriteLine("Steel pillars basic setup");
        }

        protected override void BuildWalls()
        {
            Console.WriteLine("Glass wall surroundings");
        }

        protected override void BuildWindows()
        {
            Console.WriteLine("4 sided window setup");
        }
    }
}
