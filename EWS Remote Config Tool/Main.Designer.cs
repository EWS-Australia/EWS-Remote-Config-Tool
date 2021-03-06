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
            this.SendChangesPage = new MetroFramework.Controls.MetroTabPage();
            this.ConsolePanel = new MetroFramework.Controls.MetroPanel();
            this.ConsoleTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SendChangesButton = new MetroFramework.Controls.MetroButton();
            this.EmailDetailsPage = new MetroFramework.Controls.MetroTabPage();
            this.IMEIListPanel = new MetroFramework.Controls.MetroPanel();
            this.IMEIListTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ChangeDestinationLabel = new MetroFramework.Controls.MetroLabel();
            this.ChangeDestinationComboBox = new MetroFramework.Controls.MetroComboBox();
            this.IMEILabel = new MetroFramework.Controls.MetroLabel();
            this.ExcelFilePathLabel = new MetroFramework.Controls.MetroLabel();
            this.ExcelFileButton = new MetroFramework.Controls.MetroButton();
            this.ChangeFilesPage = new MetroFramework.Controls.MetroTabPage();
            this.ChangeFilesPanel = new MetroFramework.Controls.MetroPanel();
            this.ChangeFilesTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ChangeFilesButton = new MetroFramework.Controls.MetroButton();
            this.SettingsPage = new MetroFramework.Controls.MetroTabPage();
            this.SettingsLogOutButton = new MetroFramework.Controls.MetroButton();
            this.SettingsColourComboBox = new MetroFramework.Controls.MetroComboBox();
            this.SettingsColourLabel = new MetroFramework.Controls.MetroLabel();
            this.SettingsDarkModeLabel = new MetroFramework.Controls.MetroLabel();
            this.SettingsDarkModeToggle = new MetroFramework.Controls.MetroToggle();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.AccountLabel = new MetroFramework.Controls.MetroLabel();
            this.VersionLabel = new MetroFramework.Controls.MetroLabel();
            this.TabControl.SuspendLayout();
            this.EmailLoginPage.SuspendLayout();
            this.SendChangesPage.SuspendLayout();
            this.ConsolePanel.SuspendLayout();
            this.EmailDetailsPage.SuspendLayout();
            this.IMEIListPanel.SuspendLayout();
            this.ChangeFilesPage.SuspendLayout();
            this.ChangeFilesPanel.SuspendLayout();
            this.SettingsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.EmailLoginPage);
            this.TabControl.Controls.Add(this.SendChangesPage);
            this.TabControl.Controls.Add(this.EmailDetailsPage);
            this.TabControl.Controls.Add(this.ChangeFilesPage);
            this.TabControl.Controls.Add(this.SettingsPage);
            this.TabControl.Location = new System.Drawing.Point(23, 77);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 1;
            this.TabControl.Size = new System.Drawing.Size(754, 350);
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
            this.EmailLoginPage.Location = new System.Drawing.Point(4, 35);
            this.EmailLoginPage.Name = "EmailLoginPage";
            this.EmailLoginPage.Size = new System.Drawing.Size(746, 311);
            this.EmailLoginPage.TabIndex = 0;
            this.EmailLoginPage.Text = "Email Login";
            this.EmailLoginPage.VerticalScrollbarBarColor = true;
            // 
            // EmailLoginButton
            // 
            this.EmailLoginButton.Location = new System.Drawing.Point(286, 166);
            this.EmailLoginButton.Name = "EmailLoginButton";
            this.EmailLoginButton.Size = new System.Drawing.Size(227, 26);
            this.EmailLoginButton.TabIndex = 11;
            this.EmailLoginButton.Text = "Login";
            this.EmailLoginButton.Click += new System.EventHandler(this.EmailLoginButton_Click);
            // 
            // EmailPasswordLabel
            // 
            this.EmailPasswordLabel.Location = new System.Drawing.Point(160, 106);
            this.EmailPasswordLabel.Name = "EmailPasswordLabel";
            this.EmailPasswordLabel.Size = new System.Drawing.Size(110, 22);
            this.EmailPasswordLabel.TabIndex = 10;
            this.EmailPasswordLabel.Text = "Password:";
            // 
            // EmailLoginLabel
            // 
            this.EmailLoginLabel.Location = new System.Drawing.Point(160, 78);
            this.EmailLoginLabel.Name = "EmailLoginLabel";
            this.EmailLoginLabel.Size = new System.Drawing.Size(110, 22);
            this.EmailLoginLabel.TabIndex = 9;
            this.EmailLoginLabel.Text = "Email:";
            // 
            // EmailPasswordTextBox
            // 
            this.EmailPasswordTextBox.Location = new System.Drawing.Point(286, 106);
            this.EmailPasswordTextBox.Name = "EmailPasswordTextBox";
            this.EmailPasswordTextBox.PasswordChar = '*';
            this.EmailPasswordTextBox.Size = new System.Drawing.Size(228, 22);
            this.EmailPasswordTextBox.TabIndex = 8;
            // 
            // EmailLoginTextBox
            // 
            this.EmailLoginTextBox.Location = new System.Drawing.Point(286, 78);
            this.EmailLoginTextBox.Name = "EmailLoginTextBox";
            this.EmailLoginTextBox.Size = new System.Drawing.Size(228, 22);
            this.EmailLoginTextBox.TabIndex = 7;
            // 
            // SendChangesPage
            // 
            this.SendChangesPage.Controls.Add(this.ConsolePanel);
            this.SendChangesPage.Controls.Add(this.SendChangesButton);
            this.SendChangesPage.HorizontalScrollbarBarColor = true;
            this.SendChangesPage.Location = new System.Drawing.Point(4, 35);
            this.SendChangesPage.Name = "SendChangesPage";
            this.SendChangesPage.Size = new System.Drawing.Size(746, 311);
            this.SendChangesPage.TabIndex = 4;
            this.SendChangesPage.Text = "Send Changes";
            this.SendChangesPage.VerticalScrollbarBarColor = true;
            // 
            // ConsolePanel
            // 
            this.ConsolePanel.Controls.Add(this.ConsoleTextBox);
            this.ConsolePanel.HorizontalScrollbar = true;
            this.ConsolePanel.HorizontalScrollbarBarColor = true;
            this.ConsolePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.ConsolePanel.HorizontalScrollbarSize = 10;
            this.ConsolePanel.Location = new System.Drawing.Point(225, 10);
            this.ConsolePanel.Name = "ConsolePanel";
            this.ConsolePanel.Size = new System.Drawing.Size(494, 290);
            this.ConsolePanel.TabIndex = 16;
            this.ConsolePanel.VerticalScrollbar = true;
            this.ConsolePanel.VerticalScrollbarBarColor = true;
            this.ConsolePanel.VerticalScrollbarHighlightOnWheel = false;
            this.ConsolePanel.VerticalScrollbarSize = 10;
            // 
            // ConsoleTextBox
            // 
            this.ConsoleTextBox.Location = new System.Drawing.Point(3, 3);
            this.ConsoleTextBox.Multiline = true;
            this.ConsoleTextBox.Name = "ConsoleTextBox";
            this.ConsoleTextBox.ReadOnly = true;
            this.ConsoleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ConsoleTextBox.Size = new System.Drawing.Size(488, 284);
            this.ConsoleTextBox.TabIndex = 3;
            this.ConsoleTextBox.Text = " ";
            // 
            // SendChangesButton
            // 
            this.SendChangesButton.Location = new System.Drawing.Point(30, 20);
            this.SendChangesButton.Name = "SendChangesButton";
            this.SendChangesButton.Size = new System.Drawing.Size(173, 37);
            this.SendChangesButton.TabIndex = 2;
            this.SendChangesButton.Text = "Send Changes";
            this.SendChangesButton.Click += new System.EventHandler(this.SendChangesButton_Click);
            // 
            // EmailDetailsPage
            // 
            this.EmailDetailsPage.Controls.Add(this.IMEIListPanel);
            this.EmailDetailsPage.Controls.Add(this.ChangeDestinationLabel);
            this.EmailDetailsPage.Controls.Add(this.ChangeDestinationComboBox);
            this.EmailDetailsPage.Controls.Add(this.IMEILabel);
            this.EmailDetailsPage.Controls.Add(this.ExcelFilePathLabel);
            this.EmailDetailsPage.Controls.Add(this.ExcelFileButton);
            this.EmailDetailsPage.HorizontalScrollbarBarColor = true;
            this.EmailDetailsPage.Location = new System.Drawing.Point(4, 35);
            this.EmailDetailsPage.Name = "EmailDetailsPage";
            this.EmailDetailsPage.Size = new System.Drawing.Size(746, 311);
            this.EmailDetailsPage.TabIndex = 1;
            this.EmailDetailsPage.Text = "Email Details";
            this.EmailDetailsPage.VerticalScrollbarBarColor = true;
            // 
            // IMEIListPanel
            // 
            this.IMEIListPanel.Controls.Add(this.IMEIListTextBox);
            this.IMEIListPanel.HorizontalScrollbar = true;
            this.IMEIListPanel.HorizontalScrollbarBarColor = true;
            this.IMEIListPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.IMEIListPanel.HorizontalScrollbarSize = 10;
            this.IMEIListPanel.Location = new System.Drawing.Point(449, 21);
            this.IMEIListPanel.Name = "IMEIListPanel";
            this.IMEIListPanel.Size = new System.Drawing.Size(297, 269);
            this.IMEIListPanel.TabIndex = 14;
            this.IMEIListPanel.VerticalScrollbar = true;
            this.IMEIListPanel.VerticalScrollbarBarColor = true;
            this.IMEIListPanel.VerticalScrollbarHighlightOnWheel = false;
            this.IMEIListPanel.VerticalScrollbarSize = 10;
            // 
            // IMEIListTextBox
            // 
            this.IMEIListTextBox.Location = new System.Drawing.Point(3, 3);
            this.IMEIListTextBox.Multiline = true;
            this.IMEIListTextBox.Name = "IMEIListTextBox";
            this.IMEIListTextBox.ReadOnly = true;
            this.IMEIListTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.IMEIListTextBox.Size = new System.Drawing.Size(291, 262);
            this.IMEIListTextBox.TabIndex = 3;
            // 
            // ChangeDestinationLabel
            // 
            this.ChangeDestinationLabel.Location = new System.Drawing.Point(169, 95);
            this.ChangeDestinationLabel.Name = "ChangeDestinationLabel";
            this.ChangeDestinationLabel.Size = new System.Drawing.Size(111, 29);
            this.ChangeDestinationLabel.TabIndex = 13;
            this.ChangeDestinationLabel.Text = "Email Destination";
            this.ChangeDestinationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChangeDestinationComboBox
            // 
            this.ChangeDestinationComboBox.ItemHeight = 23;
            this.ChangeDestinationComboBox.Items.AddRange(new object[] {"Iridium", "Cellular", "Custom"});
            this.ChangeDestinationComboBox.Location = new System.Drawing.Point(50, 95);
            this.ChangeDestinationComboBox.Name = "ChangeDestinationComboBox";
            this.ChangeDestinationComboBox.Size = new System.Drawing.Size(113, 29);
            this.ChangeDestinationComboBox.TabIndex = 12;
            // 
            // IMEILabel
            // 
            this.IMEILabel.Location = new System.Drawing.Point(170, 47);
            this.IMEILabel.Name = "IMEILabel";
            this.IMEILabel.Size = new System.Drawing.Size(161, 22);
            this.IMEILabel.TabIndex = 11;
            this.IMEILabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ExcelFilePathLabel
            // 
            this.ExcelFilePathLabel.Location = new System.Drawing.Point(170, 25);
            this.ExcelFilePathLabel.Name = "ExcelFilePathLabel";
            this.ExcelFilePathLabel.Size = new System.Drawing.Size(519, 22);
            this.ExcelFilePathLabel.TabIndex = 10;
            this.ExcelFilePathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ExcelFileButton
            // 
            this.ExcelFileButton.Location = new System.Drawing.Point(50, 25);
            this.ExcelFileButton.Name = "ExcelFileButton";
            this.ExcelFileButton.Size = new System.Drawing.Size(114, 22);
            this.ExcelFileButton.TabIndex = 2;
            this.ExcelFileButton.Text = "Select IMEI List";
            this.ExcelFileButton.Click += new System.EventHandler(this.ExcelFileButton_Click);
            // 
            // ChangeFilesPage
            // 
            this.ChangeFilesPage.Controls.Add(this.ChangeFilesPanel);
            this.ChangeFilesPage.Controls.Add(this.ChangeFilesButton);
            this.ChangeFilesPage.HorizontalScrollbarBarColor = true;
            this.ChangeFilesPage.Location = new System.Drawing.Point(4, 35);
            this.ChangeFilesPage.Name = "ChangeFilesPage";
            this.ChangeFilesPage.Size = new System.Drawing.Size(746, 311);
            this.ChangeFilesPage.TabIndex = 2;
            this.ChangeFilesPage.Text = "Change Files";
            this.ChangeFilesPage.VerticalScrollbarBarColor = true;
            // 
            // ChangeFilesPanel
            // 
            this.ChangeFilesPanel.Controls.Add(this.ChangeFilesTextBox);
            this.ChangeFilesPanel.HorizontalScrollbar = true;
            this.ChangeFilesPanel.HorizontalScrollbarBarColor = true;
            this.ChangeFilesPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.ChangeFilesPanel.HorizontalScrollbarSize = 10;
            this.ChangeFilesPanel.Location = new System.Drawing.Point(225, 10);
            this.ChangeFilesPanel.Name = "ChangeFilesPanel";
            this.ChangeFilesPanel.Size = new System.Drawing.Size(494, 290);
            this.ChangeFilesPanel.TabIndex = 15;
            this.ChangeFilesPanel.VerticalScrollbar = true;
            this.ChangeFilesPanel.VerticalScrollbarBarColor = true;
            this.ChangeFilesPanel.VerticalScrollbarHighlightOnWheel = false;
            this.ChangeFilesPanel.VerticalScrollbarSize = 10;
            // 
            // ChangeFilesTextBox
            // 
            this.ChangeFilesTextBox.Location = new System.Drawing.Point(3, 3);
            this.ChangeFilesTextBox.Multiline = true;
            this.ChangeFilesTextBox.Name = "ChangeFilesTextBox";
            this.ChangeFilesTextBox.ReadOnly = true;
            this.ChangeFilesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ChangeFilesTextBox.Size = new System.Drawing.Size(488, 284);
            this.ChangeFilesTextBox.TabIndex = 3;
            this.ChangeFilesTextBox.Text = " ";
            // 
            // ChangeFilesButton
            // 
            this.ChangeFilesButton.Location = new System.Drawing.Point(50, 25);
            this.ChangeFilesButton.Name = "ChangeFilesButton";
            this.ChangeFilesButton.Size = new System.Drawing.Size(114, 22);
            this.ChangeFilesButton.TabIndex = 3;
            this.ChangeFilesButton.Text = "Select Change Files";
            this.ChangeFilesButton.Click += new System.EventHandler(this.ChangeFilesButton_Click);
            // 
            // SettingsPage
            // 
            this.SettingsPage.Controls.Add(this.SettingsLogOutButton);
            this.SettingsPage.Controls.Add(this.SettingsColourComboBox);
            this.SettingsPage.Controls.Add(this.SettingsColourLabel);
            this.SettingsPage.Controls.Add(this.SettingsDarkModeLabel);
            this.SettingsPage.Controls.Add(this.SettingsDarkModeToggle);
            this.SettingsPage.HorizontalScrollbarBarColor = true;
            this.SettingsPage.Location = new System.Drawing.Point(4, 35);
            this.SettingsPage.Name = "SettingsPage";
            this.SettingsPage.Size = new System.Drawing.Size(746, 311);
            this.SettingsPage.TabIndex = 3;
            this.SettingsPage.Text = "Settings";
            this.SettingsPage.VerticalScrollbarBarColor = true;
            // 
            // SettingsLogOutButton
            // 
            this.SettingsLogOutButton.Location = new System.Drawing.Point(614, 34);
            this.SettingsLogOutButton.Name = "SettingsLogOutButton";
            this.SettingsLogOutButton.Size = new System.Drawing.Size(114, 24);
            this.SettingsLogOutButton.TabIndex = 7;
            this.SettingsLogOutButton.Text = "Log Out";
            this.SettingsLogOutButton.Click += new System.EventHandler(this.SettingsLogOutButton_Click);
            // 
            // SettingsColourComboBox
            // 
            this.SettingsColourComboBox.FormattingEnabled = true;
            this.SettingsColourComboBox.ItemHeight = 23;
            this.SettingsColourComboBox.Items.AddRange(new object[] {"Black", "White", "Silver", "Blue", "Green", "Lime", "Teal", "Orange", "Brown", "Pink", "Magenta", "Purple", "Red", "Yellow"});
            this.SettingsColourComboBox.Location = new System.Drawing.Point(119, 68);
            this.SettingsColourComboBox.Name = "SettingsColourComboBox";
            this.SettingsColourComboBox.Size = new System.Drawing.Size(108, 29);
            this.SettingsColourComboBox.TabIndex = 6;
            this.SettingsColourComboBox.SelectedIndexChanged += new System.EventHandler(this.SettingsColourComboBox_SelectedIndexChanged);
            // 
            // SettingsColourLabel
            // 
            this.SettingsColourLabel.Location = new System.Drawing.Point(3, 68);
            this.SettingsColourLabel.Name = "SettingsColourLabel";
            this.SettingsColourLabel.Size = new System.Drawing.Size(110, 29);
            this.SettingsColourLabel.TabIndex = 5;
            this.SettingsColourLabel.Text = "Select a Colour";
            this.SettingsColourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SettingsDarkModeLabel
            // 
            this.SettingsDarkModeLabel.Location = new System.Drawing.Point(32, 40);
            this.SettingsDarkModeLabel.Name = "SettingsDarkModeLabel";
            this.SettingsDarkModeLabel.Size = new System.Drawing.Size(81, 19);
            this.SettingsDarkModeLabel.TabIndex = 3;
            this.SettingsDarkModeLabel.Text = "Dark Mode";
            this.SettingsDarkModeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SettingsDarkModeToggle
            // 
            this.SettingsDarkModeToggle.Location = new System.Drawing.Point(119, 40);
            this.SettingsDarkModeToggle.Name = "SettingsDarkModeToggle";
            this.SettingsDarkModeToggle.Size = new System.Drawing.Size(70, 21);
            this.SettingsDarkModeToggle.TabIndex = 2;
            this.SettingsDarkModeToggle.Text = "Off";
            this.SettingsDarkModeToggle.UseVisualStyleBackColor = true;
            this.SettingsDarkModeToggle.CheckedChanged += new System.EventHandler(this.SettingsDarkModeToggle_CheckedChanged);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Blue;
            // 
            // AccountLabel
            // 
            this.AccountLabel.Location = new System.Drawing.Point(476, 9);
            this.AccountLabel.Name = "AccountLabel";
            this.AccountLabel.Size = new System.Drawing.Size(240, 21);
            this.AccountLabel.TabIndex = 8;
            this.AccountLabel.Text = "Logged Out";
            this.AccountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VersionLabel
            // 
            this.VersionLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.VersionLabel.Location = new System.Drawing.Point(4, 9);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(124, 15);
            this.VersionLabel.TabIndex = 9;
            this.VersionLabel.Text = "Verison 1.2.4.2";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.AccountLabel);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Resizable = false;
            this.Text = "EWS Remote Config Tool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.TabControl.ResumeLayout(false);
            this.EmailLoginPage.ResumeLayout(false);
            this.SendChangesPage.ResumeLayout(false);
            this.ConsolePanel.ResumeLayout(false);
            this.EmailDetailsPage.ResumeLayout(false);
            this.IMEIListPanel.ResumeLayout(false);
            this.ChangeFilesPage.ResumeLayout(false);
            this.ChangeFilesPanel.ResumeLayout(false);
            this.SettingsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
        }

        private MetroFramework.Controls.MetroLabel VersionLabel;

        private MetroFramework.Controls.MetroPanel ConsolePanel;
        private MetroFramework.Controls.MetroTextBox ConsoleTextBox;

        private MetroFramework.Controls.MetroButton SendChangesButton;

        private MetroFramework.Controls.MetroTabPage SendChangesPage;

        private MetroFramework.Controls.MetroPanel ChangeFilesPanel;
        private MetroFramework.Controls.MetroTextBox ChangeFilesTextBox;

        private MetroFramework.Controls.MetroButton ChangeFilesButton;

        private MetroFramework.Controls.MetroTextBox IMEIListTextBox;

        private MetroFramework.Controls.MetroPanel IMEIListPanel;

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