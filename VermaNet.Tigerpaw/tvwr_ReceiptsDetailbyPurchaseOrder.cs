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
    
    public partial class tvwr_ReceiptsDetailbyPurchaseOrder
    {
        public string AccountName { get; set; }
        public int PoNumber { get; set; }
        public string Description { get; set; }
        public string Reference { get; set; }
        public string Status { get; set; }
        public decimal Freight { get; set; }
        public Nullable<System.DateTime> PoDate { get; set; }
        public string ItemID { get; set; }
        public string ItemDescription { get; set; }
        public decimal ReceivedCost { get; set; }
        public bool Stock { get; set; }
        public double QuantityOrdered { get; set; }
        public double QuantityCancelled { get; set; }
        public double QuantityReceived { get; set; }
        public Nullable<System.DateTime> ReceivedDate { get; set; }
        public bool Posted { get; set; }
        public int POReceiptsKeyID { get; set; }
        public string Shipper { get; set; }
        public string ShipperTrackingNumber { get; set; }
    }
}
