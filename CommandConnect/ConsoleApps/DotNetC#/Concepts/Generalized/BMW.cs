using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandConnect.ConsoleApps.DotNetC_.Concepts.Generalized
{
    public class BMW : ICar
    {
        public void Start()
        {
            Console.WriteLine($"BMW Start");
        }
        public void Stop()
        {
            Console.WriteLine($"BMW Stop");
        }
    }
}
