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

        public Logger(IDataService dataService)
        {
            _dataService = dataService;
        }

        public void Log(string message)
        {
            _dataService.Save(message);
        }
        public void RollbackTransaction(string transId)
        {
            _dataService.RollBack(transId);
        }
    }
}
