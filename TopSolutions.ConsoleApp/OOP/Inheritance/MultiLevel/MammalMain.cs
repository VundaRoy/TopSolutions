using System;
using System.Collections.Generic;
using System.Text;
using TopSolutions.ConsoleApp.OOP.Inheritance.MultiLevel.Contracts;

namespace TopSolutions.ConsoleApp.OOP.Inheritance.MultiLevel
{
    internal class MammalMain
    {
        public static void Main(string[] args)
        {
            // Create an instance of a monotreme
            IMonotreme platypus = new Platypus();
            platypus.LayEggs();
            platypus.HaveBill();
            platypus.Electroreception();
            // Create an instance of a feliformia
            IFeliformia cat = new Cat();
            cat.NightVision();
            cat.RetractileClaws();
            cat.Purring();
            
        }

    }
}
