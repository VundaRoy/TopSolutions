using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.DIP.DatabaseSample
{
    public interface ILoggingService  // This is the abstraction that defines the contract for logging services, allowing for different implementations without changing the dependent code
    {
        void WriteToSeriLog(string message);
        void ArchiveSeriLog();
    }
}
