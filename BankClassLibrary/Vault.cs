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
        

        
        //twenty, ten, five, one, .25, .5, .1
        //SortedPile[0] = 20's
        /*SortedPile[1] = 10's
         Sorted Pile[2] = 5's
         
         Sorted Pile[3] = 2's
         Sorted Pile[4] = 1's
         Sorted Pile[5] = .25
         Sorted Pile[6] = .10
         Sorted Pile[7] = .5
         Sorted Pile[8] = .01*/
        List<List<CirculatingMoney>> SortedPile = new List<List<CirculatingMoney>>();
        
        


        public Vault() {
            
            for (int i = 0; i < 9; i++)
            {
                SortedPile.Add(new List<CirculatingMoney>());
            }

        }
        
        //Lists the money objects in the VaultMoney
        public void ListMoney() {
            //go through the outer list
            for (int i = 0; i < SortedPile.Count; i++) {
                //at each index of the outerlist print each object in the inner list
                for (int d = 0; d < SortedPile[i].Count; i++) {
                    Console.WriteLine(SortedPile[i][d]);
                }
            }
        }
        
        //add money objects to the list
        //coins
        public void addPenny(){

            SortedPile[8].Add(new Penny());
        }
        public void addNickel()
        {

            SortedPile[7].Add(new Nickel());
        }
        public void addDime()
        {

            SortedPile[6].Add(new Dime());
        }
        public void addQuarter()
        {

            SortedPile[5].Add(new Quarter());
        }
        //bills
        public void addDollarBill()
        {

            SortedPile[4].Add(new DollarBill());
        }
        public void addTwoDollar()
        {

            SortedPile[3].Add(new TwoDollarBill());
        }
        public void addFiveDollar()
        {

            SortedPile[2].Add(new FiveDollarBill());
        }
        public void addTenDollarBill()
        {
            SortedPile[1].Add(new TenDollarBill());
        }
        public void addTwentyDollarBill()
        {

            SortedPile[0].Add(new TwentyDollarBill());
        }


        //Add money
        //Remvove money
        //Get total
        //Get amount of each denomination

        
        public void addMoney(List<CirculatingMoney> Money) {
            //accept list of money objects
            //put money objects into VaultMoney

            for (int i = 0; i < Money.Count; i++) {
                //rewrite for list in lists vault UnsortedPile.Add(Money[i]);
            }

            

        }
        //next is remove money
        //request for an amount of money
       
        public List<CirculatingMoney> RemoveMoney(decimal amt) {
            //17.89
            
            /*if the  money object is in the vault
             sort list*/
             
            if (amt >= 20.0m ) {

                //go through the vault list and remove the first instance of that number
            }
            List<CirculatingMoney> list = new List<CirculatingMoney>();
            
            return list;
        }
        
    }

}