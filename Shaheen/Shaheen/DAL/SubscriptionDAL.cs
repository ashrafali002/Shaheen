using Shaheen.ShaheenDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaheen.DAL
{
    public class SubscriptionDAL : BaseDAL
    {
        public SubscriptionDAL()
        {
        }
        public int SaveSubscription(Subscription subscription)
        {
            context.Subscriptions.Add(subscription);
            context.SaveChanges();
            return subscription.subscriptionId;
        }
        public bool CheckDuplicateSubscription(string subscriptionCode)
        {
            bool duplicateFound = false;
            var resultCount = context.Subscriptions.Where(w => w.subscriptionCode == subscriptionCode).ToList();
            if (resultCount.Count > 0)
                duplicateFound = true;
            else
                duplicateFound = false;
            return duplicateFound;
        }
    }
}
