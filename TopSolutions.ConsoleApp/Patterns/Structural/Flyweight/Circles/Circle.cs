using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Structural.Flyweight.Circles
{
    public class Circle : IShape
    {
        public string Color { get; set; }
        //The following Properties Values are going to be the same for all Circle Shape Object
        private readonly int XCor = 10;
        private readonly int YCor = 20;
        private readonly int Radius = 30;
        //For Each Circle Object, we need to call the Following Method to set the Color
        public void SetColor(string Color)
        {
            this.Color = Color;
        }
        public void Draw()
        {
            Console.WriteLine(" Circle: Draw() [Color : " + Color + ", X Cor : " + XCor + ", YCor :" + YCor + ", Radius :" + Radius);
        }
    }
}
