using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Singleton.Practical
{
    internal class PracticalSingletonMain
    {
        public static void Main()
        {
            Console.WriteLine("Practical Singleton Pattern Demo");
            var onceOff1 = OnceOffCall.Instance;
            var onceOff2 = OnceOffCall.Instance;
            //get call status
            Console.WriteLine(onceOff1.CallStatus);
            Console.WriteLine($"Are both OnceOffCall instances the same? {ReferenceEquals(onceOff1, onceOff2)}");
            // Additional practical singleton usage can be demonstrated here
            //call ExecuteOnce again
            onceOff1.ExecuteOnce(); // This will work
            //onceOff2.ExecuteOnce(); // This will throw an exception
            //get call status
                        Console.WriteLine(onceOff1.CallStatus);
            Console.WriteLine("End of Practical Singleton Pattern Demo");
        }
    }
}
