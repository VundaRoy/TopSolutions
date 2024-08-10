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
        public void displayBook()
        {
            Console.WriteLine("Title : {0}", title);
            Console.WriteLine("Author : {0}", author);
            Console.WriteLine("Subject : {0}", subject);
            Console.WriteLine("Description :{0}", description);
        }
    }
}
