using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.ISP.Basic
{
    public interface IDishWasher
    {
        string CheckStatus(int WasherId);
        void PutDetergent(int quantity);
        void WashDishes();
    }
}
