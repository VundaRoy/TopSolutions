using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Classes.Abstract.Contract
{
    public class LibraryMain
    {
        public static void Main()
        {
            ILibrary universityLibrary = new FisherLibrary();
            universityLibrary.AddBook("C# Programming", "John Doe");
            universityLibrary.LendBook("C# Programming", "Alice");
            List<string> availableBooks = universityLibrary.GetAvailableBooks();
            Console.WriteLine("Available Books in University Library:");
            foreach (var book in availableBooks)
            {
                Console.WriteLine(book);
            }
            ILibrary publicLibrary = new NewtownLibrary();
            publicLibrary.AddBook("Introduction to the world of mary janes", "Jane Smith");
            publicLibrary.LendBook("Introduction to Algorithms", "Bob");
            List<string> publicAvailableBooks = publicLibrary.GetAvailableBooks();
            Console.WriteLine("Available Books in Public Library:");
            foreach (var book in publicAvailableBooks)
            {
                Console.WriteLine(book);
            }
        }   
    }
}
