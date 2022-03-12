using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using MetroFramework;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace EWS_Remote_Config_Tool
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        private SmtpClient client { get; set; }
        private MailboxAddress emailAddressMA { get; set; }
        private string emailAddress { get; set; }
        private string destinationAddress { get; set; }
        private string[] filePaths { get; set; }

        #region Checks

        private bool isLoggedIn { get; set; }
        private bool filesLoaded { get; set; }
        
        private bool isOpened { get; set; }

        #endregion
        

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
            emailAddress = EmailLoginTextBox.Text;
            string emailPassword = EmailPasswordTextBox.Text;
            
            if (!emailAddress.Contains("@ewsaustralia.com"))
            {
                MessageBox.Show("Invalid email address, this tool is only usable by EWS Australia staff.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EmailLoginTextBox.Clear();
                EmailPasswordTextBox.Clear();
                Console.WriteLine("Invalid email. Not EWS Staff");
                isLoggedIn = false;
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
                    MessageBoxIcon.None);
                SettingsLogOutButton.Show();
                AccountLabel.Text = "Logged in as: " + emailAddress;
                emailAddressMA = MailboxAddress.Parse(emailAddress);
                isLoggedIn = true;
            }
            catch (Exception ex)
            {
                isLoggedIn = false;
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
            isOpened = false;
            filesLoaded = false;
            isLoggedIn = false;
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
            isLoggedIn = false;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            if (isLoggedIn)
            {
                client.Disconnect(true);
                Console.WriteLine("Disconnected");
                client.Dispose();
                Console.WriteLine("Disposed");
            }

            if (isOpened == true)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                Marshal.ReleaseComObject(xlRange);
                Marshal.ReleaseComObject(xlWs);
                xlWb.Close(false);
                Marshal.ReleaseComObject(xlWb);
                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);
                Console.WriteLine("Excel Closed");
            }
        }

        private void ExcelFileButton_Click(object sender, EventArgs e)
        {
            isOpened = false;
            IMEIListTextBox.Clear();
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
                isOpened = true;
            }
        }

        private void ChangeFilesButton_Click(object sender, EventArgs e)
        {
            filesLoaded = false;
            ChangeFilesTextBox.Clear();
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Select Change Files";
            fileDialog.InitialDirectory = @"c:\";
            fileDialog.Multiselect = true;
            fileDialog.Filter = "Change Files (*.sbd)|*.sbd|" + "All files (*.*)|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                filePaths = fileDialog.FileNames;
                StringBuilder sb = new StringBuilder();
                foreach (var file in fileDialog.FileNames)
                {
                    
                    string fileName = file.Substring(file.LastIndexOf("\\") + 1,
                        file.Length - file.LastIndexOf("\\") - 1);
                    sb.AppendLine(fileName);
                }

                ChangeFilesTextBox.Text += sb;
                filesLoaded = true;
            }
        }

        private void SendChangesButton_Click(object sender, EventArgs e)
        {
            if (isOpened && filesLoaded && isLoggedIn && !ChangeDestinationComboBox.Text.Equals(""))
            {
                try
                {
                    Console.WriteLine("Ready to Send");
                    
                    if(ChangeDestinationComboBox.Text == "Iridium")
                    {
                        //destinationAddress = "data@sbd.iridium.com";
                        destinationAddress = "rileyleno@gmail.com";
                    }else if (ChangeDestinationComboBox.Text == "Cellular")
                    {
                        //destinationAddress = "devices@ewsaustralia.com";
                        destinationAddress = "bradyhazell1@gmail.com";
                    }else if (ChangeDestinationComboBox.Text == "Custom")
                    {
                        string display, title, defaultValue;
                        object customInput;

                        display = "Please input your custom destination.";
                        title = "Custom Destination";
                        defaultValue = "";

                        customInput = Interaction.InputBox(display, title, defaultValue);
                        if (customInput == "")
                        {
                            customInput = emailAddress;
                        }

                        destinationAddress = customInput.ToString();
                    }
                    else
                    {
                        MessageBox.Show(
                            "An error occured, please ensure there is a destination selected in the Email Detais tab.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    StringBuilder sb = new StringBuilder();
                    for (int i = 2; i < xlRange.Rows.Count + 1; i++)
                    {
                        MimeMessage message = new MimeMessage();
                        message.From.Add(emailAddressMA);
                        message.To.Add(MailboxAddress.Parse(destinationAddress));
                        message.Subject = Convert.ToString(xlWs.Cells[i, 1].Value);
                        var builder = new BodyBuilder();
                        foreach (var file in filePaths)
                        {
                            builder.Attachments.Add(file);
                        }

                        message.Body = builder.ToMessageBody();
                        client.Send(message);
                        sb.AppendLine("Sent changes to " + message.Subject.ToString());
                        ConsoleTextBox.Text += sb;
                        sb.Clear();
                    }

                    sb.AppendLine("Complete");
                    MessageBox.Show("Remote Changes Completed!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.None);

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else
            {
                MessageBox.Show("Not all options are selected.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
        
    }
}