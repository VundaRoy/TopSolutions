using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Constructors
{
    public class ClientForConstructor 
    {
        static void Main(string[] args)
        {
            ClassConstructor constructor = new ClassConstructor();
            constructor.SomeMeth();
            constructor.Dispose();
        }

        
    }
}
