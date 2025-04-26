using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.DIP.DatabaseSample
{
    public class Logger
    {
        private readonly IDataService _dataService;
        private readonly ILoggingService _loggingService;

        public Logger(IDataService dataService, ILoggingService loggingService)
        {
            _dataService = dataService;
            _loggingService = loggingService;
        }

        public void Log(string message)
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
