using Microsoft.Extensions.ObjectPool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.ObjectPool.BookInventory
{
    public class BookInventoryPoolManager
    {
        private readonly DefaultObjectPool<Book> _bookPool;
        public BookInventoryPoolManager()
        {
            var bookPoolPolicy = new BookPoolPolicy();
            _bookPool = new DefaultObjectPool<Book>(new BookPoolPolicy());
        }
        public Book AcquireBook()
        {
            Console.WriteLine("Acquiring a book from the pool...");
            return _bookPool.Get();
        }
        public void ReleaseBook(Book book)
        {
            Console.WriteLine($"Releasing a book {book.ISBN} back to the pool...");
            _bookPool.Return(book);
        }
    }
}
