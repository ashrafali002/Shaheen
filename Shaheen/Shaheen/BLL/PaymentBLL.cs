using Shaheen.ShaheenDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaheen.BLL
{
    public class PaymentBLL
    {
        ShaheenEntities context = null;
        public PaymentBLL()
        {
            context = new ShaheenEntities();
        }
        public int SavePayment(Payment payment)
        {
            context.Payments.Add(payment);
            context.SaveChanges();
            return payment.paymentId;
        }
    }
}
