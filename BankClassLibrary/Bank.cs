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
            _vault = new Vault();
            _atm = new ATM();
            _teller = new Teller();
            _accounts = new List<Account>();
            _customers = new List<Customer>();
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
                _accounts.Add(acct);
                cst.UserAccount = acct;

                return acct;
            }


        }

        public decimal GetAccountBalance(Customer cst, string accountNumber)
        {
            throw new System.NotImplementedException();
        }
    }
}