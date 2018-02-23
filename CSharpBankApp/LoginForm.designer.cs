namespace CSharpBankApp
{
    partial class LoginForm
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
            this.Usernamelbl = new System.Windows.Forms.Label();
            this.Passwordlbl = new System.Windows.Forms.Label();
            this.Usernametxt = new System.Windows.Forms.TextBox();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.Createlbl = new System.Windows.Forms.LinkLabel();
            this.Forgotlnk = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Mainlbl
            // 
            this.Mainlbl.AutoSize = true;
            this.Mainlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mainlbl.Location = new System.Drawing.Point(12, 9);
            this.Mainlbl.Name = "Mainlbl";
            this.Mainlbl.Size = new System.Drawing.Size(322, 20);
            this.Mainlbl.TabIndex = 0;
            this.Mainlbl.Text = "Please Enter Your Username And Password";
            // 
            // Usernamelbl
            // 
            this.Usernamelbl.AutoSize = true;
            this.Usernamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernamelbl.Location = new System.Drawing.Point(12, 42);
            this.Usernamelbl.Name = "Usernamelbl";
            this.Usernamelbl.Size = new System.Drawing.Size(81, 17);
            this.Usernamelbl.TabIndex = 0;
            this.Usernamelbl.Text = "Username";
            // 
            // Passwordlbl
            // 
            this.Passwordlbl.AutoSize = true;
            this.Passwordlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordlbl.Location = new System.Drawing.Point(12, 80);
            this.Passwordlbl.Name = "Passwordlbl";
            this.Passwordlbl.Size = new System.Drawing.Size(77, 17);
            this.Passwordlbl.TabIndex = 0;
            this.Passwordlbl.Text = "Password";
            // 
            // Usernametxt
            // 
            this.Usernametxt.Location = new System.Drawing.Point(121, 39);
            this.Usernametxt.Name = "Usernametxt";
            this.Usernametxt.Size = new System.Drawing.Size(189, 20);
            this.Usernametxt.TabIndex = 1;
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Location = new System.Drawing.Point(121, 77);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(189, 20);
            this.Passwordtxt.TabIndex = 2;
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelbtn.Location = new System.Drawing.Point(69, 117);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.Cancelbtn.TabIndex = 3;
            this.Cancelbtn.Text = "&Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            // 
            // Loginbtn
            // 
            this.Loginbtn.Location = new System.Drawing.Point(206, 117);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(75, 23);
            this.Loginbtn.TabIndex = 4;
            this.Loginbtn.Text = "&Login";
            this.Loginbtn.UseVisualStyleBackColor = true;
            // 
            // Createlbl
            // 
            this.Createlbl.AutoSize = true;
            this.Createlbl.Location = new System.Drawing.Point(48, 152);
            this.Createlbl.Name = "Createlbl";
            this.Createlbl.Size = new System.Drawing.Size(96, 13);
            this.Createlbl.TabIndex = 5;
            this.Createlbl.TabStop = true;
            this.Createlbl.Text = "Create an Account";
            this.Createlbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Createlbl_LinkClicked);
            // 
            // Forgotlnk
            // 
            this.Forgotlnk.AutoSize = true;
            this.Forgotlnk.Location = new System.Drawing.Point(203, 152);
            this.Forgotlnk.Name = "Forgotlnk";
            this.Forgotlnk.Size = new System.Drawing.Size(92, 13);
            this.Forgotlnk.TabIndex = 6;
            this.Forgotlnk.TabStop = true;
            this.Forgotlnk.Text = "Forgot Password?";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.Loginbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancelbtn;
            this.ClientSize = new System.Drawing.Size(350, 178);
            this.Controls.Add(this.Forgotlnk);
            this.Controls.Add(this.Createlbl);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.Usernametxt);
            this.Controls.Add(this.Passwordlbl);
            this.Controls.Add(this.Usernamelbl);
            this.Controls.Add(this.Mainlbl);
            this.Location = new System.Drawing.Point(0, 380);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Mainlbl;
        private System.Windows.Forms.Label Usernamelbl;
        private System.Windows.Forms.Label Passwordlbl;
        private System.Windows.Forms.TextBox Usernametxt;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.LinkLabel Createlbl;
        private System.Windows.Forms.LinkLabel Forgotlnk;
    }
}

