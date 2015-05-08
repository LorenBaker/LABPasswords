using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LabPasswords
{
    using Newtonsoft.Json;
    using System.Diagnostics;
    using System.IO;

    public static class clsFormattingMethods
    {

        public static String formatPhoneNumber(String unformattedPhoneNumber)
        {
            unformattedPhoneNumber = unFormatPhoneNumber((unformattedPhoneNumber));

            String formattedPhoneNumber = unformattedPhoneNumber;
            String areaCode;
            String exchange;
            String subscriber;
            switch (unformattedPhoneNumber.Length)
            {

                case 7:
                    exchange = unformattedPhoneNumber.Substring(0, 3);
                    subscriber = unformattedPhoneNumber.Substring(3, 4);
                    formattedPhoneNumber = exchange + "-" + subscriber;
                    break;

                case 10:
                    areaCode = unformattedPhoneNumber.Substring(0, 3);
                    exchange = unformattedPhoneNumber.Substring(3, 3);
                    subscriber = unformattedPhoneNumber.Substring(6, 4);
                    formattedPhoneNumber = "(" + areaCode + ") " + exchange + "-" + subscriber;
                    break;

                case 11:
                    if (unformattedPhoneNumber.StartsWith("1"))
                    {
                        areaCode = unformattedPhoneNumber.Substring(1, 3);
                        exchange = unformattedPhoneNumber.Substring(4, 3);
                        subscriber = unformattedPhoneNumber.Substring(7, 4);
                        formattedPhoneNumber = "(" + areaCode + ") " + exchange + "-" + subscriber;
                    }
                    break;

            }

            return formattedPhoneNumber;
        }

        public static String unFormatPhoneNumber(String formattedPhoneNumber)
        {
            String unformattedPhoneNumber = formattedPhoneNumber.Trim();
            if (unformattedPhoneNumber == "")
            {
                return "";
            }
            unformattedPhoneNumber = unformattedPhoneNumber.Replace(" ", "");
            unformattedPhoneNumber = unformattedPhoneNumber.Replace("-", "");
            unformattedPhoneNumber = unformattedPhoneNumber.Replace("(", "");
            unformattedPhoneNumber = unformattedPhoneNumber.Replace(")", "");
            unformattedPhoneNumber = unformattedPhoneNumber.Replace(".", "");

            switch (unformattedPhoneNumber.Length)
            {
                case 7:
                case 10:
                    return unformattedPhoneNumber;

                case 11:
                    if (unformattedPhoneNumber.StartsWith("1"))
                    {
                        unformattedPhoneNumber = unformattedPhoneNumber.Substring(1, 10);
                        return unformattedPhoneNumber;
                    }
                    else
                    {
                        unformattedPhoneNumber = unformattedPhoneNumber.Substring(0, 10);
                        return unformattedPhoneNumber;
                    }

                default:
                    int numberLength = unformattedPhoneNumber.Length;
                    if (numberLength > 10)
                    {
                        numberLength = 10;
                    }
                    unformattedPhoneNumber = unformattedPhoneNumber.Substring(0, numberLength);
                    return unformattedPhoneNumber;
            }

        }

        public static String[] CreditCardNames = { "American Express", "Diners Club", "Discover", "JCB", "MasterCard", "VISA" };
        public const String UNKNOWN = "UNKNOWN";
        public const int UNKNOWN_CARD = -1;
        public const int AMERICAN_EXPRESS = 0;
        public const int DINERS_CLUB = 1;
        public const int DISCOVER = 2;
        public const int JCB = 3;
        public const int MASTERCARD = 4;
        public const int VISA = 5;

        public const int INVALID_POSITION = -1;
        private const String dash = "\u2013";


        public class creditCard
        {
            private String cardType = UNKNOWN;
            private int cardPosition = INVALID_POSITION;
            private String formattedCardNumber = "";

            public String getCardType()
            {
                return cardType;
            }

            public void setCardType(String cardType)
            {
                this.cardType = cardType;
            }

            public String getFormattedCardNumber()
            {
                return formattedCardNumber;
            }

            public void setFormattedCardNumber(String formattedCardNumber)
            {
                this.formattedCardNumber = formattedCardNumber;
            }

            public int getCardPosition()
            {
                return cardPosition;
            }

            public void setCardPosition(int cardPosition)
            {
                this.cardPosition = cardPosition;
            }

            public creditCard()
            {

            }
        }


        public static creditCard getCreditCardType(String creditCardNumber)
        {
            creditCard card = new creditCard();
            if (creditCardNumber != null && creditCardNumber.Length > 0)
            {
                if (isVISACard(creditCardNumber))
                {
                    card.setCardPosition(VISA);
                    card.setCardType(CreditCardNames[VISA]);
                    card.setFormattedCardNumber(formatTypicalAccountNumber(creditCardNumber, 4));
                }
                else if (isMasterCard(creditCardNumber))
                {
                    card.setCardPosition(MASTERCARD);
                    card.setCardType(CreditCardNames[MASTERCARD]);
                    card.setFormattedCardNumber(formatTypicalAccountNumber(creditCardNumber, 4));
                }
                else if (isAmericanExpress(creditCardNumber))
                {
                    card.setCardPosition(AMERICAN_EXPRESS);
                    card.setCardType(CreditCardNames[AMERICAN_EXPRESS]);
                    card.setFormattedCardNumber(formatAmericanExpress(creditCardNumber));
                }
                else if (isDiscoverCard(creditCardNumber))
                {
                    card.setCardPosition(DISCOVER);
                    card.setCardType(CreditCardNames[DISCOVER]);
                    card.setFormattedCardNumber(formatTypicalAccountNumber(creditCardNumber, 4));
                }
                else if (isDinersClubCard(creditCardNumber))
                {
                    card.setCardPosition(DINERS_CLUB);
                    card.setCardType(CreditCardNames[DINERS_CLUB]);
                    card.setFormattedCardNumber(formatDinersClub(creditCardNumber));
                }
                else if (isJCBCard(creditCardNumber))
                {
                    card.setCardPosition(JCB);
                    card.setCardType(CreditCardNames[JCB]);
                    card.setFormattedCardNumber(formatTypicalAccountNumber(creditCardNumber, 4));
                }
                else
                {
                    card.setCardPosition(INVALID_POSITION);
                    card.setCardType(UNKNOWN);
                    card.setFormattedCardNumber(creditCardNumber);
                }
            }
            return card;
        }

        private const String VISACreditCardPattern = "^4[0-9]{12}(?:[0-9]{3})?$";
        private static bool isVISACard(String creditCardNumber)
        {
            Regex regex = new Regex(VISACreditCardPattern);
            Match match = regex.Match(creditCardNumber);
            return match.Success;
        }

        private const String MasterCardCreditCardPattern = "^5[1-5][0-9]{14}$";
        private static bool isMasterCard(String creditCardNumber)
        {
            Regex regex = new Regex(MasterCardCreditCardPattern);
            Match match = regex.Match(creditCardNumber);
            return match.Success;
        }

        private const String AmericanExpressCreditCardPattern = "^3[47][0-9]{13}$";
        private static bool isAmericanExpress(String creditCardNumber)
        {
            Regex regex = new Regex(AmericanExpressCreditCardPattern);
            Match match = regex.Match(creditCardNumber);
            return match.Success;
        }

        private const String DiscoverCreditCardPattern = "^6(?:011|5[0-9]{2})[0-9]{12}$";
        private static bool isDiscoverCard(String creditCardNumber)
        {
            Regex regex = new Regex(DiscoverCreditCardPattern);
            Match match = regex.Match(creditCardNumber);
            return match.Success;
        }

        private const String DinersClubCreditCardPattern = "^3(?:0[0-5]|[68][0-9])[0-9]{11}$";
        private static bool isDinersClubCard(String creditCardNumber)
        {
            Regex regex = new Regex(DinersClubCreditCardPattern);
            Match match = regex.Match(creditCardNumber);
            return match.Success;
        }

        private const String JCBCreditCardPattern = "^(?:2131|1800|35\\d{3})\\d{11}$";
        private static bool isJCBCard(String creditCardNumber)
        {
            Regex regex = new Regex(JCBCreditCardPattern);
            Match match = regex.Match(creditCardNumber);
            return match.Success;
        }

        // source: http://rosettacode.org/wiki/Luhn_test_of_credit_card_numbers
        public static bool LuhnCheck(this string cardNumber)
        {
            return LuhnCheck(cardNumber.Select(c => c - '0').ToArray());
        }

        private static bool LuhnCheck(this int[] digits)
        {
            bool result = false;
            if (digits.Length != 0)
            {
                result = GetCheckValue(digits) == 0;
            }
            return result;
        }

        private static int GetCheckValue(int[] digits)
        {
            return digits.Select((d, i) => i % 2 == digits.Length % 2 ? ((2 * d) % 10) + d / 5 : d).Sum() % 10;
        }

        public static String unformatAccountNumber(String accountNumber)
        {
            // clean up the provided accountNumber
            String unformattedAccountNumber = accountNumber.Trim();
            unformattedAccountNumber = unformattedAccountNumber.Replace("-", "");
            unformattedAccountNumber = unformattedAccountNumber.Replace(" ", "");

            unformattedAccountNumber = unformattedAccountNumber.Replace(dash, "");
            return unformattedAccountNumber;
        }

        public static String formatTypicalAccountNumber(String accountNumber, int subGroupLength)
        {
            //String formattedNumber = accountNumber;
            StringBuilder sb = new StringBuilder();
            if (subGroupLength < 1)
            {
                subGroupLength = 1;
            }

            // clean up the provided accountNumber
            accountNumber = unformatAccountNumber(accountNumber);

            if (accountNumber.Length > 0)
            {
                int substringLength = subGroupLength;
                if (substringLength > accountNumber.Length)
                {
                    substringLength = accountNumber.Length;
                }

                sb.Append(accountNumber.Substring(0, substringLength));
                // formattedNumber = accountNumber.Substring(0, substringLength);
                int remainingLength = accountNumber.Length - substringLength;
                int start = substringLength;
                while (remainingLength > 0)
                {
                    if (substringLength > remainingLength)
                    {
                        substringLength = remainingLength;
                    }
                    sb.Append(dash).Append(accountNumber.Substring(start, substringLength));
                    //formattedNumber = formattedNumber + dash + accountNumber.Substring(start, substringLength);
                    remainingLength = remainingLength - substringLength;
                    start = start + substringLength;
                }
            }

            String result = sb.ToString();
            if (result.Length == 0)
            {
                result = accountNumber;
            }

            return result;
        }

        private static String formatAmericanExpress(String accountNumber)
        {
            String formattedNumber = accountNumber;
            accountNumber = accountNumber.Trim();
            if (accountNumber.Length == 0)
            {
                formattedNumber = "";
            }
            else
            {
                if (accountNumber.Length == 15)
                {
                    formattedNumber = accountNumber.Substring(0, 4);
                    formattedNumber = formattedNumber + "-" + accountNumber.Substring(4, 6);
                    formattedNumber = formattedNumber + "-" + accountNumber.Substring(10, 5);
                }
            }

            return formattedNumber;
        }

        private static String formatDinersClub(String accountNumber)
        {
            String formattedNumber = accountNumber;
            accountNumber = accountNumber.Trim();
            if (accountNumber.Length == 0)
            {
                formattedNumber = "";
            }
            else
            {
                if (accountNumber.Length == 14)
                {
                    formattedNumber = accountNumber.Substring(0, 4);
                    formattedNumber = formattedNumber + "-" + accountNumber.Substring(4, 6);
                    formattedNumber = formattedNumber + "-" + accountNumber.Substring(10, 4);
                }
            }

            return formattedNumber;
        }

        // This method compares the provided decrypted Passwords file clsLabPasswords content 
        // with the backup file clsLabPasswords content.
        // Returns true if the decrypted contents of the files are the same.
        // Returns false if the files are not the same.
        public static bool PasswordsFileCompare(String key, clsLabPasswords passwordsObject, String backupFilename)
        {
            String backupFileEncryptedContents = "";
            try
            {
                // verify that the backup file exists ... if not, return false
                if (!File.Exists(backupFilename))
                {
                    Debug.WriteLine("clsFormattingMethods: FileCompare: " + backupFilename + " file not found... returning false");
                    return false;
                }

                // Read the backup file
                backupFileEncryptedContents = File.ReadAllText(backupFilename);

            }
            catch (IOException e)
            {
                Debug.WriteLine("clsFormattingMethods: FileCompare: IOException: " + e.Message + " ... returning false");
                return false;
            }

            // Decrypt the backup file
            if (backupFileEncryptedContents.Equals(""))
            {
                // there is nothing to decrypt .... return false
                Debug.WriteLine("clsFormattingMethods: FileCompare: backup file encrypted content is empty... returning false");
                return false;
            }

            String decryptedBackupFileContents;
            try
            {
                CryptLib _crypt = new CryptLib();
                String iv = backupFileEncryptedContents.Substring(0, 16);
                backupFileEncryptedContents = backupFileEncryptedContents.Substring(16, backupFileEncryptedContents.Length - 16);
                decryptedBackupFileContents = _crypt.decrypt(backupFileEncryptedContents, key, iv);
                decryptedBackupFileContents = decryptedBackupFileContents.Trim();
            }
            catch (Exception e)
            {
                Debug.WriteLine("clsFormattingMethods: FileCompare: Exception decrypting backup file: " + e.Message + " ... returning false");
                return false;
            }

            // Create clsLabPasswords object from the backup file
            clsLabPasswords backupFilePasswordsObject = JsonConvert.DeserializeObject<clsLabPasswords>(decryptedBackupFileContents);

            bool result = false;

            if (passwordsObject != null && backupFilePasswordsObject != null)
            {
                // Sort the backup file object
                if (backupFilePasswordsObject.PasswordItems.Count > 0)
                {

                    //backupFilePasswordsObject.PasswordItems.Sort((a, b) => String.Compare(a.Name.ToUpper(), b.Name.ToUpper()));
                    backupFilePasswordsObject.PasswordItems.Sort((a, b) =>
                    {
                        int ret = a.Name.ToUpper().CompareTo(b.Name.ToUpper());
                        if (ret == 0)
                        {
                            ret = a.ID - b.ID;
                        }
                        return ret;
                    });
                }

                if (backupFilePasswordsObject.Users.Count > 0)
                {
                    //backupFilePasswordsObject.Users.Sort((a, b) => String.Compare(a.UserName.ToUpper(), b.UserName.ToUpper()));
                    backupFilePasswordsObject.Users.Sort((a, b) =>
                    {
                        int ret = a.UserName.ToUpper().CompareTo(b.UserName.ToUpper());
                        if (ret == 0) ret = a.UserID.CompareTo(b.UserID);
                        return ret;
                    });
                }

                // Compare the password items count
                if (passwordsObject.PasswordItems.Count == backupFilePasswordsObject.PasswordItems.Count)
                {
                    // Compare the users items count
                    if (passwordsObject.Users.Count == passwordsObject.Users.Count)
                    {
                        // Compare the user lists
                        if (compareUsers(passwordsObject.Users, passwordsObject.Users))
                        {
                            // Compare the password itme lists
                            result = comparePasswordItems(passwordsObject.PasswordItems, backupFilePasswordsObject.PasswordItems);
                        }
                    }
                }
            }

            return result;
        }


        private static bool comparePasswordItems(List<clsPasswordItem> passwordsItemsList1, List<clsPasswordItem> passwordsItemsList2)
        {
            bool result = false;
            int index = 0;

            foreach (clsPasswordItem item1 in passwordsItemsList1)
            {
                clsPasswordItem item2 = passwordsItemsList2[index];
                if (item1.ID != item2.ID)
                {
                    Debug.WriteLine("clsFormattingMethods: comparePasswordItems: item IDs are NOT the same! index = "
                        + index + "; item1 ID = " + item1.ID + "; item2 ID = " + item2.ID
                        + "; item1 Name = " + item1.Name + "; item 2 Name = " + item2.Name);
                    return result;
                }

                if (!item1.AlternatePhoneNumber.Equals(item2.AlternatePhoneNumber)) break;
                if (!item1.Comments.Equals(item2.Comments)) break;
                if (!item1.CreditCardAccountNumber.Equals(item2.CreditCardAccountNumber)) break;
                if (!item1.CreditCardExpirationMonth.Equals(item2.CreditCardExpirationMonth)) break;
                if (!item1.CreditCardExpirationYear.Equals(item2.CreditCardExpirationYear)) break;
                if (!item1.CreditCardSecurityCode.Equals(item2.CreditCardSecurityCode)) break;
                if (!item1.GeneralAccountNumber.Equals(item2.GeneralAccountNumber)) break;
                if (item1.ItemType_ID != item2.ItemType_ID) break;
                if (!item1.Name.Equals(item2.Name)) break;
                if (!item1.PrimaryPhoneNumber.Equals(item2.PrimaryPhoneNumber)) break;
                if (!item1.SoftwareKeyCode.Equals(item2.SoftwareKeyCode)) break;
                if (item1.SoftwareSubgroupLength != item2.SoftwareSubgroupLength) break;
                if (item1.User_ID != item2.User_ID) break;
                if (!item1.WebsitePassword.Equals(item2.WebsitePassword)) break;
                if (!item1.WebsiteURL.Equals(item2.WebsiteURL)) break;
                if (!item1.WebsiteUserID.Equals(item2.WebsiteUserID)) break;

                index++;
            }

            if (index == passwordsItemsList1.Count)
            {
                // All password items examined. The two password item lists are the same.
                result = true;
            }
            return result;
        }

        private static bool compareUsers(List<clsUsers> userList1, List<clsUsers> userList2)
        {
            bool result = false;
            int index = 0;

            foreach (clsUsers user1 in userList1)
            {
                clsUsers user2 = userList2[index];
                if (user1.UserID != user2.UserID)
                {
                    Debug.WriteLine("clsFormattingMethods: compareUsers: user IDs are NOT the same!");
                    break;
                }

                if (!user1.UserName.Equals(user2.UserName)) break;
                index++;
            }

            if (index == userList1.Count)
            {
                // All users examined. The two user lists are the same.
                result = true;
            }

            return result;
        }


        // This method accepts two strings (full file names) the represent the two files to compare.
        // Returns true if the contents of the files are the same.
        // Returns false if the files are not the same.
        //public static bool FileCompare(string file1, string file2)
        //{
        //    int file1byte;
        //    int file2byte;
        //    FileStream fs1;
        //    FileStream fs2;

        //    // Determine if the same file was referenced two times.
        //    if (file1.ToUpper().Equals(file2.ToUpper()))
        //    {
        //        // Return true to indicate that the files are the same.
        //        return true;
        //    }

        //    // Open the two files.
        //    fs1 = new FileStream(file1, FileMode.Open);
        //    fs2 = new FileStream(file2, FileMode.Open);

        //    // Check the file sizes. If they are not the same, the files 
        //    // are not the same.
        //    if (fs1.Length != fs2.Length)
        //    {
        //        // Close the file
        //        fs1.Close();
        //        fs2.Close();

        //        // Return false to indicate files are different
        //        return false;
        //    }

        //    // Read and compare a byte from each file until either a
        //    // non-matching set of bytes is found or until the end of
        //    // file1 is reached.
        //    do
        //    {
        //        // Read one byte from each file.
        //        file1byte = fs1.ReadByte();
        //        file2byte = fs2.ReadByte();
        //    }
        //    while ((file1byte == file2byte) && (file1byte != -1));

        //    // Close the files.
        //    fs1.Close();
        //    fs2.Close();

        //    // Return the success of the comparison. "file1byte" is 
        //    // equal to "file2byte" at this point only if the files are 
        //    // the same.
        //    return ((file1byte - file2byte) == 0);
        //}
    }
}
