using Shaheen.ShaheenDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
