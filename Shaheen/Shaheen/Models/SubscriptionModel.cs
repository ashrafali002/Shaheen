using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaheen.Models
{
    public class SubscriptionModel
    {
        public int personId { get; set; }
        public string personName { get; set; }
        public int subscriptionId { get; set; }
        public string subscriptionCode { get; set; }
        public DateTime subscriptionDate { get; set; }
        public int subscriptionDetailId { get; set; }
        public DateTime subscriptionStartDate { get; set; }
        public DateTime subscriptionEndDate { get; set; }
        public string AreaName { get; set; }
        public string cityName { get; set; }
        public string districtName { get; set; }
        public string stateName { get; set; }
        public string agentName { get; set; }
        public decimal pendingAmount { get; set; }
        public int status { get; set; }
    }
}
