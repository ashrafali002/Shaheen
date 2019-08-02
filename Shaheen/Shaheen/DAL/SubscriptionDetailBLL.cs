using Shaheen.ShaheenDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaheen.DAL
{
    public class SubscriptionDetailDAL
    {
        ShaheenEntities context = null;
        public SubscriptionDetailDAL()
        {
            context = new ShaheenEntities();
        }
        public int SaveSubscriptionDetail(SubscriptionDetail subscriptionDetail)
        {
            context.SubscriptionDetails.Add(subscriptionDetail);
            context.SaveChanges();
            return subscriptionDetail.subscriptionDetailId;
        }
    }
}
