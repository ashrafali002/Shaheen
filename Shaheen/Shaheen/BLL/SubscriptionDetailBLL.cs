using Shaheen.DAL;
using Shaheen.ShaheenDB;

namespace Shaheen.BLL
{
    public class SubscriptionDetailBLL
    {
        public SubscriptionDetailDAL subscriptionDetailDal;
        public SubscriptionDetailBLL()
        {
            subscriptionDetailDal = new SubscriptionDetailDAL();
        }

        public SubscriptionDetail GetSubscriptionDetailById(int Id)
        {
            return subscriptionDetailDal.GetSubscriptionDetailById(Id);
        }
        public int SaveSubscriptionDetail(SubscriptionDetail subscriptionDetail)
        {
            return subscriptionDetailDal.SaveSubscriptionDetail(subscriptionDetail);
        }
    }
}
