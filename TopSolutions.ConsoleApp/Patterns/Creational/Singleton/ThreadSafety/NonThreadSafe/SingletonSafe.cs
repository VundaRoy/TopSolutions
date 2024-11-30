using System;
namespace SingletonDemo
{
    public sealed class SingletonSafe
    {
        //This variable value will be increment by 1 each time the object of the class is created
        private static int Counter = 0;

        //This variable is going to store the Singleton Instance
        private static SingletonSafe Instance = null;

        //The following Static Method is going to return the Singleton Instance
        public static SingletonSafe GetInstance()
        {
            //This is not thread-safe
            if (Instance == null)
            {
                Instance = new SingletonSafe();
            }

            //Return the Singleton Instance
            return Instance;
        }

        private SingletonSafe()
        {
            //Each Time the Constructor is called, increment the Counter value by 1
            Counter++;
            Console.WriteLine("Counter Value " + Counter.ToString());
        }

        //The following method can be accessed from outside of the class by using the Singleton Instance
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}