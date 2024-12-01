using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.DIP.DatabaseSample
{
    public class DatabaseService : IDataService

    {
        public void Save(string message)
        {
            Console.WriteLine($"Save the message into the database. {message}");
        }
    }
}
