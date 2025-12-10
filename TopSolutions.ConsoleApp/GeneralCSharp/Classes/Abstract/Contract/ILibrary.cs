using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Classes.Abstract.Contract
{
    public interface ILibrary
    {
        //Basic library operations
        void AddBook(string title, string author);
        void RemoveBook(string title);
        void LendBook(string title, string borrower);
        void ReturnBook(string title);
        //Library information
        List<string> GetAvailableBooks();
    }
}
