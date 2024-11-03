using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.Samples.Patterns.Iterator.After.Contracts;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Iterator.Playlist
{
    public interface IAggregate<T>
    {
        IIterator<T> CreateIterator();
    }
}
