using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankClassLibrary;
using MoneyLib;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            Customer bob = bank.CreateCustomer("bobby");
            Account myAccount = bank.OpenAccount(bob, 1234, 1234, "MyChecking", 500m);
            bob.EnterBank(bank);
            bob.WithdrawFromAccount(1234, 1234, 100m);
            bob.Accounts[0].DisplayHistory();

            Console.ReadKey();
        }
    }
}
