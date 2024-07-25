using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.Samples.Misc.Variance.Model;

namespace TopSolutions.ConsoleApp.Samples.Misc.Variance.Contracts
{
    public interface IExecute
    {
        void Render();
       
        void PrintList(IEnumerable<User> entity);
    }
}
