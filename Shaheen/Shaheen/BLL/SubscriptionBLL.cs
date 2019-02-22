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
        static ShaheenEntities entities = null;
        public SubscriptionBLL()
        {
            entities = new ShaheenEntities();
        }
        public int SaveSubscription(Subscription subscription)
        {
            entities.Subscriptions.Add(subscription);
            entities.SaveChanges();
            return subscription.subscriptionId;
        }
    }
}
