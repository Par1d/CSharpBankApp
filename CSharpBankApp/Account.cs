using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyLib;


namespace CSharpBankApp
{
    public class Account
    {
        //FIELDS
        private string accountName = "";
        private decimal totalAmount = 20.0m;
        private int pin = 1;

        //CONSTRUCTOR
        public Account(int pin) { this.Pin = pin; } //test

        public Account(string accountName, decimal totalAmount, int pin)
        {
            this.AccountName = accountName;

        }

        //PROPERTIES 
        public string AccountName
        {
            get { return accountName; }
            set { accountName = value; }
        }

        public decimal TotalAmount
        {
            get { return totalAmount; }
            set { totalAmount = value; }
        }

        public int Pin
        {
            get { return pin; }
            set { pin = value; }
        }

        //METHODS
        public bool Deposit(decimal amount)
        {
            totalAmount += amount;
            return true;

        }

        public List<Money> Withdraw(decimal withdrawAmount) //add dll to fix
        {
            List<Money> money = new List<Money>();


            //use new objects not references
            //CirculatingMoney p = new Penny();

            /* money.Add(p);
             money.Add(p);


             Console.WriteLine(money[0].Value);
             Console.WriteLine(money[1].Value);

             Console.WriteLine(money[0].Value + money[1].Value);*/



            //amount is the decimal passed into the withdraw method
            //totalAmount is the class field variable
            //newTotal = totalAmount - amount

            decimal newTotal = totalAmount;

            if (withdrawAmount <= totalAmount)
            {

                totalAmount -= withdrawAmount;

            }





            while (withdrawAmount >= 0)
            {
                //bills
                if (withdrawAmount >= 20.0m)
                {
                    withdrawAmount -= 20.0m;
                    money.Add(new TwentyDollarBill());
                }
                else if (withdrawAmount >= 10.0m)
                {
                    withdrawAmount -= 10.0m;
                    money.Add(new TenDollarBill());
                }
                else if (withdrawAmount >= 5.0m)
                {
                    withdrawAmount -= 5.0m;
                    money.Add(new TenDollarBill());
                }
                else if (withdrawAmount >= 2.0m)
                {
                    withdrawAmount -= 2.0m;
                    money.Add(new TenDollarBill());
                }
                else if (withdrawAmount >= 1.0m)
                {
                    withdrawAmount -= 1.0m;
                    money.Add(new TenDollarBill());
                }
                //coins

                //SilverDollar handler 
                /*else if (withdrawAmount >= 1.0m)
                {
                    withdrawAmount -= 10.0m;
                    money.Add(new TenDollarBill());
                }*/

                else if (withdrawAmount >= 0.25m)
                {
                    withdrawAmount -= 0.25m;
                    money.Add(new Quarter());
                }
                else if (withdrawAmount >= 0.10m)
                {
                    withdrawAmount -= 0.10m;
                    money.Add(new Dime());
                }
                else if (withdrawAmount >= 0.05m)
                {
                    withdrawAmount -= 0.05m;
                    money.Add(new Nickel());
                }
                else if (withdrawAmount >= .01m)
                {
                    withdrawAmount -= 0.01m;
                    money.Add(new Penny());
                }
            }

            return money;
        }

        public bool Save()
        {
            return true;
        }

    }
}
