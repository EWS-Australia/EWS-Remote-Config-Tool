using System.ComponentModel;

namespace EWS_Remote_Config_Tool
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TabControl = new MetroFramework.Controls.MetroTabControl();
            this.EmailLoginPage = new MetroFramework.Controls.MetroTabPage();
            this.EmailLoginButton = new MetroFramework.Controls.MetroButton();
            this.EmailPasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.EmailLoginLabel = new MetroFramework.Controls.MetroLabel();
            this.EmailPasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.EmailLoginTextBox = new MetroFramework.Controls.MetroTextBox();
            this.EmailDetailsPage = new MetroFramework.Controls.MetroTabPage();
            this.ChangeDestinationLabel = new MetroFramework.Controls.MetroLabel();
            this.ChangeDestinationComboBox = new MetroFramework.Controls.MetroComboBox();
            this.IMEILabel = new MetroFramework.Controls.MetroLabel();
            this.ExcelFilePathLabel = new MetroFramework.Controls.MetroLabel();
            this.ExcelFileButton = new MetroFramework.Controls.MetroButton();
            this.SettingsPage = new MetroFramework.Controls.MetroTabPage();
            this.SettingsLogOutButton = new MetroFramework.Controls.MetroButton();
            this.SettingsColourComboBox = new MetroFramework.Controls.MetroComboBox();
            this.SettingsColourLabel = new MetroFramework.Controls.MetroLabel();
            this.SettingsDarkModeLabel = new MetroFramework.Controls.MetroLabel();
            this.SettingsDarkModeToggle = new MetroFramework.Controls.MetroToggle();
            this.ChangeFilesPage = new MetroFramework.Controls.MetroTabPage();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.AccountLabel = new MetroFramework.Controls.MetroLabel();
            this.IMEIListPanel = new MetroFramework.Controls.MetroTabPage();
            this.TabControl.SuspendLayout();
            this.EmailLoginPage.SuspendLayout();
            this.EmailDetailsPage.SuspendLayout();
            this.SettingsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.EmailLoginPage);
            this.TabControl.Controls.Add(this.EmailDetailsPage);
            this.TabControl.Controls.Add(this.ChangeFilesPage);
            this.TabControl.Controls.Add(this.IMEIListPanel);
            this.TabControl.Controls.Add(this.SettingsPage);
            this.TabControl.Location = new System.Drawing.Point(46, 148);
            this.TabControl.Margin = new System.Windows.Forms.Padding(6);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1508, 673);
            this.TabControl.TabIndex = 7;
            // 
            // EmailLoginPage
            // 
            this.EmailLoginPage.Controls.Add(this.EmailLoginButton);
            this.EmailLoginPage.Controls.Add(this.EmailPasswordLabel);
            this.EmailLoginPage.Controls.Add(this.EmailLoginLabel);
            this.EmailLoginPage.Controls.Add(this.EmailPasswordTextBox);
            this.EmailLoginPage.Controls.Add(this.EmailLoginTextBox);
            this.EmailLoginPage.HorizontalScrollbarBarColor = true;
            this.EmailLoginPage.HorizontalScrollbarSize = 19;
            this.EmailLoginPage.Location = new System.Drawing.Point(4, 39);
            this.EmailLoginPage.Margin = new System.Windows.Forms.Padding(6);
            this.EmailLoginPage.Name = "EmailLoginPage";
            this.EmailLoginPage.Size = new System.Drawing.Size(1500, 630);
            this.EmailLoginPage.TabIndex = 0;
            this.EmailLoginPage.Text = "Email Login";
            this.EmailLoginPage.VerticalScrollbarBarColor = true;
            this.EmailLoginPage.VerticalScrollbarSize = 20;
            // 
            // EmailLoginButton
            // 
            this.EmailLoginButton.Location = new System.Drawing.Point(572, 319);
            this.EmailLoginButton.Margin = new System.Windows.Forms.Padding(6);
            this.EmailLoginButton.Name = "EmailLoginButton";
            this.EmailLoginButton.Size = new System.Drawing.Size(454, 50);
            this.EmailLoginButton.TabIndex = 11;
            this.EmailLoginButton.Text = "Send";
            this.EmailLoginButton.Click += new System.EventHandler(this.EmailLoginButton_Click);
            // 
            // EmailPasswordLabel
            // 
            this.EmailPasswordLabel.Location = new System.Drawing.Point(320, 204);
            this.EmailPasswordLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.EmailPasswordLabel.Name = "EmailPasswordLabel";
            this.EmailPasswordLabel.Size = new System.Drawing.Size(220, 42);
            this.EmailPasswordLabel.TabIndex = 10;
            this.EmailPasswordLabel.Text = "Password:";
            // 
            // EmailLoginLabel
            // 
            this.EmailLoginLabel.Location = new System.Drawing.Point(320, 150);
            this.EmailLoginLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.EmailLoginLabel.Name = "EmailLoginLabel";
            this.EmailLoginLabel.Size = new System.Drawing.Size(220, 42);
            this.EmailLoginLabel.TabIndex = 9;
            this.EmailLoginLabel.Text = "Email:";
            // 
            // EmailPasswordTextBox
            // 
            this.EmailPasswordTextBox.Location = new System.Drawing.Point(572, 204);
            this.EmailPasswordTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.EmailPasswordTextBox.Name = "EmailPasswordTextBox";
            this.EmailPasswordTextBox.PasswordChar = '*';
            this.EmailPasswordTextBox.Size = new System.Drawing.Size(456, 42);
            this.EmailPasswordTextBox.TabIndex = 8;
            // 
            // EmailLoginTextBox
            // 
            this.EmailLoginTextBox.Location = new System.Drawing.Point(572, 150);
            this.EmailLoginTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.EmailLoginTextBox.Name = "EmailLoginTextBox";
            this.EmailLoginTextBox.Size = new System.Drawing.Size(456, 42);
            this.EmailLoginTextBox.TabIndex = 7;
            // 
            // EmailDetailsPage
            // 
            this.EmailDetailsPage.Controls.Add(this.ChangeDestinationLabel);
            this.EmailDetailsPage.Controls.Add(this.ChangeDestinationComboBox);
            this.EmailDetailsPage.Controls.Add(this.IMEILabel);
            this.EmailDetailsPage.Controls.Add(this.ExcelFilePathLabel);
            this.EmailDetailsPage.Controls.Add(this.ExcelFileButton);
            this.EmailDetailsPage.HorizontalScrollbarBarColor = true;
            this.EmailDetailsPage.HorizontalScrollbarSize = 19;
            this.EmailDetailsPage.Location = new System.Drawing.Point(4, 39);
            this.EmailDetailsPage.Margin = new System.Windows.Forms.Padding(6);
            this.EmailDetailsPage.Name = "EmailDetailsPage";
            this.EmailDetailsPage.Size = new System.Drawing.Size(1500, 630);
            this.EmailDetailsPage.TabIndex = 1;
            this.EmailDetailsPage.Text = "Email Details";
            this.EmailDetailsPage.VerticalScrollbarBarColor = true;
            this.EmailDetailsPage.VerticalScrollbarSize = 20;
            // 
            // ChangeDestinationLabel
            // 
            this.ChangeDestinationLabel.Location = new System.Drawing.Point(340, 183);
            this.ChangeDestinationLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ChangeDestinationLabel.Name = "ChangeDestinationLabel";
            this.ChangeDestinationLabel.Size = new System.Drawing.Size(1038, 29);
            this.ChangeDestinationLabel.TabIndex = 13;
            this.ChangeDestinationLabel.Text = "Email Destination";
            this.ChangeDestinationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChangeDestinationComboBox
            // 
            this.ChangeDestinationComboBox.ItemHeight = 23;
            this.ChangeDestinationComboBox.Items.AddRange(new object[] {"Iridium", "Cellular", "Custom"});
            this.ChangeDestinationComboBox.Location = new System.Drawing.Point(100, 183);
            this.ChangeDestinationComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.ChangeDestinationComboBox.Name = "ChangeDestinationComboBox";
            this.ChangeDestinationComboBox.Size = new System.Drawing.Size(222, 29);
            this.ChangeDestinationComboBox.TabIndex = 12;
            // 
            // IMEILabel
            // 
            this.IMEILabel.Location = new System.Drawing.Point(340, 90);
            this.IMEILabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.IMEILabel.Name = "IMEILabel";
            this.IMEILabel.Size = new System.Drawing.Size(322, 42);
            this.IMEILabel.TabIndex = 11;
            this.IMEILabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ExcelFilePathLabel
            // 
            this.ExcelFilePathLabel.Location = new System.Drawing.Point(340, 48);
            this.ExcelFilePathLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ExcelFilePathLabel.Name = "ExcelFilePathLabel";
            this.ExcelFilePathLabel.Size = new System.Drawing.Size(1038, 42);
            this.ExcelFilePathLabel.TabIndex = 10;
            this.ExcelFilePathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ExcelFileButton
            // 
            this.ExcelFileButton.Location = new System.Drawing.Point(110, 48);
            this.ExcelFileButton.Margin = new System.Windows.Forms.Padding(6);
            this.ExcelFileButton.Name = "ExcelFileButton";
            this.ExcelFileButton.Size = new System.Drawing.Size(218, 42);
            this.ExcelFileButton.TabIndex = 2;
            this.ExcelFileButton.Text = "Select IMEI List";
            this.ExcelFileButton.Click += new System.EventHandler(this.ExcelFileButton_Click);
            // 
            // SettingsPage
            // 
            this.SettingsPage.Controls.Add(this.SettingsLogOutButton);
            this.SettingsPage.Controls.Add(this.SettingsColourComboBox);
            this.SettingsPage.Controls.Add(this.SettingsColourLabel);
            this.SettingsPage.Controls.Add(this.SettingsDarkModeLabel);
            this.SettingsPage.Controls.Add(this.SettingsDarkModeToggle);
            this.SettingsPage.HorizontalScrollbarBarColor = true;
            this.SettingsPage.HorizontalScrollbarSize = 19;
            this.SettingsPage.Location = new System.Drawing.Point(4, 39);
            this.SettingsPage.Margin = new System.Windows.Forms.Padding(6);
            this.SettingsPage.Name = "SettingsPage";
            this.SettingsPage.Size = new System.Drawing.Size(1500, 630);
            this.SettingsPage.TabIndex = 3;
            this.SettingsPage.Text = "Settings";
            this.SettingsPage.VerticalScrollbarBarColor = true;
            this.SettingsPage.VerticalScrollbarSize = 20;
            // 
            // SettingsLogOutButton
            // 
            this.SettingsLogOutButton.Location = new System.Drawing.Point(1228, 65);
            this.SettingsLogOutButton.Margin = new System.Windows.Forms.Padding(6);
            this.SettingsLogOutButton.Name = "SettingsLogOutButton";
            this.SettingsLogOutButton.Size = new System.Drawing.Size(228, 46);
            this.SettingsLogOutButton.TabIndex = 7;
            this.SettingsLogOutButton.Text = "Log Out";
            this.SettingsLogOutButton.Click += new System.EventHandler(this.SettingsLogOutButton_Click);
            // 
            // SettingsColourComboBox
            // 
            this.SettingsColourComboBox.FormattingEnabled = true;
            this.SettingsColourComboBox.ItemHeight = 23;
            this.SettingsColourComboBox.Items.AddRange(new object[] {"Black", "White", "Silver", "Blue", "Green", "Lime", "Teal", "Orange", "Brown", "Pink", "Magenta", "Purple", "Red", "Yellow"});
            this.SettingsColourComboBox.Location = new System.Drawing.Point(238, 131);
            this.SettingsColourComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.SettingsColourComboBox.Name = "SettingsColourComboBox";
            this.SettingsColourComboBox.Size = new System.Drawing.Size(212, 29);
            this.SettingsColourComboBox.TabIndex = 6;
            this.SettingsColourComboBox.SelectedIndexChanged += new System.EventHandler(this.SettingsColourComboBox_SelectedIndexChanged);
            // 
            // SettingsColourLabel
            // 
            this.SettingsColourLabel.Location = new System.Drawing.Point(6, 131);
            this.SettingsColourLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SettingsColourLabel.Name = "SettingsColourLabel";
            this.SettingsColourLabel.Size = new System.Drawing.Size(220, 56);
            this.SettingsColourLabel.TabIndex = 5;
            this.SettingsColourLabel.Text = "Select a Colour";
            this.SettingsColourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SettingsDarkModeLabel
            // 
            this.SettingsDarkModeLabel.Location = new System.Drawing.Point(64, 77);
            this.SettingsDarkModeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SettingsDarkModeLabel.Name = "SettingsDarkModeLabel";
            this.SettingsDarkModeLabel.Size = new System.Drawing.Size(162, 37);
            this.SettingsDarkModeLabel.TabIndex = 3;
            this.SettingsDarkModeLabel.Text = "Dark Mode";
            this.SettingsDarkModeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SettingsDarkModeToggle
            // 
            this.SettingsDarkModeToggle.Location = new System.Drawing.Point(238, 77);
            this.SettingsDarkModeToggle.Margin = new System.Windows.Forms.Padding(6);
            this.SettingsDarkModeToggle.Name = "SettingsDarkModeToggle";
            this.SettingsDarkModeToggle.Size = new System.Drawing.Size(140, 40);
            this.SettingsDarkModeToggle.TabIndex = 2;
            this.SettingsDarkModeToggle.Text = "Off";
            this.SettingsDarkModeToggle.UseVisualStyleBackColor = true;
            this.SettingsDarkModeToggle.CheckedChanged += new System.EventHandler(this.SettingsDarkModeToggle_CheckedChanged);
            // 
            // ChangeFilesPage
            // 
            this.ChangeFilesPage.HorizontalScrollbarBarColor = true;
            this.ChangeFilesPage.HorizontalScrollbarSize = 19;
            this.ChangeFilesPage.Location = new System.Drawing.Point(4, 39);
            this.ChangeFilesPage.Margin = new System.Windows.Forms.Padding(6);
            this.ChangeFilesPage.Name = "ChangeFilesPage";
            this.ChangeFilesPage.Size = new System.Drawing.Size(1500, 630);
            this.ChangeFilesPage.TabIndex = 2;
            this.ChangeFilesPage.Text = "Change Files";
            this.ChangeFilesPage.VerticalScrollbarBarColor = true;
            this.ChangeFilesPage.VerticalScrollbarSize = 20;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Blue;
            // 
            // AccountLabel
            // 
            this.AccountLabel.Location = new System.Drawing.Point(952, 17);
            this.AccountLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AccountLabel.Name = "AccountLabel";
            this.AccountLabel.Size = new System.Drawing.Size(480, 40);
            this.AccountLabel.TabIndex = 8;
            this.AccountLabel.Text = "Logged Out";
            this.AccountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IMEIListPanel
            // 
            this.IMEIListPanel.HorizontalScrollbarBarColor = true;
            this.IMEIListPanel.Location = new System.Drawing.Point(4, 39);
            this.IMEIListPanel.Name = "IMEIListPanel";
            this.IMEIListPanel.Size = new System.Drawing.Size(1500, 630);
            this.IMEIListPanel.TabIndex = 4;
            this.IMEIListPanel.Text = "IMEI List";
            this.IMEIListPanel.VerticalScrollbarBarColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.AccountLabel);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(40, 115, 40, 38);
            this.Resizable = false;
            this.Text = "EWS Remote Config Tool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.TabControl.ResumeLayout(false);
            this.EmailLoginPage.ResumeLayout(false);
            this.EmailDetailsPage.ResumeLayout(false);
            this.SettingsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
        }

        private MetroFramework.Controls.MetroTabPage IMEIListPanel;

        private MetroFramework.Controls.MetroButton SettingsLogOutButton;

        private MetroFramework.Controls.MetroLabel AccountLabel;

        private MetroFramework.Controls.MetroLabel ChangeDestinationLabel;

        private MetroFramework.Controls.MetroComboBox SettingsColourComboBox;
        private MetroFramework.Controls.MetroLabel SettingsColourLabel;

        private MetroFramework.Controls.MetroLabel SettingsDarkModeLabel;

        private MetroFramework.Controls.MetroToggle SettingsDarkModeToggle;

        private MetroFramework.Controls.MetroTabPage SettingsPage;

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;

        private MetroFramework.Controls.MetroComboBox ChangeDestinationComboBox;

        private MetroFramework.Controls.MetroLabel IMEILabel;

        private MetroFramework.Controls.MetroLabel ExcelFilePathLabel;

        private MetroFramework.Controls.MetroButton ExcelFileButton;

        private MetroFramework.Controls.MetroTabPage EmailDetailsPage;
        private MetroFramework.Controls.MetroTabPage EmailLoginPage;
        private MetroFramework.Controls.MetroTabPage ChangeFilesPage;
        private MetroFramework.Controls.MetroButton EmailLoginButton;
        private MetroFramework.Controls.MetroLabel EmailPasswordLabel;
        private MetroFramework.Controls.MetroLabel EmailLoginLabel;
        private MetroFramework.Controls.MetroTextBox EmailPasswordTextBox;
        private MetroFramework.Controls.MetroTextBox EmailLoginTextBox;

        

        private MetroFramework.Controls.MetroTabControl TabControl;

        #endregion
    }
}