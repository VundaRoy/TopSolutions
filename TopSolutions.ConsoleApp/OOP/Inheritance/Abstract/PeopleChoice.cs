using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.OOP.Inheritance.Abstract
{
    public class PeopleChoice : HRcompany
    {
        public override decimal CalculateBonus()
        {
            Console.WriteLine("Calculating bonus for People Choice staff...");
            //if end of year, give 12% bonus
            Console.WriteLine("End of year bonus is 12% of salary.");
            return 0; // Placeholder implementation
        }
        public override void Promote(string newPosition, decimal salaryIncrease)
        {
            Console.WriteLine("Promoting People Choice staff...");
            base.Promote(newPosition, salaryIncrease);
        }
    }
}
