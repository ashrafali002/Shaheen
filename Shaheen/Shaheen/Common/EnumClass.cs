﻿using System;

namespace Shaheen
{
    public class EnumClass
    {

    }

    public class MessageText
    {
        public const string MessageBoxCaption = "Ishtiraq - Shaheen Weekly";
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
        Complementary = 3

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
