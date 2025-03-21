﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Mediator.Basic
{
    public abstract class User
    {
        public string Name;
        //This Property is going to set and get the Mediator Instance
        //This Property value is going to be set when we register a user with the Mediator
        public IFacebookGroupMediator Mediator { get; set; }

        //Initializing the name using Constructor
        public User(string name)
        {
            Name = name;
        }
        //The following Methods are going to be Implemented by the Concrete Colleague
        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}
