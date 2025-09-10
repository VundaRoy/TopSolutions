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
            ShoppingCart shoppingCart = new ShoppingCart();
            Console.WriteLine($"This struct says {shoppingCart.GetInfoByFormId(5)}.");
        }
    }
}
