using System.Collections;
using System;

namespace TopSolutions.ConsoleApp.GeneralCSharp.HashTableSample
{
    public class MainHashTable
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("UserId", 1001);
            hashtable.Add("Name", "Teriko");
            hashtable.Add("Salary", 28000);
            hashtable.Add("Location", "Samabula");
            hashtable.Add("Email", "aga@tel.com.fj");
            Console.WriteLine("Printing list");
            foreach (DictionaryEntry key in hashtable) 
            { 
                Console.WriteLine(key.Key + " : " + key.Value);
            }
            Console.WriteLine("Location : " + hashtable["Location"]);
            Console.WriteLine("\n Printing using keys ");
            //without using Add method
            Hashtable altHash = new()
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
    }
}
