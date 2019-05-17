using Shaheen.ShaheenDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaheen.BLL
{
    public class SubscriptionDetailBLL
    {
        ShaheenEntities context = null;
        public SubscriptionDetailBLL()
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
