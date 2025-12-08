using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Contravariance.ParameterCompatibility
{
    delegate void StringDelegate(string str);
    delegate void AnotherStringDelegate(string str);
    delegate void IntegerDelegate(int num);
    delegate void DecimalDelegate(decimal dec);
    internal class ParamCompMain
    {
        public static void Main()
        {
            StringDelegate del = new (ActionObject);
            del("Hello, World!");
            //IntegerDelegate delInt = new (ActionObject); // This line would cause a compile-time error
            //due to delegate variance rules, because ActionObject expects an object, not an int.
            IntegerDelegate delInt = num => ActionObject(num); //lambda works with boxing
            //call another string delgate
            AnotherStringDelegate del2 = new (AnotherStringDelegate);
            del2("Yes another one type");
            //Intgeger type
            IntegerDelegate del3 = new (IntegerDelegate);
            del3(233);
            
        }
        static void ActionObject(object obj)
        {
            Console.WriteLine("Object: " + obj);
        }
        static void AnotherStringDelegate(object obj)
        {
            Console.WriteLine("Another string type: " + obj);
        }
        static void IntegerDelegate(int num)
        {
            Console.WriteLine("An int type of "+ num );

        }
    }
}
