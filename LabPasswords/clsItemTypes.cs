using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPasswords
{
    class clsItemTypes 
    {
        public int ItemTypeID { get; set; }
        public String ItemType { get; set; }



        public override string ToString()
        {
            return this.ItemType;
        }
    }
}
