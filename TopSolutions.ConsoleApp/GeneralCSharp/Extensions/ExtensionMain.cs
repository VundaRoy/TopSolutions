
namespace TopSolutions.ConsoleApp.GeneralCSharp.Extensions
{
    public class ExtensionMain
    {
        static void Main(string[] args)
        {
            int[] ints = { 1001, 255, 113, 15, 88, 152, 102, 755, 885 };
            var res = ints.OrderBy(x => x).ToArray();
            foreach (int i in res) 
            {  
                Console.WriteLine(i + " ");
            }

            string s = "So this is the original text. ";
            string result = s.AppendDisclosure();
            
            Console.WriteLine(result);
            result = s.CapsLockTheThing();
            Console.WriteLine(result);
            result = s.AppendDisclosureExtra("Wananavu koya!");
            Console.WriteLine(result);
            s = "REMOVE all ITEMS now!!";
            result = s.LowerCaseTheLot();
            Console.WriteLine(result);
            Console.WriteLine(s.FijianizeThis());
            Console.WriteLine(s.ChennaiyizeThis());
        }

    }
}
