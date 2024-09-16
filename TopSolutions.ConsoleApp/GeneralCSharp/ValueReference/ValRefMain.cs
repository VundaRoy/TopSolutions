using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.ValueReference
{
    public class ValRefMain
    {
        static void Main(string[] args)
        {
            int aNumber = 18;
            UpdateNumber(aNumber);
            Console.WriteLine("Value is " + aNumber);
            //Example with reference
            Person person = new()
            {
                PersonId = 1001,
                Name = "Golding"
            };
            Person person2 = person;
            person.Name = "Chandler";
            Console.WriteLine($"Person is {person.Name}");
            Console.WriteLine($"Person2 is {person2.Name}");
            //Using method to update name
            UpdatePersonWithTitle( person );
            Console.WriteLine($"After title update person is {person.Name}");

        }
        static void UpdateNumber(int aNumber) 
        {
          aNumber = aNumber + 10;
        }
        static void UpdatePersonWithTitle(Person person) 
        { 
            person.Name = "Mr " + person.Name;
           // Console.WriteLine($"Person is now called {person.Name}");
        }
    }
}
