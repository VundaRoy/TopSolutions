using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.ISP.Library
{
    public interface ISearchable
    {
        void SearchCatalog(string searchTerm);
    }
}
