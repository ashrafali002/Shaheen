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
    public enum SubscriptionStatus
    {
        Active = 1,     //Active Subscription
        Close = 2,      //Close Subscription
        Continue = 3    //Expired but Active
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
