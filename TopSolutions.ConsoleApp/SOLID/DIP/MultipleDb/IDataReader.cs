using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.DIP.MultipleDb
{
    public interface IDataReader
    {
        List<string> GetData(string query);
        void SaveData(string data);
    }
}
