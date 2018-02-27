namespace CSharpBankApp
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Depositbtn = new System.Windows.Forms.Button();
            this.Withdrawbtn = new System.Windows.Forms.Button();
            this.Withdrawpnl = new System.Windows.Forms.Panel();
            this.WithdrawSubmitbtn = new System.Windows.Forms.Button();
            this.WtihdrawClearbtn = new System.Windows.Forms.Button();
            this.WithdrawCancelbtn = new System.Windows.Forms.Button();
            this.WithdrawPinVerifytxt = new System.Windows.Forms.TextBox();
            this.WithdrawPinVerifylbl = new System.Windows.Forms.Label();
            this.WithdrawPintxt = new System.Windows.Forms.TextBox();
            this.WithdrawPinlbl = new System.Windows.Forms.Label();
            this.WithdrawAmountVerifytxt = new System.Windows.Forms.TextBox();
            this.WithdrawAmountVerifylbl = new System.Windows.Forms.Label();
            this.Withdrawsecondary = new System.Windows.Forms.Label();
            this.WithdrawAmounttxt = new System.Windows.Forms.TextBox();
            this.WithdrawAmountlbl = new System.Windows.Forms.Label();
            this.WithdrawMain = new System.Windows.Forms.Label();
            this.Depositpnl = new System.Windows.Forms.Panel();
            this.DepositSubmitbtn = new System.Windows.Forms.Button();
            this.DepositClearbtn = new System.Windows.Forms.Button();
            this.DepositCancelbtn = new System.Windows.Forms.Button();
            this.DepositPinVerifytxt = new System.Windows.Forms.TextBox();
            this.DepositPinVerifylbl = new System.Windows.Forms.Label();
            this.DepositPintxt = new System.Windows.Forms.TextBox();
            this.DepositPinlbl = new System.Windows.Forms.Label();
            this.DepositAmountVerifytxt = new System.Windows.Forms.TextBox();
            this.DepositAmountVerifylbl = new System.Windows.Forms.Label();
            this.DepositAmountlbl = new System.Windows.Forms.Label();
            this.DepositAmounttxt = new System.Windows.Forms.TextBox();
            this.Depositsecondary = new System.Windows.Forms.Label();
            this.Depositmain = new System.Windows.Forms.Label();
            this.Mainlbl = new System.Windows.Forms.Label();
            this.Closebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Withdrawpnl.SuspendLayout();
            this.Depositpnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Closebtn);
            this.splitContainer1.Panel1.Controls.Add(this.Depositbtn);
            this.splitContainer1.Panel1.Controls.Add(this.Withdrawbtn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Mainlbl);
            this.splitContainer1.Panel2.Controls.Add(this.Depositpnl);
            this.splitContainer1.Panel2.Controls.Add(this.Withdrawpnl);
            this.splitContainer1.Size = new System.Drawing.Size(669, 273);
            this.splitContainer1.SplitterDistance = 156;
            this.splitContainer1.TabIndex = 0;
            // 
            // Depositbtn
            // 
            this.Depositbtn.Location = new System.Drawing.Point(36, 118);
            this.Depositbtn.Name = "Depositbtn";
            this.Depositbtn.Size = new System.Drawing.Size(75, 23);
            this.Depositbtn.TabIndex = 2;
            this.Depositbtn.Text = "&Deposit";
            this.Depositbtn.UseVisualStyleBackColor = true;
            this.Depositbtn.Click += new System.EventHandler(this.Depositbtn_Click);
            // 
            // Withdrawbtn
            // 
            this.Withdrawbtn.Location = new System.Drawing.Point(36, 81);
            this.Withdrawbtn.Name = "Withdrawbtn";
            this.Withdrawbtn.Size = new System.Drawing.Size(75, 23);
            this.Withdrawbtn.TabIndex = 1;
            this.Withdrawbtn.Text = "&Withdraw";
            this.Withdrawbtn.UseVisualStyleBackColor = true;
            this.Withdrawbtn.Click += new System.EventHandler(this.Withdrawbtn_Click);
            // 
            // Withdrawpnl
            // 
            this.Withdrawpnl.Controls.Add(this.WithdrawSubmitbtn);
            this.Withdrawpnl.Controls.Add(this.WtihdrawClearbtn);
            this.Withdrawpnl.Controls.Add(this.WithdrawCancelbtn);
            this.Withdrawpnl.Controls.Add(this.WithdrawPinVerifytxt);
            this.Withdrawpnl.Controls.Add(this.WithdrawPinVerifylbl);
            this.Withdrawpnl.Controls.Add(this.WithdrawPintxt);
            this.Withdrawpnl.Controls.Add(this.WithdrawPinlbl);
            this.Withdrawpnl.Controls.Add(this.WithdrawAmountVerifytxt);
            this.Withdrawpnl.Controls.Add(this.WithdrawAmountVerifylbl);
            this.Withdrawpnl.Controls.Add(this.Withdrawsecondary);
            this.Withdrawpnl.Controls.Add(this.WithdrawAmounttxt);
            this.Withdrawpnl.Controls.Add(this.WithdrawAmountlbl);
            this.Withdrawpnl.Controls.Add(this.WithdrawMain);
            this.Withdrawpnl.Location = new System.Drawing.Point(16, 45);
            this.Withdrawpnl.Name = "Withdrawpnl";
            this.Withdrawpnl.Size = new System.Drawing.Size(481, 203);
            this.Withdrawpnl.TabIndex = 0;
            this.Withdrawpnl.Visible = false;
            // 
            // WithdrawSubmitbtn
            // 
            this.WithdrawSubmitbtn.Location = new System.Drawing.Point(348, 167);
            this.WithdrawSubmitbtn.Name = "WithdrawSubmitbtn";
            this.WithdrawSubmitbtn.Size = new System.Drawing.Size(75, 23);
            this.WithdrawSubmitbtn.TabIndex = 7;
            this.WithdrawSubmitbtn.Text = "&Submit";
            this.WithdrawSubmitbtn.UseVisualStyleBackColor = true;
            // 
            // WtihdrawClearbtn
            // 
            this.WtihdrawClearbtn.Location = new System.Drawing.Point(204, 167);
            this.WtihdrawClearbtn.Name = "WtihdrawClearbtn";
            this.WtihdrawClearbtn.Size = new System.Drawing.Size(75, 23);
            this.WtihdrawClearbtn.TabIndex = 6;
            this.WtihdrawClearbtn.Text = "Clea&r";
            this.WtihdrawClearbtn.UseVisualStyleBackColor = true;
            // 
            // WithdrawCancelbtn
            // 
            this.WithdrawCancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.WithdrawCancelbtn.Location = new System.Drawing.Point(55, 167);
            this.WithdrawCancelbtn.Name = "WithdrawCancelbtn";
            this.WithdrawCancelbtn.Size = new System.Drawing.Size(75, 23);
            this.WithdrawCancelbtn.TabIndex = 5;
            this.WithdrawCancelbtn.Text = "&Cancel";
            this.WithdrawCancelbtn.UseVisualStyleBackColor = true;
            // 
            // WithdrawPinVerifytxt
            // 
            this.WithdrawPinVerifytxt.Location = new System.Drawing.Point(329, 116);
            this.WithdrawPinVerifytxt.MaxLength = 4;
            this.WithdrawPinVerifytxt.Name = "WithdrawPinVerifytxt";
            this.WithdrawPinVerifytxt.PasswordChar = '*';
            this.WithdrawPinVerifytxt.Size = new System.Drawing.Size(113, 20);
            this.WithdrawPinVerifytxt.TabIndex = 4;
            // 
            // WithdrawPinVerifylbl
            // 
            this.WithdrawPinVerifylbl.AutoSize = true;
            this.WithdrawPinVerifylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithdrawPinVerifylbl.Location = new System.Drawing.Point(251, 123);
            this.WithdrawPinVerifylbl.Name = "WithdrawPinVerifylbl";
            this.WithdrawPinVerifylbl.Size = new System.Drawing.Size(72, 13);
            this.WithdrawPinVerifylbl.TabIndex = 0;
            this.WithdrawPinVerifylbl.Text = "Verify PIN :";
            // 
            // WithdrawPintxt
            // 
            this.WithdrawPintxt.Location = new System.Drawing.Point(94, 116);
            this.WithdrawPintxt.MaxLength = 4;
            this.WithdrawPintxt.Name = "WithdrawPintxt";
            this.WithdrawPintxt.PasswordChar = '*';
            this.WithdrawPintxt.Size = new System.Drawing.Size(113, 20);
            this.WithdrawPintxt.TabIndex = 2;
            // 
            // WithdrawPinlbl
            // 
            this.WithdrawPinlbl.AutoSize = true;
            this.WithdrawPinlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithdrawPinlbl.Location = new System.Drawing.Point(52, 123);
            this.WithdrawPinlbl.Name = "WithdrawPinlbl";
            this.WithdrawPinlbl.Size = new System.Drawing.Size(36, 13);
            this.WithdrawPinlbl.TabIndex = 0;
            this.WithdrawPinlbl.Text = "PIN :";
            // 
            // WithdrawAmountVerifytxt
            // 
            this.WithdrawAmountVerifytxt.Location = new System.Drawing.Point(329, 75);
            this.WithdrawAmountVerifytxt.Name = "WithdrawAmountVerifytxt";
            this.WithdrawAmountVerifytxt.Size = new System.Drawing.Size(113, 20);
            this.WithdrawAmountVerifytxt.TabIndex = 3;
            // 
            // WithdrawAmountVerifylbl
            // 
            this.WithdrawAmountVerifylbl.AutoSize = true;
            this.WithdrawAmountVerifylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithdrawAmountVerifylbl.Location = new System.Drawing.Point(230, 82);
            this.WithdrawAmountVerifylbl.Name = "WithdrawAmountVerifylbl";
            this.WithdrawAmountVerifylbl.Size = new System.Drawing.Size(93, 13);
            this.WithdrawAmountVerifylbl.TabIndex = 0;
            this.WithdrawAmountVerifylbl.Text = "Verify Amount :";
            // 
            // Withdrawsecondary
            // 
            this.Withdrawsecondary.AutoSize = true;
            this.Withdrawsecondary.Location = new System.Drawing.Point(101, 49);
            this.Withdrawsecondary.Name = "Withdrawsecondary";
            this.Withdrawsecondary.Size = new System.Drawing.Size(283, 13);
            this.Withdrawsecondary.TabIndex = 0;
            this.Withdrawsecondary.Text = "Please Do Not Include The $ When Entering Your Amount";
            // 
            // WithdrawAmounttxt
            // 
            this.WithdrawAmounttxt.Location = new System.Drawing.Point(94, 75);
            this.WithdrawAmounttxt.Name = "WithdrawAmounttxt";
            this.WithdrawAmounttxt.Size = new System.Drawing.Size(113, 20);
            this.WithdrawAmounttxt.TabIndex = 1;
            // 
            // WithdrawAmountlbl
            // 
            this.WithdrawAmountlbl.AutoSize = true;
            this.WithdrawAmountlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithdrawAmountlbl.Location = new System.Drawing.Point(31, 82);
            this.WithdrawAmountlbl.Name = "WithdrawAmountlbl";
            this.WithdrawAmountlbl.Size = new System.Drawing.Size(57, 13);
            this.WithdrawAmountlbl.TabIndex = 0;
            this.WithdrawAmountlbl.Text = "Amount :";
            // 
            // WithdrawMain
            // 
            this.WithdrawMain.AutoSize = true;
            this.WithdrawMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithdrawMain.Location = new System.Drawing.Point(31, 36);
            this.WithdrawMain.Name = "WithdrawMain";
            this.WithdrawMain.Size = new System.Drawing.Size(418, 13);
            this.WithdrawMain.TabIndex = 0;
            this.WithdrawMain.Text = "Please Enter The Amount You Wish To Withdraw And Provide Your Pin For Verificatio" +
    "n";
            // 
            // Depositpnl
            // 
            this.Depositpnl.Controls.Add(this.DepositSubmitbtn);
            this.Depositpnl.Controls.Add(this.DepositClearbtn);
            this.Depositpnl.Controls.Add(this.DepositCancelbtn);
            this.Depositpnl.Controls.Add(this.DepositPinVerifytxt);
            this.Depositpnl.Controls.Add(this.DepositPinVerifylbl);
            this.Depositpnl.Controls.Add(this.DepositPintxt);
            this.Depositpnl.Controls.Add(this.DepositPinlbl);
            this.Depositpnl.Controls.Add(this.DepositAmountVerifytxt);
            this.Depositpnl.Controls.Add(this.DepositAmountVerifylbl);
            this.Depositpnl.Controls.Add(this.DepositAmountlbl);
            this.Depositpnl.Controls.Add(this.DepositAmounttxt);
            this.Depositpnl.Controls.Add(this.Depositsecondary);
            this.Depositpnl.Controls.Add(this.Depositmain);
            this.Depositpnl.Location = new System.Drawing.Point(16, 45);
            this.Depositpnl.Name = "Depositpnl";
            this.Depositpnl.Size = new System.Drawing.Size(481, 203);
            this.Depositpnl.TabIndex = 0;
            this.Depositpnl.Visible = false;
            // 
            // DepositSubmitbtn
            // 
            this.DepositSubmitbtn.Location = new System.Drawing.Point(348, 167);
            this.DepositSubmitbtn.Name = "DepositSubmitbtn";
            this.DepositSubmitbtn.Size = new System.Drawing.Size(75, 23);
            this.DepositSubmitbtn.TabIndex = 7;
            this.DepositSubmitbtn.Text = "&Submit";
            this.DepositSubmitbtn.UseVisualStyleBackColor = true;
            // 
            // DepositClearbtn
            // 
            this.DepositClearbtn.Location = new System.Drawing.Point(204, 167);
            this.DepositClearbtn.Name = "DepositClearbtn";
            this.DepositClearbtn.Size = new System.Drawing.Size(75, 23);
            this.DepositClearbtn.TabIndex = 6;
            this.DepositClearbtn.Text = "Clea&r";
            this.DepositClearbtn.UseVisualStyleBackColor = true;
            // 
            // DepositCancelbtn
            // 
            this.DepositCancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DepositCancelbtn.Location = new System.Drawing.Point(55, 167);
            this.DepositCancelbtn.Name = "DepositCancelbtn";
            this.DepositCancelbtn.Size = new System.Drawing.Size(75, 23);
            this.DepositCancelbtn.TabIndex = 5;
            this.DepositCancelbtn.Text = "&Cancel";
            this.DepositCancelbtn.UseVisualStyleBackColor = true;
            // 
            // DepositPinVerifytxt
            // 
            this.DepositPinVerifytxt.Location = new System.Drawing.Point(329, 116);
            this.DepositPinVerifytxt.MaxLength = 4;
            this.DepositPinVerifytxt.Name = "DepositPinVerifytxt";
            this.DepositPinVerifytxt.PasswordChar = '*';
            this.DepositPinVerifytxt.Size = new System.Drawing.Size(113, 20);
            this.DepositPinVerifytxt.TabIndex = 4;
            // 
            // DepositPinVerifylbl
            // 
            this.DepositPinVerifylbl.AutoSize = true;
            this.DepositPinVerifylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositPinVerifylbl.Location = new System.Drawing.Point(251, 123);
            this.DepositPinVerifylbl.Name = "DepositPinVerifylbl";
            this.DepositPinVerifylbl.Size = new System.Drawing.Size(72, 13);
            this.DepositPinVerifylbl.TabIndex = 0;
            this.DepositPinVerifylbl.Text = "Verify PIN :";
            // 
            // DepositPintxt
            // 
            this.DepositPintxt.Location = new System.Drawing.Point(94, 116);
            this.DepositPintxt.MaxLength = 4;
            this.DepositPintxt.Name = "DepositPintxt";
            this.DepositPintxt.PasswordChar = '*';
            this.DepositPintxt.Size = new System.Drawing.Size(113, 20);
            this.DepositPintxt.TabIndex = 2;
            // 
            // DepositPinlbl
            // 
            this.DepositPinlbl.AutoSize = true;
            this.DepositPinlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositPinlbl.Location = new System.Drawing.Point(52, 123);
            this.DepositPinlbl.Name = "DepositPinlbl";
            this.DepositPinlbl.Size = new System.Drawing.Size(36, 13);
            this.DepositPinlbl.TabIndex = 0;
            this.DepositPinlbl.Text = "PIN :";
            // 
            // DepositAmountVerifytxt
            // 
            this.DepositAmountVerifytxt.Location = new System.Drawing.Point(329, 75);
            this.DepositAmountVerifytxt.Name = "DepositAmountVerifytxt";
            this.DepositAmountVerifytxt.Size = new System.Drawing.Size(113, 20);
            this.DepositAmountVerifytxt.TabIndex = 3;
            // 
            // DepositAmountVerifylbl
            // 
            this.DepositAmountVerifylbl.AutoSize = true;
            this.DepositAmountVerifylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositAmountVerifylbl.Location = new System.Drawing.Point(230, 82);
            this.DepositAmountVerifylbl.Name = "DepositAmountVerifylbl";
            this.DepositAmountVerifylbl.Size = new System.Drawing.Size(93, 13);
            this.DepositAmountVerifylbl.TabIndex = 0;
            this.DepositAmountVerifylbl.Text = "Verify Amount :";
            // 
            // DepositAmountlbl
            // 
            this.DepositAmountlbl.AutoSize = true;
            this.DepositAmountlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositAmountlbl.Location = new System.Drawing.Point(31, 82);
            this.DepositAmountlbl.Name = "DepositAmountlbl";
            this.DepositAmountlbl.Size = new System.Drawing.Size(57, 13);
            this.DepositAmountlbl.TabIndex = 0;
            this.DepositAmountlbl.Text = "Amount :";
            // 
            // DepositAmounttxt
            // 
            this.DepositAmounttxt.Location = new System.Drawing.Point(94, 75);
            this.DepositAmounttxt.Name = "DepositAmounttxt";
            this.DepositAmounttxt.Size = new System.Drawing.Size(113, 20);
            this.DepositAmounttxt.TabIndex = 1;
            // 
            // Depositsecondary
            // 
            this.Depositsecondary.AutoSize = true;
            this.Depositsecondary.Location = new System.Drawing.Point(101, 49);
            this.Depositsecondary.Name = "Depositsecondary";
            this.Depositsecondary.Size = new System.Drawing.Size(283, 13);
            this.Depositsecondary.TabIndex = 0;
            this.Depositsecondary.Text = "Please Do Not Include The $ When Entering Your Amount";
            // 
            // Depositmain
            // 
            this.Depositmain.AutoSize = true;
            this.Depositmain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Depositmain.Location = new System.Drawing.Point(31, 36);
            this.Depositmain.Name = "Depositmain";
            this.Depositmain.Size = new System.Drawing.Size(409, 13);
            this.Depositmain.TabIndex = 0;
            this.Depositmain.Text = "Please Enter The Amount You Wish To Deposit And Provide Your Pin For Verification" +
    "";
            // 
            // Mainlbl
            // 
            this.Mainlbl.AutoSize = true;
            this.Mainlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mainlbl.Location = new System.Drawing.Point(23, 7);
            this.Mainlbl.Name = "Mainlbl";
            this.Mainlbl.Size = new System.Drawing.Size(472, 17);
            this.Mainlbl.TabIndex = 0;
            this.Mainlbl.Text = "Please Verify The Form You Are On Before Entering Information";
            this.Mainlbl.Visible = false;
            // 
            // Closebtn
            // 
            this.Closebtn.Location = new System.Drawing.Point(36, 225);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(75, 23);
            this.Closebtn.TabIndex = 3;
            this.Closebtn.Text = "Close";
            this.Closebtn.UseVisualStyleBackColor = true;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 273);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Withdrawpnl.ResumeLayout(false);
            this.Withdrawpnl.PerformLayout();
            this.Depositpnl.ResumeLayout(false);
            this.Depositpnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button WithdrawSubmitbtn;
        private System.Windows.Forms.Button WtihdrawClearbtn;
        private System.Windows.Forms.Button WithdrawCancelbtn;
        private System.Windows.Forms.TextBox WithdrawPinVerifytxt;
        private System.Windows.Forms.Label WithdrawPinVerifylbl;
        private System.Windows.Forms.TextBox WithdrawPintxt;
        private System.Windows.Forms.Label WithdrawPinlbl;
        private System.Windows.Forms.TextBox WithdrawAmountVerifytxt;
        private System.Windows.Forms.Label WithdrawAmountVerifylbl;
        private System.Windows.Forms.Label Withdrawsecondary;
        private System.Windows.Forms.TextBox WithdrawAmounttxt;
        private System.Windows.Forms.Label WithdrawAmountlbl;
        private System.Windows.Forms.Label WithdrawMain;
        private System.Windows.Forms.Button Withdrawbtn;
        public System.Windows.Forms.Panel Withdrawpnl;
        private System.Windows.Forms.Button Depositbtn;
        private System.Windows.Forms.Panel Depositpnl;
        private System.Windows.Forms.Button DepositSubmitbtn;
        private System.Windows.Forms.Button DepositClearbtn;
        private System.Windows.Forms.Button DepositCancelbtn;
        private System.Windows.Forms.TextBox DepositPinVerifytxt;
        private System.Windows.Forms.Label DepositPinVerifylbl;
        private System.Windows.Forms.TextBox DepositPintxt;
        private System.Windows.Forms.Label DepositPinlbl;
        private System.Windows.Forms.TextBox DepositAmountVerifytxt;
        private System.Windows.Forms.Label DepositAmountVerifylbl;
        private System.Windows.Forms.Label DepositAmountlbl;
        private System.Windows.Forms.TextBox DepositAmounttxt;
        private System.Windows.Forms.Label Depositsecondary;
        private System.Windows.Forms.Label Depositmain;
        private System.Windows.Forms.Label Mainlbl;
        private System.Windows.Forms.Button Closebtn;
    }
}