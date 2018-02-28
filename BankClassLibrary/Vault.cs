using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoneyLib;

namespace BankClassLibrary
{
    public class Vault
    {
        //Fund the bank
        //List of money
        //Sortable

        //Password / combination
        

        List<CirculatingMoney> VaultMoney;


        public Vault() {
            VaultMoney = new List<CirculatingMoney>();


        }
        
        //Lists the money objects in the VaultMoney
        public void ListMoney() {
            for (int i = 0; i < VaultMoney.Count; i++) {
                Console.WriteLine(VaultMoney[i].Value);
            }
        }
        //sorts the money objects in the VaultMoney
        public void SortMoney()
        {
            VaultMoney.Sort();
        }
        //add money objects to the list
        //coins
        public void addPenny(){
            
            VaultMoney.Add(new Penny());
        }
        public void addNickel()
        {
           
            VaultMoney.Add(new Nickel());
        }
        public void addDime()
        {
            
            VaultMoney.Add(new Dime());
        }
        public void addQuarter()
        {
            
            VaultMoney.Add(new Quarter());
        }
        //bills
        public void addDollarBill()
        {
            
            VaultMoney.Add(new DollarBill());
        }
        public void addTwoDollar()
        {
            
            VaultMoney.Add(new TwoDollarBill());
        }
        public void addFiveDollar()
        {
            
            VaultMoney.Add(new FiveDollarBill());
        }
        public void addTenDollarBill()
        {
            VaultMoney.Add(new TenDollarBill());
        }
        public void addTwentyDollarBill()
        {
            
            VaultMoney.Add(new TwentyDollarBill());
        }


        //Add money
        //Remvove money
        //Get total
        //Get amount of each denomination

        
        public void addMoney(List<CirculatingMoney> Money) {
            //accept list of money objects
            //put money objects into VaultMoney

            for (int i = 0; i < Money.Count; i++) {
                VaultMoney.Add(Money[i]);
            }

            

        }
        //next is remove money
        
    }

}