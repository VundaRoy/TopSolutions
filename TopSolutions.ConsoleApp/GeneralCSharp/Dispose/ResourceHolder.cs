using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Dispose
{
    public class ResourceHolder : IDisposable
    {
        private bool _disposed = false;
        public ResourceHolder() 
        {
            Console.WriteLine("Unmanaged resources allocated");

        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if ((!_disposed))
            {
                if (disposing)
                {
                    Console.WriteLine("Free other managed objects");
                }
                Console.WriteLine("Unmanaged resource released.");
                _disposed = true;
            }
        }
        ~ResourceHolder() 
        { 
            Dispose(false);
            Console.WriteLine("Finilizer called");
        }
    }
}
