using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Contravariance.ParameterCompatibility
{
    delegate void StringDelegate(string str);
    delegate void IntegerDelegate(int num);
    delegate void DecimalDelegate(decimal dec);
    internal class ParamCompMain
    {
        public static void Main()
        {
            StringDelegate del = new (ActionObject);
            del("Hello, World!");
            //IntegerDelegate delInt = new IntegerDelegate(ActionString); // This line would cause a compile-time error
            
        }
        static void ActionObject(object obj)
        {
            Console.WriteLine("Object: " + obj);
        }
    }
}
