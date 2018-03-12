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
        Dictionary<int, Account> _accounts;
        List<Customer> _customers;

        public Bank()
        {
            _vault = new Vault();
            _atm = new ATM();
            _teller = new Teller();
            _accounts = new Dictionary<int, Account>();
            _customers = new List<Customer>();
        }

        public Customer CreateCustomer(string username)
        {
            Customer cst = new Customer(username);
            _customers.Add(cst);
            return cst;
        }

        public Account OpenAccount(Customer cst, int accountID, int PIN, string accountName, decimal depositAmount = 0)
        {
            if (_accounts.ContainsKey(accountID))
            {
                throw new AccountInformationAlreadyUsed();
            }

            Account acct = new Account(accountID, PIN, accountName, depositAmount);
            _accounts.Add(accountID, acct);
            cst.Accounts.Add(acct);

            return acct;

        }

        public List<MoneyLib.CirculatingMoney> WithdrawFromCustomerAccount(Customer cst, int accountId, int pin, decimal amount)
        {
            if (_customers.Contains(cst) && _accounts.ContainsKey(accountId) && 
                cst.Accounts.Contains(_accounts[accountId]) && _accounts[accountId].Pin == pin)
            {
                _accounts[accountId].Withdraw(amount);
                //Withdraw from vault and return
                return new List<MoneyLib.CirculatingMoney> { new MoneyLib.Penny() };
            }
            else
            {
                return null;
            }
        }

        public decimal GetAccountBalance(Customer cst, int accountNumber)
        {
            return cst.Accounts[accountNumber].Balance;
        }
    }
}