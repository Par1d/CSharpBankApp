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
            bob.WithdrawFromAccount(1234, 1234, 200m);
            bob.Accounts[0].DisplayHistory();
            
            
            
            
            //messing with queue below
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            Vault v = new Vault();
            Queue<CirculatingMoney> q = new Queue<CirculatingMoney>();

            Dime n = new Dime(); // n is the variable containing a dime
            int a = n.GetHashCode(); //dime hashcode is a

            q.Enqueue(new Penny());
            q.Enqueue(new Penny());
            q.Enqueue(new Dime());
            
            

            Console.WriteLine(q.Count);
            // Console.WriteLine(q.Peek());

            //check to see if there is a dime in the queue
             if (q.Contains(1))
             {
                 Console.WriteLine("the queue has a dime");
             }
             else {
                 Console.WriteLine("there is no dime");

             }
            //take off objects in queue
            int s = q.Count;
            for (int i = 0; i < s; i++) {
                Console.WriteLine(q.Dequeue().Value + " this is the " + i +" object");
                

            }
            Console.WriteLine(q.Count +" number of objects in queue");
            v.enterVault(q);
            Console.ReadKey();
        }

        IComparable penny = new Penny();
    }
}
