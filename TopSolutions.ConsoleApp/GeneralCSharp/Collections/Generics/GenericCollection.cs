using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Collections.Generics
{
    public class GenericCollection
    {
        //Genric List Example
        public void GenericListExample()
        {
            List<int> intList = new List<int>();
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            intList.Add(4);
            intList.Add(5);
            Console.WriteLine("Generic List Example:");
            foreach (var item in intList)
            {
                Console.WriteLine(item);
            }
        }
        //Generic Dictionary Example    
        public void GenericDictionaryExample()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("One", 1);
            dict.Add("Two", 2);
            dict.Add("Three", 3);
            dict.Add("Four", 4);
            dict.Add("Five", 5);
            Console.WriteLine("Generic Dictionary Example:");
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
        //Generic Queue Example
        public void GenericQueueExample()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            Console.WriteLine("Generic Queue Example:");
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
        //Generic T List Example
        public void GenericTListExample<T>(List<T> items)
        {
            Console.WriteLine("Generic T List Example:");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
        public void GenericTQueueExample<T>(Queue<T> items)
        {
            Console.WriteLine("Generic T Queue Example:");
            while (items.Count > 0)
            {
                Console.WriteLine(items.Dequeue());
            }
        }
        public Queue<T> GenericTCreateQueueExample<T>(T[] items)
        {
            Queue<T> queue = new Queue<T>();
            foreach (var item in items)
            {
                queue.Enqueue(item);
            }
            Console.WriteLine("Generic T Create Queue Example:");
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
            return queue;
        }
    }
}
