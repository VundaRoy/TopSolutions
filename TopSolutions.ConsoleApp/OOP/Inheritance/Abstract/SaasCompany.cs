using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.OOP.Inheritance.Abstract
{
    public class SaasCompany : CorporateStaff
    {
        public override decimal CalculateBonus()
        {
            Console.WriteLine("Calculating bonus for SaaS Company staff...");
            //if end of year, give 15% bonus
            Console.WriteLine("End of year bonus is 15% of salary.");
            return 0; // Placeholder implementation
        }
        //Display SaaS Company staff info
        public void DisplaySaasInfo()
        {
            Console.WriteLine("Displaying SaaS Company staff information...");
            base.DisplayInfo();
        }
        //Promote SaaS Company staff
        public override void Promote(string newPosition, decimal salaryIncrease)
        {
            Console.WriteLine("Promoting SaaS Company staff...");
            base.Promote(newPosition, salaryIncrease);
        }
        //sealed override of terminate staff method
        public sealed override void Terminate()
        {
            Console.WriteLine("Terminating SaaS Company staff...");
            base.Terminate();
        }
    }
}
