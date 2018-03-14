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

        //dictionary of que
        Dictionary<Queue<CirculatingMoney>, CirculatingMoney> d = new Dictionary<Queue<CirculatingMoney>, CirculatingMoney>();

        

        Penny p = new Penny();
        
        








        


        //vault constructor
        public Vault()
        {
            
            

        }
        //add money to list
        public void enterVault(Queue<CirculatingMoney> queue) {

            Queue<Penny> pennyQ = new Queue<Penny>();
        }


    }//vault class
}//namespace