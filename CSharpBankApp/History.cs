using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBankApp
{
    /// <summary>
    /// A record of a withdrawal or deposit into an account
    /// </summary>
    class History
    {
        private string username = "";

        private decimal money1 = 0m;

        private DateTime date;

        private string accountname = "";

        private bool isDeposit;
        private bool isWithdrawl;


        public History(string username, decimal money1, string Accountname)
        {
            this.username = username;
            this.money1 = money1;
            this.date = DateTime.Now;
            this.accountname = Accountname;

            if (money1 > 0)
            {
                isDeposit = true;
                isWithdrawl = false;
            }
            else
            {
                isDeposit = false;
                isWithdrawl = true;
            }


        }

        public History(string username, decimal money1, string Accountname, DateTime date)
        {
            this.username = username;
            this.money1 = money1;
            this.date = date;
            this.accountname = Accountname;

            if (money1 > 0)
            {
                isDeposit = true;
                isWithdrawl = false;
            }
            else
            {
                isDeposit = false;
                isWithdrawl = true;
            }
        }

        /// <summary>
        /// User who the transaction belongs to
        /// </summary>
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        /// <summary>
        /// Amount of money that is involved in the transaction
        /// </summary>
        public decimal Money1
        {
            get
            {
                return money1;
            }
        }

        /// <summary>
        /// Date and time of transaction
        /// </summary>
        public DateTime Date
        {
            get
            {
                return date;
            }
        }

        /// <summary>
        /// Account that the transaction belongs to
        /// </summary>
        public string AccountName
        {
            get
            {
                return accountname;
            }
            set
            {
                accountname = value;
            }
        }

        /// <summary>
        /// Is the transaction a deposit
        /// </summary>
        public bool IsDeposit
        {
            get
            {
                return isDeposit;
            }
        }

        /// <summary>
        /// Is the transaciton a withdrawal
        /// </summary>
        public bool IsWithdrawal
        {
            get
            {
                return isWithdrawl;
            }
        }



        bool Save()
        {
            //David ToDo
            return true;
        }
    }
}
