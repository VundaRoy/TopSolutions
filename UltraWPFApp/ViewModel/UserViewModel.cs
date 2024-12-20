﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UltraWPFApp.Model;

namespace UltraWPFApp.ViewModel
{
    public class UserViewModel
    {
        private IList<User> _UsersList;

        public UserViewModel()
        {
            _UsersList = new List<User>
        {
            new User { UserId = 1, FirstName = "Raj", LastName = "Beniwal", City = "Delhi", State = "DEL", Country = "INDIA" },
            new User { UserId = 2, FirstName = "Mark", LastName = "henry", City = "New York", State = "NY", Country = "USA" },
            new User { UserId = 3, FirstName = "Mahesh", LastName = "Chand", City = "Philadelphia", State = "PA", Country = "USA" },
            new User { UserId = 4, FirstName = "Vikash", LastName = "Nanda", City = "Noida", State = "UP", Country = "INDIA" },
            new User { UserId = 5, FirstName = "Harsh", LastName = "Kumar", City = "Ghaziabad", State = "UP", Country = "INDIA" },
            new User { UserId = 6, FirstName = "Reetesh", LastName = "Tomar", City = "Mumbai", State = "MAH", Country = "INDIA" },
            new User { UserId = 7, FirstName = "Deven", LastName = "Verma", City = "Palwal", State = "HP", Country = "INDIA" },
            new User { UserId = 8, FirstName = "Ravi", LastName = "Taneja", City = "Delhi", State = "DEL", Country = "INDIA" },
            new User { UserId = 9, FirstName = "Vikram", LastName = "Ahluwala", City = "Patna", State = "BIH", Country = "INDIA" },
            new User { UserId = 10, FirstName = "Sambandhar", LastName = "Pillai", City = "Madurai", State = "TN", Country = "INDIA" },
            new User { UserId = 11, FirstName = "Abdul-Latif", LastName = "Junejo", City = "Karachi", State = "SND", Country = "PAKISTAN" },
            new User { UserId = 12, FirstName = "Khwaja", LastName = "Ahmad", City = "Abu Dhabi", State = "ABU", Country = "UAE" },
            new User { UserId = 13, FirstName = "Ricardo", LastName = "Palma", City = "Mascot", State = "NSW", Country = "AUSTRALIA" },
            new User { UserId = 14, FirstName = "Luis", LastName = "Borges", City = "Wincester", State = "QLD", Country = "AUSTRALIA" }
        };
        }

        public IList<User> Users
        {
            get { return _UsersList; }
            set { _UsersList = value; }
        }

        private ICommand mUpdater;

        public ICommand UpdateCommand
        {
            get
            {
                mUpdater ??= new Updater();
                return mUpdater;
            }
            set
            {
                mUpdater = value;
            }
        }

        private class Updater : ICommand
        {
            public bool CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter)
            {
                // Code implementation for execution
            }
        }
    }
}
