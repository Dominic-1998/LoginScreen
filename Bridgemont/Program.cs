using System;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Configuration;
using System.Net.Mail;
using System.Text;

namespace Bridgemont
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ODBC.Connect();
            // Opens the Login Screen.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
    public class ODBC
    {
        // Pulls the connection string from the App.config and assigns it to connectionString.
        public static string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public static OdbcConnection connect = new OdbcConnection(connectionString);

        public static void Connect()
        {
            using (ODBC.connect)
                // This opens the database connection.
                try
                {
                    ODBC.connect.Open();
                }
                // This closes and catches any ODBC errors then displays the error. The program will close if no connection is found.
                catch (OdbcException exception)
                {
                    ODBC.connect.Close();
                    MessageBox.Show(exception.Message);
                    Environment.Exit(0);
                }
        }
    }
    public class Email
    {
        // Used to check if the email is valid.
        public static bool IsValidEmail(string emailaddress)
        {
            try
            {
                MailAddress mail = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        public static void SendEmail(string emailaddress, string NewPassword)
        {
            SmtpClient Client = new SmtpClient("smtpout.secureserver.net");
            Client.Port = 25;
            MailMessage Message = new MailMessage("somerandomguy@somecompany.com", emailaddress);
            Message.Subject = "Reset Password";
            Message.Body = "Your new password is " + NewPassword;
            Message.BodyEncoding = Encoding.UTF8;
            Message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            Client.Send(Message);
        }
    }
    public class Generate
    {
        // Used to generate a new password on the ForgotPassword form.
        public static string Password()
        {
            int passwordLength = 20;
            string allowedChars = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789!@$?_-";
            char[] NewPassword = new char[passwordLength];
            Random rd = new Random();

            for (int i = 0; i < passwordLength; i++)
            {
                NewPassword[i] = allowedChars[rd.Next(0, allowedChars.Length)];
            }

            return new string(NewPassword);
        }
    }
    public class API
    {
        public static string gmapkey { get; } = "Key";
    }
}
