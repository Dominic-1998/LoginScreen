namespace Bridgemont
{
    partial class CreateAccount
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
            this.label_Username = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.textbox_Password = new System.Windows.Forms.TextBox();
            this.label_RetypePassword = new System.Windows.Forms.Label();
            this.combobox_UserGroup = new System.Windows.Forms.ComboBox();
            this.label_FullName = new System.Windows.Forms.Label();
            this.textbox_RetypePassword = new System.Windows.Forms.TextBox();
            this.button_Continue = new System.Windows.Forms.Button();
            this.label_Email = new System.Windows.Forms.Label();
            this.textbox_FullName = new System.Windows.Forms.TextBox();
            this.label_UserGroup = new System.Windows.Forms.Label();
            this.textbox_Email = new System.Windows.Forms.TextBox();
            this.linklabel_AlreadyHaveAccount = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textbox_Username
            // 
            this.textbox_Username.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Username.Location = new System.Drawing.Point(12, 27);
            this.textbox_Username.MaxLength = 32;
            this.textbox_Username.Name = "textbox_Username";
            this.textbox_Username.Size = new System.Drawing.Size(300, 22);
            this.textbox_Username.TabIndex = 0;
            this.textbox_Username.Tag = "";
            this.textbox_Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_Username_KeyPress);
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label_Username.Location = new System.Drawing.Point(12, 8);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(67, 16);
            this.label_Username.TabIndex = 1;
            this.label_Username.Text = "Username";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label_Password.Location = new System.Drawing.Point(12, 56);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(65, 16);
            this.label_Password.TabIndex = 3;
            this.label_Password.Text = "Password";
            // 
            // textbox_Password
            // 
            this.textbox_Password.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Password.Location = new System.Drawing.Point(12, 75);
            this.textbox_Password.MaxLength = 100;
            this.textbox_Password.Name = "textbox_Password";
            this.textbox_Password.Size = new System.Drawing.Size(300, 22);
            this.textbox_Password.TabIndex = 1;
            this.textbox_Password.UseSystemPasswordChar = true;
            // 
            // label_RetypePassword
            // 
            this.label_RetypePassword.AutoSize = true;
            this.label_RetypePassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RetypePassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label_RetypePassword.Location = new System.Drawing.Point(12, 104);
            this.label_RetypePassword.Name = "label_RetypePassword";
            this.label_RetypePassword.Size = new System.Drawing.Size(110, 16);
            this.label_RetypePassword.TabIndex = 7;
            this.label_RetypePassword.Text = "Retype Password";
            // 
            // combobox_UserGroup
            // 
            this.combobox_UserGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combobox_UserGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_UserGroup.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox_UserGroup.FormattingEnabled = true;
            this.combobox_UserGroup.Items.AddRange(new object[] {
            "Admin",
            "User",
            "Guest"});
            this.combobox_UserGroup.Location = new System.Drawing.Point(12, 267);
            this.combobox_UserGroup.Name = "combobox_UserGroup";
            this.combobox_UserGroup.Size = new System.Drawing.Size(300, 24);
            this.combobox_UserGroup.TabIndex = 5;
            // 
            // label_FullName
            // 
            this.label_FullName.AutoSize = true;
            this.label_FullName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FullName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label_FullName.Location = new System.Drawing.Point(12, 152);
            this.label_FullName.Name = "label_FullName";
            this.label_FullName.Size = new System.Drawing.Size(67, 16);
            this.label_FullName.TabIndex = 5;
            this.label_FullName.Text = "Full Name";
            // 
            // textbox_RetypePassword
            // 
            this.textbox_RetypePassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_RetypePassword.Location = new System.Drawing.Point(12, 123);
            this.textbox_RetypePassword.MaxLength = 100;
            this.textbox_RetypePassword.Name = "textbox_RetypePassword";
            this.textbox_RetypePassword.Size = new System.Drawing.Size(300, 22);
            this.textbox_RetypePassword.TabIndex = 2;
            this.textbox_RetypePassword.UseSystemPasswordChar = true;
            // 
            // button_Continue
            // 
            this.button_Continue.BackColor = System.Drawing.Color.SkyBlue;
            this.button_Continue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Continue.FlatAppearance.BorderSize = 0;
            this.button_Continue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.button_Continue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_Continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Continue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Continue.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_Continue.Location = new System.Drawing.Point(12, 310);
            this.button_Continue.Name = "button_Continue";
            this.button_Continue.Size = new System.Drawing.Size(300, 50);
            this.button_Continue.TabIndex = 6;
            this.button_Continue.TabStop = false;
            this.button_Continue.Text = "Continue";
            this.button_Continue.UseVisualStyleBackColor = false;
            this.button_Continue.Click += new System.EventHandler(this.button_Continue_Click);
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label_Email.Location = new System.Drawing.Point(12, 200);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(41, 16);
            this.label_Email.TabIndex = 12;
            this.label_Email.Text = "Email";
            // 
            // textbox_FullName
            // 
            this.textbox_FullName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_FullName.Location = new System.Drawing.Point(12, 171);
            this.textbox_FullName.MaxLength = 100;
            this.textbox_FullName.Name = "textbox_FullName";
            this.textbox_FullName.Size = new System.Drawing.Size(300, 22);
            this.textbox_FullName.TabIndex = 3;
            this.textbox_FullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_FullName_KeyPress);
            // 
            // label_UserGroup
            // 
            this.label_UserGroup.AutoSize = true;
            this.label_UserGroup.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserGroup.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label_UserGroup.Location = new System.Drawing.Point(12, 248);
            this.label_UserGroup.Name = "label_UserGroup";
            this.label_UserGroup.Size = new System.Drawing.Size(74, 16);
            this.label_UserGroup.TabIndex = 14;
            this.label_UserGroup.Text = "User Group";
            // 
            // textbox_Email
            // 
            this.textbox_Email.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Email.Location = new System.Drawing.Point(12, 219);
            this.textbox_Email.MaxLength = 100;
            this.textbox_Email.Name = "textbox_Email";
            this.textbox_Email.Size = new System.Drawing.Size(300, 22);
            this.textbox_Email.TabIndex = 4;
            // 
            // linklabel_AlreadyHaveAccount
            // 
            this.linklabel_AlreadyHaveAccount.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.linklabel_AlreadyHaveAccount.AutoSize = true;
            this.linklabel_AlreadyHaveAccount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklabel_AlreadyHaveAccount.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linklabel_AlreadyHaveAccount.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linklabel_AlreadyHaveAccount.Location = new System.Drawing.Point(12, 367);
            this.linklabel_AlreadyHaveAccount.Name = "linklabel_AlreadyHaveAccount";
            this.linklabel_AlreadyHaveAccount.Size = new System.Drawing.Size(157, 16);
            this.linklabel_AlreadyHaveAccount.TabIndex = 15;
            this.linklabel_AlreadyHaveAccount.TabStop = true;
            this.linklabel_AlreadyHaveAccount.Text = "Already have an account?";
            this.linklabel_AlreadyHaveAccount.VisitedLinkColor = System.Drawing.SystemColors.Highlight;
            this.linklabel_AlreadyHaveAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklabel_AlreadyHaveAccount_LinkClicked);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(325, 392);
            this.Controls.Add(this.linklabel_AlreadyHaveAccount);
            this.Controls.Add(this.label_UserGroup);
            this.Controls.Add(this.textbox_Email);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.textbox_FullName);
            this.Controls.Add(this.button_Continue);
            this.Controls.Add(this.label_FullName);
            this.Controls.Add(this.textbox_RetypePassword);
            this.Controls.Add(this.combobox_UserGroup);
            this.Controls.Add(this.label_RetypePassword);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.textbox_Password);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.textbox_Username);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_Username;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textbox_Password;
        private System.Windows.Forms.Label label_RetypePassword;
        private System.Windows.Forms.ComboBox combobox_UserGroup;
        private System.Windows.Forms.Label label_FullName;
        private System.Windows.Forms.TextBox textbox_RetypePassword;
        private System.Windows.Forms.Button button_Continue;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.TextBox textbox_FullName;
        private System.Windows.Forms.Label label_UserGroup;
        private System.Windows.Forms.TextBox textbox_Email;
        private System.Windows.Forms.LinkLabel linklabel_AlreadyHaveAccount;
    }
}