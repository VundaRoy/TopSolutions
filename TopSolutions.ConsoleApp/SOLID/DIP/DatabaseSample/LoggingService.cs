using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.DIP.DatabaseSample
{
    // This is a concrete implementation of the ILoggingService interface, providing specific functionality for logging messages and archiving logs
    public class LoggingService : ILoggingService  
    {
        public void ArchiveSeriLog()
        {
            Console.WriteLine($"Archiving started at {DateTime.Now} - Have a nice day :)");
        }

        public void WriteToSeriLog(string message)
        {
            Console.WriteLine(message);
        }
    }
}
