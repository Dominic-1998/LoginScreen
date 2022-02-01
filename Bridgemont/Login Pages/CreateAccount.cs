using System;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Text.RegularExpressions;
using System.Drawing;

namespace Bridgemont
{
    public partial class CreateAccount : Form
    {

        public CreateAccount()
        {
            InitializeComponent();
            AcceptButton = button_Continue;
        }

        private void button_Continue_Click(object sender, EventArgs e)
        {
            using (ODBC.connect = new OdbcConnection(ODBC.connectionString))
            {
                // This command creates a new user in the database.
                OdbcCommand command = new OdbcCommand("INSERT INTO Users (Username, Password, Full_Name, Email, User_Group) VALUES (?, ?, ?, ?, ?)", ODBC.connect);
                // These are the values in the above SQL statement.
                command.Parameters.AddWithValue("?1", textbox_Username.Text);
                command.Parameters.AddWithValue("?2", textbox_Password.Text);
                command.Parameters.AddWithValue("?3", textbox_FullName.Text);
                command.Parameters.AddWithValue("?4", textbox_Email.Text);
                command.Parameters.AddWithValue("?5", combobox_UserGroup.Text);

                // This command checks if the username entered already exists in the database.
                OdbcCommand command2 = new OdbcCommand("SELECT COUNT(*) FROM Users WHERE Username= ?", ODBC.connect);
                // These are the values in the above SQL statement.
                command2.Parameters.AddWithValue("?1", textbox_Username.Text);

                // This command checks if the email entered already exists in the database.
                OdbcCommand command3 = new OdbcCommand("SELECT COUNT(*) FROM Users WHERE Email= ?", ODBC.connect);
                // These are the values in the above SQL statement.
                command3.Parameters.AddWithValue("?1", textbox_Email.Text);

                try
                {
                    ODBC.connect.Open();
                    int count = (int)command2.ExecuteScalar(); // Assigns count to how many lines are returned in the select for command2.
                    int count1 = (int)command3.ExecuteScalar(); // Assigns count1 to how many lines are returned in the select for command3.

                    // tbx_Username Checks
                    if (string.IsNullOrWhiteSpace(textbox_Username.Text))
                    {
                        label_Username.ForeColor = Color.Red;
                        label_Username.Text = "Username - This field is required.";
                    }
                    else if (count == 1)
                    {
                        label_Username.ForeColor = Color.Red;
                        label_Username.Text = "Username - This username already exists.";
                    }
                    else if (!(new Regex(@".{2,32}$")).IsMatch(textbox_Username.Text))
                    {
                        label_Username.ForeColor = Color.Red;
                        label_Username.Text = "Username - Must be between 2 to 32 characters.";
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
                        label_Password.Text = "Password - This field is required.";
                    }
                    else if (!(new Regex(@".{8,100}$")).IsMatch(textbox_Password.Text))
                    {
                        label_Password.ForeColor = Color.Red;
                        label_Password.Text = "Password - Must be at least 8 characters.";
                    }
                    else
                    {
                        label_Password.ForeColor = Color.Black;
                        label_Password.Text = "Password";
                    }

                    // tbx_RetypePassword Checks
                    if (textbox_RetypePassword.Text != textbox_Password.Text)
                    {
                        label_RetypePassword.ForeColor = Color.Red;
                        label_RetypePassword.Text = "Retype Password - Password doesn't match.";
                    }
                    else
                    {
                        label_RetypePassword.ForeColor = Color.Black;
                        label_RetypePassword.Text = "Retype Password";
                    }

                    // tbx_Email Checks
                    if (string.IsNullOrWhiteSpace(textbox_Email.Text))
                    {
                        label_Email.ForeColor = Color.Red;
                        label_Email.Text = "Email - This field is required.";
                    }
                    else if (Email.IsValidEmail(textbox_Email.Text) == false)
                    {
                        label_Email.ForeColor = Color.Red;
                        label_Email.Text = "Email - Not a well formed email address.";
                    }
                    else if (count1 == 1)
                    {
                        label_Email.ForeColor = Color.Red;
                        label_Email.Text = "Email - This email already exists.";
                    }
                    else
                    {
                        label_Email.ForeColor = Color.Black;
                        label_Email.Text = "Email";
                    }

                    // cbx_UserGroup Checks
                    if (string.IsNullOrWhiteSpace(combobox_UserGroup.Text))
                    {
                        label_UserGroup.ForeColor = Color.Red;
                        label_UserGroup.Text = "User Group - This field is required.";
                    }
                    else if (combobox_UserGroup.Text == "Admin")
                    {

                    }
                    else
                    {
                        label_UserGroup.ForeColor = Color.Black;
                        label_UserGroup.Text = "User Group";
                    }

                    // Checks if any label is red and returns nothing.
                    if (label_Username.ForeColor == Color.Red
                        || label_Password.ForeColor == Color.Red
                        || label_RetypePassword.ForeColor == Color.Red
                        || label_Email.ForeColor == Color.Red
                        || label_UserGroup.ForeColor == Color.Red)
                    {
                        return;
                    }
                    // If no labels are red it'll execute the insert statement.
                    else
                    {
                        command.ExecuteNonQuery();
                        this.Close();
                        MessageBox.Show("User Created");
                    }
                }
                catch (OdbcException exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        // This prevents any special characters or spaces being entered in the Username textbox.
        private void textbox_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        // This prevents any special characters being entered in the Full Name textbox.
        private void textbox_FullName_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void linklabel_AlreadyHaveAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}