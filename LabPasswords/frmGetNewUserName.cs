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
        private List<clsUsers> mUsers = null;
        public frmGetNewUserName(List<clsUsers> users)
        {
            InitializeComponent();
            this.mUsers = users;
        }
        //public frmGetNewUserName()
        //{

        //}

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // return Cancel
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            newUserName = txtNewUserName.Text.Trim();
            if (isValidUserName())
            {
                // return OK
                DialogResult = DialogResult.OK;
            }
            else
            {
                StringBuilder msg = new StringBuilder();
                msg.Append("Provided user name is already in the database or is empty.").Append(System.Environment.NewLine)
                    .Append("Please enter a valid name");
                MessageBox.Show(msg.ToString(), "Invalid User Name", MessageBoxButtons.OK);
            }
        }

        private bool isValidUserName()
        {
            bool result = true;
            String name = newUserName.ToUpper();

            if (name.Equals("") || mUsers == null)
            {
                result = false;
            }
            else
            {
                // name is not valid if the user's name already exists in the data base
                foreach (clsUsers user in mUsers)
                {
                    if (user.UserName.ToUpper().Equals(name))
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
