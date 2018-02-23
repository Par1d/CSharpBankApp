using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankClassLibrary
{
    public enum TransactionType
    {
        Withdrawal,
        Deposit
    }

    public class Transaction
    {
        private DateTime _date;
        private decimal _amount;
        private int _accountID;
        private TransactionType _type;

        public Transaction(decimal amount, int accountID, TransactionType type)
        {
            _date = DateTime.Now;
            _amount = amount;
            _accountID = accountID;
            _type = type;
        }

        public DateTime Date { get { return _date; } }
        public decimal Amount { get { return _amount; } }
        public int AccountID { get { return _accountID; } }
        public TransactionType Type { get { return _type; } }
    }
}