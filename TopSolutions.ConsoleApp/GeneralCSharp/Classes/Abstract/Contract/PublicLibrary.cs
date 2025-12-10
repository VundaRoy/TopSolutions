using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Classes.Abstract.Contract
{
    public abstract class PublicLibrary : ILibrary
    {
        //Implementing ILibrary methods
        public void AddBook(string title, string author)
        {
            Console.WriteLine($"Adding book: {title} by {author}");
        }
        public void RemoveBook(string title)
        {
            Console.WriteLine($"Removing book: {title}");
        }
        public void LendBook(string title, string borrower)
        {
            Console.WriteLine($"Lending book: {title} to {borrower}");
        }
        public void ReturnBook(string title)
        {
            Console.WriteLine($"Returning book: {title}");
        }
        public List<string> GetAvailableBooks()
        {
            Console.WriteLine("Fetching available books...");
            return new List<string> { "PublicBook1", "PublicBook2", "PublicBook3" };
        }

        public abstract void OrganizeCommunityEvent(string eventName);
    }
}
