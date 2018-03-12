using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClassLibrary
{
    static class Documentation
    {
        static public void HowToCreateAccount()
        {
            //Create Bank
            Bank bank = new Bank();

            //Create Customer
            Customer customer = bank.CreateCustomer("bobby-o");

            //Create Account
            Account account = bank.OpenAccount(customer, 1234, 1234, "bobby-o checking");
        }
    }
}
