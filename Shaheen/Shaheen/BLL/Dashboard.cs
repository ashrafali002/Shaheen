using Shaheen.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaheen
{
    public class CustomerModel
    {
        public int subscriptionId { get; set; }
        public string subscriptionCode { get; set; }
        public int personId { get; set; }
        public string personName { get; set; }
        public string phone { get; set; }
        public int agentId { get; set; }
        public string agentName { get; set; }
        public decimal pendingAmount { get; set; }
        public DateTime subscriptionDate { get; set; }
        public DateTime subscriptionStartDate { get; set; }
        public DateTime subscriptionEndDate { get; set; }
        public string note { get; set; }
    }
    public class Dashboard
    {
        public List<CustomerModel> getCustomerList()
        {
            List<CustomerModel> customerList = new List<CustomerModel>();
            CustomerModel model = new CustomerModel();
            PersonDAL person = new PersonDAL();
            

        }
    }
}
