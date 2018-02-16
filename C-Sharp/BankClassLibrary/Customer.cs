using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankClassLibrary
{
    public class Customer
    {
        private string _username;
        private Account _account;

        public Account UserAccount
        {
            get
            {
                return _account;
            }
            set
            {
                _account = value;
            }
        }

        public Customer(string username)
        {
            _username = username;
        }

        public void DisplayAccounts()
        {
            throw new System.NotImplementedException();
        }
    }
}