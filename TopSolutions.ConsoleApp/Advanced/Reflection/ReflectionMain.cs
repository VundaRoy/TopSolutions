using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.Advanced.Reflection
{
    internal class ReflectionMain
    {
        public static void Main(string[] args)
        {
            // Get the type of the Customer class
            Type customerType = typeof(Customer);
            // Get the properties of the Customer class
            var properties = customerType.GetProperties();
            Console.WriteLine("Properties of Customer class:");
            foreach (var property in properties)
            {
                Console.WriteLine($"- {property.Name} ({property.PropertyType.Name})");
            }
            // Create an instance of the Customer class using reflection
            var customerInstance = Activator.CreateInstance(customerType);
            // Set property values using reflection
            customerType.GetProperty("CustomerId")?.SetValue(customerInstance, "C007");
            customerType.GetProperty("FirstName")?.SetValue(customerInstance, "David");
            customerType.GetProperty("LastName")?.SetValue(customerInstance, "Miller");
            customerType.GetProperty("Address")?.SetValue(customerInstance, "404 Cedar St");
            customerType.GetProperty("NumberOfOrders")?.SetValue(customerInstance, 7);
            customerType.GetProperty("TotalCharged")?.SetValue(customerInstance, 350.75m);
            // Get property values using reflection
            Console.WriteLine("\nCustomer instance created using reflection:");
            foreach (var property in properties)
            {
                var value = property.GetValue(customerInstance);
                Console.WriteLine($"- {property.Name}: {value}");
            }
        }
    }
}
