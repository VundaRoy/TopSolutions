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
            //Create a Product with Out of Stock Status
            Subject RedMI = new ("Red MI Mobile", 652.65, "Out Of Stock");
            //User Anurag will be created and the user1 object will be registered to the subject
            Observer user1 = new("Anurag", "124 Anderi West");
            user1.AddSubscriber(RedMI);
            //User Pranaya will be created and the user1 object will be registered to the subject
            Observer user2 = new ("Pranaya", "23 Atola Ave");
            user2.AddSubscriber(RedMI);
            //User Priyanka will be created and the user3 object will be registered to the subject
            Observer user3 = new ("Priyanka", "3/7 Quaker rd. Tourisma");
            user3.AddSubscriber(RedMI);
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
            OrangeNet.SetAvailability(" in your local store ");
        }
    }
}
