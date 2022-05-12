using System.Text.RegularExpressions;

namespace Utility
{    public static class ValidationUtility
    {
        public static bool ValidName(string name)
        {
            string strRegex = "^[a-z]([a-z]|-|\\s)*";
            Regex re = new Regex(strRegex, RegexOptions.IgnoreCase);
            return re.IsMatch(name);
        }
        public static bool ValidPhoneNumber(string phoneNumber)
        {
            string strRegex = "^[0-9]([0-9]|/|\\s|.)*";
            Regex re = new Regex(strRegex, RegexOptions.IgnoreCase);
            return re.IsMatch(phoneNumber);
        }
        public static bool ValidEmailAddress(string emailAddress)
        {
            string strRegex = "\\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\\Z";
            Regex re = new Regex(strRegex, RegexOptions.IgnoreCase);
            return re.IsMatch(emailAddress);
        }
        public static bool ValidAll(string name, string phoneNumber,string emailAddress)
        {
            if(ValidName(name)&&ValidPhoneNumber(phoneNumber)&&ValidEmailAddress(emailAddress))
                return true;
            return false;
        }
    }
}