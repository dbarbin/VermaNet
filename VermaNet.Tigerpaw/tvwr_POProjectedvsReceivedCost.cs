//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VermaNet.Tigerpaw
{
    using System;
    using System.Collections.Generic;
    
    public partial class tvwr_POProjectedvsReceivedCost
    {
        public int PoNumber { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> PoDate { get; set; }
        public string Status { get; set; }
        public string ItemID { get; set; }
        public Nullable<decimal> ProjectedCost { get; set; }
        public Nullable<decimal> ReceivedCost { get; set; }
        public Nullable<decimal> TotalProjectedCost { get; set; }
        public Nullable<double> TotalReceivedCost { get; set; }
        public Nullable<double> QuantityReceived { get; set; }
    }
}