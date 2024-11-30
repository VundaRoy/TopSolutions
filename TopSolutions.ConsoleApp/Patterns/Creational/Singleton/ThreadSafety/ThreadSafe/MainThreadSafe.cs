using SingletonDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Singleton.ThreadSafety.ThreadSafe
{
    public class MainThreadSafe
    {
        //Example to Understand Thraed-Safe Problem with Singleton Design Pattern
        //When use in a Multithreaded Environment
        static void Main(string[] args)
        {
            //The following Code will Invoke both methods Parallely using two different Threads
            Parallel.Invoke(
                //Let us Assume PrintTeacherDetails method is Invoked by Thread-1
                () => PrintTeacherDetails(),
                //Let us Assume PrintStudentDetails method is Invoked by Thread-2
                () => PrintStudentDetails()
                );
            Console.ReadLine();
        }
        private static void PrintTeacherDetails()
        {
            //Thread-1 Calling the GetInstance() Method of the Singleton class
            SingletonSafe fromTeacher = SingletonSafe.GetInstance();
            fromTeacher.PrintDetails("From Teacher");
        }
        private static void PrintStudentDetails()
        {
            //At the same time, Thread-2 also Calling the GetInstance() Method of the Singleton Class
            SingletonSafe fromStudent = SingletonSafe.GetInstance();
            fromStudent.PrintDetails("From Student");
        }
    }
}
