using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Samples.Patterns.Primera
{
    public interface IBank
    {
        void AddBank(IBank bank);
        void DeleteBank(IBank bank);
        void UpdateBank(IBank bank);

    }
}
