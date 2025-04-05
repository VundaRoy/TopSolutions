using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandConnect.ConsoleApps.DotNetC_.Concepts.Generalized
{
    public class Innova : ICar
    {
        public void Start()
        {
            Console.WriteLine($"Innova Start");
        }
        public void Stop()
        {
            Console.WriteLine($"Innova Stop");
        }
    }
}
