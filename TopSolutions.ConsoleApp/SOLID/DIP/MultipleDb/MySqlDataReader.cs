using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.DIP.MultipleDb
{
    public class MySqlDataReader : IDataReader
    {
        public List<string> GetData(string query)
        {
            Console.WriteLine($"Retrieving data from MySQL with query: {query}");
            return new List<string> { "MySQL Item X", "MySQL Item Y" };
        }

        public void SaveData(string data)
        {
            Console.WriteLine($"Saving '{data}' to MySQL.");
        }
    }
}
