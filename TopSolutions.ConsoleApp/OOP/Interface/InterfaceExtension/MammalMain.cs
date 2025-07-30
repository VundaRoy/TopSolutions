using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.OOP.Interface.InterfaceExtension
{
    public class MammalMain
    {
        public static void Main(string[] args)
        {
            DomesticCat cat = new();
            cat.BreastFeed();
            cat.HasRetractileClaws();
            cat.ConsumesMeat();
        }
    }
}
