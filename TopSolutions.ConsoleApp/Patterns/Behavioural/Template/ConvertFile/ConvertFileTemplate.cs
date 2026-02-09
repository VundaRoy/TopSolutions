using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Template.ConvertFile
{
    public abstract class ConvertFileTemplate
    {
        //a template class to convert text file to pdf and save to download folder
        public void ConvertAndSave()
        {
            //define steps to convert and save file
            ReadFile();
            ConvertToPdf();
            SaveToPdf();
            SaveToDownloadFolder();
            Console.WriteLine("File converted and saved to download folder");
        }
        //Read file from source
        protected abstract void ReadFile();
        //Convert to pdf
        protected abstract void ConvertToPdf();
        //Save to download folder
        protected abstract void SaveToDownloadFolder();
        protected abstract void SaveToPdf();

    }
}
