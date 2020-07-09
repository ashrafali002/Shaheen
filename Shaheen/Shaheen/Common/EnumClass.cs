using System;

namespace Shaheen
{
    public class EnumClass
    {

    }

    public class MessageText
    {
        public const string MessageBoxCaption = "Shaheen Weekly";
        public const string ConfirmEdit = "Are you sure want to edit the record?";
        public const string ConfirmDelete = "Are you sure want to delete the record?";
        public const string SaveMessage = "Record saved successfully";
    }
    public enum PaymentType
    {
        Cash,
        DD,
        Cheque,
        MO
    }

    public enum SubscriptionType
    {
        Paid = 1,
        Free = 2,
        Donar = 3,
        Exchange = 4,
        Advertisement = 5
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

        public static string NullToString(object obj)
        {
            if (obj == System.DBNull.Value)
                return string.Empty;
            else
                return Convert.ToString(obj);            
        }

        public static int NullToInt(object obj)
        {
            if (obj == System.DBNull.Value)
                return 0;
            else
                return Convert.ToInt32(obj);
        }

        public static decimal NullToDecimal(object obj)
        {
            if (obj == System.DBNull.Value)
                return 0;
            else
                return Convert.ToDecimal(obj);
        }

        public static DateTime? NullToDateTime(object obj)
        {
            if (obj == System.DBNull.Value)
                return null;
            else
                return Convert.ToDateTime(obj);
        }
    }

    public class GlobalVariables
    {
        public static string userName { get; set; }
        public static int userType { get; set; }
    }

    
}
