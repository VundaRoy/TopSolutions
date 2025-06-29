using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandConnect.ConsoleApps.DotNetCSharp.Files
{
    public class FileStreamAppendMain
    {
        public static void Main(string[] args)
        {
            string FilePath = @"C:\dev\MyFile.txt";
            int a, b, result;
            a = 122;
            b= 3434;
            result = a + b;
            using(StreamWriter streamWriter = new StreamWriter(FilePath, true))
            {
                streamWriter.WriteLine($"Sum of {a} + {b} = {result}");
            }
            Console.WriteLine("Variable data is saved into the File");
            Console.ReadKey();

        }
    }
}
