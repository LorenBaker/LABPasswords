using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPasswords
{
    public class clsLabPasswords
    {
        private List<clsUsers> mUsers = new List<clsUsers>();
        public List<clsUsers> Users
        {
            get { return mUsers; }
            set { mUsers = value; }
        }

        private List<clsPasswordItem> mPasswordItems = new List<clsPasswordItem>();
        public List<clsPasswordItem> PasswordItems
        {
            get { return mPasswordItems; }
            set { mPasswordItems = value; }
        }

    }
}
