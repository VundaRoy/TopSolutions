using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Samples.QuickTest
{
    public class Independent : IDisposable
    {
        public Independent()
        {

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public static void GetInput(string entry)
        {
            Console.WriteLine(entry);
        }
    }
}
