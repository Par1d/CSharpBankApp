using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClassLibrary
{
    class Account
    {
        private int _accountID;
        private int _pin;
        private string _name;
        private decimal _balance;
        List<Transaction> _history;

        public Account(int accountID, int PIN, string accountName, decimal balance = 0)
        {
            _accountID = accountID;
            _pin = PIN;
            _name = accountName;
            _balance = balance;
        }



        public void Deposit(MoneyBag money)
        {

        }

        MoneyBag Withdraw(decimal amount)
        {

        }
    }
}
