namespace TopSolutions.ConsoleApp.GeneralCSharp.Basics.Equals
{
    public class EqualMain
    {
        public static void Main()
        {
            // Using == operator
            int a = 5;
            int b = 5;
            Console.WriteLine($"Using '==': {a == b}"); // True
            // Using Equals() method
            string str1 = "Hello";
            string str2 = "Hello";
            Console.WriteLine($"Using Equals(): {str1.Equals(str2)}"); // True
            // Comparing reference types
            object obj1 = new ();
            object obj2 = new ();
            Console.WriteLine($"Reference comparison using '==': {obj1 == obj2}"); // False
            Console.WriteLine($"Reference comparison using Equals(): {obj1.Equals(obj2)}"); // False
            // Comparing custom objects
            Person person1 = new ("Alice");
            Person person2 = new ("Alice");
            Console.WriteLine($"Custom object comparison using '==': {person1 == person2}"); // False
            Console.WriteLine($"Custom object comparison using Equals(): {person1.Equals(person2)}"); // True
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public override bool Equals(object obj)
        {
            if (obj is Person other)
            {
                return this.Name == other.Name;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
