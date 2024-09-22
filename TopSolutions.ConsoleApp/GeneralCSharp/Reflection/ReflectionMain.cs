using System.Diagnostics;
using System.Reflection;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Reflection
{
    public class ReflectionMain
    {
        static void Main(string[] args)
        {
            var MyAssembly = Assembly.LoadFile(@"C:\source\etc\core\TopSolutions\SuperbLibrary\bin\Debug\net6.0\SuperbLibrary.dll");
                        
            try
            {
                foreach (var type in MyAssembly.GetTypes())
                {
                    Console.WriteLine(type.FullName);
                }

                var MyType = MyAssembly.GetType("SuperbLibrary.SuberbClass");
                dynamic MyObject = Activator.CreateInstance(MyType);
                Type parameterType = MyObject.GetType();

                //Get all public fields
                Console.WriteLine("All public fields");
                foreach (MemberInfo memberInfo in parameterType.GetFields())
                {
                    Console.WriteLine(memberInfo.Name);
                }
                //get all public methods
                Console.WriteLine("All public methods");
                foreach (MemberInfo memberInfo in parameterType.GetMethods())
                {
                    Console.WriteLine(memberInfo.Name);
                }
                //get all public properties
                Console.WriteLine("All public properties");
                foreach (MemberInfo memberInfo in parameterType.GetProperties())
                {
                    Console.WriteLine(memberInfo.Name);
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}
