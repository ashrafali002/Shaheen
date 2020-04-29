using Shaheen.DAL;
using System.Linq;

namespace Shaheen.BLL
{
    public class SubscriptionBLL
    {
        public SubscriptionDAL subscriptionDal;
        public SubscriptionBLL()
        {
            subscriptionDal = new SubscriptionDAL();
        }
        public bool IsDuplicateSubscriptionCode(int subscriptionId, string subscriptionCode)
        {
            var isDuplicateFound = true;
            var duplicateList = subscriptionDal.GetDuplicateSubscriptionCode(subscriptionId, subscriptionCode);
            if (duplicateList.Count() == 0)
            {
                isDuplicateFound = false;
            }
            else
            {
                isDuplicateFound = true;
            }
            return isDuplicateFound;
        }
    }
}
