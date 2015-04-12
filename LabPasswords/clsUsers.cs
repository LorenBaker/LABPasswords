using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPasswords 
{
    class clsUsers 
    {
        public int UserID { get; set; }
        public String UserName { get; set; }

        public override string ToString()
        {
            return this.UserName;
        }
    }
}
