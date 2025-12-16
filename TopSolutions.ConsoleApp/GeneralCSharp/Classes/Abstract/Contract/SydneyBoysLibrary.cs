using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Classes.Abstract.Contract
{
    public class SydneyBoysLibrary : SchoolLibrary
    {
        public override void AddBook(string title, string author)
        {
            Console.WriteLine($"Adding book: {title} by {author} to Sydney Boys Library");
        }

        public override List<string> GetAvailableBooks()
        {
            //Create list of available books
            List<string> availableBooks = new List<string>
            {
                "The Great Gatsby by F. Scott Fitzgerald",
                "To Kill a Mockingbird by Harper Lee",
                "1984 by George Orwell"
            };
            Console.WriteLine("Getting available");
            return availableBooks;

        }

        public override void LendBook(string title, string borrower)
        {
            Console.WriteLine($"Lending book: {title} to {borrower} from Sydney Boys Library"); 
        }

        public override void RegisterStudent(string studentName)
        {
            Console.WriteLine($"Registering student: {studentName} to Sydney Boys Library");
        }

        public override void UnregisterStudent(string studentName)
        {
            Console.WriteLine($"Unregistering student: {studentName} from Sydney Boys Library");
        }
    }
}
