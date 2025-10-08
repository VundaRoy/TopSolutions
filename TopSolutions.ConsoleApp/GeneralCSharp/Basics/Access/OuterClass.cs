using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Basics.Access
{

    public class OuterClass
    {
        private enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
        enum Month { January, February, March, April, May, June, July, August, September, October, November, December };
        public enum Season { Spring, Summer, Autumn, Winter };
        private class InnerClass
        {
            public void Show()
            {
                Console.WriteLine("Accessing from InnerClass: ");
            }
            public void ShowPublicEnum()
            {
                Season season = Season.Winter; // Accessible everywhere
                Console.WriteLine("Inner public Season: " + season);
            }
            public void ShowPrivateEnum()
            {
                Day day = Day.Monday; // Accessible within OuterClass
                Console.WriteLine("Inner private Day: " + day);
            }
        }
        private string outerField = "Outer Field";
        public void Display()
        {
            Console.WriteLine("Accessing from OuterClass: " + outerField);
            InnerClass inner = new InnerClass();
            inner.Show();
        }

        public static void Main()
        {
            OuterClass outer = new();
            Month month = Month.January; // Accessible within OuterClass
            Season season = Season.Winter; // Accessible everywhere
            Day day = Day.Monday; // Accessible within OuterClass

            outer.Display();
            outer.Display();
            OuterClass.InnerClass inner = new();
            inner.Show();
            inner.ShowPublicEnum();
            inner.ShowPrivateEnum();
        }
    }
}
