using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LabPasswords
{
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



        // This method accepts two strings the represent two files to
        // compare. A returns true if the contents of the files
        // are the same. A returns false if the files are not the same.
        public static bool FileCompare(string file1, string file2)
        {
            int file1byte;
            int file2byte;
            FileStream fs1;
            FileStream fs2;

            // Determine if the same file was referenced two times.
            if (file1.ToUpper().Equals(file2.ToUpper()))
            {
                // Return true to indicate that the files are the same.
                return true;
            }

            // Open the two files.
            fs1 = new FileStream(file1, FileMode.Open);
            fs2 = new FileStream(file2, FileMode.Open);

            // Check the file sizes. If they are not the same, the files 
            // are not the same.
            if (fs1.Length != fs2.Length)
            {
                // Close the file
                fs1.Close();
                fs2.Close();

                // Return false to indicate files are different
                return false;
            }

            // Read and compare a byte from each file until either a
            // non-matching set of bytes is found or until the end of
            // file1 is reached.
            do
            {
                // Read one byte from each file.
                file1byte = fs1.ReadByte();
                file2byte = fs2.ReadByte();
            }
            while ((file1byte == file2byte) && (file1byte != -1));

            // Close the files.
            fs1.Close();
            fs2.Close();

            // Return the success of the comparison. "file1byte" is 
            // equal to "file2byte" at this point only if the files are 
            // the same.
            return ((file1byte - file2byte) == 0);
        }
    }
}
