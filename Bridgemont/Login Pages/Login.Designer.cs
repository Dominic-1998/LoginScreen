namespace Bridgemont
{
    partial class Login
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
            this.textbox_Username = new System.Windows.Forms.TextBox();
            this.textbox_Password = new System.Windows.Forms.TextBox();
            this.linklabel_Register = new System.Windows.Forms.LinkLabel();
            this.picturebox_Lorry = new System.Windows.Forms.PictureBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.label_Username = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.linklabel_ForgotPassword = new System.Windows.Forms.LinkLabel();
            this.label_NeedAnAccount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_Lorry)).BeginInit();
            this.SuspendLayout();
            // 
            // textbox_Username
            // 
            this.textbox_Username.BackColor = System.Drawing.SystemColors.Window;
            this.textbox_Username.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Username.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textbox_Username.Location = new System.Drawing.Point(12, 27);
            this.textbox_Username.MaxLength = 30;
            this.textbox_Username.Name = "textbox_Username";
            this.textbox_Username.Size = new System.Drawing.Size(300, 22);
            this.textbox_Username.TabIndex = 0;
            this.textbox_Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_Username_KeyPress);
            // 
            // textbox_Password
            // 
            this.textbox_Password.BackColor = System.Drawing.SystemColors.Window;
            this.textbox_Password.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Password.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textbox_Password.Location = new System.Drawing.Point(12, 71);
            this.textbox_Password.MaxLength = 250;
            this.textbox_Password.Name = "textbox_Password";
            this.textbox_Password.Size = new System.Drawing.Size(300, 22);
            this.textbox_Password.TabIndex = 1;
            this.textbox_Password.UseSystemPasswordChar = true;
            // 
            // linklabel_Register
            // 
            this.linklabel_Register.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.linklabel_Register.AutoSize = true;
            this.linklabel_Register.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklabel_Register.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linklabel_Register.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linklabel_Register.Location = new System.Drawing.Point(121, 168);
            this.linklabel_Register.Name = "linklabel_Register";
            this.linklabel_Register.Size = new System.Drawing.Size(56, 16);
            this.linklabel_Register.TabIndex = 4;
            this.linklabel_Register.TabStop = true;
            this.linklabel_Register.Text = "Register";
            this.linklabel_Register.VisitedLinkColor = System.Drawing.SystemColors.Highlight;
            this.linklabel_Register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklabel_Register_Click);
            // 
            // picturebox_Lorry
            // 
            this.picturebox_Lorry.Image = global::Bridgemont.Properties.Resources.Homepage;
            this.picturebox_Lorry.Location = new System.Drawing.Point(162, -29);
            this.picturebox_Lorry.Name = "picturebox_Lorry";
            this.picturebox_Lorry.Size = new System.Drawing.Size(584, 261);
            this.picturebox_Lorry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebox_Lorry.TabIndex = 3;
            this.picturebox_Lorry.TabStop = false;
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.SkyBlue;
            this.button_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Login.FlatAppearance.BorderSize = 0;
            this.button_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.button_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_Login.Location = new System.Drawing.Point(12, 115);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(300, 50);
            this.button_Login.TabIndex = 7;
            this.button_Login.TabStop = false;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label_Username.Location = new System.Drawing.Point(12, 8);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(67, 16);
            this.label_Username.TabIndex = 8;
            this.label_Username.Text = "Username";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label_Password.Location = new System.Drawing.Point(12, 52);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(65, 16);
            this.label_Password.TabIndex = 9;
            this.label_Password.Text = "Password";
            // 
            // linklabel_ForgotPassword
            // 
            this.linklabel_ForgotPassword.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.linklabel_ForgotPassword.AutoSize = true;
            this.linklabel_ForgotPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklabel_ForgotPassword.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linklabel_ForgotPassword.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linklabel_ForgotPassword.Location = new System.Drawing.Point(9, 96);
            this.linklabel_ForgotPassword.Name = "linklabel_ForgotPassword";
            this.linklabel_ForgotPassword.Size = new System.Drawing.Size(140, 16);
            this.linklabel_ForgotPassword.TabIndex = 10;
            this.linklabel_ForgotPassword.TabStop = true;
            this.linklabel_ForgotPassword.Text = "Forgot your password?";
            this.linklabel_ForgotPassword.VisitedLinkColor = System.Drawing.SystemColors.Highlight;
            this.linklabel_ForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklabel_ForgotPassword_LinkClicked);
            // 
            // label_NeedAnAccount
            // 
            this.label_NeedAnAccount.AutoSize = true;
            this.label_NeedAnAccount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NeedAnAccount.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label_NeedAnAccount.Location = new System.Drawing.Point(12, 168);
            this.label_NeedAnAccount.Name = "label_NeedAnAccount";
            this.label_NeedAnAccount.Size = new System.Drawing.Size(113, 16);
            this.label_NeedAnAccount.TabIndex = 11;
            this.label_NeedAnAccount.Text = "Need an account?";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(517, 193);
            this.Controls.Add(this.label_NeedAnAccount);
            this.Controls.Add(this.linklabel_ForgotPassword);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.linklabel_Register);
            this.Controls.Add(this.textbox_Password);
            this.Controls.Add(this.textbox_Username);
            this.Controls.Add(this.picturebox_Lorry);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_Lorry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_Username;
        private System.Windows.Forms.TextBox textbox_Password;
        private System.Windows.Forms.PictureBox picturebox_Lorry;
        private System.Windows.Forms.LinkLabel linklabel_Register;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.LinkLabel linklabel_ForgotPassword;
        private System.Windows.Forms.Label label_NeedAnAccount;
    }
}

