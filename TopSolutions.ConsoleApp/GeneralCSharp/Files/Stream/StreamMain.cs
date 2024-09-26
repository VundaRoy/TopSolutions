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
            string FilePath = @"C:\dev\Text\SampleText.txt";
            FileStream fileStream = new FileStream(FilePath, FileMode.Append);
            //Create the byte array which contains the string data to be appended in the File
            byte[] bytedata = Encoding.Default.GetBytes("C# Is an Object Oriented Programming Language");
            //count (bytedata.Length): The maximum number of bytes to write.
            fileStream.Write(bytedata, 0, bytedata.Length);
            fileStream.Close();
            Console.WriteLine("File created is in C:\\dev\\Text");
            Console.ReadKey();
            
        }
    }
}
