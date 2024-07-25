using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Samples.Patterns.Primera
{
    public class Person
    {
        public string Name { get; set; }   
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
    }
    public class BankingApplication
    {
        //Create a CRUD method for managing Accounts
        readonly IBank? _bank;
        Trustee myTrust;
        void CreatePerson(Person person)
        {

        }
        void DeletePerson(Person person) { 
        
        }
        void UpdatePerson(Person person)
        {

        }

        private void UpdateBankDetails(Bank bank)
        {
            _bank?.UpdateBank(bank);
            myTrust = new Trustee();
            myTrust.UpdateBank(_bank);
        }

    }
}
