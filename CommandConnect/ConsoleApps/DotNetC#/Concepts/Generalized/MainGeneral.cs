using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandConnect.ConsoleApps.DotNetC_.Concepts.Generalized
{
    public class MainGeneral
    {
        public static void Main(string[] args)
        {
            Innova innova = new Innova();
            innova.Start();
            innova.Stop();
            BMW bmw = new BMW();
            bmw.Start();
            bmw.Stop();
            Console.ReadKey();
        }
    }
}
