﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Structural.Proxy.Employment
{
    public class Employee
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public Employee(string username, string password, string role)
        {
            Username = username;
            Password = password;
            Role = role;
        }
    }
}
