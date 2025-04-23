using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.ISP.Library
{
    public class Guest
    {
        public void SearchCatalog(string searchTerm)
        {
            // Implementation to search books.
            Console.WriteLine($"Guest Search Book, Search Catalog: {searchTerm}");
        }
    }
}
