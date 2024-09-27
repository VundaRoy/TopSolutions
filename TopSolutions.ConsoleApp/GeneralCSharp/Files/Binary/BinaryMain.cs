namespace TopSolutions.ConsoleApp.GeneralCSharp.Files.Binary
{
    public class BinaryMain
    {
        static void Main(string[] args)
        {
            using (BinaryWriter writer = new(File.Open("C:\\dev\\Text\\TheBinary.bin", FileMode.Create)))
            {
                writer.Write("0x80234400");
                writer.Write("Windows error alert");
                writer.Write(true);
            }
            Console.WriteLine("Binary file created ");
            Console.ReadKey();

        }
    }
}
