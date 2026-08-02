using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.Advanced.Linq.CustomerSearch
{
    internal class CustomerMain
    {
        //List of customers to search from
        public static List<Customer> CustomerList;
        //a program to utilise Linq to look up customer based on id
        public static void InititaliseData()
        {
            //create data for CustomerList
            CustomerList = new List<Customer>() {
                new Customer { CustomerId = "C001", FirstName = "John", LastName = "Doe", Address = "123 Main St" },
                new Customer { CustomerId = "C002", FirstName =  "Jane", LastName = "Smith", Address = "456 Elm St" },
            new Customer{CustomerId = "C003", FirstName = "Coleman", LastName = "Johnson", Address = "789 Oak St" }};

        }
        public static void Main(string[] args)
        {
            //linq to search by customer id
            InititaliseData();
            //Get first name from CustomerList using linq where customer id is C001
            var customer = CustomerList.Where(c => c.CustomerId == "C001").FirstOrDefault();
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
