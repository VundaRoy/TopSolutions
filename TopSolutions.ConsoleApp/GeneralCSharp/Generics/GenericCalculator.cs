using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Generics
{
    public class GenericCalculator
    {
        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
        public static bool AreTwoTypesEqual<T1, T2>(T1 value1, T2 value2)
        {
            return value1.Equals(value2);
        }
    }
}
