using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Iterator.Sample
{
    public class IteratorMain
    {
        static void Main()
        {
            // Build a collection
            ConcreteCollection collection = new ConcreteCollection();
            collection.AddEmployee(new Employee("Anurag", 100));
            collection.AddEmployee(new Employee("Pranaya", 101));
            collection.AddEmployee(new Employee("Santosh", 102));
            collection.AddEmployee(new Employee("Priyanka", 103));
            collection.AddEmployee(new Employee("Abinash", 104));
            collection.AddEmployee(new Employee("Preety", 105));
            collection.AddEmployee(new Employee("Srinivas", 106));
            collection.AddEmployee(new Employee("Yadav", 107));

            // Create iterator
            Iterator iterator = collection.CreateIterator();
            //looping iterator      
            Console.WriteLine("Iterating over collection:");

            for (Employee emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
            {
                Console.WriteLine($"ID : {emp.ID} & Name : {emp.Name}");
            }
            Console.Read();
        }
    }
}
