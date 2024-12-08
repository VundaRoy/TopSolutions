using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Iterator.RadioChannels
{
    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
        bool HasPrevious();
        T Previous();
    }
}
