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
            MathDelegate del1 = new MathDelegate(Add);
            MathDelegate del2 = new MathDelegate(Sub);
            MathDelegate del3 = new MathDelegate(main.Mul);
            MathDelegate del4 = new MathDelegate(main.Div);
            MathDelegate del5 = new MathDelegate(main.XpowerY);

            MathDelegate deln = del1 + del2 + del3 + del4 + del5;
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
            deln -= del2;
            deln(22, 7);
            Console.ReadKey();

        }
    }
}
