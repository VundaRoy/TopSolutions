using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Basics.ReferenceType
{
    public class RefVersusValueMain
    {
        public static void Main()
        {
            // Reference types example
            string name1 = "Coleman";
            string name2 = "Coleman";

            Console.WriteLine($"Equal with operator == : {name1 == name2}"); // True, because the values are the same
            Console.WriteLine($"Equal with method Equals : {name1.Equals(name2)}"); // True, because the values are the same
            Console.WriteLine($"RefrenceEquals : {ReferenceEquals(name1, name2)}"); // True, because both refer to the same interned string
        }
    }

}
