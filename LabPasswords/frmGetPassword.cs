using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabPasswords
{
    public partial class frmGetPassword : Form
    {
        public String passwordKey = "";
        public frmGetPassword()
        {
            InitializeComponent();
        }

        private void frmGetPassword_Load(object sender, EventArgs e)
        {
            txtWarningMessage.Rtf = @"{\rtf1\ansi \b WARNING\b0. Please remember your Password. It is used to encrypt your Passwords file and is \b NOT\b0 stored. There is no way to reset or recover your Password";        
        }


        private void frmGetPassword_Shown(object sender, EventArgs e)
        {
            if (LabPasswords.Properties.Settings.Default.PasswordsDropboxFolder.Equals(""))
            {
                String msg = "Please select a Dropbox folder";
                MessageBox.Show(msg, "Select Dropbox Folder", MessageBoxButtons.OK);
            }
            else
            {
                txtDropboxFolder.Text = LabPasswords.Properties.Settings.Default.PasswordsDropboxFolder;
                if (!Directory.Exists(txtDropboxFolder.Text))
                {
                    showDropboxFolderNotExistDialog();
                }
            }
            txtPassword.Select();
            //TODO: remove hard coded password
            //txtPassword.Text = "Test Password";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String dropboxFolder = txtDropboxFolder.Text.Trim();
            if (!Directory.Exists(dropboxFolder))
            {
                showDropboxFolderNotExistDialog();
            }
            else
            {
                // The selected dropbox folder exists .... so save it
                LabPasswords.Properties.Settings.Default.PasswordsDropboxFolder = dropboxFolder;
                LabPasswords.Properties.Settings.Default.Save();

                // Make sure that the password is not empty
                String password = txtPassword.Text.Trim();
                if (password.Equals(""))
                {
                    showPasswordEmptyDialog();
                }
                else
                {
                    // Create the password key
                    passwordKey = CryptLib.getHashSha256(password, 32); //32 bytes = 256 bits
                    // Clear variables that hold the password value
                    txtPassword.Text = "";
                    password = "";
                    // return OK
                    DialogResult = DialogResult.OK;
                }
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


        private void showDropboxFolderNotExistDialog()
        {
            StringBuilder msg = new StringBuilder();
            msg.Append("The provided Dropbox folder does not exits!")
                .Append(System.Environment.NewLine)
                .Append(" Please select a Dropbox folder");
            MessageBox.Show(msg.ToString(), "Select Dropbox Folder", MessageBoxButtons.OK);
        }


        private void showPasswordEmptyDialog()
        {
            StringBuilder msg = new StringBuilder();
            msg.Append("The provided Password is empty!")
                .Append(System.Environment.NewLine)
                .Append(" Please Enter Password");
            MessageBox.Show(msg.ToString(), "Enter Password", MessageBoxButtons.OK);
        }

        private void btnDisplayPassword_Click(object sender, EventArgs e)
        {
            if (btnDisplayPassword.Text.Equals("Display"))
            {
                btnDisplayPassword.Text = "Hide";
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                btnDisplayPassword.Text = "Display";
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnBrowseForDropboxFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDropboxFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }



    }
}
