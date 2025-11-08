using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Collections.Generics
{
    public class GenericMain
    {
        public static void Main()
        {
            GenericCollection genericCollection = new GenericCollection();
            genericCollection.GenericListExample();
            //Generic T example of strings
            List<string> stringList = new List<string> { "Apple", "Banana", "Cherry" };
            genericCollection.GenericTListExample(stringList);
            //Generic T example of doubles
            List<double> doubleList = new List<double> { 1.1, 2.2, 3.3 };
            genericCollection.GenericTListExample(doubleList);
            
        }
    }
}
