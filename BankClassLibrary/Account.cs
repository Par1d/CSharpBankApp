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

        public Account(int accountID, int PIN, string accountName, decimal balance = 0)
        {
            _accountID = accountID;
            _pin = PIN;
            _name = accountName;
            _balance = balance;
            _history = new List<Transaction>();
        }

        public int AccountID { get { return _accountID; } }
        public int Pin { get { return _pin; } }
        public string Name { get { return _name; } }
        public decimal Balance { get { return _balance; } }
        public List<Transaction> History { get { return _history; } }

        /// <summary>
        /// Deposits a decimal amount into the account's balance and records the history
        /// </summary>
        /// <param name="amount">The amount to be deposited into the account</param>
        public void Deposit(decimal amount)
        {
            Transaction transaction = new Transaction(amount, _accountID, TransactionType.Deposit);
            _history.Add(transaction);
            _balance += amount;
        }

        /// <summary>
        /// Withdraws a decimal amount from the account's balance and records the history
        /// </summary>
        /// <param name="amount">The amount to be withdrawan from the account</param>
        public void Withdraw(decimal amount)
        {
            if (amount > _balance)
            {
                throw new InsufficientFundsException();
            }
            else
            {
                Transaction transaction = new Transaction(amount, _accountID, TransactionType.Withdrawal);
                _history.Add(transaction);
                _balance -= amount;
            }
        }

        /// <summary>
        /// Displays the accounts history to the console
        /// </summary>
        public void DisplayHistory()
        {
            Console.WriteLine("{0}{1}{2}{3}", "Type:".PadRight(15), "Account:".PadRight(15), "Amount:".PadRight(15), "Date:");
            foreach (Transaction i in _history)
            {
                Console.WriteLine("{0}{1}{2}{3}", i.Type.ToString().PadRight(15),
                    i.AccountID.ToString().PadRight(15), i.Amount.ToString("c").PadRight(15), i.Date);
            }
        }
    }
}
