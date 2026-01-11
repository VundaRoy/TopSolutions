using Microsoft.Extensions.ObjectPool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.ObjectPool.BookInventory
{
    public class BookPoolPolicy : PooledObjectPolicy<Book>
    {
        public override Book Create() => new Book();
        public override bool Return(Book obj)
        {
            obj.ResetState();
            return true;
        }
    }
}
