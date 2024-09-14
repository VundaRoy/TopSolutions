using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.IEnumerator
{
    public class EnumeratorMain
    {
        static void EnumeratorMethodOne(IEnumerator<string> i)
        {
            while (i.MoveNext())
            {
                Console.WriteLine(i.Current);

                if (i.Current == "Shravana")
                {
                    EnumeratorMethodTwo(i);
                }
            }
        }
        static void EnumeratorMethodTwo(IEnumerator<string> i)
        {
            while (i.MoveNext())
            {
                Console.WriteLine(i.Current);
            }
        }
        static void Main(string[] args)
        {
            List<string> Month = new()
            {
                "Chaitra",
                "Vaishakka",
                "Jyaishta",
                "Ashadha",
                "Shravana",
                "Kartika",
                "Margashira",
                "Pausha",
                "Magha",
                "Phalguna"
            };
            //Create IEnumerator of string.

            IEnumerator<string> iEnumeratorOfString = Month.GetEnumerator();//to convert list into IEnumerator we can invoke the GetEnumerator method

            while (iEnumeratorOfString.MoveNext())
            {
                Console.WriteLine(iEnumeratorOfString.Current);
            }
             iEnumeratorOfString = Month.GetEnumerator();
            EnumeratorMethodOne(iEnumeratorOfString);
        }
    }
}
