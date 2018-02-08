using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClassLibrary
{
    public class Account
    {
        private string _accountID;
        private int _ownerID;
        private string _pin;
        private string _description;
        private AccountType _type;
        private decimal Balance;
        List<Transaction> History;

        public Account(string accountID, string PIN)
        {

        }

        public void Deposit(MoneyBag money)
        {

        }

        MoneyBag Withdraw(decimal amount)
        {

        }
    }
}
