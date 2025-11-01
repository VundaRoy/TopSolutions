using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Generics.Collections
{
    public class CollectionsGenericMain
    {
        
        //Collections examples with generics
        public static void Main()
        {
            CollectionsGenericMain collectionExtensions = new();
            var stackOfInt = collectionExtensions.CreateGenericStack<int>();
            var stackOfString = collectionExtensions.CreateGenericStack<string>();
            
            collectionExtensions.PushToStack(stackOfInt, 10);
            collectionExtensions.PushToStack(stackOfInt, 20);
            collectionExtensions.PushToStackString(stackOfString, "Hello");
            collectionExtensions.PushToStackString(stackOfString, "World");
            collectionExtensions.PopFromStack(stackOfInt);
            collectionExtensions.ShowStackCount(stackOfInt);
            //using generic methods
            collectionExtensions.PushToStackGeneric(stackOfInt, 30);
            collectionExtensions.PopFromStackGeneric(stackOfInt);
            collectionExtensions.ShowStackCount(stackOfInt);
        }
        //Generic Stack Example
        public void GenericStackExample()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine("Stack contents:");
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
        //Create generic stack
        public Stack<T> CreateGenericStack<T>()
        {
            return new Stack<T>();
        }
        public void PushToStack(Stack<int> stack, int item)
        {
            stack.Push(item);
            Console.WriteLine($"Pushed item: {item}");
        }
        public void PushToStackGeneric<T>(Stack<T> stack, T item)
        {
            stack.Push(item);
            Console.WriteLine($"Pushed item: {item}");
        }
        public void PopFromStackGeneric<T>(Stack<T> stack)
        {
            if (stack.Count > 0)
            {
                T item = stack.Pop();
                Console.WriteLine($"Popped item: {item}");
            }
            else
            {
                Console.WriteLine("Stack is empty.");
            }
        }
        public void PushToStackString(Stack<string> stack, string item)
        {
            stack.Push(item);
            Console.WriteLine($"Pushed item: {item}");
        }
        public void PopFromStack(Stack<int> stack)
        {
            if (stack.Count > 0)
            {
                int item = stack.Pop();
                Console.WriteLine($"Popped item: {item}");
            }
            else
            {
                Console.WriteLine("Stack is empty.");
            }
        }
        public void PopFromStackString(Stack<string> stack)
        {
            if (stack.Count > 0)
            {
                string item = stack.Pop();
                Console.WriteLine($"Popped item: {item}");
            }
            else
            {
                Console.WriteLine("Stack is empty.");
            }
        }
        public void ShowStackCount<T>(Stack<T> stack)
        {
            Console.WriteLine($"Stack count: {stack.Count}");
        }
    }
}
