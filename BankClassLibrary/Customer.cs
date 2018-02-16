using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankClassLibrary
{
    public class Customer
    {
        private string _username;
        private int _accountID;

        public int AccountID
        {
            get
            {
                return _accountID;
            }
            set
            {
                _accountID = value;
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