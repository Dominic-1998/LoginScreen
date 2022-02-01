using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Bridgemont
{
    public partial class ForgotPassword : Form
    {

        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            using (ODBC.connect = new OdbcConnection(ODBC.connectionString))
            {


                // This command checks if the email entered exists in the database.
                OdbcCommand command = new OdbcCommand("SELECT COUNT(*) FROM Users WHERE Email= ?", ODBC.connect);
                // These are the values in the above SQL statement.
                command.Parameters.AddWithValue("?1", textbox_Email.Text);

                string NewPassword = Generate.Password();
                OdbcCommand command1 = new OdbcCommand("UPDATE Users SET Password= ? WHERE Email= ?", ODBC.connect);
                command1.Parameters.AddWithValue("?1", NewPassword);
                command1.Parameters.AddWithValue("?2", textbox_Email.Text);

                try
                {
                    ODBC.connect.Open();
                    int count = (int)command.ExecuteScalar();

                    if (string.IsNullOrWhiteSpace(textbox_Email.Text))
                    {
                        label_Email.ForeColor = Color.Red;
                        label_Email.Text = "Email - This field is required";
                    }
                    else if (Email.IsValidEmail(textbox_Email.Text) == false)
                    {
                        label_Email.ForeColor = Color.Red;
                        label_Email.Text = "Email - Not a well formed email address";
                    }
                    else if (count == 1)
                    {
                        label_Email.ForeColor = Color.Black;
                        label_Email.Text = "Email";
                        Email.SendEmail(textbox_Email.Text, NewPassword);
                        command1.ExecuteNonQuery();
                        MessageBox.Show("Password reset email sent to " +textbox_Email.Text);
                    }
                    else
                    {
                        label_Email.ForeColor = Color.Red;
                        label_Email.Text = "Email - An account with that email doesn't exist.";
                    }
                }
                catch (OdbcException exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
    }
}
