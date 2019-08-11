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
    }
}
