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
            //Update customer address using linq where last name is Johnson
            UpdateCustomerAddress(CustomerList, "C003", "999 New Address St");
            //Insert new customer into CustomerList
            InsertIntoList(CustomerList, new Customer { CustomerId = "C007", FirstName = "David", LastName = "Johnson", Address = "404 Cedar St" });
            //show all customers in CustomerList
            Console.WriteLine("All customers in the list:");
            ShowAllCustomers(CustomerList);

        }

        public static void UpdateCustomerAddress(List<Customer> customerList, string customerId, string newAddress)
        {
            var customer = customerList.FirstOrDefault(c => c.CustomerId == customerId);
            if (customer != null)
            {
                customer.Address = newAddress;
                Console.WriteLine($"Customer address updated: {customer.FirstName} {customer.LastName}, New Address: {customer.Address}");
            }
            else
            {
                Console.WriteLine("Customer not found.");
            }
        }

        public static void InsertIntoList(List<Customer> customerList, Customer customer)
        {
            customerList.Add(customer);
        }
        public static void ShowAllCustomers(List<Customer> customerList)
        {
            foreach (var customer in customerList)
            {
                Console.WriteLine($"CustomerId: {customer.CustomerId}, Name: {customer.FirstName} {customer.LastName}, Address: {customer.Address}");
            }
        }
    }
}
