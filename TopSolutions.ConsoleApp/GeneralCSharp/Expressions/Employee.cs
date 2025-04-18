using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Expressions
{
    public class Employee
    {
        private string FirstName;
        private string LastName;
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string GetFullName() =>  $"{FirstName} {LastName}";
        public void DisplayName() => Console.WriteLine($"Full name is {GetFullName()}");

        public int GetLastNameLength() => LastName.Length;
        public int GetFirstNameLength() => FirstName.Length;

    }
}
