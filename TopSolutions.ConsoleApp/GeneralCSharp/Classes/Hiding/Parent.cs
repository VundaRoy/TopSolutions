using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Classes.Hiding
{
    internal class Parent
    {
        public virtual void Show() { }
        public void Display()
        {
            Console.WriteLine("Display method from Parent class");
        }
    }
}
