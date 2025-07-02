using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.DIP.MultipleDb
{
    public class IbmDataReader : IDataReader
    {
       public List<string> GetData(string query)
        {
            Console.WriteLine($"Retrieving data from IBM DB2 with query: {query}");
            return new List<string> { "IBM data 1", "IBM data 2" };
        }
        public void SaveData(string data)
        {
            Console.WriteLine($"Saving {data} to IBM db2 server");
        }
    }
}
