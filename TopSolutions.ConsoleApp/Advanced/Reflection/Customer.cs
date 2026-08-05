using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.Advanced.Reflection
{
    public class Customer
    {
        public string CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int NumberOfOrders { get; set; }
        public decimal TotalCharged { get; set; }
    }
}
