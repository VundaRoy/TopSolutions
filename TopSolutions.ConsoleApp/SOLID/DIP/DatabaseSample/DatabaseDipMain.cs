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
            DatabaseDipMain dipMain = new();

            //factory method to create logger instance, this is the only place where we create the logger and we can easily change the implementation
            //of the logger without affecting the rest of the code

            var logger = dipMain.CreateLogger();
            logger.Log("Hello, no errors");
            logger.WriteToLog("Logged at " + DateTime.Now);
            logger.ArchiveLogs();
            logger.RollbackTransaction("myId12");
            dipMain.SendComms("This is a message to send");
            dipMain.UnSendComms("This is a message to unsend");
        }
        //Create new logger instance
        public Logger CreateLogger()
        {
            return new Logger(new DatabaseService(), new LoggingService());
        }
        public void SendComms(string message)
        {
            var comms = new Comms(new DatabaseService());
            comms.SendComms(message);
        }
        public void UnSendComms(string message)
        {
            var comms = new Comms(new DatabaseService());
            comms.UnSendMessage(message);
        }
        public void WriteToLog(string message)
        {
            var logger = new Logger(new DatabaseService(), new LoggingService());
            logger.WriteToLog(message);
        }
    }
}
