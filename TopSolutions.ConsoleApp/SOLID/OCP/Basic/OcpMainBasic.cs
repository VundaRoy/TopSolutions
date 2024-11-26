using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.OCP.Basic
{
    public class OcpMainBasic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OCP samples with translate");
            Translate greek = new TranslateGreek();
            string greekWord = greek.GetMeaning("Minataur");
            Console.WriteLine(greekWord);
            Translate latin = new TranslateLatin();
            string latinWord = latin.GetMeaning("Cicero");
            Console.WriteLine(latinWord);
            Translate sanskrit = new TranslateSanskrit();
            string sanskritWord = sanskrit.GetMeaning("Budhi");
            Console.WriteLine(sanskritWord);
            
        }
    }
}
