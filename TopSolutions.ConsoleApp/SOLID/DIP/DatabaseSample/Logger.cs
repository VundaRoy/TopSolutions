using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.DIP.DatabaseSample
{
    // The Logger class depends on the IDataService abstraction, allowing for flexibility in how data is saved without changing the Logger class
    public class Logger
    {
        // _dataService is an abstraction that allows the Logger class to use data saving functionality without being tightly coupled to a specific implementation,
        // adhering to the Dependency Inversion Principle
        private readonly IDataService _dataService; 
        // _loggingService is an abstraction that allows the Logger class to use logging functionality without being tightly coupled to
        // a specific implementation, adhering to the Dependency Inversion Principle
        private readonly ILoggingService _loggingService; 

        // The Logger class depends on the abstractions (IDataService and ILoggingService) rather than concrete implementations, adhering to the Dependency Inversion Principle
        public Logger(IDataService dataService, ILoggingService loggingService) 
        {
            _dataService = dataService;
            _loggingService = loggingService;
        }

        public void Log(string message)  // This method uses the IDataService abstraction to save the message, allowing for flexibility in how the data is stored without changing the Logger class
        {
            _dataService.Save(message);
        }
        public void RollbackTransaction(string transId)
        {
            _dataService.RollBack(transId);
        }
        public void WriteToLog(string message)
        {
            _loggingService.WriteToSeriLog(message);
        }
        public void ArchiveLogs()
        {
            _loggingService.ArchiveSeriLog();
        }
    }
}
