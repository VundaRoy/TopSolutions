using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Classes.Hiding
{
    internal class MethodHidingMain
    {
        public static void Main(string[] args)
        {
            Parent parentRef;
            Child childObj = new Child();
            // Calling hidden method using child class object
            childObj.Display(); // Output: Display method from Child class
            // Calling hidden method using parent class reference
            parentRef = childObj;
            parentRef.Display(); // Output: Display method from Parent class
            // Calling overridden method using child class object
            childObj.Show(); // Output: Show method from Child class
            // Calling hidden method using parent class reference
            parentRef.Show(); // Output: Show method from Parent class
        }
    }
}
