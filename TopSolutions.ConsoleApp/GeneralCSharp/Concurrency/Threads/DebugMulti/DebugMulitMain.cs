using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Concurrency.Threads.DebugMulti
{
    public class DebugMulitMain
    {
        //Debug multi thread example
        public static void Main()
        {
            Thread thread1 = new (SomeMethod);
            Thread thread2 = new (AnotherMethod);
            Thread thread3 = new (SomeMethod);
            thread1.Start();
            thread2.Start();
            thread3.Start();
            Console.ReadKey();
        }
        public static void SomeMethod()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"SomeMethod Count: {i}");
            }
        }
        public static void AnotherMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"AnotherMethod Count: {i}");
            }
        }
    }
}
