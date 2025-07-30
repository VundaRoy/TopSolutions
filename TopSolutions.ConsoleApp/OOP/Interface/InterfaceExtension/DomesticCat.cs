using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.OOP.Interface.InterfaceExtension
{
    public class DomesticCat : IFelidae
    {
        public void BreastFeed()
        {
            Console.WriteLine("Female Cats breastfeed kittens");
        }

        public void ConsumesMeat()
        {
            Console.WriteLine("All cats east meat almost exclusively");
        }

        public void HasRetractileClaws()
        {
            Console.WriteLine("All cats have retractile claws and soft fur");
        }
        public void Meows()
        {
            Console.WriteLine("Cats makes meow sound");
        }
    }
}
