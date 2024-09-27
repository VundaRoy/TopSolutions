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
            ReadDataFromBinaryFile();
            Console.ReadKey();

        }
        static void ReadDataFromBinaryFile()
        {
            using (BinaryReader reader = new BinaryReader(File.Open("C:\\dev\\Text\\TheBinary.bin", FileMode.Open)))
            {
                Console.WriteLine("Error Code : " + reader.ReadString());
                Console.WriteLine("Message : " + reader.ReadString());
                Console.WriteLine("Restart Explorer : " + reader.ReadBoolean());
            }
        }
    }
}
