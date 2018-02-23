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
            this.Withdrawbtn = new System.Windows.Forms.Button();
            this.Withdrawpnl = new System.Windows.Forms.Panel();
            this.Submitbtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.VerifyPintxt = new System.Windows.Forms.TextBox();
            this.VerifyPinlbl = new System.Windows.Forms.Label();
            this.Pintxt = new System.Windows.Forms.TextBox();
            this.Pinlbl = new System.Windows.Forms.Label();
            this.VerifyAmounttxt = new System.Windows.Forms.TextBox();
            this.VerifyAmountlbl = new System.Windows.Forms.Label();
            this.Secondarylbl = new System.Windows.Forms.Label();
            this.Amounttxt = new System.Windows.Forms.TextBox();
            this.Amountlbl = new System.Windows.Forms.Label();
            this.Mainlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Withdrawpnl.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.Withdrawbtn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Withdrawpnl);
            this.splitContainer1.Size = new System.Drawing.Size(669, 322);
            this.splitContainer1.SplitterDistance = 156;
            this.splitContainer1.TabIndex = 0;
            // 
            // Withdrawbtn
            // 
            this.Withdrawbtn.Location = new System.Drawing.Point(41, 81);
            this.Withdrawbtn.Name = "Withdrawbtn";
            this.Withdrawbtn.Size = new System.Drawing.Size(75, 23);
            this.Withdrawbtn.TabIndex = 1;
            this.Withdrawbtn.Text = "Withdraw";
            this.Withdrawbtn.UseVisualStyleBackColor = true;
            this.Withdrawbtn.Click += new System.EventHandler(this.Withdrawbtn_Click);
            // 
            // Withdrawpnl
            // 
            this.Withdrawpnl.Controls.Add(this.Submitbtn);
            this.Withdrawpnl.Controls.Add(this.Clearbtn);
            this.Withdrawpnl.Controls.Add(this.Cancelbtn);
            this.Withdrawpnl.Controls.Add(this.VerifyPintxt);
            this.Withdrawpnl.Controls.Add(this.VerifyPinlbl);
            this.Withdrawpnl.Controls.Add(this.Pintxt);
            this.Withdrawpnl.Controls.Add(this.Pinlbl);
            this.Withdrawpnl.Controls.Add(this.VerifyAmounttxt);
            this.Withdrawpnl.Controls.Add(this.VerifyAmountlbl);
            this.Withdrawpnl.Controls.Add(this.Secondarylbl);
            this.Withdrawpnl.Controls.Add(this.Amounttxt);
            this.Withdrawpnl.Controls.Add(this.Amountlbl);
            this.Withdrawpnl.Controls.Add(this.Mainlbl);
            this.Withdrawpnl.Location = new System.Drawing.Point(16, 45);
            this.Withdrawpnl.Name = "Withdrawpnl";
            this.Withdrawpnl.Size = new System.Drawing.Size(481, 226);
            this.Withdrawpnl.TabIndex = 0;
            this.Withdrawpnl.Visible = false;
            // 
            // Submitbtn
            // 
            this.Submitbtn.Location = new System.Drawing.Point(348, 167);
            this.Submitbtn.Name = "Submitbtn";
            this.Submitbtn.Size = new System.Drawing.Size(75, 23);
            this.Submitbtn.TabIndex = 20;
            this.Submitbtn.Text = "&Submit";
            this.Submitbtn.UseVisualStyleBackColor = true;
            // 
            // Clearbtn
            // 
            this.Clearbtn.Location = new System.Drawing.Point(204, 167);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(75, 23);
            this.Clearbtn.TabIndex = 19;
            this.Clearbtn.Text = "Clea&r";
            this.Clearbtn.UseVisualStyleBackColor = true;
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelbtn.Location = new System.Drawing.Point(55, 167);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.Cancelbtn.TabIndex = 18;
            this.Cancelbtn.Text = "&Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            // 
            // VerifyPintxt
            // 
            this.VerifyPintxt.Location = new System.Drawing.Point(329, 116);
            this.VerifyPintxt.MaxLength = 4;
            this.VerifyPintxt.Name = "VerifyPintxt";
            this.VerifyPintxt.PasswordChar = '*';
            this.VerifyPintxt.Size = new System.Drawing.Size(113, 20);
            this.VerifyPintxt.TabIndex = 17;
            // 
            // VerifyPinlbl
            // 
            this.VerifyPinlbl.AutoSize = true;
            this.VerifyPinlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyPinlbl.Location = new System.Drawing.Point(251, 123);
            this.VerifyPinlbl.Name = "VerifyPinlbl";
            this.VerifyPinlbl.Size = new System.Drawing.Size(72, 13);
            this.VerifyPinlbl.TabIndex = 8;
            this.VerifyPinlbl.Text = "Verify PIN :";
            // 
            // Pintxt
            // 
            this.Pintxt.Location = new System.Drawing.Point(94, 116);
            this.Pintxt.MaxLength = 4;
            this.Pintxt.Name = "Pintxt";
            this.Pintxt.PasswordChar = '*';
            this.Pintxt.Size = new System.Drawing.Size(113, 20);
            this.Pintxt.TabIndex = 16;
            // 
            // Pinlbl
            // 
            this.Pinlbl.AutoSize = true;
            this.Pinlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pinlbl.Location = new System.Drawing.Point(52, 123);
            this.Pinlbl.Name = "Pinlbl";
            this.Pinlbl.Size = new System.Drawing.Size(36, 13);
            this.Pinlbl.TabIndex = 9;
            this.Pinlbl.Text = "PIN :";
            // 
            // VerifyAmounttxt
            // 
            this.VerifyAmounttxt.Location = new System.Drawing.Point(329, 75);
            this.VerifyAmounttxt.Name = "VerifyAmounttxt";
            this.VerifyAmounttxt.Size = new System.Drawing.Size(113, 20);
            this.VerifyAmounttxt.TabIndex = 15;
            // 
            // VerifyAmountlbl
            // 
            this.VerifyAmountlbl.AutoSize = true;
            this.VerifyAmountlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyAmountlbl.Location = new System.Drawing.Point(230, 82);
            this.VerifyAmountlbl.Name = "VerifyAmountlbl";
            this.VerifyAmountlbl.Size = new System.Drawing.Size(93, 13);
            this.VerifyAmountlbl.TabIndex = 10;
            this.VerifyAmountlbl.Text = "Verify Amount :";
            // 
            // Secondarylbl
            // 
            this.Secondarylbl.AutoSize = true;
            this.Secondarylbl.Location = new System.Drawing.Point(101, 49);
            this.Secondarylbl.Name = "Secondarylbl";
            this.Secondarylbl.Size = new System.Drawing.Size(283, 13);
            this.Secondarylbl.TabIndex = 11;
            this.Secondarylbl.Text = "Please Do Not Include The $ When Entering Your Amount";
            // 
            // Amounttxt
            // 
            this.Amounttxt.Location = new System.Drawing.Point(94, 75);
            this.Amounttxt.Name = "Amounttxt";
            this.Amounttxt.Size = new System.Drawing.Size(113, 20);
            this.Amounttxt.TabIndex = 14;
            // 
            // Amountlbl
            // 
            this.Amountlbl.AutoSize = true;
            this.Amountlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amountlbl.Location = new System.Drawing.Point(31, 82);
            this.Amountlbl.Name = "Amountlbl";
            this.Amountlbl.Size = new System.Drawing.Size(57, 13);
            this.Amountlbl.TabIndex = 12;
            this.Amountlbl.Text = "Amount :";
            // 
            // Mainlbl
            // 
            this.Mainlbl.AutoSize = true;
            this.Mainlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mainlbl.Location = new System.Drawing.Point(31, 36);
            this.Mainlbl.Name = "Mainlbl";
            this.Mainlbl.Size = new System.Drawing.Size(418, 13);
            this.Mainlbl.TabIndex = 13;
            this.Mainlbl.Text = "Please Enter The Amount You Wish To Withdraw And Provide Your Pin For Verificatio" +
    "n";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 322);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Withdrawpnl.ResumeLayout(false);
            this.Withdrawpnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Submitbtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.TextBox VerifyPintxt;
        private System.Windows.Forms.Label VerifyPinlbl;
        private System.Windows.Forms.TextBox Pintxt;
        private System.Windows.Forms.Label Pinlbl;
        private System.Windows.Forms.TextBox VerifyAmounttxt;
        private System.Windows.Forms.Label VerifyAmountlbl;
        private System.Windows.Forms.Label Secondarylbl;
        private System.Windows.Forms.TextBox Amounttxt;
        private System.Windows.Forms.Label Amountlbl;
        private System.Windows.Forms.Label Mainlbl;
        private System.Windows.Forms.Button Withdrawbtn;
        public System.Windows.Forms.Panel Withdrawpnl;
    }
}