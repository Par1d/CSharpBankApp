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
    }
}