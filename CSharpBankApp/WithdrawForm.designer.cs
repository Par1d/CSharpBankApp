namespace Withdraw
{
    partial class WithdrawForm
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
            this.Mainlbl = new System.Windows.Forms.Label();
            this.Amountlbl = new System.Windows.Forms.Label();
            this.Amounttxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VerifyAmountlbl = new System.Windows.Forms.Label();
            this.VerifyAmounttxt = new System.Windows.Forms.TextBox();
            this.Pinlbl = new System.Windows.Forms.Label();
            this.Pintxt = new System.Windows.Forms.TextBox();
            this.VerifyPinlbl = new System.Windows.Forms.Label();
            this.VerifyPintxt = new System.Windows.Forms.TextBox();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.Submitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Mainlbl
            // 
            this.Mainlbl.AutoSize = true;
            this.Mainlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mainlbl.Location = new System.Drawing.Point(21, 9);
            this.Mainlbl.Name = "Mainlbl";
            this.Mainlbl.Size = new System.Drawing.Size(416, 13);
            this.Mainlbl.TabIndex = 0;
            this.Mainlbl.Text = "Please Enter The Amount You With To Withdraw And Provide Your Pin For Verificatio" +
    "n";
            // 
            // Amountlbl
            // 
            this.Amountlbl.AutoSize = true;
            this.Amountlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amountlbl.Location = new System.Drawing.Point(21, 55);
            this.Amountlbl.Name = "Amountlbl";
            this.Amountlbl.Size = new System.Drawing.Size(57, 13);
            this.Amountlbl.TabIndex = 0;
            this.Amountlbl.Text = "Amount :";
            // 
            // Amounttxt
            // 
            this.Amounttxt.Location = new System.Drawing.Point(84, 48);
            this.Amounttxt.Name = "Amounttxt";
            this.Amounttxt.Size = new System.Drawing.Size(113, 20);
            this.Amounttxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please Do Not Include The $ When Entering Your Amount";
            // 
            // VerifyAmountlbl
            // 
            this.VerifyAmountlbl.AutoSize = true;
            this.VerifyAmountlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyAmountlbl.Location = new System.Drawing.Point(220, 55);
            this.VerifyAmountlbl.Name = "VerifyAmountlbl";
            this.VerifyAmountlbl.Size = new System.Drawing.Size(93, 13);
            this.VerifyAmountlbl.TabIndex = 0;
            this.VerifyAmountlbl.Text = "Verify Amount :";
            // 
            // VerifyAmounttxt
            // 
            this.VerifyAmounttxt.Location = new System.Drawing.Point(319, 48);
            this.VerifyAmounttxt.Name = "VerifyAmounttxt";
            this.VerifyAmounttxt.Size = new System.Drawing.Size(113, 20);
            this.VerifyAmounttxt.TabIndex = 2;
            // 
            // Pinlbl
            // 
            this.Pinlbl.AutoSize = true;
            this.Pinlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pinlbl.Location = new System.Drawing.Point(42, 96);
            this.Pinlbl.Name = "Pinlbl";
            this.Pinlbl.Size = new System.Drawing.Size(36, 13);
            this.Pinlbl.TabIndex = 0;
            this.Pinlbl.Text = "PIN :";
            // 
            // Pintxt
            // 
            this.Pintxt.Location = new System.Drawing.Point(84, 89);
            this.Pintxt.MaxLength = 4;
            this.Pintxt.Name = "Pintxt";
            this.Pintxt.PasswordChar = '*';
            this.Pintxt.Size = new System.Drawing.Size(113, 20);
            this.Pintxt.TabIndex = 3;
            // 
            // VerifyPinlbl
            // 
            this.VerifyPinlbl.AutoSize = true;
            this.VerifyPinlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyPinlbl.Location = new System.Drawing.Point(241, 96);
            this.VerifyPinlbl.Name = "VerifyPinlbl";
            this.VerifyPinlbl.Size = new System.Drawing.Size(72, 13);
            this.VerifyPinlbl.TabIndex = 0;
            this.VerifyPinlbl.Text = "Verify PIN :";
            // 
            // VerifyPintxt
            // 
            this.VerifyPintxt.Location = new System.Drawing.Point(319, 89);
            this.VerifyPintxt.MaxLength = 4;
            this.VerifyPintxt.Name = "VerifyPintxt";
            this.VerifyPintxt.PasswordChar = '*';
            this.VerifyPintxt.Size = new System.Drawing.Size(113, 20);
            this.VerifyPintxt.TabIndex = 4;
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Location = new System.Drawing.Point(45, 140);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.Cancelbtn.TabIndex = 5;
            this.Cancelbtn.Text = "&Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            // 
            // Clearbtn
            // 
            this.Clearbtn.Location = new System.Drawing.Point(194, 140);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(75, 23);
            this.Clearbtn.TabIndex = 6;
            this.Clearbtn.Text = "Clea&r";
            this.Clearbtn.UseVisualStyleBackColor = true;
            // 
            // Submitbtn
            // 
            this.Submitbtn.Location = new System.Drawing.Point(338, 140);
            this.Submitbtn.Name = "Submitbtn";
            this.Submitbtn.Size = new System.Drawing.Size(75, 23);
            this.Submitbtn.TabIndex = 7;
            this.Submitbtn.Text = "&Submit";
            this.Submitbtn.UseVisualStyleBackColor = true;
            // 
            // WithdrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 187);
            this.Controls.Add(this.Submitbtn);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.VerifyPintxt);
            this.Controls.Add(this.VerifyPinlbl);
            this.Controls.Add(this.Pintxt);
            this.Controls.Add(this.Pinlbl);
            this.Controls.Add(this.VerifyAmounttxt);
            this.Controls.Add(this.VerifyAmountlbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Amounttxt);
            this.Controls.Add(this.Amountlbl);
            this.Controls.Add(this.Mainlbl);
            this.Name = "WithdrawForm";
            this.Text = "Withdrawal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Mainlbl;
        private System.Windows.Forms.Label Amountlbl;
        private System.Windows.Forms.TextBox Amounttxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label VerifyAmountlbl;
        private System.Windows.Forms.TextBox VerifyAmounttxt;
        private System.Windows.Forms.Label Pinlbl;
        private System.Windows.Forms.TextBox Pintxt;
        private System.Windows.Forms.Label VerifyPinlbl;
        private System.Windows.Forms.TextBox VerifyPintxt;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Button Submitbtn;
    }
}

