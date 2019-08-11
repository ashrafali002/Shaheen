using Shaheen.ShaheenDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaheen.DAL
{
    public class SubscriptionDetailDAL : BaseDAL
    {
        public SubscriptionDetailDAL()
        {
        }
        public int SaveSubscriptionDetail(SubscriptionDetail subscriptionDetail)
        {
            context.SubscriptionDetails.Add(subscriptionDetail);
            context.SaveChanges();
            return subscriptionDetail.subscriptionDetailId;
        }
    }
}
