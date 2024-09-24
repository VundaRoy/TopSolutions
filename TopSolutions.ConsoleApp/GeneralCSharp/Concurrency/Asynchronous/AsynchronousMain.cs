using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Concurrency.Asynchronous
{
    public class AsynchronousMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Started......");
            SomeMethod();
            Console.WriteLine("Main Method End");
            Console.ReadKey();
        }
        public async static void SomeMethod()
        {
            Console.WriteLine("Some Method Started......");
            //Thread.Sleep(TimeSpan.FromSeconds(10));
            await Task.Delay(TimeSpan.FromSeconds(3));
            Console.WriteLine("\n");
            Console.WriteLine("Some Method End");
            ConcludedMethod();
        }
        public async static void ConcludedMethod()
        {
            Console.WriteLine("Conclusion Started......");
            //Thread.Sleep(TimeSpan.FromSeconds(10));
            await Task.Delay(TimeSpan.FromSeconds(2));
            Console.WriteLine("\n");
            Console.WriteLine("Conclusive End");
        }
    }
}
