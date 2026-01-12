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
            
            //CreateBook example
            Book book3 = new BookPoolMain().CreateBook(bookPoolManager, "Clean Code");
            Console.WriteLine($"Book 3 - ISBN: {book3.ISBN}, Title: {book3.Title}, Checked Out: {book3.IsCheckedOut}");
            //Checkout status change example
            new BookPoolMain().ChangeBookStatus(book3, true);
            Console.WriteLine($"Book 3 - ISBN: {book3.ISBN}, Title: {book3.Title}, Checked Out: {book3.IsCheckedOut}");
            //ReturnBook example
            new BookPoolMain().ReturnBook(bookPoolManager, book3);
            

        }
        public Book CreateBook(BookInventoryPoolManager poolManager, string bookTitle)
        {
            var book = poolManager.AcquireBook();
            // Initialize book properties as needed
            book.Title = bookTitle;
            return book;
        }
        public void ReturnBook(BookInventoryPoolManager poolManager, Book book)
        {
            // Reset book state if necessary
            book.ResetState();
            poolManager.ReleaseBook(book);
        }
        public void ChangeBookStatus(Book book, bool isCheckedOut)
        {
            book.IsCheckedOut = isCheckedOut;
        }
        public void DisplayBookInfo(Book book)
        {
            Console.WriteLine($"Book - ISBN: {book.ISBN}, Title: {book.Title}, Checked Out: {book.IsCheckedOut}");
        }
    }
}
