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
    public partial class frmGetNewUserName : Form
    {
        public String newUserName;
        public frmGetNewUserName()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // return Cancel
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            newUserName = txtNewUserName.Text.Trim();
            if (!newUserName.Equals(""))
            {
                // return OK
                DialogResult = DialogResult.OK;            
            }
            else
            {
                MessageBox.Show("No user name provided.", "Invalid User Name", MessageBoxButtons.OK);
            }
            
        }
    }
}
