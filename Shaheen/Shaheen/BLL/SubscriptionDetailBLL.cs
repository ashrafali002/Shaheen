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
        static ShaheenEntities entities = null;
        public SubscriptionDetailBLL()
        {
            entities = new ShaheenEntities();
        }
        public int SaveSubscriptionDetail(SubscriptionDetail subscriptionDetail)
        {
            entities.SubscriptionDetails.Add(subscriptionDetail);
            entities.SaveChanges();
            return subscriptionDetail.subscriptionDetailId;
        }
    }
}
