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

        /// <summary>
        /// Creates a customer and registers it with the bank
        /// </summary>
        /// <param name="username">Human friendly username</param>
        /// <returns>A new customer object</returns>
        public Customer CreateCustomer(string username)
        {
            Customer cst = new Customer(username);
            _customers.Add(cst);
            return cst;
        }

        /// <summary>
        /// Opens account with the bank and assigns it to a customer
        /// </summary>
        /// <param name="cst">Owner of the account</param>
        /// <param name="accountID">Unique identifier for account</param>
        /// <param name="PIN">Passcode to use the account</param>
        /// <param name="accountName">Human friendly name for account</param>
        /// <param name="depositAmount">Initial deposit amount</param>
        /// <returns>A new account object</returns>
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

        /// <summary>
        /// Withdraws money from the specified account and returns money from the vault
        /// </summary>
        /// <param name="cst">The owner of the account</param>
        /// <param name="accountId">Unique identifier of existing account</param>
        /// <param name="pin">Passcode for existing account</param>
        /// <param name="amount">Amount of money to be withdrawan from account</param>
        /// <returns>A list of circulating money representing the amount that was withdrawn</returns>
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
    }
}