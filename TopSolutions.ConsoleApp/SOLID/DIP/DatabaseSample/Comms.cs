using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.DIP.DatabaseSample
{
    public class Comms
    {
        private readonly IDataService _dataService;
        public Comms(IDataService dataService)
        {
            _dataService = dataService;    
        }
        public void SendComms(string message)
        {
            _dataService.Save(message);
        }
    }
}
