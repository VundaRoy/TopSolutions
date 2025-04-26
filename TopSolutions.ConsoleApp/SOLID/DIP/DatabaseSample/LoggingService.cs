using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.DIP.DatabaseSample
{
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
