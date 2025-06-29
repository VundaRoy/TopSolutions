using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandConnect.ConsoleApps.DotNetCSharp.Files
{
    public class FileStreamInputWriteMain
    {
        public static void Main(string[] args)
        {
            string FilePath = @"C:\dev\MyFile.txt";
            Console.WriteLine("Write what you may...");

            string inputData = Console.ReadLine();
            using(StreamWriter streamWriter = new StreamWriter(FilePath, true))
            {
                streamWriter.WriteLine(inputData);
            }
            Console.WriteLine("Input data has been written");
            Console.ReadKey();
               
        }
    }
}
