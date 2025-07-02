using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.DIP.MultipleDb
{
    public class MultipleReaderMain
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--- Using SQL Server Data Reader ---");
            IDataReader ibmServerReader = new IbmDataReader();
            DataProcessor ibmDataProcessor = new(ibmServerReader);
            ibmDataProcessor.ProcessAndDisplayData("SELECT * FROM Customers");
            ibmDataProcessor.StoreProcessedData("New Customer Record");

            Console.WriteLine("\n--- Using MySQL Data Reader ---");
            IDataReader mySqlReader = new MySqlDataReader();
            DataProcessor mySqlDataProcessor = new(mySqlReader);
            mySqlDataProcessor.ProcessAndDisplayData("SELECT * FROM Orders");
            mySqlDataProcessor.StoreProcessedData("New Order Details");

            Console.WriteLine("\n--- Using MS SQL Server Data Reader ---");
            IDataReader sqlDataReader = new SqlServerDataReader();
            DataProcessor sqlServerDataProc = new(sqlDataReader);
            sqlServerDataProc.ProcessAndDisplayData("SELECT * from allOrds");
            sqlServerDataProc.StoreProcessedData("New SQL server selection from all Ords");
        }
    }
}
