namespace CSharpBankApp
{
    partial class ForgotForm
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
            this.Forgotmain = new System.Windows.Forms.Label();
            this.ForgotEmaillbl = new System.Windows.Forms.Label();
            this.ForgotPinlbl = new System.Windows.Forms.Label();
            this.ForgotEmailtxt = new System.Windows.Forms.TextBox();
            this.ForgotPintxt = new System.Windows.Forms.TextBox();
            this.ForgotCancelbtn = new System.Windows.Forms.Button();
            this.ForgotClearbtn = new System.Windows.Forms.Button();
            this.ForgotSubmitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Forgotmain
            // 
            this.Forgotmain.AutoSize = true;
            this.Forgotmain.Location = new System.Drawing.Point(12, 9);
            this.Forgotmain.Name = "Forgotmain";
            this.Forgotmain.Size = new System.Drawing.Size(305, 13);
            this.Forgotmain.TabIndex = 0;
            this.Forgotmain.Text = "Please enter your email and PIN associated with your password";
            // 
            // ForgotEmaillbl
            // 
            this.ForgotEmaillbl.AutoSize = true;
            this.ForgotEmaillbl.Location = new System.Drawing.Point(12, 43);
            this.ForgotEmaillbl.Name = "ForgotEmaillbl";
            this.ForgotEmaillbl.Size = new System.Drawing.Size(41, 13);
            this.ForgotEmaillbl.TabIndex = 1;
            this.ForgotEmaillbl.Text = "Email : ";
            // 
            // ForgotPinlbl
            // 
            this.ForgotPinlbl.AutoSize = true;
            this.ForgotPinlbl.Location = new System.Drawing.Point(12, 78);
            this.ForgotPinlbl.Name = "ForgotPinlbl";
            this.ForgotPinlbl.Size = new System.Drawing.Size(34, 13);
            this.ForgotPinlbl.TabIndex = 2;
            this.ForgotPinlbl.Text = "PIN : ";
            // 
            // ForgotEmailtxt
            // 
            this.ForgotEmailtxt.Location = new System.Drawing.Point(59, 36);
            this.ForgotEmailtxt.Name = "ForgotEmailtxt";
            this.ForgotEmailtxt.Size = new System.Drawing.Size(258, 20);
            this.ForgotEmailtxt.TabIndex = 3;
            // 
            // ForgotPintxt
            // 
            this.ForgotPintxt.Location = new System.Drawing.Point(59, 75);
            this.ForgotPintxt.MaxLength = 4;
            this.ForgotPintxt.Name = "ForgotPintxt";
            this.ForgotPintxt.PasswordChar = '*';
            this.ForgotPintxt.Size = new System.Drawing.Size(100, 20);
            this.ForgotPintxt.TabIndex = 4;
            // 
            // ForgotCancelbtn
            // 
            this.ForgotCancelbtn.Location = new System.Drawing.Point(15, 118);
            this.ForgotCancelbtn.Name = "ForgotCancelbtn";
            this.ForgotCancelbtn.Size = new System.Drawing.Size(75, 23);
            this.ForgotCancelbtn.TabIndex = 5;
            this.ForgotCancelbtn.Text = "Cancel";
            this.ForgotCancelbtn.UseVisualStyleBackColor = true;
            this.ForgotCancelbtn.Click += new System.EventHandler(this.ForgotCancelbtn_Click);
            // 
            // ForgotClearbtn
            // 
            this.ForgotClearbtn.Location = new System.Drawing.Point(128, 118);
            this.ForgotClearbtn.Name = "ForgotClearbtn";
            this.ForgotClearbtn.Size = new System.Drawing.Size(75, 23);
            this.ForgotClearbtn.TabIndex = 6;
            this.ForgotClearbtn.Text = "Clear";
            this.ForgotClearbtn.UseVisualStyleBackColor = true;
            this.ForgotClearbtn.Click += new System.EventHandler(this.ForgotClearbtn_Click);
            // 
            // ForgotSubmitbtn
            // 
            this.ForgotSubmitbtn.Location = new System.Drawing.Point(242, 118);
            this.ForgotSubmitbtn.Name = "ForgotSubmitbtn";
            this.ForgotSubmitbtn.Size = new System.Drawing.Size(75, 23);
            this.ForgotSubmitbtn.TabIndex = 7;
            this.ForgotSubmitbtn.Text = "Submit";
            this.ForgotSubmitbtn.UseVisualStyleBackColor = true;
            this.ForgotSubmitbtn.Click += new System.EventHandler(this.ForgotSubmitbtn_Click);
            // 
            // ForgotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 153);
            this.Controls.Add(this.ForgotSubmitbtn);
            this.Controls.Add(this.ForgotClearbtn);
            this.Controls.Add(this.ForgotCancelbtn);
            this.Controls.Add(this.ForgotPintxt);
            this.Controls.Add(this.ForgotEmailtxt);
            this.Controls.Add(this.ForgotPinlbl);
            this.Controls.Add(this.ForgotEmaillbl);
            this.Controls.Add(this.Forgotmain);
            this.Name = "ForgotForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Forgotmain;
        private System.Windows.Forms.Label ForgotEmaillbl;
        private System.Windows.Forms.Label ForgotPinlbl;
        private System.Windows.Forms.TextBox ForgotEmailtxt;
        private System.Windows.Forms.TextBox ForgotPintxt;
        private System.Windows.Forms.Button ForgotCancelbtn;
        private System.Windows.Forms.Button ForgotClearbtn;
        private System.Windows.Forms.Button ForgotSubmitbtn;
    }
}