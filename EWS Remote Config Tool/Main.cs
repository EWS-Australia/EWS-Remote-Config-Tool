using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using MetroFramework;
using MailKit.Net.Smtp;
using MailKit.Security;

namespace EWS_Remote_Config_Tool
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        private SmtpClient client { get; set; }

        #region Excel Variables

        private Microsoft.Office.Interop.Excel.Application xlApp { get; set; }
        private Workbook xlWb { get; set; }
        private Range xlRange { get; set; }
        private _Worksheet xlWs { get; set; }

        #endregion
        
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
                Console.WriteLine("Invalid email. Not EWS Staff");
                return;
            }
            
            // create a new SMTP client
            client = new SmtpClient();

            try
            {
                // Connect to a smtp server
                client.Connect("smtp.office365.com", 587, SecureSocketOptions.StartTls);
                Console.WriteLine("Connected");
                client.Authenticate(emailAddress, emailPassword);
                Console.WriteLine("Logged In");
                MessageBox.Show("Login To Email Server Successful", "Login Successful", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                SettingsLogOutButton.Show();
                AccountLabel.Text = "Logged in as: " + emailAddress;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
                throw;
            }
        }


        private void SettingsDarkModeToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (SettingsDarkModeToggle.Checked)
            {
                metroStyleManager1.Theme = MetroThemeStyle.Dark;
                Console.WriteLine("Loaded Dark Theme");
            }
                
            else
            {
                metroStyleManager1.Theme = MetroThemeStyle.Light;
                Console.WriteLine("Loaded Light Theme");
            }
        }

        private void SettingsColourComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroStyleManager1.Style =
                (MetroFramework.MetroColorStyle) Convert.ToInt32(SettingsColourComboBox.SelectedIndex);
            Console.WriteLine("Loaded New Colour");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            SettingsColourComboBox.SelectedIndex = 3;
            SettingsDarkModeToggle.Checked = true;
            SettingsLogOutButton.Hide();
            IMEIListPanel.Hide();
        }
        
        private void SettingsLogOutButton_Click(object sender, EventArgs e)
        {
            client.Disconnect(true);
            Console.WriteLine("Disconnected");
            client.Dispose();
            Console.WriteLine("Disposed");
            EmailPasswordTextBox.Clear();
            AccountLabel.Text = "Logged Out";
            SettingsLogOutButton.Hide();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            if (AccountLabel.Text.Contains("Logged in"))
            {
                client.Disconnect(true);
                Console.WriteLine("Disconnected");
                client.Dispose();
                Console.WriteLine("Disposed");
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWs);
            xlWb.Close();
            Marshal.ReleaseComObject(xlWb);
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);

        }

        private void ExcelFileButton_Click(object sender, EventArgs e)
        {
            string filePath = "";
            Console.WriteLine("Opening File Picker Dialog");
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Select IMEI List";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "Excel Files|*.xls;*.xlsx;*.csv";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine("File Selected");
                ExcelFilePathLabel.Text = "Loading...";
                filePath = fdlg.FileName;
                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWb = xlApp.Workbooks.Open(filePath);
                xlWs = xlWb.Sheets[1];
                xlRange = xlWs.UsedRange;
                Console.WriteLine("Calculating IMEI Count");
                int rowCount = xlRange.Rows.Count - 1;
                IMEILabel.Text = rowCount + " IMEIs Found.";
                
                string DisplayPath = filePath.Substring(filePath.LastIndexOf("\\") + 1, filePath.Length - filePath.LastIndexOf("\\") - 1);
                ExcelFilePathLabel.Text = DisplayPath;
                IMEIListPanel.Show();
                StringBuilder IMEIs = new StringBuilder();
                for (int i = 2; i < xlRange.Rows.Count + 1; i++)
                {
                    IMEIs.AppendLine(Convert.ToString(xlWs.Cells[i, 1].Value));
                }
                IMEIListTextBox.Text += IMEIs;

                
            }
        }
    }
}