using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.GeneralCSharp.Concurrency.Polly.WhileSample;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Events.Delegates.GenericDelegates
{
    public class GenericDelMain
    {

        delegate bool PredicateStringInt(string input, int length);

        static void Main(string[] args)
        {
            //Func
            Func<int, float, double, double> obj1 = new(AddIntFloatDoubleReturn);
            double Result = obj1.Invoke(100, 125.45f, 456.789);
            Console.WriteLine($"Adding int, float and double makes : {Result}");
            //Action
            Action<int, float, double> obj2 = new(AddIntFloatDoubleVoid);
            obj2.Invoke(50, 255.45f, 123.456);
            //use Predicate
            Predicate<string> obj3 = new(CheckLength);
            Console.WriteLine("Enter a text to see if it is greater than 5 ");
            var str = Console.ReadLine();
            while (!string.IsNullOrEmpty(str)) 
            {
                Console.WriteLine(obj3.Invoke(str) == true ? $"{str} is longer than 5" : $"{str} is shorter than 5.");
                break;
            }
                var Status = obj3.Invoke("Pran");
            PredicateStringInt obj4 = new(CheckLengthConditional);
            Status = obj4.Invoke("Deochand", 3);
            Console.WriteLine("Length is > 3 : " + Status);
            Console.ReadKey();
        
        }
        public static double AddIntFloatDoubleReturn(int no1, float no2, double no3) => no1 + no2 + no3;
        public static void AddIntFloatDoubleVoid(int no1, float no2, double no3)
        {
            Console.WriteLine(no1 + no2 + no3);
        }
        public static bool CheckLength(string name)
        {
            if (name.Length > 5)
                return true;
            return false;
        }
        public static bool CheckLengthConditional(string name, int stringLength)
        {
            if (name.Length > stringLength)
                return true;
            return false;
        }

    }
}
