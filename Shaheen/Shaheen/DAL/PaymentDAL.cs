using Shaheen.ShaheenDB;
using System.Collections.Generic;
using System.Linq;

namespace Shaheen.DAL
{
    public class PaymentDAL : BaseDAL
    {
        public PaymentDAL()
        {
        }

        public List<Payment> GetPaymentBySubscriptionId(int subscriptionId)
        {
            return context.Payments.Where(w => w.subscriptionId == subscriptionId).ToList();
        }

        public int SavePayment(Payment payment)
        {
            if (payment.paymentId == 0)
            {
                context.Payments.Add(payment);
            }
            else
            {
                Payment p = context.Payments.Find(payment.paymentId);
                p.subscriptionId = payment.subscriptionId;
                p.paymentType = payment.paymentType;
                p.paymentDate = payment.paymentDate;
                p.chequeNo = payment.chequeNo;
                p.chequeDate = payment.chequeDate;
                p.amountPaid = payment.amountPaid;
                p.receiptNo = payment.receiptNo;
                p.bankName = payment.bankName;
                context.Entry(p).State = System.Data.Entity.EntityState.Modified;
            }
            context.SaveChanges();
            return payment.paymentId;
        }

        public Payment GetPaymentById(int Id)
        {
            return context.Payments.Where(w => w.paymentId == Id).FirstOrDefault();
        }
        public void DeletePayment(int paymentId)
        {
            var p = context.Payments.Find(paymentId);
            context.Payments.Remove(p);
            context.SaveChanges();
        }
    }
}
