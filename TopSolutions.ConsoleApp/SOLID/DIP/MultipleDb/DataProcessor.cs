using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.DIP.MultipleDb
{
    public class DataProcessor
    {
        private readonly IDataReader _reader;
        public DataProcessor(IDataReader reader)
        {
            _reader = reader;
        }
        public void ProcessAndDisplayData(string query)
        {
            Console.WriteLine("Displaying data");
            List<string> data = _reader.GetData(query);
            foreach(var item in data)
            {
                Console.WriteLine(item);
            }
        }
        public void StoreProcessedData(string data)
        {
            Console.WriteLine("\nStoring processed data:");
            _reader.SaveData(data);
        }
    }
}
