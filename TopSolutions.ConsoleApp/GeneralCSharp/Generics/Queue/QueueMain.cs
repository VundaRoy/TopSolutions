using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Generics.Queue
{
    public class QueueMain
    {
        static void Main(string[] args)
        {
            //Creating a Queue to Store Integer Values
            Queue<int> queue = new Queue<int>();
            //Adding Elements to the Queue using Enqueue Method
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            //Adding Duplicate
            queue.Enqueue(30);
            //queue.Enqueue(null);
            //Accesing all the Elements of the Queue using For Each Loop
            Console.WriteLine("Generic Queue Elements");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            // Removing and Returning an Element from the Begining of the Stack using Dequeue method
            Console.WriteLine($"\nDeleted Element: {queue.Dequeue()}");
            Console.WriteLine($"\nDeleted Element: {queue.Dequeue()}");
            //Printing Elements After Removing the First Added Element
            Console.WriteLine($"\nAll Queue Elements After Deletion: Count {queue.Count}");
            foreach (var element in queue)
            {
                Console.WriteLine($"{element} ");
            }
            //Removing All Elements from Queue using Clear Method
            queue.Clear();
            Console.WriteLine($"\nAll Queue Elements Counts After Clear: Count {queue.Count}");
            Console.ReadKey();
        }
    }
}
