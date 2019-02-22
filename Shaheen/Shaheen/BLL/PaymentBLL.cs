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
        static ShaheenEntities entities = null;
        public PaymentBLL()
        {
            entities = new ShaheenEntities();
        }
        public int SavePayment(Payment payment)
        {
            entities.Payments.Add(payment);
            entities.SaveChanges();
            return payment.paymentId;
        }
    }
}
