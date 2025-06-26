using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandConnect.ConsoleApps.DotNetCSharp.Files
{
    public class FileStreamCreateMain
    {
        public static void Main(string[] args)
        {
            string FilePath = @"C:\dev\MyFile.txt";
            FileStream fileStream = new FileStream(FilePath, FileMode.Create);
            fileStream.Close();
            Console.WriteLine("File has been created and the path is C:\\dev\\MyFile.txt ");
        }
    }
}
