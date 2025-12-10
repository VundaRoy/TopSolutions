using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Classes.Abstract.Contract
{
    public abstract class UniversityLibrary : ILibrary
    {
        public void AddBook(string title, string author)
        {
            Console.WriteLine($"Adding book: {title} by {author}");
        }

        public List<string> GetAvailableBooks()
        {
            Console.WriteLine("Fetching available books...");
            return new List<string> { "Book1", "Book2", "Book3" };  
        }

        public void LendBook(string title, string borrower)
        {
            Console.WriteLine($"Lending book: {title} to {borrower}");
        }

        public void RemoveBook(string title)
        {
            Console.WriteLine($"Removing book: {title}");
        }

        public void ReturnBook(string title)
        {
            Console.WriteLine($"Returning book: {title}");
        }
        public abstract void ConductResearch(string topic);
        public abstract void CheckStudentEligibility(string studentName);   
    }
}
