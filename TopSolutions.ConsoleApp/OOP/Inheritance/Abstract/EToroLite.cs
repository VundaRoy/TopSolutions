using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.OOP.Inheritance.Abstract
{
    public class EToroLite : EToroTraders
    {
        //inherit EtoroTraders class
        public EToroLite() { }
        //Override CalculateBonus method
        public override decimal CalculateBonus()
        {
            Console.WriteLine("Calculating bonus for eToro Lite Trader...");
            //eToro Lite Trader bonus calculation logic
            double bonus = 1500; // Example fixed bonus for eToro Lite Traders
            Console.WriteLine($"eToro Lite Trader bonus calculated: {bonus}");
            return 200;
        }
    }
}
