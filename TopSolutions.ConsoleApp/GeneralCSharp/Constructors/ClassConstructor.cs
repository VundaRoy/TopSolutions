using NPOI.OpenXmlFormats.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Constructors
{
    public class ClassConstructor : IDisposable
    {
        public ClassConstructor()
        {
            Console.WriteLine("Just started");
        }
        ~ClassConstructor() 
        {
            //Dispose(false);
            Console.WriteLine("final call");
        }

        public void Dispose()
        {
            Console.WriteLine("disposing");
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                Console.WriteLine("Freeing up space");
            }
            // Free unmanaged resources
        }
        public void SomeMeth()
        {
            Console.WriteLine("Meth aint good for ya");
        }
    }
}
