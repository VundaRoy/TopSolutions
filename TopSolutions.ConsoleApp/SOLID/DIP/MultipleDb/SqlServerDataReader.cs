using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.DIP.MultipleDb
{
    public class SqlServerDataReader : IDataReader
    {
        public List<string> GetData(string query)
        {
            Console.WriteLine($"Retrieving data from SQL Server with query: {query}");
            return new List<string> { "MS SQL Item A", "MS SQL Item B" };
        }

        public void SaveData(string data)
        {
            Console.WriteLine($"Saving '{data}' to SQL Server.");
        }
    }
}
