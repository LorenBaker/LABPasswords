﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPasswords
{
    class clsLabPasswords
    {
        private List<clsUsers> mUsers = new List<clsUsers>();
        public List<clsUsers> Users
        {
            get { return mUsers; }
            set { mUsers = value; }
        }


        //List<clsItemTypes> mItemTypes = new List<clsItemTypes>();
        //public List<clsItemTypes> ItemTypes
        //{
        //    get { return mItemTypes; }
        //    set { mItemTypes = value; }
        //}


        private List<clsPasswordItem> mPasswordItems = new List<clsPasswordItem>();
        public List<clsPasswordItem> PasswordItems
        {
            get { return mPasswordItems; }
            set { mPasswordItems = value; }
        }

    }
}