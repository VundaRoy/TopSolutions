using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Events.Delegates.Multicast
{
    public delegate void MathDelegate(int No1, int No2);

    public class MulticastDelegateMain
    {
        //Static Method
        public static void Add(int x, int y)
        {
            Console.WriteLine($"Addition of {x} and {y} is : {x + y}");
        }
        //Static Method
        public static void Sub(int x, int y)
        {
            Console.WriteLine($"Subtraction of {x} and {y} is : {x - y}");
        }
        //Non-Static Method
        public void Mul(int x, int y)
        {
            Console.WriteLine($"Multiplication of {x} and {y} is : {x * y}");
        }
        //Non-Static Method
        public void Div(int x, int y)
        {
            Console.WriteLine($"Division of {x} and {y} is : {x / y}");
        }
        public void XpowerY(int x, int y)
        {
            Console.WriteLine($"{x} to the power of {y} is : {Math.Pow( x, y)}");
        }
        static void Main(string[] args)
        {
            MulticastDelegateMain main = new MulticastDelegateMain();
            MathDelegate addDel = new(Add);
            MathDelegate subDel = new(Sub);
            MathDelegate multDel = new(main.Mul);
            MathDelegate divDel = new(main.Div);
            MathDelegate powDel = new(main.XpowerY);

            MathDelegate deln = addDel + subDel + multDel + divDel + powDel;
            Delegate[] InvocationList = deln.GetInvocationList();
            Console.WriteLine("InvocationList");
            foreach (var item in InvocationList)
            {
                Console.WriteLine($"{item.Method} {item.GetType}");
            }
            Console.WriteLine();
            Console.WriteLine("Invoking Multicast delegate");
            deln.Invoke(20, 5);
            Console.WriteLine();
            Console.WriteLine("Invoking Multicast Delegate After Removing one Delegate:");
            deln -= subDel;
            deln(22, 7);
            deln += addDel;
            deln(2, 8);
            Console.ReadKey();

        }
    }
}
