using Shaheen.ShaheenDB;

namespace Shaheen.DAL
{
    public class PaymentDAL : BaseDAL
    {
        public PaymentDAL()
        {
        }
        public int SavePayment(Payment payment)
        {
            context.Payments.Add(payment);
            context.SaveChanges();
            return payment.paymentId;
        }
    }
}
