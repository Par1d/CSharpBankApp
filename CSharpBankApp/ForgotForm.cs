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
    public partial class ForgotForm : Form
    {
        public ForgotForm()
        {
            InitializeComponent();
        }


        #region Forgot Form Stuff


        private void ForgotClearbtn_Click(object sender, EventArgs e)
        {
            ForgotEmailtxt.Clear();
            ForgotPintxt.Clear();
        }

        private void ForgotCancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ForgotSubmitbtn_Click(object sender, EventArgs e)
        {
            ForgotPintxt.Clear();
            ForgotEmailtxt.Clear();
            var Confirmation = System.Windows.Forms.MessageBox.Show("An Email Containing Your Password Has Been Sent To You");
            this.Close();
        }

        #endregion Forgot Form Stuff
    }
}
