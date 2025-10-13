using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Classes.Abstract
{
    public class AbsMain
    {
        public static void Main()
        {
            AbsChild absChild = new();
            absChild.Add(10, 5);
            absChild.Sub(10, 5);
            absChild.Mul(10, 5);
            absChild.Div(10, 5);
            absChild.Div(10, 0);
            Console.ReadLine();
        }
    }
}
