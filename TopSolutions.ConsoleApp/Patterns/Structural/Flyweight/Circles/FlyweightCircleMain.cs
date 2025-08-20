using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Structural.Flyweight.Circles
{
    public class FlyweightCircleMain
    {
        static void Main(string[] args)
        {
            //Creating Circle Objects with designated Color
            
            DrawCircle("red");
            DrawCircle("green");
            DrawCircle("blue");
            DrawCircle("black");
            DrawCircle("orange");
            
            Console.ReadKey();
        }

        private static void DrawCircle(string color)
        {
            Console.WriteLine($"{color} color Circles ");
            for (int i = 0; i < 3; i++)
            {
                Circle circle = (Circle)ShapeFactory.GetShape("circle");
                circle.SetColor(color);
                circle.Draw();
            }
        }
    }
}
