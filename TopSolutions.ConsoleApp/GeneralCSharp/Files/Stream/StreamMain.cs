using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Files.Stream
{
    public class StreamMain
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\dev\Text\SampleText.txt";
            string content = "Klondike mine expedition";
            FileStreamWrite(filePath, content);
            //Read
            FileStreamRead(filePath);

            Console.WriteLine("File created is in C:\\dev\\Text");
            Console.ReadKey();
            //Create new file
            string streamPath = @"C:\dev\Text\StreamText.txt";           

            StreamWriteOut(streamPath);

            Console.ReadKey();
        }

        private static void FileStreamRead(string FilePath)
        {
            string data;
            FileStream fileStreamRead = new(FilePath, FileMode.Open, FileAccess.Read);
            using (StreamReader sr = new(fileStreamRead))
            {
                data = sr.ReadToEnd();
            }
            fileStreamRead.Close();
            Console.WriteLine(data);
        }

        private static void FileStreamWrite(string FilePath, string content)
        {
            FileStream fileStream = new(FilePath, FileMode.Append);
            //Create the byte array which contains the string data to be appended in the File
            byte[] bytedata = Encoding.Default.GetBytes(content);
            //count (bytedata.Length): The maximum number of bytes to write.
            fileStream.Write(bytedata, 0, bytedata.Length);
            fileStream.Close();
        }

        private static void StreamWriteOut(string streamPath)
        {
            int a, b, result;
            // Create a new Random object
            Random random = new Random();
            a = random.Next(1, 999);
            b = random.Next(1000, 4500); ;
            result = a + b;
            using (StreamWriter streamWriter = new StreamWriter(streamPath, true))
            {
                streamWriter.WriteLine($"\nSum of {a} + {b} = {result}");
            }
            Console.WriteLine("Variable is saved into the File");
        }
    }
}
