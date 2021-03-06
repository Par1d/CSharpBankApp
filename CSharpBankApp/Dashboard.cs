﻿using System;
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
        #region Dashboard App



        #region Dashboard Form Stuff



        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
        }


        #endregion Dashboard Form Stuff



        #region Log In Form



        private void Loginbtn_Click(object sender, EventArgs e)
        {
            Loginpnl.Hide();
            Maintab.Show();
        }

        private void LoginCancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Createlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewUserpnl.Show();
            Loginpnl.Hide();
        }

        private void Forgotlnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ForgotForm().Show();
        }



        #endregion Log In Form



        #region New User Form



        private void NewUserCancel_Click(object sender, EventArgs e)
        {
            NewUserpnl.Hide();
            Loginpnl.Show();
        }

        private void NewUserSubmit_Click(object sender, EventArgs e)
        {
            NewUserpnl.Hide();
            Loginpnl.Show();
        }

        private void NewUserClear_Click(object sender, EventArgs e)
        {
            Firsttxt.Clear(); Middletxt.Clear(); Lasttxt.Clear();
            NewUsernametxt.Clear(); NewPasswordtxt.Clear();
            NewPasswordVerifytxt.Clear(); Mailingtxt.Clear();
            MailingCitytxt.Clear(); Physicaltxt.Clear(); PhysicalCitytxt.Clear();
            Hometxt.Clear(); Worktxt.Clear(); Celltxt.Clear(); CreatePintxt.Clear();
            CreatePinVerifytxt.Clear(); Emailtxt.Clear(); EmailVerifytxt.Clear();
            Questiontxt.Clear(); Answertxt.Clear();
        }

        private void AddressCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (AddressCheck.Checked)
            {
                Physicaltxt.ReadOnly = true;
                PhysicalCitytxt.ReadOnly = true;
            }
            else
            {
                Physicaltxt.ReadOnly = false;
                PhysicalCitytxt.ReadOnly = false;
            }
        }



        #endregion New User Form



        #region Dashboard Tab


        private void Logoutlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Maintab.Hide();
            Loginpnl.Show();
        }


        #endregion Dashboard Tab



        #region Withdraw Tab



        private void WithdrawCancelbtn_Click(object sender, EventArgs e)
        {
            dashboardtab.Show();
            withdrawtab.Hide();
            deposittab.Hide();
            historytab.Hide();

        }

        private void WithdrawClearbtn_Click(object sender, EventArgs e)
        {
            WithdrawAmounttxt.Clear();
            WithdrawAmountVerifytxt.Clear();
            WithdrawPintxt.Clear();
            WithdrawPinVerifytxt.Clear();
        }

        private void WithdrawSubmitbtn_Click(object sender, EventArgs e)
        {
            WithdrawAmounttxt.Clear();
            WithdrawAmountVerifytxt.Clear();
            WithdrawPintxt.Clear();
            WithdrawPinVerifytxt.Clear();
            System.Windows.Forms.MessageBox.Show("Thank You for Your Withdrawl!");
        }



        #endregion Withdraw Tab



        #region Deposit Tab



        private void DepositCancelbtn_Click(object sender, EventArgs e)
        {
            deposittab.Hide();
            withdrawtab.Hide();
            dashboardtab.Show();
            historytab.Hide();
        }

        private void DepositClearbtn_Click(object sender, EventArgs e)
        {
            DepositAmounttxt.Clear();
            DepositAmountVerifytxt.Clear();
            DepositPintxt.Clear();
            DepositPinVerifytxt.Clear();
        }

        private void DepositSubmitbtn_Click(object sender, EventArgs e)
        {
            DepositAmounttxt.Clear();
            DepositAmountVerifytxt.Clear();
            DepositPintxt.Clear();
            DepositPinVerifytxt.Clear();
            System.Windows.Forms.MessageBox.Show("Thank You for Your Deposit!");
        }



        #endregion Deposit Tab



        #region History Tab


        private void HistoryCancelbtn_Click(object sender, EventArgs e)
        {
            dashboardtab.Show();
            historytab.Hide();
            withdrawtab.Hide();
            deposittab.Hide();
        }

        private void HistoryConfirmbtn_Click(object sender, EventArgs e)
        {
            new HistoryForm().Show();
        }

        private void HistorySelector_DateSelected(object sender, System.Windows.Forms.DateRangeEventArgs e)
        {
            this.DateVerify.Text = "Date Selected: Start = " +
                e.Start.ToShortDateString() + " : End = " + e.End.ToShortDateString();
        }

        private void HistorySelector_DateChanged(object sender, System.Windows.Forms.DateRangeEventArgs e)
        {
            this.DateVerify.Text = "Date Changed: Start =  " +
                e.Start.ToShortDateString() + " : End = " + e.End.ToShortDateString();
        }




        #endregion History Tab

        #endregion Dashboard App

    }
}