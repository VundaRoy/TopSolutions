using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Template.ConvertFile
{
    public class LatexDocumentReader : ConvertFileTemplate
    {
        protected override void ReadFile()
        {
            Console.WriteLine("Reading Latex Document");
        }
        protected override void ConvertToPdf()
        {
            Console.WriteLine("Converting Latex Document to PDF");
        }
        protected override void SaveToDownloadFolder()
        {
            Console.WriteLine("Saving PDF to Download Folder");
        }
        protected override void SaveToPdf()
        {
            Console.WriteLine("Saving PDF to Temporary Folder");
        }

    }
}
