using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Samples.Patterns.Primera
{
    public class Bank : IBank
    {
        public int BankID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public void AddBank(IBank bank)
        {
            if (bank == null) throw new ArgumentNullException();
        }

        public void DeleteBank(IBank bank)
        {
            if (bank == null) throw new ArgumentNullException();
            else
            {
               
            }
                    
        }

        public void UpdateBank(IBank bank)
        {
            throw new NotImplementedException();
        }
    }
}
