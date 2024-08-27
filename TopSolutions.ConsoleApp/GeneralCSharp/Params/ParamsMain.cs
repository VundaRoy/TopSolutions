using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Params
{
    public class ParamsMain
    {
        static void Main(string[] args)
        {
            //add 2
            SumUp(1200, 20);

            //multiple
            SumUp(1300, 30, 67, 80, 90);
            //null param
            SumUpThird(2000, 40, null);

            //multiple
            SumUpThird(1300, 30, new int[] {12,45,67,55});

        }

        public static void SumUp(int deposit, int fees, params object[] others)
        {
            int totalCost = deposit + fees;
            foreach (int item in others) 
            {
                totalCost += item;
            
            }
            Console.WriteLine("total cost : " + totalCost);
        }
        //Method overloading
        public static void SumUpThird(int deposit, int fees, int[] others= null)
        {
            int totalCost = deposit + fees;
            if (others != null)
            {
                foreach (int item in others)
                {
                    totalCost += item;

                }
            }
            Console.WriteLine("total cost -version 2  : " + totalCost);
        }
    }
}
