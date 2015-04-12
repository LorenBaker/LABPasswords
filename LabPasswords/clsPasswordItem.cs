using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPasswords
{
    class clsPasswordItem 

    {
        public int ID  { get; set; }
        public String Name { get; set; }
        public int ItemType_ID{ get; set; }
        public int User_ID{ get; set; }      
        public String SoftwareKeyCode{ get; set; }       
        public int SoftwareSubgroupLength{ get; set; }
        public String Comments{ get; set; }      
        public String CreditCardAccountNumber{ get; set; }      
        public String CreditCardSecurityCode{ get; set; }     
        public String CreditCardExpirationMonth{ get; set; }
        public String CreditCardExpirationYear { get; set; }          
        public String GeneralAccountNumber{ get; set; }      
        public String PrimaryPhoneNumber{ get; set; }        
        public String AlternatePhoneNumber{ get; set; }       
        public String WebsiteURL{ get; set; }       
        public String WebsiteUserID{ get; set; }
        public String WebsitePassword{ get; set; }

        public clsPasswordItem(int newItemID)
        {
            ID = newItemID;
            Name = "NewItem";
            ItemType_ID = -1;
            User_ID = -1;
            SoftwareKeyCode = "";
            SoftwareSubgroupLength = 4;
            Comments = "";
            CreditCardAccountNumber = "";
            CreditCardSecurityCode = "";
            CreditCardExpirationMonth = "";
            CreditCardExpirationYear="";
            GeneralAccountNumber="";
            PrimaryPhoneNumber = "";
            AlternatePhoneNumber = "";
            WebsiteURL = "";
            WebsiteUserID = "";
            WebsitePassword = "";


        }

        public override string ToString()
        {
            return this.Name;
        }


    }
}
