using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.ISP.Library
{
    public class LibraryClient
    {
        public static void Main()
        {
            Console.WriteLine("Librarian:");
            Librarian librarian = new Librarian();
            Book book = new Book()
            {
                BookId = "BK-10001",
                Title = "SOLID Principle using C#",
                Author = "Pranaya Rout",
                ISBN = "ISBN-Demo"
            };
            librarian.AddBook(book);
            librarian.BorrowBook(book.BookId);
            librarian.SearchCatalog("SOLID");
            librarian.ReturnBook(book.BookId);
            librarian.RemoveBook(book.BookId);
            Console.WriteLine("\nMember:");
            Member member = new Member();
            //member.AddBook(book); //Compile Time Error
            member.BorrowBook(book.BookId);
            member.SearchCatalog("SOLID");
            member.ReturnBook(book.BookId);
            //member.RemoveBook(book.BookId); //Compile Time Error
            Console.WriteLine("\nMember:");
            Guest guest = new Guest();
            //guest.AddBook(book); //Compile Time Error
            //guest.BorrowBook(book.BookId); //Compile Time Error
            guest.SearchCatalog("SOLID");
            //guest.ReturnBook(book.BookId); //Compile Time Error
            //guest.RemoveBook(book.BookId); //Compile Time Error
            Console.ReadKey();
        }
    }
}
