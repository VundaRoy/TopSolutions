using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Concurrency.Threads.CallBack
{
    public class CallBackMain
    {
        static void Main(string[] args)
        {
            //Create the ResultCallbackDelegate instance and to its constructor 
            //pass the callback method name
            ResultCallbackDelegate resultCallbackDelegate = new(ResultCallBackMethod);
            int Number = 100;
            //Creating the instance of NumberHelper class by passing the Number
            //the callback delegate instance
            NumberHelper obj = new(Number, resultCallbackDelegate);
            //Creating the Thread using ThreadStart delegate
            Thread T1 = new(new ThreadStart(obj.CalculateSum));

            T1.Start();
            Console.Read();
        }
        //Callback method and the signature should be the same as the callback delegate signature
        public static void ResultCallBackMethod(int Result)
        {
            Console.WriteLine("The Result is " + Result);
        }
    }
}
