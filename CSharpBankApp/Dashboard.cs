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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void LogInlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form LoginForm = new LoginForm();
            DialogResult selectedButton = LoginForm.ShowDialog();
            if (selectedButton == DialogResult.OK)
            {
                LogInlbl.Hide();
                maintab.Show();
            }
        }
    }
}
