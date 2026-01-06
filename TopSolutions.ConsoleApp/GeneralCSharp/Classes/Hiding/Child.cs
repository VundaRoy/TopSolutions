using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Classes.Hiding
{
    internal class Child : Parent
    {
        //Method hiding using 'new' keyword
        public new void Display()
        {
            base.Display(); //calling parent class method
            Console.WriteLine("Display method from Child class");
        }
        //method hiding without 'new' keyword  
        public void Show()
        {
            Console.WriteLine("Show method from Child class");
        }
        //normal inheritance of parent class method
        //public override void Show() // overriding the Show method says it is already defined in child class
        //{
        //    Console.WriteLine("Show method from Child class");
        //}

    }
}
