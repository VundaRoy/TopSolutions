using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.IEnumerator
{
    public class EnumeratorMain
    {
        static void iEnumeratorMethodOne(IEnumerator<string> i)
        {
            while (i.MoveNext())
            {
                Console.WriteLine(i.Current);

                if (i.Current == "Shravana")
                {
                    iEnumeratorMethodTwo(i);
                }
            }
        }
        static void iEnumeratorMethodTwo(IEnumerator<string> i)
        {
            while (i.MoveNext())
            {
                Console.WriteLine(i.Current);
            }
        }
        static void Main(string[] args)
        {
            List<string> Month = new List<string>();
            Month.Add("Chaitra");
            Month.Add("Vaishakka");
            Month.Add("Jyaishta");
            Month.Add("Ashadha");
            Month.Add("Shravana");
            Month.Add("Kartika");
            Month.Add("Margashira");
            Month.Add("Pausha");
            Month.Add("Magha");
            Month.Add("Phalguna");
            //Create IEnumerator of string.

            IEnumerator<string> iEnumeratorOfString = Month.GetEnumerator();//to convert list into IEnumerator we can invoke the GetEnumerator method

            while (iEnumeratorOfString.MoveNext())
            {
                Console.WriteLine(iEnumeratorOfString.Current);
            }
             iEnumeratorOfString = Month.GetEnumerator();
            iEnumeratorMethodOne(iEnumeratorOfString);
        }
    }
}
