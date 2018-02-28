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
            this.maintab = new System.Windows.Forms.TabControl();
            this.dashboardtab = new System.Windows.Forms.TabPage();
            this.logoutlbl = new System.Windows.Forms.LinkLabel();
            this.withdrawtab = new System.Windows.Forms.TabPage();
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
            this.deposittab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.balancelbl = new System.Windows.Forms.Label();
            this.balancetxt = new System.Windows.Forms.TextBox();
            this.maintab.SuspendLayout();
            this.dashboardtab.SuspendLayout();
            this.withdrawtab.SuspendLayout();
            this.deposittab.SuspendLayout();
            this.SuspendLayout();
            // 
            // maintab
            // 
            this.maintab.Controls.Add(this.dashboardtab);
            this.maintab.Controls.Add(this.withdrawtab);
            this.maintab.Controls.Add(this.deposittab);
            this.maintab.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.maintab.Location = new System.Drawing.Point(12, 12);
            this.maintab.Name = "maintab";
            this.maintab.SelectedIndex = 0;
            this.maintab.Size = new System.Drawing.Size(446, 195);
            this.maintab.TabIndex = 0;
            // 
            // dashboardtab
            // 
            this.dashboardtab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dashboardtab.Controls.Add(this.balancetxt);
            this.dashboardtab.Controls.Add(this.balancelbl);
            this.dashboardtab.Controls.Add(this.logoutlbl);
            this.dashboardtab.Location = new System.Drawing.Point(4, 22);
            this.dashboardtab.Name = "dashboardtab";
            this.dashboardtab.Padding = new System.Windows.Forms.Padding(3);
            this.dashboardtab.Size = new System.Drawing.Size(438, 169);
            this.dashboardtab.TabIndex = 0;
            this.dashboardtab.Text = "Dashboard";
            this.dashboardtab.UseVisualStyleBackColor = true;
            // 
            // logoutlbl
            // 
            this.logoutlbl.AutoSize = true;
            this.logoutlbl.Location = new System.Drawing.Point(6, 151);
            this.logoutlbl.Name = "logoutlbl";
            this.logoutlbl.Size = new System.Drawing.Size(45, 13);
            this.logoutlbl.TabIndex = 0;
            this.logoutlbl.TabStop = true;
            this.logoutlbl.Text = "Log Out";
            this.logoutlbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // withdrawtab
            // 
            this.withdrawtab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.withdrawtab.Controls.Add(this.Submitbtn);
            this.withdrawtab.Controls.Add(this.Clearbtn);
            this.withdrawtab.Controls.Add(this.Cancelbtn);
            this.withdrawtab.Controls.Add(this.VerifyPintxt);
            this.withdrawtab.Controls.Add(this.VerifyPinlbl);
            this.withdrawtab.Controls.Add(this.Pintxt);
            this.withdrawtab.Controls.Add(this.Pinlbl);
            this.withdrawtab.Controls.Add(this.VerifyAmounttxt);
            this.withdrawtab.Controls.Add(this.VerifyAmountlbl);
            this.withdrawtab.Controls.Add(this.Secondarylbl);
            this.withdrawtab.Controls.Add(this.Amounttxt);
            this.withdrawtab.Controls.Add(this.Amountlbl);
            this.withdrawtab.Controls.Add(this.Mainlbl);
            this.withdrawtab.Location = new System.Drawing.Point(4, 22);
            this.withdrawtab.Name = "withdrawtab";
            this.withdrawtab.Padding = new System.Windows.Forms.Padding(3);
            this.withdrawtab.Size = new System.Drawing.Size(438, 169);
            this.withdrawtab.TabIndex = 1;
            this.withdrawtab.Text = "Withdraw";
            this.withdrawtab.UseVisualStyleBackColor = true;
            // 
            // Submitbtn
            // 
            this.Submitbtn.Location = new System.Drawing.Point(323, 134);
            this.Submitbtn.Name = "Submitbtn";
            this.Submitbtn.Size = new System.Drawing.Size(75, 23);
            this.Submitbtn.TabIndex = 20;
            this.Submitbtn.Text = "&Submit";
            this.Submitbtn.UseVisualStyleBackColor = true;
            // 
            // Clearbtn
            // 
            this.Clearbtn.Location = new System.Drawing.Point(179, 134);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(75, 23);
            this.Clearbtn.TabIndex = 19;
            this.Clearbtn.Text = "Clea&r";
            this.Clearbtn.UseVisualStyleBackColor = true;
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelbtn.Location = new System.Drawing.Point(30, 134);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.Cancelbtn.TabIndex = 18;
            this.Cancelbtn.Text = "&Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            // 
            // VerifyPintxt
            // 
            this.VerifyPintxt.Location = new System.Drawing.Point(304, 83);
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
            this.VerifyPinlbl.Location = new System.Drawing.Point(226, 90);
            this.VerifyPinlbl.Name = "VerifyPinlbl";
            this.VerifyPinlbl.Size = new System.Drawing.Size(72, 13);
            this.VerifyPinlbl.TabIndex = 8;
            this.VerifyPinlbl.Text = "Verify PIN :";
            // 
            // Pintxt
            // 
            this.Pintxt.Location = new System.Drawing.Point(69, 83);
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
            this.Pinlbl.Location = new System.Drawing.Point(27, 90);
            this.Pinlbl.Name = "Pinlbl";
            this.Pinlbl.Size = new System.Drawing.Size(36, 13);
            this.Pinlbl.TabIndex = 9;
            this.Pinlbl.Text = "PIN :";
            // 
            // VerifyAmounttxt
            // 
            this.VerifyAmounttxt.Location = new System.Drawing.Point(304, 42);
            this.VerifyAmounttxt.Name = "VerifyAmounttxt";
            this.VerifyAmounttxt.Size = new System.Drawing.Size(113, 20);
            this.VerifyAmounttxt.TabIndex = 15;
            // 
            // VerifyAmountlbl
            // 
            this.VerifyAmountlbl.AutoSize = true;
            this.VerifyAmountlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyAmountlbl.Location = new System.Drawing.Point(205, 49);
            this.VerifyAmountlbl.Name = "VerifyAmountlbl";
            this.VerifyAmountlbl.Size = new System.Drawing.Size(93, 13);
            this.VerifyAmountlbl.TabIndex = 10;
            this.VerifyAmountlbl.Text = "Verify Amount :";
            // 
            // Secondarylbl
            // 
            this.Secondarylbl.AutoSize = true;
            this.Secondarylbl.Location = new System.Drawing.Point(76, 16);
            this.Secondarylbl.Name = "Secondarylbl";
            this.Secondarylbl.Size = new System.Drawing.Size(283, 13);
            this.Secondarylbl.TabIndex = 11;
            this.Secondarylbl.Text = "Please Do Not Include The $ When Entering Your Amount";
            // 
            // Amounttxt
            // 
            this.Amounttxt.Location = new System.Drawing.Point(69, 42);
            this.Amounttxt.Name = "Amounttxt";
            this.Amounttxt.Size = new System.Drawing.Size(113, 20);
            this.Amounttxt.TabIndex = 14;
            // 
            // Amountlbl
            // 
            this.Amountlbl.AutoSize = true;
            this.Amountlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amountlbl.Location = new System.Drawing.Point(6, 49);
            this.Amountlbl.Name = "Amountlbl";
            this.Amountlbl.Size = new System.Drawing.Size(57, 13);
            this.Amountlbl.TabIndex = 12;
            this.Amountlbl.Text = "Amount :";
            // 
            // Mainlbl
            // 
            this.Mainlbl.AutoSize = true;
            this.Mainlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mainlbl.Location = new System.Drawing.Point(6, 3);
            this.Mainlbl.Name = "Mainlbl";
            this.Mainlbl.Size = new System.Drawing.Size(418, 13);
            this.Mainlbl.TabIndex = 13;
            this.Mainlbl.Text = "Please Enter The Amount You Wish To Withdraw And Provide Your Pin For Verificatio" +
    "n";
            // 
            // deposittab
            // 
            this.deposittab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deposittab.Controls.Add(this.button1);
            this.deposittab.Controls.Add(this.button2);
            this.deposittab.Controls.Add(this.button3);
            this.deposittab.Controls.Add(this.textBox1);
            this.deposittab.Controls.Add(this.label1);
            this.deposittab.Controls.Add(this.textBox2);
            this.deposittab.Controls.Add(this.label2);
            this.deposittab.Controls.Add(this.textBox3);
            this.deposittab.Controls.Add(this.label3);
            this.deposittab.Controls.Add(this.label4);
            this.deposittab.Controls.Add(this.textBox4);
            this.deposittab.Controls.Add(this.label5);
            this.deposittab.Controls.Add(this.label6);
            this.deposittab.Location = new System.Drawing.Point(4, 22);
            this.deposittab.Name = "deposittab";
            this.deposittab.Padding = new System.Windows.Forms.Padding(3);
            this.deposittab.Size = new System.Drawing.Size(438, 169);
            this.deposittab.TabIndex = 2;
            this.deposittab.Text = "Deposit";
            this.deposittab.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "&Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Clea&r";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(30, 134);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "&Cancel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(304, 83);
            this.textBox1.MaxLength = 4;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Verify PIN :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(69, 83);
            this.textBox2.MaxLength = 4;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(113, 20);
            this.textBox2.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "PIN :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(304, 42);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(113, 20);
            this.textBox3.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Verify Amount :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Amount :";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(69, 42);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(113, 20);
            this.textBox4.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Please Do Not Include The $ When Entering Your Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(409, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Please Enter The Amount You Wish To Deposit And Provide Your Pin For Verification" +
    "";
            // 
            // balancelbl
            // 
            this.balancelbl.AutoSize = true;
            this.balancelbl.Location = new System.Drawing.Point(6, 110);
            this.balancelbl.Name = "balancelbl";
            this.balancelbl.Size = new System.Drawing.Size(89, 13);
            this.balancelbl.TabIndex = 0;
            this.balancelbl.Text = "Account Balance";
            // 
            // balancetxt
            // 
            this.balancetxt.Location = new System.Drawing.Point(101, 103);
            this.balancetxt.Name = "balancetxt";
            this.balancetxt.ReadOnly = true;
            this.balancetxt.Size = new System.Drawing.Size(100, 20);
            this.balancetxt.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 219);
            this.Controls.Add(this.maintab);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Dashboard";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.maintab.ResumeLayout(false);
            this.dashboardtab.ResumeLayout(false);
            this.dashboardtab.PerformLayout();
            this.withdrawtab.ResumeLayout(false);
            this.withdrawtab.PerformLayout();
            this.deposittab.ResumeLayout(false);
            this.deposittab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl maintab;
        private System.Windows.Forms.TabPage dashboardtab;
        private System.Windows.Forms.TabPage withdrawtab;
        private System.Windows.Forms.LinkLabel logoutlbl;
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
        private System.Windows.Forms.TabPage deposittab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox balancetxt;
        private System.Windows.Forms.Label balancelbl;
    }
}