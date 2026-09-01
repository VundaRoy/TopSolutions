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
            
            stackOnlyStruct.AddAmount(5);
            DisplayValuesBasedonDescription(stackOnlyStruct, "After Adding 5");
            stackOnlyStruct.RemoveAmount(3);
            DisplayValuesBasedonDescription(stackOnlyStruct, "After Removing 3");
            stackOnlyStruct.TothePowerOfAmount(3);
            DisplayValuesBasedonDescription(stackOnlyStruct, "After Raising to the Power of 3");
            stackOnlyStruct.MultiplyAmount(2);
            DisplayValuesBasedonDescription(stackOnlyStruct, "After Multiplying by 2");

        }
        public static void DisplayValuesBasedonDescription(StackOnlyStruct stackOnlyStruct, string description)
        {
            Console.WriteLine($"{description}: {stackOnlyStruct.GetAmount()}");
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
            public int MultiplyAmount(int amount)
            {
                Value *= amount;
                return Value;
            }
            public int TothePowerOfAmount(int amount)
            {                
                Value = (int)Math.Pow(Value, amount);
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
