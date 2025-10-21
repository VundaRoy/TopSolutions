using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Basics.Literals
{
    public class LiteralMain
    {
        //litrals examples
        public static void Main()
        {
            // Integer literal
            int intLiteral = 100;
            Console.WriteLine($"Integer Literal: {intLiteral}");
            // Floating-point literal
            double floatLiteral = 99.99;
            Console.WriteLine($"Floating-point Literal: {floatLiteral}");
            // Character literal
            char charLiteral = 'A';
            Console.WriteLine($"Character Literal: {charLiteral}");
            // String literal
            string stringLiteral = "Hello, World!";
            Console.WriteLine($"String Literal: {stringLiteral}");
            // Boolean literal
            bool boolLiteral = true;
            Console.WriteLine($"Boolean Literal: {boolLiteral}");
            // Null literal
            string nullLiteral = null;
            Console.WriteLine($"Null Literal: {nullLiteral}");
            //unsigned integer literal
            uint uintLiteral = 300U;
            Console.WriteLine($"Unsigned Integer Literal: {uintLiteral}");
            //long integer literal
            long longLiteral = 5000L;
            Console.WriteLine($"Long Integer Literal: {longLiteral}");
            //unsigned long integer literal
            ulong ulongLiteral = 7000UL;
            Console.WriteLine($"Unsigned Long Integer Literal: {ulongLiteral}");
        }
    }
}
