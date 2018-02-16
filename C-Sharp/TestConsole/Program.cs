using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankClassLibrary;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            Customer bob = bank.CreateCustomer("bobby");
            Account myAccount = bank.OpenAccount(bob, 1234, 1234, "MyChecking", 500m);

            Console.WriteLine(bob.UserAccount.Balance);
            
            Console.ReadKey();

            Console.WriteLine();//added ;
        }
    }
}
