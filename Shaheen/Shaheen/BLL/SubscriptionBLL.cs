using Shaheen.DAL;

namespace Shaheen.BLL
{
    public class SubscriptionBLL
    {
        public bool CheckDuplicateSubscription(string subscriptionCode)
        {
            var subscriptionDAL = new SubscriptionDAL();
            bool duplicateFound = false;
            duplicateFound = subscriptionDAL.CheckDuplicateSubscription(subscriptionCode);
            return duplicateFound;
        }
    }
}
