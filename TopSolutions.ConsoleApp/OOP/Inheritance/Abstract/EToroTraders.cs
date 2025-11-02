using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.OOP.Inheritance.Abstract
{
    public class EToroTraders : SaasCompany
    {
        //implement CalculateBonus method
        public override decimal CalculateBonus()
        {
            Console.WriteLine("Calculating bonus for eToro Traders...");
            //if end of year, give 20% bonus
            Console.WriteLine("End of year bonus is 20% of salary.");
            return 0; // Placeholder implementation
        }
        //implement a sealed method
        public sealed override void Promote(string newPosition, decimal salaryIncrease)
        {
            Console.WriteLine("Promoting eToro Trader...");
            base.Promote(newPosition, salaryIncrease);
        }
        //implement Terminate method will cause error as it is sealed in SaasCompany
        //public override void Terminate()
    }
}
