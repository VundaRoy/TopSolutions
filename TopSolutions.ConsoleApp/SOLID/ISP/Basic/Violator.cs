using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.ISP.Basic
{
    public class Violator : IViolate
    {
        public void Finalise(string document)
        {
            Console.WriteLine("This is final "+ document);
        }

        public void Process(string document)
        {
            Console.WriteLine("Process "+ document);
        }

        public void Submit(string document)
        {
            throw new NotImplementedException();
        }

        public void Summarise(string document)
        {
            throw new NotImplementedException();
        }
    }
}
