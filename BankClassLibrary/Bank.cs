using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankClassLibrary
{
    public class Bank
    {
        Vault _vault;
        ATM _atm;
        Teller _teller;
        List<Account> _accounts;
        List<Customer> _customers;

        public Bank()
        {
        
        }

        public void CreateCustomer(string username)
        {
            _customers.Add(new Customer(username));
        }

        public void OpenAccount(Customer cst, int accountID, int PIN, string accountName, decimal depositAmount)
        {
            if (depositAmount < 25m)
            {
                //Snarky comment
            } else
            {
                Account acct = new Account(accountID, PIN, accountName, depositAmount);
                _accounts.Add(acct);

            }


        }

        public decimal GetAccountBalance(Customer cst, string accountNumber)
        {
            throw new System.NotImplementedException();
        }
    }
}