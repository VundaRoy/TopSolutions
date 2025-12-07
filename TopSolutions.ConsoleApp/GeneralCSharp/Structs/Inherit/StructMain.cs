using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Structs.Inherit
{
    public struct StructMain
    {
        public static void Main(string[] args)
        {
            ShoppingCart shoppingCart = new();
            Console.WriteLine($"This struct says {shoppingCart.GetInfoByFormId(5)}.");
            //Assign values to properties
            shoppingCart.CartStatus = "Active";
            shoppingCart.ItemCount = 3;
            Console.WriteLine($"The shopping cart status is {shoppingCart.CartStatus} with {shoppingCart.ItemCount} items.");
        }
    }
}
