using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Events.Delegates.GenericDelegates
{
    public class GenericDelMain
    {
        static void Main(string[] args)
        {
            Func<int, float, double, double> obj1 = new(AddNumber1);
            double Result = obj1.Invoke(100, 125.45f, 456.789);
            Console.WriteLine($"Adding int, float and double makes : {Result}");
            Action<int, float, double> obj2 = new(AddNumber2);
            obj2.Invoke(50, 255.45f, 123.456);
            Predicate<string> obj3 = new(CheckLength);
            bool Status = obj3.Invoke("Pranayama");
            Console.WriteLine("Length is > 5 : " +Status);
            Status = obj3.Invoke("Pran");
            Console.WriteLine("Length is > 5 : " + Status);
            Console.ReadKey();
        }
        public static double AddNumber1(int no1, float no2, double no3)
        {
            return no1 + no2 + no3;
        }
        public static void AddNumber2(int no1, float no2, double no3)
        {
            Console.WriteLine(no1 + no2 + no3);
        }
        public static bool CheckLength(string name)
        {
            if (name.Length > 5)
                return true;
            return false;
        }

    }
}
