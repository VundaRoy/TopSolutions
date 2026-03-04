using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.LSP.Basic.Violate
{
    public class LiskovViolateMain
    {
        public static void Main(string[] args)
        {
            var rect = new Rectangle { Base = 2, Height = 3 };
            rect.ChangeDimensions(rect, 4, 5);  // This works fine
            var square = new Square { Base = 2 };
            rect.ChangeDimensions(square, 4, 5);  // This behaves unexpectedly!
            //square
            var square2 = new Square { Base = 2 };
            square2.ChangeDimensions(square2, 4, 5);  // This behaves unexpectedly!
            //square that works fine
            var square3 = new Square { Base = 2 };
            square3.ChangeDimensions(square3, 4, 4);  // This works fine
            var triangle = new Triangle { Base = 2 };
            rect.ChangeDimensions(triangle, 4, 5);
            Console.ReadKey();
        }
    }
}
