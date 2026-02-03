using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Observer.Notification
{
    public class ObserverMainClient
    {
        static void Main()
        {            
            var springObservers = GetObserversList();
            //Create a Product with Out of Stock Status
            Subject RedMI = new("Red MI Mobile", 652.65, "Out Of Stock");
            AddObserversToSubscription(RedMI, springObservers);
            //User Anurag will be created and the user1 object will be registered to the subject
            AddObservers(RedMI, out Observer user1, out Observer user2, out Observer user3);
            
            Console.WriteLine("Red MI Mobile current state : " + RedMI.GetAvailability());
            Console.WriteLine();
            user3.RemoveSubscriber(RedMI);
            // Now the product is available
            RedMI.SetAvailability("Available");
            user3.AddSubscriber(RedMI);
            RedMI.SetAvailability("Available on demand");
            Console.Read();
            Subject OrangeNet = new("Orange mobile", 745.29, "New arrivals");
            user1.AddSubscriber(OrangeNet);
            user2.AddSubscriber(OrangeNet);
            AddObserversToSubscription(OrangeNet, springObservers);
            OrangeNet.SetAvailability(" in your local store ");
        }

        private static void AddObserversToSubscription(Subject target, List<Observer> observers)
        {
            foreach(Observer observer in observers)
            {
                observer.AddSubscriber(target);
            }
        }

        private static void AddObservers(Subject RedMI, out Observer user1, out Observer user2, out Observer user3)
        {
            user1 = new("Anurag", "124 Anderi West");
            user1.AddSubscriber(RedMI);
            //User Pranaya will be created and the user1 object will be registered to the subject
            user2 = new("Pranaya", "23 Atola Ave");
            user2.AddSubscriber(RedMI);
            //User Priyanka will be created and the user3 object will be registered to the subject
            user3 = new("Priyanka", "3/7 Quaker rd. Tourisma");           
            user3.AddSubscriber(RedMI);
        }
        private static List<Observer> GetObserversList()
        {
            List<Observer> observers = new();
            Observer o1 = new("Fauda", "Tarablus Ave, North Yemen");
            observers.Add(o1);
            o1 = new("Satoo", "123 Ben Ali shara, Aasimat at-Tunis");
            observers.Add(o1);
            o1 = new("Fee Masr", "23 Auqaat, as-Saaba");
            observers.Add(o1);
            o1 = new("Laila", "7 Haret al-Andalus, Dimashq");
            observers.Add(o1);
            o1 = new("Zainab", "45 Salah ad-Din, Al Qahirah");
            observers.Add(o1);
            return observers;
    }
        
    }
}
