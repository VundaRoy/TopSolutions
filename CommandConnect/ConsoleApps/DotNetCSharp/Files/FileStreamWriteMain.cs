using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandConnect.ConsoleApps.DotNetCSharp.Files
{
    public class FileStreamWriteMain
    {
        public static void Main(string[] args)
        {
            string FilePath = @"C:\dev\MyFile.txt";
            FileStream fileStream = new FileStream(FilePath, FileMode.Append);
            byte[] byteData = Encoding.Default.GetBytes("Welcome to the c# world");
            fileStream.Write(byteData, 0, byteData.Length);
            fileStream.Close();
            Console.WriteLine("Written to file");
            Console.ReadKey();
        }
    }
}
