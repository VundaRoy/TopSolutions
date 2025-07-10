using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Concurrency.Threads
{
    public class ThreadMain
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i< 10; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(MyMethod));
            }
            Console.Read();
        }
        public static void MyMethod(object obj)
        {
            Thread thread = Thread.CurrentThread;
            string message = $"Background: {thread.IsBackground}, Thread Pool: {thread.IsThreadPoolThread}," +
                $"Thread ID: {thread.ManagedThreadId}";
            Console.WriteLine(message);
        }
    }
}
