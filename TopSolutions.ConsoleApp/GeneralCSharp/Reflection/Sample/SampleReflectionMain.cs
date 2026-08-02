using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Reflection.Sample
{
    internal class SampleReflectionMain
    {
        public static void Main(string[] args)
        {
            //Reflection main console application for testing reflection in C#
            ReflectionSample sample = new ReflectionSample();
            sample.Run();
            Console.ReadKey();
        }
        

    }
}
