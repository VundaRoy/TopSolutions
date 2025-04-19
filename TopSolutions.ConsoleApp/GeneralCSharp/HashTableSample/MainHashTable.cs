using System.Collections;
using System;

namespace TopSolutions.ConsoleApp.GeneralCSharp.HashTableSample
{
    public class MainHashTable
    {
        Hashtable hashtable;
        static Hashtable altHash;
        public MainHashTable()
        {
            hashtable = new Hashtable();
        }
        
        static void Main(string[] args)
        {
            MainHashTable mainHashTable = new MainHashTable();
            //Hashtable hashtable = new Hashtable();
            DoHash(ref mainHashTable);
            Console.WriteLine("\n Printing using keys ");
            //without using Add method
            altHash = new()
            {
                {1, "Towoomba" },
                {2, "Windhoek" },
                {3, "Walvis Bay" },
                {4, "Cape Town" },
                {5, "Longreach" },
                {14, "Cabo Verde" },
                {113, "Barcaldine" },
                {1117, "Emerald" }
            };
            foreach (var element in altHash.Keys)
            {
                Console.WriteLine("{0} is the city of {1}", element, altHash[element]);
            }

        }

        private static void DoHash(ref MainHashTable mainHashTable)
        {
            mainHashTable.hashtable.Add("UserId", 1001);
            mainHashTable.hashtable.Add("Name", "Teriko");
            mainHashTable.hashtable.Add("Salary", 28000);
            mainHashTable.hashtable.Add("Location", "Samabula");
            mainHashTable.hashtable.Add("Email", "aga@tel.com.fj");
            Console.WriteLine("Printing list");
            foreach (DictionaryEntry key in mainHashTable.hashtable)
            {
                Console.WriteLine(key.Key + " : " + key.Value);
            }
            Console.WriteLine("Location : " + mainHashTable.hashtable["Location"]);
        }
    }
}
