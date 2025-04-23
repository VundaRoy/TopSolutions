using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.ISP.Library
{
    public interface IBorrowReturn
    {
        void BorrowBook(string bookId);
        void ReturnBook(string bookId);
    }
}
