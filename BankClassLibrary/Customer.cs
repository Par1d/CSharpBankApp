using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankClassLibrary
{
    public class Customer
    {
        private string _username;
        private List<Account> _accounts;
        private Bank _currentVendor;

        public List<Account> Accounts
        {
            get
            {
                return _accounts;
            }
            set
            {
                _accounts = value;
            }
        }

        public decimal TotalOfAllAccounts
        {
            get
            {
                decimal total = 0m;
                foreach (Account acct in _accounts)
                {
                    total += acct.Balance;
                }

                return total;
            }
        }


        public Customer(string username)
        {
            _username = username;
            _accounts = new List<Account>();
        }

        
        public void DisplayAccounts()
        {
            throw new System.NotImplementedException();
        }
    }
}