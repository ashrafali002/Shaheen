using Shaheen.ShaheenDB;
using System.Data.Entity;
using System.Linq;

namespace Shaheen.DAL
{
    public class SubscriptionDetailDAL : BaseDAL
    {
        public SubscriptionDetailDAL()
        {
        }
        public SubscriptionDetail GetSubscriptionDetailById(int Id)
        {
            return context.SubscriptionDetails.Where(w => w.subscriptionDetailId == Id).FirstOrDefault();
        }
        public int SaveSubscriptionDetail(SubscriptionDetail subscriptionDetail)
        {
            if (subscriptionDetail.subscriptionDetailId == 0)
            {
                context.SubscriptionDetails.Add(subscriptionDetail);
            }
            else
            {
                SubscriptionDetail sd = context.SubscriptionDetails.Find(subscriptionDetail.subscriptionDetailId);
                sd.subscriptionId = subscriptionDetail.subscriptionId;
                sd.subscriptionDuration = subscriptionDetail.subscriptionDuration;
                sd.subscriptionAmount = subscriptionDetail.subscriptionAmount;
                sd.subscriptionStartDate = subscriptionDetail.subscriptionStartDate;
                sd.subscriptionEndDate = subscriptionDetail.subscriptionEndDate;
                sd.note = subscriptionDetail.note;
                sd.status = subscriptionDetail.status;
                context.Entry(sd).State = EntityState.Modified;
            }
            context.SaveChanges();
            return subscriptionDetail.subscriptionDetailId;
        }
    }
}
