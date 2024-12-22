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
            var triangle = new Triangle { Base = 2 };
            rect.ChangeDimensions(triangle, 4, 5);
            Console.ReadKey();
        }
    }
}
