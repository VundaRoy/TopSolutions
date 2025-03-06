using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Mediator.Basic
{
    public class ConcreteFacebookGroupMediator : IFacebookGroupMediator
    {
        //The following variable is going to hold the list of objects to whom we want to communicate
        private List<User> UsersList = new List<User>();

        public void QuitGroup(User user)
        {
            UsersList.Remove(user);
            Console.WriteLine($"{user.Name} has just left the chat");
            user.Mediator = this;
        }

        //The following method simply registers the user with Mediator
        public void RegisterUser(User user)
        {
            //Adding the user
            UsersList.Add(user);
            //Registering the user with Mediator
            user.Mediator = this;
        }
        //The following method is going to send the message in the group i.e. to the group users
        public void SendMessage(string message, User user)
        {
            foreach (User u in UsersList)
            {
                //Message should not be received by the user sending it
                if (u != user)
                {
                    u.Receive(message);
                }
            }
        }
        
    }
}
