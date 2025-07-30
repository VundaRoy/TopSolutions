using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.OOP.Interface.InterfaceExtension
{
    public class Lion : IFelidae
    {
        public void BreastFeed()
        {
            Console.WriteLine("Lions breastfeed cubs");
        }

        public void ConsumesMeat()
        {
            Console.WriteLine("Lions eats meat mostly");
        }

        public void HasRetractileClaws()
        {
            Console.WriteLine("Claws are retractile but large");        }

        public void MakesSound()
        {
            Console.WriteLine("Lions roar and occasionally purrs");
        }
    }
}
