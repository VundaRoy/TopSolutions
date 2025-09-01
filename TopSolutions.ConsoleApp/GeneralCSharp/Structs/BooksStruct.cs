using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Structs
{
    struct BooksStruct
    {        
        private string title;
        private string description;
        private string author;
        private string subject;
        
        public void getBookInfo(string t, string d, string a, string s)
        {
            title = t.Trim();
            description = d.Trim();
            author = a.Trim();
            subject = s.Trim();
        }
        public void DisplayBook()
        {
            Console.WriteLine($"Title : {title}");
            Console.WriteLine($"Author : {author}");
            Console.WriteLine($"Subject : {subject}");
            Console.WriteLine($"Description :{description}");
        }
    }
}
