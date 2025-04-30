using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.IEnumerator
{
    public class EnumeratorMain
    {
        List<string> Month;
        public EnumeratorMain()
        {
            Month = new()
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
        }
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
           
            //Create IEnumerator of string.
            EnumeratorMain main = new EnumeratorMain();
            IEnumerator<string> iEnumeratorOfString = main.Month.GetEnumerator();//to convert list into IEnumerator we can invoke the GetEnumerator method

            while (iEnumeratorOfString.MoveNext())
            {
                Console.WriteLine(iEnumeratorOfString.Current);
            }
             iEnumeratorOfString = main.Month.GetEnumerator();
            EnumeratorMethodOne(iEnumeratorOfString);
        }
    }
}
