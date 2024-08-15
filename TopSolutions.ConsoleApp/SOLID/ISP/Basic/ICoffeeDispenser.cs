using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.ISP.Basic
{
    public interface ICoffeeDispenser
    {
        string CheckDispenser(int DispenserId);
        void MakeCoffee(int CoffeeId);
        
    }
}
