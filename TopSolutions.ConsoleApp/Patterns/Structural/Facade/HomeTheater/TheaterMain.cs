using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Structural.Facade.HomeTheater
{
    public class TheaterMain
    {
        public static void Main()
        {
            var theater = new HomeTheaterFacade();
            //watch Telugu movie
            theater.WatchMovie("Baahubali");
            //watch Tamil movie
            theater.WatchMovie("Enthiran");

        }
    }
}
