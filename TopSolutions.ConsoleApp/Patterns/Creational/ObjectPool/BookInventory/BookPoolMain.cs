using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.ObjectPool.BookInventory
{
    public class BookPoolMain
    {
        public static void Main()
        {
            var bookPoolManager = new BookInventoryPoolManager();
            // Acquire a book from the pool
            Book book1 = bookPoolManager.AcquireBook();
            book1.Title = "Design Patterns in C#";
            book1.IsCheckedOut = true;
            Console.WriteLine($"Book 1 - ISBN: {book1.ISBN}, Title: {book1.Title}, Checked Out: {book1.IsCheckedOut}");
            // Release the book back to the pool
            bookPoolManager.ReleaseBook(book1);
            // Acquire another book from the pool
            Book book2 = bookPoolManager.AcquireBook();
            Console.WriteLine($"Book 2 - ISBN: {book2.ISBN}, Title: {book2.Title}, Checked Out: {book2.IsCheckedOut}");
        }
    }
}
