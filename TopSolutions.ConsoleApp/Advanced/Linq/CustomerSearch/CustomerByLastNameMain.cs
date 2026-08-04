using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.Advanced.Linq.CustomerSearch
{
    internal class CustomerByLastNameMain
    {
        public static void Main(string[] args)
        {
            //List of customers to search from
            List<Customer> CustomerList = new List<Customer>() {
                new Customer { CustomerId = "C001", FirstName = "John", LastName = "Doe", Address = "123 Main St" },
                new Customer { CustomerId = "C002", FirstName =  "Jane", LastName = "Smith", Address = "456 Elm St" },
                new Customer{CustomerId = "C003", FirstName = "Coleman", LastName = "Johnson", Address = "789 Oak St" },
                new Customer{CustomerId = "C004", FirstName = "Alice", LastName = "Williams", Address = "101 Pine St" },
                new Customer{CustomerId = "C005", FirstName = "Bob", LastName = "Brown", Address = "202 Maple St" },
                new Customer{CustomerId = "C006", FirstName = "Charlie", LastName = "Johnson", Address = "303 Birch St" }};

            //Get first name from CustomerList using linq where last name is Johnson
            var customer = CustomerList.Where(c => c.LastName == "Johnson").FirstOrDefault();
            if (customer != null)
            {
                Console.WriteLine($"Customer found: {customer.FirstName} {customer.LastName}, Address: {customer.Address}");
            }
            else
            {
                Console.WriteLine("Customer not found.");
            }
        }
    }
}
