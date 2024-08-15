using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.ISP.Basic
{
    public interface IPrinter
    {
        void FeedPaper(int numberOfPapers);
        void CheckInk();
        string CheckStatus(int PrinterId);
    }
}
