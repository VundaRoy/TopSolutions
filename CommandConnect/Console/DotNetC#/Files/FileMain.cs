using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandConnect.Console.DotNetC_.Files
{
    public class FileMain
    {
        static string fileName = "C:\\dev\\Text\\SampleText.txt";
        public static void Main(string[] args)
        {
            EditProgramFiles editProgramFiles = new EditProgramFiles();
            editProgramFiles.ReplaceTextWith("C#", "J#", fileName);
        }
    }
}
