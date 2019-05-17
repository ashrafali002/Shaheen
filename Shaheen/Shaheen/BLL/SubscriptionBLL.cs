using Shaheen.ShaheenDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaheen.BLL
{
    public class SubscriptionBLL
    {
        ShaheenEntities context = null;
        public SubscriptionBLL()
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
