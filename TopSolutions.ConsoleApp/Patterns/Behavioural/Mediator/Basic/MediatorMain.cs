using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Mediator.Basic
{
    public class MediatorMain
    {
        public static void Main(string[] args)
        {
            //Create an Instance of Mediator i.e. Creating a Facebook Group
            IFacebookGroupMediator facebookMediator = new ConcreteFacebookGroupMediator();
            //Create instances of Colleague i.e. Creating users
            User Ram = new ConcreteUser("Ram");
            User Dave = new ConcreteUser("Dave");
            User Smith = new ConcreteUser("Smith");
            User Rajesh = new ConcreteUser("Rajesh");
            User Sam = new ConcreteUser("Sam");
            User Pam = new ConcreteUser("Pam");
            User Anurag = new ConcreteUser("Anurag");
            User John = new ConcreteUser("John");
            User Kramer = new ConcreteUser("Kramer");
            //Registering the users with the Mediator i.e. Facebook Group
            facebookMediator.RegisterUser(Ram);
            facebookMediator.RegisterUser(Dave);
            facebookMediator.RegisterUser(Smith);
            facebookMediator.RegisterUser(Rajesh);
            facebookMediator.RegisterUser(Sam);
            facebookMediator.RegisterUser(Pam);
            facebookMediator.RegisterUser(Anurag);
            facebookMediator.RegisterUser(John);
            facebookMediator.RegisterUser(Kramer);
            //One of the users Sending one Message in the Facebook Group
            Dave.Send("dotnettutorials.net - this website is very good to learn Design Pattern");
            Console.WriteLine();
            //Another user Sending another Message in the Facebook Group
            Rajesh.Send("What is Design Patterns? Please explain ");
            Console.WriteLine();
            John.Send("It is what it is");
            Console.WriteLine();
            Pam.Receive("Yesterday was fine");
            Anurag.Mediator.QuitGroup(Anurag);
            John.Send("Who else is here?");
            Anurag.Receive("Got it!");
            Console.Read();
        }
    }
}
