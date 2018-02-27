using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBankApp
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            new LoginForm().Show();
        }


        /// Hides the Withdraw Panel and Shows the Deposit Panel
        private void Depositbtn_Click(object sender, EventArgs e)
        {
            Depositpnl.Show();
            Mainlbl.Show();
            Withdrawpnl.Hide();
        }

        /// Hides the Deposit Panel and Shows the Withdraw Panel
        private void Withdrawbtn_Click(object sender, EventArgs e)
        {
            Withdrawpnl.Show();
            Mainlbl.Show();
            Depositpnl.Hide();
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DepositCancelbtn_Click(object sender, EventArgs e)
        {
            Depositpnl.Hide();
            Mainlbl.Hide();
        }

        private void WithdrawCancelbtn_Click(object sender, EventArgs e)
        {
            Withdrawpnl.Hide();
            Mainlbl.Hide();
        }

        private void DepositClearbtn_Click(object sender, EventArgs e)
        {
            DepositAmounttxt.Clear();
            DepositAmountVerifytxt.Clear();
            DepositPintxt.Clear();
            DepositPinVerifytxt.Clear();
        }

        private void WtihdrawClearbtn_Click(object sender, EventArgs e)
        {
            WithdrawAmounttxt.Clear();
            WithdrawAmountVerifytxt.Clear();
            WithdrawPintxt.Clear();
            WithdrawPinVerifytxt.Clear();
        }
    }
}
