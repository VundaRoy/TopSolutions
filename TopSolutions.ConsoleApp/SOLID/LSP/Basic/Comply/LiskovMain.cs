using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.LSP.Basic.Comply
{
    public class LiskovMain
    {
        public static void Main(string[] args)
        {
            var rect = new Rectangle { Width = 2, Height = 3 };
            rect.GetArea();  // This works fine
            rect.ChangeDimensions(rect, 4, 5);  // This works fine
            var square = new Square { Side = 2 };
            //square.GetArea();  // This also works fine
            // This will not work
            //square.ChangeDimensions(square, 4, 5);  
            Console.WriteLine("Square area is : " + square.GetArea());
            var circle = new Circle { Radius = 3 };
            Console.WriteLine("Circle with radius of 3 has area of :" + circle.GetArea());
            Console.ReadKey();
        }
    }
}
