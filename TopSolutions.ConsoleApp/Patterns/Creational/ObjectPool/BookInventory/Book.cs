using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.ObjectPool.BookInventory
{
    public class Book
    {
        public string Title { get; set; }
        public string ISBN { get; private set; }
        public DateTime AcquisitionDate { get; private set; }
        public bool IsCheckedOut { get; set; }
        public Book()
        {
            ISBN = Guid.NewGuid().ToString();
            AcquisitionDate = DateTime.Now;
            Console.WriteLine($"Book {ISBN} created in memory");
        }
        public void ResetState()
        {
           Title = string.Empty;
           IsCheckedOut = false;
        }
    }
}
