using Shaheen.ShaheenDB;
using System.Collections.Generic;
using System.Linq;

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
        public List<Subscription> GetDuplicateSubscriptionCode(int subscriptionId, string subscriptionCode)
        {
            return context.Subscriptions.Where(w => w.subscriptionCode == subscriptionCode && w.subscriptionId != subscriptionId).ToList();
        }
    }
}
