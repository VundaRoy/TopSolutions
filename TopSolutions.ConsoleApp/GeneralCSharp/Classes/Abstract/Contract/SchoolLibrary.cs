using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Classes.Abstract.Contract
{
    public abstract class SchoolLibrary : ILibrary
    {
       
        public abstract void AddBook(string title, string author);
        public abstract void LendBook(string title, string borrower);
        public abstract List<string> GetAvailableBooks();
        // Additional methods specific to school libraries can be added here
        public abstract void RegisterStudent(string studentName);
        public abstract void UnregisterStudent(string studentName);

        public void RemoveBook(string title)
        {
            Console.WriteLine($"Removing book: {title}");
        }

        public void ReturnBook(string title)
        {
            Console.WriteLine($"Returning book: {title}");
        }
    }
}
