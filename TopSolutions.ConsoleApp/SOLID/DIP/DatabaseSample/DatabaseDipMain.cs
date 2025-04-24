using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.DIP.DatabaseSample
{
    public class DatabaseDipMain
    {
        public static void Main(string[] args)
        {
            var logger = new Logger(new DatabaseService(), new LoggingService());            
            logger.Log("Hello, no errors");
            logger.WriteToLog("Logged at " + DateTime.Now);
            var comms = new Comms(new  DatabaseService());
            comms.SendComms("Welcome to the channel");
            logger.RollbackTransaction("1123");
            comms.UnSendMessage("Theo was right");
        }
    }
}
