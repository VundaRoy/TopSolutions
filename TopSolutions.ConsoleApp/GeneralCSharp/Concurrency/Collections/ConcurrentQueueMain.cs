using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Concurrency.Collections
{
    public class ConcurrentQueueMain
    {
        static void Main()
        {
            TestQueue();
            Console.ReadKey();
        }
        public static void TestQueue()
        {
            var MobileOrders = new Queue<string>();
            GetOrders("Pranaya", MobileOrders);
            GetOrders("Anurag", MobileOrders);
            GetOrders("Srinivas", MobileOrders);
            GetOrders("Gokul Anand", MobileOrders);
            GetOrders("Vishwamitra", MobileOrders);
            foreach (var mobileOrder in MobileOrders)
            {
                Console.WriteLine($"Order: {mobileOrder}");
            }
        }
        private static void GetOrders(string custName, Queue<string> MobileOrders)
        {
            for (int i = 0; i < 2; i++)
            {
                Thread.Sleep(100);
                string order = string.Format($"{custName} Needs {i + 3} Mobiles");
                MobileOrders.Enqueue(order);
            }
        }
    }
}
