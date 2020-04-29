using System;

namespace Shaheen
{
    public class EnumClass
    {

    }

    public enum PaymentType
    {
        Cash,
        DD,
        Cheque,
        MO
    }

    public class CommonFunctions
    {
        public static bool checkEmail(string email)
        {
            bool isValid = false;
            try
            {
                new System.Net.Mail.MailAddress(email);
                isValid = true;
            }
            catch
            {
                isValid = false;
            }
            return isValid;
        }
    }


}
