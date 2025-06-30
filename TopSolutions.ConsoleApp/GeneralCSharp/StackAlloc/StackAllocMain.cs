using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.StackAlloc
{
    public class StackAllocMain
    {
        public static void Main(string[] args)
        {
            unsafe
            {
                int* ptr = stackalloc int[11];
                for(int i = 0; i < 11; i++)
                {
                    ptr[i] = i + 1;
                }
                for (int i = 0; i < 11; i++) 
                { 
                    Console.WriteLine(ptr[i]);  
                }
            }
            Console.ReadKey();
        }
    }
}
