using TopSolutions.ConsoleApp.OOP.Inheritance.MultiLevel.Contracts;

namespace TopSolutions.ConsoleApp.OOP.Inheritance.MultiLevel
{
    public class Cat : IFeliformia
    {
        public string Name { get; set; }
        public void NightVision()
        {
            Console.WriteLine("Cats have excellent night vision.");
        }
        public void RetractileClaws()
        {
            Console.WriteLine("Cats have retractile claws.");
        }
        public void Purring()
        {
            Console.WriteLine("Cats can purr.");
        }
        public void Hunt()
        {
            Console.WriteLine("Cats are skilled hunters.");
        }
        public void EatMeat()
        {
            Console.WriteLine("Cats are obligate carnivores and eat meat.");
        }
        public void MakeSound()
        {
            Console.WriteLine("Meow");
        }
        public void Sleep()
        {
            Console.WriteLine("Cats sleep for a significant portion of the day.");
        }
        public void Walk()
        {
            Console.WriteLine("Cats walk gracefully.");
        }
        public void NurseYoung()
        {
            Console.WriteLine("Cats nurse their young.");
        }
        public void Eat()
        {
            Console.WriteLine("Cats eat their food.");
        }


    }
}
