using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Singleton.Practical
{
    internal class OnceOffCall
    {
        //Singleton that allows only one method call
        private static OnceOffCall _instance;
        private bool _hasBeenCalled = false;
        private OnceOffCall() { }
        public static OnceOffCall Instance
        {
            get
            {
                _instance ??= new OnceOffCall();
                return _instance;
            }
        }
        //properties of the singleton
        public void ExecuteOnce()
        {
            if (_hasBeenCalled)
            {
                throw new InvalidOperationException("This method can only be called once.");
            }
            Console.WriteLine("Executing the once-off call.");
            _hasBeenCalled = true;
        }
    }
}
