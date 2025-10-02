using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Basics.Access
{
    internal class ClassAccess
    {
        public void OpenSesame()
        {
            Console.WriteLine("This is a public method.");
        }

    }
    class ClassPrivate //Internal by default
    {
        private void OpenSesame()
        {
            Console.WriteLine("This is a private method.");
        }
        public void Test()
        {
            OpenSesame();
        }
    }

    public class ClassPublic 
    {
        internal void OpenSesame()
        {
            Console.WriteLine("This is an internal method.");
        }

        public static void Main()
        {
            ClassAccess ci = new ClassAccess();
            ci.OpenSesame();
            ClassPublic cp = new ClassPublic();
            cp.OpenSesame();
            ClassPrivate cpr = new ClassPrivate();
            // cpr.OpenSesame(); // Not accessible
            cpr.Test(); // call private method via public method
        }
    }
}
