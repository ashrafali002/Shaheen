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
    
    public partial class Person
    {
        public int personId { get; set; }
        public string personName { get; set; }
        public string personAddress { get; set; }
        public Nullable<int> areaId { get; set; }
        public Nullable<int> cityId { get; set; }
        public Nullable<int> districtId { get; set; }
        public Nullable<int> stateId { get; set; }
        public Nullable<int> countryId { get; set; }
        public string pin { get; set; }
        public string phone { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
    }
}
