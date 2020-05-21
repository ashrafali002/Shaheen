using Shaheen.DAL;
using Shaheen.IshraqEntities;
using System.Collections.Generic;

namespace Shaheen.BLL
{
    public class PaymentBLL
    {
        public PaymentDAL paymentDal;
        public PaymentBLL()
        {
            paymentDal = new PaymentDAL();
        }
        public List<Payment> GetPaymentBySubscriptionId(int subscriptionId)
        {
            return paymentDal.GetPaymentBySubscriptionId(subscriptionId);
        }
        public int SavePayment(Payment payment)
        {
            return paymentDal.SavePayment(payment);
        }
        public Payment GetPaymentById(int Id)
        {
            return paymentDal.GetPaymentById(Id);
        }
        public void DeletePayment(int paymentId)
        {
            paymentDal.DeletePayment(paymentId);
        }
    }
}
