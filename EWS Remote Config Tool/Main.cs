using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using MetroFramework;
using MailKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace EWS_Remote_Config_Tool
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        private SmtpClient client { get; set; }
        
        public Main()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
        }

        private void EmailLoginButton_Click(object sender, EventArgs e)
        {
            EmailLogin();
        }

        private void EmailLogin()
        {
            string emailAddress = EmailLoginTextBox.Text;
            string emailPassword = EmailPasswordTextBox.Text;
            
            if (!emailAddress.Contains("@ewsaustralia.com"))
            {
                MessageBox.Show("Invalid email address, this tool is only usable by EWS Australia staff.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EmailLoginTextBox.Clear();
                EmailPasswordTextBox.Clear();
                return;
            }
            
            // create a new SMTP client
            client = new SmtpClient();
            
            try
            {
                // Connect to a smtp server
                client.Connect("smtp.office365.com", 587, SecureSocketOptions.StartTls);
                client.Authenticate(emailAddress, emailPassword);
                MessageBox.Show("Login To Email Server Successful", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SettingsLogOutButton.Show();
                AccountLabel.Text = "Logged in as: " + emailAddress;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                client.Disconnect(true);
                client.Dispose();
            }
        }


        private void SettingsDarkModeToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (SettingsDarkModeToggle.Checked)
                metroStyleManager1.Theme = MetroThemeStyle.Dark;
            else
                metroStyleManager1.Theme = MetroThemeStyle.Light;
        }

        private void SettingsColourComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroStyleManager1.Style =
                (MetroFramework.MetroColorStyle) Convert.ToInt32(SettingsColourComboBox.SelectedIndex);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            SettingsColourComboBox.SelectedIndex = 3;
            SettingsDarkModeToggle.Checked = true;
            SettingsLogOutButton.Hide();
        }

        private void SettingsLogOutButton_Click(object sender, EventArgs e)
        {
            AccountLabel.Text = "Logged Out";
            client.Dispose();
            SettingsLogOutButton.Hide();
        }
    }
}