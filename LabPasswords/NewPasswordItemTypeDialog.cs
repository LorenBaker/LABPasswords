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
    public partial class NewPasswordItemTypeDialog : Form

    {
        public int ItemTypeID = 1;

        public NewPasswordItemTypeDialog()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void rbCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            ItemTypeID = 1;
        }

        private void rbGeneralAccount_CheckedChanged(object sender, EventArgs e)
        {
            ItemTypeID = 2;
        }

        private void rbSoftware_CheckedChanged(object sender, EventArgs e)
        {
            ItemTypeID = 3;
        }

        private void rbWebsite_CheckedChanged(object sender, EventArgs e)
        {
            ItemTypeID = 4;
        }
    }
}
