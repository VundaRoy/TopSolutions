using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Samples.Patterns.Iterator.After.Contracts
{
    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
        T Current(int id);
        T Previous(int id);   
    }
}
