using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.DIP.MultipleDb
{
    public class MongoDbReader : IDataReader
    {
        public List<string> GetData(string query)
        {
            Console.WriteLine($"Retrieving data from MongoDB with query: {query}");
            return new List<string> { "MongoDB Item 1", "MongoDB Item 2" };
        }
        public void SaveData(string data)
        {
            Console.WriteLine($"Saving '{data}' to MongoDB.");
        }
    }
}
