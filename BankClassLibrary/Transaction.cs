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
        private TransactionType _type;
        private decimal _amount;
        private int _accountID;

        public Transaction(int accountID, decimal amount, TransactionType type)
        {
            _date = DateTime.Now;
            _type = type;
            _amount = amount;
            _accountID = accountID;
        }

        public DateTime Date
        {
            get
            {
                return _date;
            }
        }
    }
}