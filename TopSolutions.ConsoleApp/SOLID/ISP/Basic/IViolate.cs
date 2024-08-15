using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.ISP.Basic
{
    public interface IViolate
    {
        void Submit(string document);
        void Process(string document);
        void Summarise(string document);
        void Finalise(string document);
    }
}
