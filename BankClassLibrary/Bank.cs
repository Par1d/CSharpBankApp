using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankClassLibrary
{
    public class Bank
    {
        private Vault _vault;
        private ATM _atm;
        private Teller _teller;
        private Dictionary<int, Account> _accounts;
        private List<Customer> _customers;

        public Bank()
        {
            _vault = new Vault();
            _atm = new ATM();
            _teller = new Teller();
            _accounts = new Dictionary<int, Account>();
            _customers = new List<Customer>();
        }

        public Dictionary<int, Account> Accounts
        {
            get
            {
                return _accounts;
            }
        }

        public Customer CreateCustomer(string username)
        {
            Customer cst = new Customer(username);
            _customers.Add(cst);
            return cst;
        }

        public Account OpenAccount(Customer cst, int accountID, int PIN, string accountName, decimal depositAmount)
        {
            if (depositAmount < 25)
            {
                //Snarky comment
                return null;
            }
            else
            {
                Account acct = new Account(accountID, PIN, accountName, depositAmount);
                _accounts.Add(accountID, acct);
                cst.AccountID = accountID;

                return acct;
            }


        }

        public decimal GetAccountBalance(Customer cst, int accountID)
        {
            throw new NotImplementedException();
        }
    }
}