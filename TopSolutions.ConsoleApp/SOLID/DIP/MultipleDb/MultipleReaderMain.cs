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
            DemonstrateMultipleDataReaders();
        }
        //Declare a method to demonstrate the use of multiple data readers
        public static void DemonstrateMultipleDataReaders()
        {
            Console.WriteLine("--- Demonstrating Multiple Data Readers ---");
            IDataReader ibmServerReader = new IbmDataReader();
            DataProcessor ibmDataProcessor = new(ibmServerReader);
            ibmDataProcessor.ProcessAndDisplayData("SELECT * FROM Customers");
            ibmDataProcessor.StoreProcessedData("New Customer Record");
            IDataReader mySqlReader = new MySqlDataReader();
            DataProcessor mySqlDataProcessor = new(mySqlReader);
            mySqlDataProcessor.ProcessAndDisplayData("SELECT * FROM Orders");
            mySqlDataProcessor.StoreProcessedData("New Order Details");
            IDataReader sqlDataReader = new SqlServerDataReader();
            DataProcessor sqlServerDataProc = new(sqlDataReader);
            sqlServerDataProc.ProcessAndDisplayData("SELECT * from allOrds");
            sqlServerDataProc.StoreProcessedData("New SQL server selection from all Ords");
            IDataReader ingresDataReader = new IngresDataReader();
            DataProcessor ingresServerDataProc = new(ingresDataReader);
            ingresServerDataProc.ProcessAndDisplayData("Select * from entityDb");
            ingresServerDataProc.StoreProcessedData("New entity from ingres db");
            IDataReader mongoDbDataReader = new MongoDbReader();
            DataProcessor mongoDbDataProc = new(mongoDbDataReader);
            mongoDbDataProc.ProcessAndDisplayData("Select * from mongoCollection");
            mongoDbDataProc.StoreProcessedData("New entity from mongo collection");
        }
    }
}
