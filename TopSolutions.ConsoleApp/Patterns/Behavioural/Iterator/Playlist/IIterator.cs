using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Iterator.Playlist
{
    //Iterator and Aggregate Interfaces
    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }
}
