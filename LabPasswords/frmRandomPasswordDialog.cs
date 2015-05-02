using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabPasswords
{
    public partial class frmRandomPasswordDialog : Form
    {
        public String resultPassword = "";
        private int minLenght=5;
        private int maxLenght=5;

        public frmRandomPasswordDialog()
        {
            InitializeComponent();
            minLenght = LabPasswords.Properties.Settings.Default.MinPasswordLength;
            maxLenght = LabPasswords.Properties.Settings.Default.MaxPasswordLength;

            updnMinLenght.Value = minLenght;
            updnMaxLength.Value = maxLenght;
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
             minLenght = (int)updnMinLenght.Value;
             maxLenght = (int)updnMaxLength.Value;

            if (minLenght <= maxLenght)
            {
                LabPasswords.Properties.Settings.Default.MinPasswordLength = minLenght;
                LabPasswords.Properties.Settings.Default.MaxPasswordLength = maxLenght;
                LabPasswords.Properties.Settings.Default.Save();
                String randomPassword = clsRandomPassword.Generate(minLenght, maxLenght);
                txtPassword.Text = randomPassword;
            }
            else
            {
                String msg = "The password's minimum length must be smaller than or equal to the password's maximum length";
                String title = "Invalid Password Length";
                MessageBox.Show(msg, title, MessageBoxButtons.OK);
            }
        }

        private void brnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnCopyPasswordAndClose_Click(object sender, EventArgs e)
        {
            resultPassword = txtPassword.Text;
            DialogResult = DialogResult.OK;
        }

        private void btnCopyToClipboardPasteAndClose_Click(object sender, EventArgs e)
        {
            resultPassword = txtPassword.Text;
            DialogResult = DialogResult.Yes;
        }
    }
}
