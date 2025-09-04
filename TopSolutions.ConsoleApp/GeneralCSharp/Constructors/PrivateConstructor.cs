using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Constructors
{
    public class PrivateConstructor
    {
        private PrivateConstructor()
        {

        }
        public PrivateConstructor(string endPoint)
        {
            Console.Write(endPoint);
        }
        public void SomeMethod()
        {
            Console.WriteLine("Some method in private constructor");
        }
        static void Main(string[] args)
        {
            PrivateConstructor pc = new PrivateConstructor();
            pc.SomeMethod();
        }
    }
    public class Outsider
    {
        static void Main(string[] args)
        {
            //PrivateConstructor pc = new PrivateConstructor();//illegal
            PrivateConstructor pc = new PrivateConstructor("wholesome");
            pc.SomeMethod();

        }
    }
}
