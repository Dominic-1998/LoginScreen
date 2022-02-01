namespace Bridgemont
{
    partial class ForgotPassword
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
            this.textbox_Email = new System.Windows.Forms.TextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.button_Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textbox_Email
            // 
            this.textbox_Email.BackColor = System.Drawing.SystemColors.Window;
            this.textbox_Email.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Email.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textbox_Email.Location = new System.Drawing.Point(12, 28);
            this.textbox_Email.MaxLength = 100;
            this.textbox_Email.Name = "textbox_Email";
            this.textbox_Email.Size = new System.Drawing.Size(300, 22);
            this.textbox_Email.TabIndex = 1;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label_Email.Location = new System.Drawing.Point(12, 9);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(41, 16);
            this.label_Email.TabIndex = 9;
            this.label_Email.Text = "Email";
            // 
            // button_Reset
            // 
            this.button_Reset.BackColor = System.Drawing.Color.SkyBlue;
            this.button_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Reset.FlatAppearance.BorderSize = 0;
            this.button_Reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.button_Reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Reset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Reset.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_Reset.Location = new System.Drawing.Point(12, 65);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(300, 50);
            this.button_Reset.TabIndex = 10;
            this.button_Reset.TabStop = false;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = false;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(322, 129);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.textbox_Email);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Forgot Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_Email;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Button button_Reset;
    }
}