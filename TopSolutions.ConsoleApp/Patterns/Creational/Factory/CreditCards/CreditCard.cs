using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Factory.CreditCards
{
    public class CreditCard
    {
        public virtual string GetCardType()
        {
            return "Generic Credit Card";
        }
        public virtual int GetCreditLimit()
        {
            return 0;
        }
        public virtual int GetAnnualCharge()
        {
            return 0;
        }
    }
}
