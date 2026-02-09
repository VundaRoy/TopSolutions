using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Template.ConvertFile
{
    public class ConvertToPdfMain
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Converting word document to pdf");
            ConvertFileTemplate wordDocumentReader = new WordDocumentReader(); // we can use the same template for different document types
            wordDocumentReader.ConvertAndSave();
            Console.WriteLine("Converting latex to pdf");
            ConvertFileTemplate latexDocumentReader = new LatexDocumentReader(); 
            latexDocumentReader.ConvertAndSave();
        }
    }
}
