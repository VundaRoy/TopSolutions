using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.ISP.Library
{
    public class Book
    {
        public string BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public override string ToString()
        {
            return $"[BookId: {BookId}, Title: {Title}, Author:{Author}, ISBN:{ISBN}]";
        }
    }
}
