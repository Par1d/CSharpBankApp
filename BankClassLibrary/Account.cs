using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClassLibrary
{
    public class Account
    {
        private int _accountID;
        private int _pin;
        private string _name;
        private decimal _balance;
        List<Transaction> _history;

        public decimal Balance
        {
            get
            {
                return _balance;
            }
        }

        public int AccountID
        {
            get
            {
                return _accountID;
            }
        }

        public List<Transaction> History
        {
            get
            {
                return _history;
            }
        }

        public Account(int accountID, int PIN, string accountName, decimal balance = 0)
        {
            _accountID = accountID;
            _pin = PIN;
            _name = accountName;
            _balance = balance;
            _history = new List<Transaction>();
        }



        public void Deposit(decimal amount)
        {
            _balance += amount;
            Transaction transaction = new Transaction(_accountID, amount, TransactionType.Deposit);
            _history.Add(transaction);
        }

        public void Withdraw(decimal amount)
        {
            _balance -= amount;
            Transaction transaction = new Transaction(_accountID, amount, TransactionType.Withdrawal);
            _history.Add(transaction);
        }
    }
}
