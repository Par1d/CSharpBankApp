using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using BankClassLibrary;
using System.Timers;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            Customer bob = bank.CreateCustomer("bobby");
            Account bobAcct1 = bank.OpenAccount(bob, 1234, 1234, "My Checking", 200m);
            Account bobAcct2 = bank.OpenAccount(bob, 1222, 1222, "My Savings", 100m);

            Console.WriteLine(bob.TotalOfAllAccounts.ToString("c"));
            
        }
    }
}
