using NPOI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.OOP.Inheritance.Abstract
{
    public class HRcompany : CorporateStaff
    {
        override public decimal CalculateBonus()
        {
            Console.WriteLine("Calculating bonus for HR Company staff...");
            //if end of year, give 10% bonus
            Console.WriteLine("End of year bonus is 10% of salary.");
            return 0; // Placeholder implementation
        }
        override public void Promote(string newPosition, decimal salaryIncrease)
        {
            Console.WriteLine("Promoting HR Company staff...");
            base.Promote(newPosition, salaryIncrease);
        }
        override public sealed void Terminate()
        {
            Console.WriteLine("Terminating HR Company staff...");
            base.Terminate();
        }
    }
}
