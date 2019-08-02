using Shaheen.ShaheenDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaheen.DAL
{
    public class SubscriptionDAL
    {
        ShaheenEntities context = null;
        public SubscriptionDAL()
        {
            context = new ShaheenEntities();
        }
        public int SaveSubscription(Subscription subscription)
        {
            context.Subscriptions.Add(subscription);
            context.SaveChanges();
            return subscription.subscriptionId;
        }
    }
}
