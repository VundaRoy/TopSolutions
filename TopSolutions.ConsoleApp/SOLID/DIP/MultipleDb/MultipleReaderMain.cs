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

            Console.WriteLine("\n--- Using Ingres Server Data Reader ---");
            IDataReader ingresDataReader = new IngresDataReader();
            DataProcessor ingresServerDataProc = new(ingresDataReader);
            ingresServerDataProc.ProcessAndDisplayData("Select * from entityDb");
            ingresServerDataProc.StoreProcessedData("New entity from ingres db");

            Console.WriteLine("\n--- Using MongoDb Data Reader ---");
            IDataReader mongoDbDataReader = new MongoDbReader();
            DataProcessor mongoDbDataProc = new(mongoDbDataReader);
            mongoDbDataProc.ProcessAndDisplayData("Select * from mongoCollection");
            mongoDbDataProc.StoreProcessedData("New entity from mongo collection");
            //Call another mongo collection
            mongoDbDataProc.ProcessAndDisplayData("Select * from anotherMongoCollection");
            mongoDbDataProc.StoreProcessedData("New entity from another mongo collection");

        }
    }
}
