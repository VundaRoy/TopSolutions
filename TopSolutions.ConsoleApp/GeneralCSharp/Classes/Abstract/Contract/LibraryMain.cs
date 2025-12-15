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
            CreateUniversityLibraryWithParam(universityLibrary);
            ILibrary publicLibrary = new NewtownLibrary();
            CreatePublicLibraryWithParam(publicLibrary);
            CreatePublicLibrary();
            universityLibrary = CreateUniversityLibrary();
        }

        private static void CreatePublicLibraryWithParam(ILibrary publicLibrary)
        {
            publicLibrary.AddBook("Introduction to the world of mary janes", "Jane Smith");
            publicLibrary.LendBook("Introduction to Algorithms", "Bob");
            List<string> publicAvailableBooks = publicLibrary.GetAvailableBooks();
            Console.WriteLine("Available Books in Public Library:");
            foreach (var book in publicAvailableBooks)
            {
                Console.WriteLine(book);
            }
        }

        private static void CreateUniversityLibraryWithParam(ILibrary universityLibrary)
        {
            universityLibrary.AddBook("C# Programming", "John Doe");
            universityLibrary.LendBook("C# Programming", "Alice");
            List<string> availableBooks = universityLibrary.GetAvailableBooks();
            Console.WriteLine("Available Books in University Library:");
            foreach (var book in availableBooks)
            {
                Console.WriteLine(book);
            }
        }

        private static ILibrary CreateUniversityLibrary()
        {
            //do UTS Library instance
            ILibrary universityLibrary = new UniversityOfTechnologySydneyLibrary();
            universityLibrary.AddBook("Advanced C# Programming", "David Brown");
            universityLibrary.LendBook("Advanced C# Programming", "Frank");
            List<string> utsAvailableBooks = universityLibrary.GetAvailableBooks();
            Console.WriteLine("Available Books in UTS Library:");
            foreach (var book in utsAvailableBooks)
            {
                Console.WriteLine(book);

            }

            return universityLibrary;
        }

        private static void CreatePublicLibrary()
        {
            //MarrickvilleLibrary instance
            PublicLibrary marrickvilleLibrary = new MarrickvilleLibrary();
            marrickvilleLibrary.AddBook("Learning C#", "Chris Johnson");
            marrickvilleLibrary.OrganizeCommunityEvent("Book Reading Session");
            marrickvilleLibrary.LendBook("Learning C#", "Eve");
            marrickvilleLibrary.ReturnBook("Learning C#");
            List<string> marrickvilleAvailableBooks = marrickvilleLibrary.GetAvailableBooks();
            Console.WriteLine("Available Books in Marrickville Library:");
        }
    }
}
