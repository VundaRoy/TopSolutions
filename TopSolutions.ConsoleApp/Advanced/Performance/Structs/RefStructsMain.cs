using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.Advanced.Performance.Structs
{
    internal class RefStructsMain
    {
        public static void Main(string[] args)
        {
            //create a stack only struct
            StackOnlyStruct stackOnlyStruct = new StackOnlyStruct(10);
            Console.WriteLine($"Initial Value: {stackOnlyStruct.GetAmount()}");
            stackOnlyStruct.AddAmount(5);
            Console.WriteLine($"After Adding 5: {stackOnlyStruct.GetAmount()}");
            stackOnlyStruct.RemoveAmount(3);
            Console.WriteLine($"After Removing 3: {stackOnlyStruct.GetAmount()}");

        }
        //create stack only structures
        //struct of integers that can only be allocated on the stack and cannot be boxed or stored in heap memory
        public struct StackOnlyStruct
        {
            public int Value;
            public StackOnlyStruct(int value)
            {
                Value = value;
            }
            public void AddAmount(int amount)
            {
                Value += amount;
            }
            public int GetAmount()
            {
                return Value;
            }
            public void RemoveAmount(int amount){
                {
                    Value -= amount;
                }

            }
        }
        
        
    }
}
