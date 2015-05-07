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
    public partial class frmChangePassword : Form
    {

        public String passwordKey = "";

        public frmChangePassword()
        {
            InitializeComponent();
        }


        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            txtWarningMessage.Rtf = @"{\rtf1\ansi \b WARNING\b0. Please remember your Password. It is used to encrypt your Passwords file and is \b NOT\b0 stored. There is no way to reset or recover your Password";

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
        }

        private void btnBrowseForDropboxFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDropboxFolder.Text = folderBrowserDialog1.SelectedPath;
            }
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

        private void btnDisplayReenterPassword_Click(object sender, EventArgs e)
        {
            if (btnDisplayReenterPassword.Text.Equals("Display"))
            {
                btnDisplayReenterPassword.Text = "Hide";
                txtReenterPassword.PasswordChar = '\0';
            }
            else
            {
                btnDisplayReenterPassword.Text = "Display";
                txtReenterPassword.PasswordChar = '*';
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
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
                String reenteredPassword = txtReenterPassword.Text.Trim();

                if (password.Equals("") || reenteredPassword.Equals(""))
                {
                    showPasswordEmptyDialog();
                }
                else
                {
                    if (password.Equals(reenteredPassword))
                    {
                        // Create the password key
                        passwordKey = CryptLib.getHashSha256(password, 32); //32 bytes = 256 bits
                        // Clear variables that hold the password value
                        txtPassword.Text = "";
                        password = "";
                        txtReenterPassword.Text = "";
                        reenteredPassword = "";
                        // return OK
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        StringBuilder msg = new StringBuilder();
                        msg.Append("Passwords are not identical!").Append(System.Environment.NewLine)
                            .Append("Please reenter Passwords.");
                        MessageBox.Show(msg.ToString(), "Reenter Passwords", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            validatePasswordsAreTheSame();
        }

        private void txtReenterPassword_TextChanged(object sender, EventArgs e)
        {
            validatePasswordsAreTheSame();
        }


        private void validatePasswordsAreTheSame()
        {
            String password = txtPassword.Text.Trim();
            String reenteredPassword = txtReenterPassword.Text.Trim();

            if (password.Equals(reenteredPassword))
            {
                btnOK.Enabled = true;
                picCheckMark.Image = LabPasswords.Properties.Resources.check_on;
            }
            else
            {
                btnOK.Enabled = false;
                picCheckMark.Image = LabPasswords.Properties.Resources.check_off;
            }
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
            msg.Append("One or both of the provided Passwords is empty!")
                .Append(System.Environment.NewLine)
                .Append(" Please Enter Passwords");
            MessageBox.Show(msg.ToString(), "Enter Passwords", MessageBoxButtons.OK);
        }

    }
}
