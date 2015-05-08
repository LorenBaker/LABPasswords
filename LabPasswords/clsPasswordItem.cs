using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace LabPasswords
{
    public class clsPasswordItem : INotifyPropertyChanged
    {
        public int ID { get; set; }

        private String nameValue;
        public String Name
        {
            get
            {
                return this.nameValue;
            }

            set
            {
                if (!value.Equals(this.nameValue))
                {
                    this.nameValue = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private int ItemType_IDValue;
        public int ItemType_ID
        {
            get
            {
                return this.ItemType_IDValue;
            }

            set
            {
                if (value != this.ItemType_IDValue)
                {
                    this.ItemType_IDValue = value;
                    NotifyPropertyChanged();
                }
            }
        }


        private int User_IDValue;
        public int User_ID
        {
            get
            {
                return this.User_IDValue;
            }

            set
            {
                if (value != this.User_IDValue)
                {
                    this.User_IDValue = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private String SoftwareKeyCodeValue;
        public String SoftwareKeyCode
        {
            get
            {
                return this.SoftwareKeyCodeValue;
            }

            set
            {
                if (!value.Equals(this.SoftwareKeyCodeValue))
                {
                    this.SoftwareKeyCodeValue = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private int SoftwareSubgroupLengthValue;
        public int SoftwareSubgroupLength
        {
            get
            {
                return this.SoftwareSubgroupLengthValue;
            }

            set
            {
                if (value != this.SoftwareSubgroupLengthValue)
                {
                    this.SoftwareSubgroupLengthValue = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private String CommentsValue;
        public String Comments
        {
            get
            {
                return this.CommentsValue;
            }

            set
            {
                if (!value.Equals(this.CommentsValue))
                {
                    this.CommentsValue = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private String CreditCardAccountNumberValue;
        public String CreditCardAccountNumber
        {
            get
            {
                return this.CreditCardAccountNumberValue;
            }

            set
            {
                if (!value.Equals(this.CreditCardAccountNumberValue))
                {
                    this.CreditCardAccountNumberValue = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private String CreditCardSecurityCodeValue;
        public String CreditCardSecurityCode
        {
            get
            {
                return this.CreditCardSecurityCodeValue;
            }

            set
            {
                if (!value.Equals(this.CreditCardSecurityCodeValue))
                {
                    this.CreditCardSecurityCodeValue = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private String CreditCardExpirationMonthValue;
        public String CreditCardExpirationMonth
        {
            get
            {
                return this.CreditCardExpirationMonthValue;
            }

            set
            {
                if (!value.Equals(this.CreditCardExpirationMonthValue))
                {
                    this.CreditCardExpirationMonthValue = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private String CreditCardExpirationYearValue;
        public String CreditCardExpirationYear
        {
            get
            {
                return this.CreditCardExpirationYearValue;
            }

            set
            {
                if (!value.Equals(this.CreditCardExpirationYearValue))
                {
                    this.CreditCardExpirationYearValue = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private String GeneralAccountNumberValue;
        public String GeneralAccountNumber
        {
            get
            {
                return this.GeneralAccountNumberValue;
            }

            set
            {
                if (!value.Equals(this.GeneralAccountNumberValue))
                {
                    this.GeneralAccountNumberValue = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private String PrimaryPhoneNumberValue;
        public String PrimaryPhoneNumber
        {
            get
            {
                return this.PrimaryPhoneNumberValue;
            }

            set
            {
                if (!value.Equals(this.PrimaryPhoneNumberValue))
                {
                    this.PrimaryPhoneNumberValue = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private String AlternatePhoneNumberValue;
        public String AlternatePhoneNumber
        {
            get
            {
                return this.AlternatePhoneNumberValue;
            }

            set
            {
                if (!value.Equals(this.AlternatePhoneNumberValue))
                {
                    this.AlternatePhoneNumberValue = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private String WebsiteURLValue;
        public String WebsiteURL
        {
            get
            {
                return this.WebsiteURLValue;
            }

            set
            {
                if (!value.Equals(this.WebsiteURLValue))
                {
                    this.WebsiteURLValue = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private String WebsiteUserIDValue;
        public String WebsiteUserID
        {
            get
            {
                return this.WebsiteUserIDValue;
            }

            set
            {
                if (!value.Equals(this.WebsiteUserIDValue))
                {
                    this.WebsiteUserIDValue = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private String WebsitePasswordValue;
        public String WebsitePassword
        {
            get
            {
                return this.WebsitePasswordValue;
            }

            set
            {
                if (!value.Equals(this.WebsitePasswordValue))
                {
                    this.WebsitePasswordValue = value;
                    NotifyPropertyChanged();
                }
            }
        }

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
            CreditCardExpirationYear = "";
            GeneralAccountNumber = "";
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



        public event PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property. 
        // The CallerMemberName attribute that is applied to the optional propertyName 
        // parameter causes the property name of the caller to be substituted as an argument. 
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
