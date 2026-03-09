using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.DIP.DatabaseSample
{
    public interface IDataService // This is the abstraction that defines the contract for data services, allowing for different implementations without changing the dependent code
    {
        public void Save(string message);
        public void RollBack(string message);
    }
}
