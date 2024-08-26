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
            foreach (object key in hashtable) 
            { 
                Console.WriteLine(key.ToString() + " : " + hashtable["Name"]);
            }
            Console.WriteLine("Location : " + hashtable["Location"]);
            Console.WriteLine("\n Printing using keys ");
        }
    }
}
