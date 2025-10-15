using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Classes.Sealed
{
    public sealed class SealedClass
    {
        public void DisplayMessage()
        {
            Console.WriteLine("This is a sealed class. It cannot be inherited.");
        }
    }
}
