using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.LSP.Basic.Violate
{
    public class Rectangle
    {
        public virtual double Base { get; set; }
        public virtual double Height { get; set; }
        public double GetArea()
        {
            return Base * Height;
        }
        public void ChangeDimensions(Rectangle rect, double width, double height)
        {
            rect.Base = width;
            rect.Height = height;
            Console.WriteLine($"Area: {rect.GetArea()}");
        }
    }
}
