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
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            Loginpnl.Hide();
            Maintab.Show();
        }

        private void LoginCancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logoutlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Maintab.Hide();
            Loginpnl.Show();
        }

        private void Createlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewUserpnl.Show();
            Loginpnl.Hide();
        }

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
        
    
    }
}
