//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shaheen.IshraqEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class SubscriptionDetail
    {
        public int subscriptionDetailId { get; set; }
        public int subscriptionId { get; set; }
        public string subscriptionDuration { get; set; }
        public Nullable<decimal> subscriptionAmount { get; set; }
        public Nullable<System.DateTime> subscriptionStartDate { get; set; }
        public Nullable<System.DateTime> subscriptionEndDate { get; set; }
        public string note { get; set; }
        public Nullable<bool> status { get; set; }
    }
}
