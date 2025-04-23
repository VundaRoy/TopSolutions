using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.Patterns.Creational.Factory.Simple;

namespace TopSolutions.ConsoleApp.SOLID.ISP.Library
{
    public interface IManageInventory
    {
        void AddBook(Book book);
        void RemoveBook(string bookId);
    }
}
