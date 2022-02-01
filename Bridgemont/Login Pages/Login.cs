using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Bridgemont
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            AcceptButton = button_Login;
        }

        
        private void textbox_Username_KeyPress(object sender, KeyPressEventArgs e) 
        {
            // This prevents any special characters being entered in textBox1.
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar); 
        }

        
        private void linklabel_Register_Click(object sender, LinkLabelLinkClickedEventArgs e) 
        {
            // Create Account Link Label, opens a new form on click.
            CreateAccount createAccount = new CreateAccount();
            createAccount.ShowDialog();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            using (ODBC.connect = new OdbcConnection(ODBC.connectionString))
            { 
                // This command checks if the username and password entered match anything in the database.
                OdbcCommand command = new OdbcCommand("SELECT COUNT(*) FROM Users WHERE Username= ? AND convert(varbinary, Password) = convert(varbinary, ?)", ODBC.connect);
                // These are the values in the above SQL statement.
                command.Parameters.AddWithValue("?1", textbox_Username.Text);
                command.Parameters.AddWithValue("?2", textbox_Password.Text);
                try
                {
                    ODBC.connect.Open();
                    int count = (int)command.ExecuteScalar();

                    // tbx_Username Checks
                    if (string.IsNullOrWhiteSpace(textbox_Username.Text))
                    {
                        label_Username.ForeColor = Color.Red;
                        label_Username.Text = "Username - This field is required";
                    }
                    else
                    {
                        label_Username.ForeColor = Color.Black;
                        label_Username.Text = "Username";
                    }

                    // tbx_Password Checks
                    if (string.IsNullOrWhiteSpace(textbox_Password.Text))
                    {
                        label_Password.ForeColor = Color.Red;
                        label_Password.Text = "Password - This field is required";
                    }
                    else
                    {
                        label_Password.ForeColor = Color.Black;
                        label_Password.Text = "Password";
                    }

                    // Checks if any label is red and returns nothing
                    if (label_Username.ForeColor == Color.Red || label_Password.ForeColor == Color.Red)
                    {
                        return;
                    }
                    // Checks if username and password match anything in the database
                    else if (count == 1)
                    {
                        Map homepage = new Map();
                        this.Hide();
                        homepage.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password", "Check login details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (OdbcException exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void linklabel_ForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.ShowDialog();
        }
    }
}
