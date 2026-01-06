using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Basics.Strings
{
    internal class StringConversion
    {
        public static void Main(string[] args)
        {
            //Convert object to string using ToString()
            object obj = 12345;
            string str1 = obj.ToString();
            Console.WriteLine("Convert using ToString()" +str1);
            //Convert object to string using Convert.ToString()
            string str2 = Convert.ToString(obj);
            //Convert string to int using int.Parse()
            //convert null value to string using Convert.ToString()
            string nullString = null;
            string str3 = Convert.ToString(nullString);
            Console.WriteLine("Convert null using Convert.ToString(): " + (str3 == null ? "null" : str3));
            //convert null value to string using ToString() - this will throw an exception
            //string str4 = nullString.ToString(); // Uncommenting this line will throw a NullReferenceException
        }
    }
}
