using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Structs.Inherit
{
    public class CheckStructMain
    {
        public static void Main(string[] args)
        {
            ShoppingCart sc = new ();
            var id = Console.ReadLine();

            sc.GetInfoByFormId(Convert.ToInt32(id));
        }
    }
}
