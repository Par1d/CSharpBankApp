using System;
using System.Collections.Generic;
using MoneyLib;
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

        public void EnterBank(Bank bank)
        {
            _currentVendor = bank;
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

        public List<CirculatingMoney> WithdrawFromAccount(int accountId, int pin, decimal amount)
        {
            return _currentVendor.WithdrawFromCustomerAccount(this, accountId, pin, amount);
        }
    }
}