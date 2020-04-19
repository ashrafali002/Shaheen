using Shaheen.ShaheenDB;

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
