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
            //TestQueue();
            TestQueueAsync();
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
        public static void TestQueueAsync()
        {
            var MobileOrders = new Queue<string>();
            Task t1 = Task.Run(() => GetOrders("Pranaya", MobileOrders));
            Task t2 = Task.Run(() => GetOrders("Anurag", MobileOrders));
            Task t3 = Task.Run(() => GetOrders("Srinivas", MobileOrders));
            Task.WaitAll(t1, t2, t3); //Wait till all the tasks are completed

            foreach (var mobileOrder in MobileOrders)
            {
                Console.WriteLine($"Order: {mobileOrder}");
            }
        }
        private static void GetOrders(string custName, Queue<string> MobileOrders)
        {
            for (int i = 0; i < 100; i++)
            {
                //Thread.Sleep(100);
                string order = string.Format($"{custName} Needs {i + 3} Mobiles");
                MobileOrders.Enqueue(order);
            }
        }
    }
}
