using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.DIP.MultipleDb
{
    public class IngresDataReader : IDataReader
    {
        public List<string> GetData(string query)
        {
            Console.WriteLine($"Retrieving data from Ingres with query: {query}");
            return new List<string> { "Ingres Item A", "Ingres Item B" };
        }

        public void SaveData(string data)
        {
            Console.WriteLine($"Saving '{data}' to Ingres Server.");
        }
    }
}
